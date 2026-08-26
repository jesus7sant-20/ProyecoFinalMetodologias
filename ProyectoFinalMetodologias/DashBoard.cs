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

            //Suscribir los eventos
            cmbnumeroHabitacion.SelectedIndexChanged += cmbnumeroHabitacion_SelectedIndexChanged;
            dateFechaEntrada.ValueChanged += dateFechaEntrada_ValueChanged;
            dateFechaSalida.ValueChanged += dateFechaSalida_ValueChanged;

            //Forzar el llenado del primer elemento (tipo de habitación, costo, etc.)
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

            dvgHabitacionesPrecio.DataSource = null;
            dvgHabitacionesPrecio.DataSource = listas.listaHabitaciones;

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listas.listaReservaciones;

            LimpiarFormulario();
            CargarListaReservaciones();
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
                        habitacion.Estado = "Limpieza";
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

        private void ExportarDataGridViewACSV(DataGridView dgv, string nombreArchivo)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo CSV (*.csv)|*.csv";
            sfd.FileName = nombreArchivo;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                // Obtener cabeceras
                string[] columnas = new string[dgv.Columns.Count];
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    columnas[i] = dgv.Columns[i].HeaderText;
                }
                sb.AppendLine(string.Join(",", columnas));

                // Obtener filas
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        string[] celdas = new string[dgv.Columns.Count];
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            celdas[j] = fila.Cells[j].Value?.ToString().Replace(",", " ") ?? "";
                        }
                        sb.AppendLine(string.Join(",", celdas));
                    }
                }

                System.IO.File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Datos exportados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExportarExcel2_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewACSV(dataGridView2, "Reservaciones.csv");
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewACSV(dataGridView1, "Reporte_general.cvs");
        }

        private void btnRegistros_Click_1(object sender, EventArgs e)
        {
            panelRegistroReservacion.BringToFront();
        }

        private void btnCancelarCambio_Click(object sender, EventArgs e)
        {
            txtHabitacion.Text = "";
            txtPrecioActual.Text = "";
            txtNuevoPrecio.Text = "";
        }

        private void btnCambiarPrecio_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtHabitacion.Text, out int numHab) &&
                decimal.TryParse(txtNuevoPrecio.Text, out decimal nuevoPrecio))
            {
                var habitacion = listas.listaHabitaciones.FirstOrDefault(h => h.NumeroHabitacion == numHab);
                if (habitacion != null)
                {
                    habitacion.TarifaPorNoche = nuevoPrecio;
                    MessageBox.Show("¡Precio actualizado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescamos las tablas para que reflejen el cambio de tarifa
                    dvgHabitacionesPrecio.DataSource = null;
                    dvgHabitacionesPrecio.DataSource = listas.listaHabitaciones;

                    dgvHabitaciones.DataSource = null;
                    dgvHabitaciones.DataSource = listas.listaHabitaciones;

                    // Limpiamos campos
                    txtHabitacion.Text = "";
                    txtPrecioActual.Text = "";
                    txtNuevoPrecio.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una habitación válida e ingrese un nuevo precio numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dvgHabitacionesPrecio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dvgHabitacionesPrecio.Rows[e.RowIndex];
                txtHabitacion.Text = fila.Cells["NumeroHabitacion"].Value?.ToString();
                txtPrecioActual.Text = fila.Cells["TarifaPorNoche"].Value?.ToString();
                txtNuevoPrecio.Text = ""; // Limpiamos para que escribas el nuevo
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var reservaSeleccionada = dataGridView2.SelectedRows[0].DataBoundItem as cLogicaRegistros;
                if (reservaSeleccionada != null)
                {
                    // 1. Mandamos los datos de regreso al panel de registros
                    panelRegistroReservacion.BringToFront();

                    txtNombre.Text = reservaSeleccionada.NombreCompleto;
                    txtTelefono.Text = reservaSeleccionada.Telefono;
                    txtCorreo.Text = reservaSeleccionada.Correo;
                    cmbTipoIdentifiacion.SelectedItem = reservaSeleccionada.TipoIdentificacion;
                    txtNumeroIdentificaion.Text = reservaSeleccionada.NumeroIdentificacion;
                    cmbnumeroHabitacion.SelectedValue = reservaSeleccionada.NumHabitacion;
                    dateFechaEntrada.Value = reservaSeleccionada.FechaEntrada;
                    dateFechaSalida.Value = reservaSeleccionada.FechaSalida;
                    cmbMetodoPago.SelectedItem = reservaSeleccionada.MetodoPago;
                    cmbEstadoPago.SelectedItem = reservaSeleccionada.EstadoPago;
                    txtSolicitudesEspeciales.Text = reservaSeleccionada.Solicitudesespeciales;
                    txtNotasHuesped.Text = reservaSeleccionada.NOtasHuesped;

                    // 2. Opcional: eliminamos la viejas para que al registrar de nuevo se actualice limpia
                    listas.listaReservaciones.Remove(reservaSeleccionada);
                    CargarListaReservaciones();

                    MessageBox.Show("Modifique los datos necesarios en el formulario y vuelva a registrar.", "Modo Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una reservación de la tabla para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.SelectedRows.Count > 0)
            {
                var habitacionSeleccionada = dgvHabitaciones.SelectedRows[0].DataBoundItem as cModeloHabitaciones;
                string nuevoEstado = cmbCambiarEstado.SelectedItem?.ToString(); // Asegúrate que el ComboBox de estados se llame cmbCambiarEstado

                if (habitacionSeleccionada != null && !string.IsNullOrEmpty(nuevoEstado))
                {
                    habitacionSeleccionada.Estado = nuevoEstado;
                    MessageBox.Show("¡Estado de la habitación actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescamos las tablas en todo el sistema para que reflejen el cambio al instante
                    dgvHabitaciones.DataSource = null;
                    dgvHabitaciones.DataSource = listas.listaHabitaciones;

                    dvgHabitacionesPrecio.DataSource = null;
                    dvgHabitacionesPrecio.DataSource = listas.listaHabitaciones;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un estado válido en el menú desplegable.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una habitación de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvHabitaciones.Rows[e.RowIndex];
                // Aquí puedes capturar datos si lo requieres visualmente
            }
        }
    }
}

