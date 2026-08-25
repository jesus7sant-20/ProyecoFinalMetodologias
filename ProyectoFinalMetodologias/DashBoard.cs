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
            GenerarReportesAutomaticos(); // Actualiza los datos al abrir el panel
        }

        private void btnCostos_Click(object sender, EventArgs e)
        {
            panelAdministracionCostos.BringToFront();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir del sistema de hotel?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpiamos los campos de texto
            LimpiarFormulario();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Metodo para el boton de Regsistrar Reservacion
        private void Button1_Click(object sender, EventArgs e)
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

        // Método para cargar y refrescar la tabla de reservaciones
        private void CargarListaReservaciones(List<cLogicaRegistros> listaAMostrar = null)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listaAMostrar ?? listas.listaReservaciones;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtroTexto = txtBuscador.Text.Trim().ToLower();
            string estadoSeleccionado = comboBox1.SelectedItem?.ToString(); // Asumiendo comboBox1 es para filtrar por estado

            var resultado = listas.listaReservaciones.Where(r =>
                (string.IsNullOrEmpty(filtroTexto) || r.NombreCompleto.ToLower().Contains(filtroTexto) || r.NumeroIdentificacion.Contains(filtroTexto)) &&
                (string.IsNullOrEmpty(estadoSeleccionado) || estadoSeleccionado == "Todos" || r.EstadoPago == estadoSeleccionado)
            ).ToList();

            CargarListaReservaciones(resultado);
        }

        private void btnCancelarReservacion_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Obtenemos el objeto seleccionado de la fila
                var reservaSeleccionada = dataGridView2.SelectedRows[0].DataBoundItem as cLogicaRegistros;
                if (reservaSeleccionada != null)
                {
                    // Liberamos la habitación asociada
                    var habitacion = listas.listaHabitaciones.FirstOrDefault(h => h.NumeroHabitacion == reservaSeleccionada.NumHabitacion);
                    if (habitacion != null)
                    {
                        habitacion.Estado = "Libre";
                    }

                    // Removemos de la lista de reservaciones activas
                    listas.listaReservaciones.Remove(reservaSeleccionada);

                    // Refrescamos las tablas
                    CargarListaReservaciones();

                    MessageBox.Show("La reservación ha sido cancelada y la habitación liberada.", "Cancelación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila completa de la tabla para cancelar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GenerarReportesAutomaticos()
        {
            int totalHabitaciones = listas.listaHabitaciones.Count;
            int habitacionesOcupadas = listas.listaHabitaciones.Count(h => h.Estado == "Ocupada");

            // 1. Ocupación actual (Calculada en porcentaje o texto)
            decimal porcentajeOcupacion = totalHabitaciones > 0 ? ((decimal)habitacionesOcupadas / totalHabitaciones) * 100 : 0;
            txtOcupacionActual.Text = $"{porcentajeOcupacion:0.0}% ({habitacionesOcupadas}/{totalHabitaciones})";

            // 2. Reservaciones activas
            int activas = listas.listaReservaciones.Count;
            txtReservacionesActivas.Text = activas.ToString();

            // 3. Cancelaciones (Simulado o basado en un contador que gestiones)
            txtCancelaciones.Text = "0";

            // 4. Ingresos del día (Suma de montos de hoy)
            decimal ingresosHoy = listas.listaReservaciones
                .Where(r => r.FechaEntrada.Date == DateTime.Now.Date)
                .Sum(r => r.MontoTotal);
            txtIngresos.Text = $"${ingresosHoy:0.00}";
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DateTime desde = dateTimePicker1.Value.Date;
            DateTime hasta = dateTimePicker2.Value.Date;

            if (desde > hasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Rango inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Filtramos las reservaciones en el rango de fechas seleccionado
            var reporteFiltrado = listas.listaReservaciones
                .Where(r => r.FechaEntrada.Date >= desde && r.FechaEntrada.Date <= hasta)
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reporteFiltrado.Select(r => new
            {
                Fecha = r.FechaEntrada.ToShortDateString(),
                Reservaciones = r.NombreCompleto,
                Cancelaciones = "N/A",
                Ingresos = $"${r.MontoTotal:0.00}"
            }).ToList();

            MessageBox.Show("Reporte generado exitosamente para el rango de fechas seleccionado.", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelAdministracionCostos_Paint(object sender, PaintEventArgs e)
        {

        }

        // --- Lógica del módulo Administración de Costos ---

        // 1. Al tocar una celda/fila de la tabla de costos (dataGridView3)
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView3.Rows[e.RowIndex];

                if (fila.Cells[0].Value != null)
                {
                    txtHabitacionSeleccionada.Text = fila.Cells[0].Value.ToString();
                }

                if (fila.Cells[1].Value != null)
                {
                    txtNuevoPrecio.Text = fila.Cells[1].Value.ToString();
                }
            }
        }

        // 2. Evento del botón "Actualizar Precio" (actualprecio)
        private void actualprecio_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null && !string.IsNullOrEmpty(txtNuevoPrecio.Text))
            {
                dataGridView3.CurrentRow.Cells[1].Value = txtNuevoPrecio.Text;
                MessageBox.Show("Precio actualizado correctamente en la tabla.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecciona una habitación de la tabla primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 3. Evento del botón "Cancelar" (cancelar)
        private void cancelar_Click(object sender, EventArgs e)
        {
            txtHabitacionSeleccionada.Clear();
            txtNuevoPrecio.Clear();
            dataGridView3.ClearSelection();
        }
    }
}