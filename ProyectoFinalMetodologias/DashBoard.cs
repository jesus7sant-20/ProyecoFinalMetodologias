using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ProyectoFinalMetodologias
{
    public partial class DashBoard : Form
    {
        cListas listas = new cListas();
        //Le ingresamos el rol segun el login
        private string rolUsuario;
        private Login loginFormulario;

        public DashBoard(string rol, Login loginForm)
        {
            InitializeComponent();
            this.rolUsuario = rol;
            this.loginFormulario = loginForm;
        }

        //Aqui vamos a validar el rol del usuario para mostrar u ocultar los botones correspondientes
        private void DashBoard_Load(object sender, EventArgs e)
        {
            if (rolUsuario == "recepcionista")
            {
                //Ocultamos la ventana de reportes y costos para el rol de recepcionista
                btnCostos.Visible = false;
                btnReportes.Visible = false;
            }

            //Eventos corregidos
            cmbnumeroHabitacion.DataSource = listas.listaHabitaciones;
            cmbnumeroHabitacion.DisplayMember = "NumeroHabitacion";
            cmbnumeroHabitacion.ValueMember = "NumeroHabitacion";

            // 2. Suscribir los eventos
            cmbnumeroHabitacion.SelectedIndexChanged += cmbnumeroHabitacion_SelectedIndexChanged;
            dateFechaEntrada.ValueChanged += dateFechaEntrada_ValueChanged;
            dateFechaSalida.ValueChanged += dateFechaSalida_ValueChanged;

            // 3. Forzar el llenado del primer elemento (tipo de habitación, costo, etc.)
            cmbnumeroHabitacion_SelectedIndexChanged(null, null);
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            panelRegistroReservacion.BringToFront();
            //Rellenar el combobox
            cmbnumeroHabitacion.DataSource = listas.listaHabitaciones;
            cmbnumeroHabitacion.DisplayMember = "NumeroHabitacion"; // Corrección de tipografía
            cmbnumeroHabitacion.ValueMember = "NumeroHabitacion";
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            panelGestionHabitaciones.BringToFront();
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            panelListaReservaciones.BringToFront();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            panelReportesBasicos.BringToFront();
        }

        private void btnCostos_Click(object sender, EventArgs e)
        {
            panelAdministracionCostos.BringToFront();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpiamos los campos de texto
            LimpiarFormulario();
        }

        //Metodo para el boton de Regsistrar Reservacion
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtNumeroIdentificaion.Text) ||
                cmbnumeroHabitacion.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int noches = (dateFechaSalida.Value.Date - dateFechaEntrada.Value.Date).Days;
            if (noches <= 0)
            {
                MessageBox.Show("La fecha de salida debe ser posterior a la fecha de entrada.", "Fechas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cLogicaRegistros nuevaReservacion = new cLogicaRegistros
            {
                NombreCompleto = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                TipoIdentificacion = cmbTipoIdentifiacion.SelectedItem?.ToString(),
                NumeroIdentificacion = txtNumeroIdentificaion.Text,
                TipoHabitacion = txtTipoHabitacion.Text,
                NumHabitacion = (int)cmbnumeroHabitacion.SelectedValue,
                EstadoHabitacion = "Ocupada",
                FechaEntrada = dateFechaEntrada.Value,
                FechaSalida = dateFechaSalida.Value,
                NumeroNoches = noches,
                MetodoPago = cmbMetodoPago.SelectedItem?.ToString(),
                EstadoPago = cmbEstadoPago.SelectedItem?.ToString(),
                MontoTotal = decimal.TryParse(txtMontoTotal.Text, out decimal monto) ? monto : 0,
                Solicitudesespeciales = txtSolicitudesEspeciales.Text,
                NOtasHuesped = txtNotasHuesped.Text
            };

            listas.RegistrarReservacion(nuevaReservacion);
            MessageBox.Show("Reservación registrada y habitación marcada como ocupada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvHabitaciones.DataSource = null;
            dgvHabitaciones.DataSource = listas.listaHabitaciones;

            LimpiarFormulario();

            //Para llenar la tabla de reservaciones
            //dgvReservaciones.DataSource = null;
            //dgvReservaciones.DataSource = listas.listaReservaciones;
        }

        private void cmbnumeroHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbnumeroHabitacion.SelectedValue is int numHab)
            {
                var hab = listas.listaHabitaciones.FirstOrDefault(h => h.NumeroHabitacion == numHab);
                if (hab != null)
                {
                    txtTipoHabitacion.Text = hab.TipoHabitacion;
                    txtEstado.Text = hab.Estado;
                }
            }
            //llamamos al metodo
            CalcularMontoAutomatico();
        }

        //metodo CalcularMontoAutomatico
        private void CalcularMontoAutomatico()
        {
            if (cmbnumeroHabitacion.SelectedValue is int numHab)
            {
                var hab = listas.listaHabitaciones.FirstOrDefault(h => h.NumeroHabitacion == numHab);
                if (hab != null)
                {
                    int noches = (dateFechaSalida.Value.Date - dateFechaEntrada.Value.Date).Days;
                    if (noches > 0)
                    {
                        decimal monto = noches * hab.TarifaPorNoche;
                        txtMontoTotal.Text = monto.ToString("0.00");
                        txtNumNoches.Text = noches.ToString();
                    }
                    else
                    {
                        txtMontoTotal.Text = "0.00";
                        txtNumNoches.Text = "0";
                    }
                }
            }
        }

        private void dateFechaEntrada_ValueChanged(object sender, EventArgs e)
        {
            CalcularMontoAutomatico();
        }

        private void dateFechaSalida_ValueChanged(object sender, EventArgs e)
        {
            CalcularMontoAutomatico();
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LimpiarFormulario()
        {
            // --- 1. Datos del Huésped ---
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtNumeroIdentificaion.Text = "";
            if (cmbTipoIdentifiacion.Items.Count > 0)
                cmbTipoIdentifiacion.SelectedIndex = -1;

            // --- 2. Datos de la Habitación ---
            if (cmbnumeroHabitacion.Items.Count > 0)
                cmbnumeroHabitacion.SelectedIndex = 0; // Actualiza tipo y estado al primer elemento

            dateFechaEntrada.Value = DateTime.Now;
            dateFechaSalida.Value = DateTime.Now;
            txtNumNoches.Text = "";

            // --- 3. Pago ---
            if (cmbMetodoPago.Items.Count > 0)
                cmbMetodoPago.SelectedIndex = -1;

            if (cmbEstadoPago.Items.Count > 0)
                cmbEstadoPago.SelectedIndex = -1;

            txtMontoTotal.Text = "";

            // --- 4. Opciones Adicionales ---
            txtSolicitudesEspeciales.Text = "";
            txtNotasHuesped.Text = "";
        }
    }
}
