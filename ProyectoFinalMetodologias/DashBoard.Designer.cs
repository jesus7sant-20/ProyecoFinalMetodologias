namespace ProyectoFinalMetodologias
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            PanelMenu = new Panel();
            lblMenu = new Label();
            btnSalir = new Button();
            btnCostos = new Button();
            btnReportes = new Button();
            btnReservaciones = new Button();
            btnHabitaciones = new Button();
            btnRegistros = new Button();
            lblNombreSistema = new Label();
            panelRegistroReservacion = new Panel();
            label21 = new Label();
            txtTipoHabitacion = new TextBox();
            cmbEstadoPago = new ComboBox();
            txtNumNoches = new TextBox();
            label20 = new Label();
            dateFechaSalida = new DateTimePicker();
            dateFechaEntrada = new DateTimePicker();
            label19 = new Label();
            label15 = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            txtNotasHuesped = new TextBox();
            txtSolicitudesEspeciales = new TextBox();
            txtEstado = new TextBox();
            txtMontoTotal = new TextBox();
            cmbMetodoPago = new ComboBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label14 = new Label();
            label13 = new Label();
            label10 = new Label();
            cmbnumeroHabitacion = new ComboBox();
            label12 = new Label();
            cmbTipoIdentifiacion = new ComboBox();
            txtNumeroIdentificaion = new TextBox();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panelGestionHabitaciones = new Panel();
            dgvHabitaciones = new DataGridView();
            panelSup4 = new Panel();
            label22 = new Label();
            panelListaReservaciones = new Panel();
            panelSup3 = new Panel();
            panelReportesBasicos = new Panel();
            panelSup2 = new Panel();
            panelAdministracionCostos = new Panel();
            panelSup1 = new Panel();
            PanelMenu.SuspendLayout();
            panelRegistroReservacion.SuspendLayout();
            panel1.SuspendLayout();
            panelGestionHabitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).BeginInit();
            panelSup4.SuspendLayout();
            panelListaReservaciones.SuspendLayout();
            panelReportesBasicos.SuspendLayout();
            panelAdministracionCostos.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(44, 62, 80);
            PanelMenu.BorderStyle = BorderStyle.FixedSingle;
            PanelMenu.Controls.Add(lblMenu);
            PanelMenu.Controls.Add(btnSalir);
            PanelMenu.Controls.Add(btnCostos);
            PanelMenu.Controls.Add(btnReportes);
            PanelMenu.Controls.Add(btnReservaciones);
            PanelMenu.Controls.Add(btnHabitaciones);
            PanelMenu.Controls.Add(btnRegistros);
            PanelMenu.Controls.Add(lblNombreSistema);
            PanelMenu.Location = new Point(1, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(187, 654);
            PanelMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            lblMenu.FlatStyle = FlatStyle.Flat;
            lblMenu.Font = new Font("Franklin Gothic Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = Color.Black;
            lblMenu.Image = (Image)resources.GetObject("lblMenu.Image");
            lblMenu.ImageAlign = ContentAlignment.MiddleLeft;
            lblMenu.Location = new Point(47, 61);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(92, 23);
            lblMenu.TabIndex = 8;
            lblMenu.Text = "Menu";
            lblMenu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(13, 587);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(159, 33);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCostos
            // 
            btnCostos.FlatStyle = FlatStyle.Flat;
            btnCostos.Image = (Image)resources.GetObject("btnCostos.Image");
            btnCostos.ImageAlign = ContentAlignment.MiddleLeft;
            btnCostos.Location = new Point(13, 378);
            btnCostos.Name = "btnCostos";
            btnCostos.Size = new Size(159, 33);
            btnCostos.TabIndex = 6;
            btnCostos.Text = "Costos";
            btnCostos.UseVisualStyleBackColor = true;
            btnCostos.Click += btnCostos_Click;
            // 
            // btnReportes
            // 
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(13, 310);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(159, 33);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnReservaciones
            // 
            btnReservaciones.FlatStyle = FlatStyle.Flat;
            btnReservaciones.Image = (Image)resources.GetObject("btnReservaciones.Image");
            btnReservaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservaciones.Location = new Point(13, 240);
            btnReservaciones.Name = "btnReservaciones";
            btnReservaciones.Size = new Size(159, 33);
            btnReservaciones.TabIndex = 4;
            btnReservaciones.Text = "Reservaciones";
            btnReservaciones.UseVisualStyleBackColor = true;
            btnReservaciones.Click += btnReservaciones_Click;
            // 
            // btnHabitaciones
            // 
            btnHabitaciones.FlatStyle = FlatStyle.Flat;
            btnHabitaciones.Image = (Image)resources.GetObject("btnHabitaciones.Image");
            btnHabitaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnHabitaciones.Location = new Point(13, 170);
            btnHabitaciones.Name = "btnHabitaciones";
            btnHabitaciones.Size = new Size(159, 33);
            btnHabitaciones.TabIndex = 3;
            btnHabitaciones.Text = "Habitaciones";
            btnHabitaciones.UseVisualStyleBackColor = true;
            btnHabitaciones.Click += btnHabitaciones_Click;
            // 
            // btnRegistros
            // 
            btnRegistros.FlatStyle = FlatStyle.Flat;
            btnRegistros.Image = (Image)resources.GetObject("btnRegistros.Image");
            btnRegistros.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistros.Location = new Point(13, 104);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(159, 33);
            btnRegistros.TabIndex = 1;
            btnRegistros.Text = "Registro";
            btnRegistros.UseVisualStyleBackColor = true;
            btnRegistros.Click += btnRegistros_Click;
            // 
            // lblNombreSistema
            // 
            lblNombreSistema.AutoSize = true;
            lblNombreSistema.BackColor = Color.Transparent;
            lblNombreSistema.FlatStyle = FlatStyle.Popup;
            lblNombreSistema.Font = new Font("Franklin Gothic Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreSistema.ForeColor = Color.Black;
            lblNombreSistema.Location = new Point(3, 17);
            lblNombreSistema.Name = "lblNombreSistema";
            lblNombreSistema.Size = new Size(179, 23);
            lblNombreSistema.TabIndex = 0;
            lblNombreSistema.Text = "SISTEMA DE HOTEL";
            // 
            // panelRegistroReservacion
            // 
            panelRegistroReservacion.BackColor = Color.FromArgb(127, 140, 141);
            panelRegistroReservacion.BorderStyle = BorderStyle.FixedSingle;
            panelRegistroReservacion.Controls.Add(label21);
            panelRegistroReservacion.Controls.Add(txtTipoHabitacion);
            panelRegistroReservacion.Controls.Add(cmbEstadoPago);
            panelRegistroReservacion.Controls.Add(txtNumNoches);
            panelRegistroReservacion.Controls.Add(label20);
            panelRegistroReservacion.Controls.Add(dateFechaSalida);
            panelRegistroReservacion.Controls.Add(dateFechaEntrada);
            panelRegistroReservacion.Controls.Add(label19);
            panelRegistroReservacion.Controls.Add(label15);
            panelRegistroReservacion.Controls.Add(btnCancelar);
            panelRegistroReservacion.Controls.Add(btnRegistrar);
            panelRegistroReservacion.Controls.Add(txtNotasHuesped);
            panelRegistroReservacion.Controls.Add(txtSolicitudesEspeciales);
            panelRegistroReservacion.Controls.Add(txtEstado);
            panelRegistroReservacion.Controls.Add(txtMontoTotal);
            panelRegistroReservacion.Controls.Add(cmbMetodoPago);
            panelRegistroReservacion.Controls.Add(label18);
            panelRegistroReservacion.Controls.Add(label17);
            panelRegistroReservacion.Controls.Add(label16);
            panelRegistroReservacion.Controls.Add(label14);
            panelRegistroReservacion.Controls.Add(label13);
            panelRegistroReservacion.Controls.Add(label10);
            panelRegistroReservacion.Controls.Add(cmbnumeroHabitacion);
            panelRegistroReservacion.Controls.Add(label12);
            panelRegistroReservacion.Controls.Add(cmbTipoIdentifiacion);
            panelRegistroReservacion.Controls.Add(txtNumeroIdentificaion);
            panelRegistroReservacion.Controls.Add(label11);
            panelRegistroReservacion.Controls.Add(label9);
            panelRegistroReservacion.Controls.Add(label8);
            panelRegistroReservacion.Controls.Add(label7);
            panelRegistroReservacion.Controls.Add(txtCorreo);
            panelRegistroReservacion.Controls.Add(txtTelefono);
            panelRegistroReservacion.Controls.Add(label6);
            panelRegistroReservacion.Controls.Add(label5);
            panelRegistroReservacion.Controls.Add(label4);
            panelRegistroReservacion.Controls.Add(label3);
            panelRegistroReservacion.Controls.Add(txtNombre);
            panelRegistroReservacion.Controls.Add(label2);
            panelRegistroReservacion.Controls.Add(panel1);
            panelRegistroReservacion.Location = new Point(194, 3);
            panelRegistroReservacion.Name = "panelRegistroReservacion";
            panelRegistroReservacion.Size = new Size(839, 643);
            panelRegistroReservacion.TabIndex = 1;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(22, 534);
            label21.Name = "label21";
            label21.Size = new Size(128, 21);
            label21.TabIndex = 42;
            label21.Text = "Estado de Pago:";
            // 
            // txtTipoHabitacion
            // 
            txtTipoHabitacion.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTipoHabitacion.Location = new Point(619, 119);
            txtTipoHabitacion.Name = "txtTipoHabitacion";
            txtTipoHabitacion.Size = new Size(166, 23);
            txtTipoHabitacion.TabIndex = 17;
            // 
            // cmbEstadoPago
            // 
            cmbEstadoPago.FormattingEnabled = true;
            cmbEstadoPago.Items.AddRange(new object[] { "Pagado", "Pendiente" });
            cmbEstadoPago.Location = new Point(167, 533);
            cmbEstadoPago.Name = "cmbEstadoPago";
            cmbEstadoPago.Size = new Size(166, 23);
            cmbEstadoPago.TabIndex = 41;
            // 
            // txtNumNoches
            // 
            txtNumNoches.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumNoches.Location = new Point(619, 335);
            txtNumNoches.Name = "txtNumNoches";
            txtNumNoches.Size = new Size(84, 23);
            txtNumNoches.TabIndex = 40;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(460, 337);
            label20.Name = "label20";
            label20.Size = new Size(155, 21);
            label20.TabIndex = 39;
            label20.Text = "Numero de Noches:";
            // 
            // dateFechaSalida
            // 
            dateFechaSalida.Location = new Point(587, 294);
            dateFechaSalida.Name = "dateFechaSalida";
            dateFechaSalida.Size = new Size(200, 23);
            dateFechaSalida.TabIndex = 38;
            dateFechaSalida.ValueChanged += dateFechaSalida_ValueChanged;
            // 
            // dateFechaEntrada
            // 
            dateFechaEntrada.Location = new Point(587, 254);
            dateFechaEntrada.Name = "dateFechaEntrada";
            dateFechaEntrada.Size = new Size(200, 23);
            dateFechaEntrada.TabIndex = 37;
            dateFechaEntrada.ValueChanged += dateFechaEntrada_ValueChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(460, 256);
            label19.Name = "label19";
            label19.Size = new Size(122, 21);
            label19.TabIndex = 36;
            label19.Text = "Fecha Entrada:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(460, 298);
            label15.Name = "label15";
            label15.Size = new Size(109, 21);
            label15.TabIndex = 35;
            label15.Text = "Fecha Salida:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(44, 62, 80);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(494, 601);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 32);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += button2_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(44, 62, 80);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(657, 601);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(140, 32);
            btnRegistrar.TabIndex = 33;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += button1_Click;
            // 
            // txtNotasHuesped
            // 
            txtNotasHuesped.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotasHuesped.Location = new Point(451, 540);
            txtNotasHuesped.Multiline = true;
            txtNotasHuesped.Name = "txtNotasHuesped";
            txtNotasHuesped.Size = new Size(319, 40);
            txtNotasHuesped.TabIndex = 32;
            // 
            // txtSolicitudesEspeciales
            // 
            txtSolicitudesEspeciales.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSolicitudesEspeciales.Location = new Point(449, 458);
            txtSolicitudesEspeciales.Multiline = true;
            txtSolicitudesEspeciales.Name = "txtSolicitudesEspeciales";
            txtSolicitudesEspeciales.Size = new Size(319, 41);
            txtSolicitudesEspeciales.TabIndex = 31;
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstado.Location = new Point(657, 206);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(140, 23);
            txtEstado.TabIndex = 30;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMontoTotal.Location = new Point(167, 482);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(140, 23);
            txtMontoTotal.TabIndex = 28;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            cmbMetodoPago.Location = new Point(161, 431);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(166, 23);
            cmbMetodoPago.TabIndex = 27;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(443, 434);
            label18.Name = "label18";
            label18.Size = new Size(172, 21);
            label18.TabIndex = 26;
            label18.Text = "Solicitudes Especiales:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(449, 512);
            label17.Name = "label17";
            label17.Size = new Size(150, 21);
            label17.TabIndex = 25;
            label17.Text = "Notas de Huesped:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(22, 484);
            label16.Name = "label16";
            label16.Size = new Size(136, 21);
            label16.TabIndex = 24;
            label16.Text = "Monto Total:   $";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(22, 429);
            label14.Name = "label14";
            label14.Size = new Size(133, 21);
            label14.TabIndex = 22;
            label14.Text = "Metodo de Pago:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.FlatStyle = FlatStyle.Popup;
            label13.Font = new Font("Franklin Gothic Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(532, 385);
            label13.Name = "label13";
            label13.Size = new Size(199, 23);
            label13.TabIndex = 21;
            label13.Text = "Opciones Adicionales:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.FlatStyle = FlatStyle.Popup;
            label10.Font = new Font("Franklin Gothic Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(155, 382);
            label10.Name = "label10";
            label10.Size = new Size(59, 23);
            label10.TabIndex = 20;
            label10.Text = "Pago:";
            // 
            // cmbnumeroHabitacion
            // 
            cmbnumeroHabitacion.FormattingEnabled = true;
            cmbnumeroHabitacion.Location = new Point(621, 162);
            cmbnumeroHabitacion.Name = "cmbnumeroHabitacion";
            cmbnumeroHabitacion.Size = new Size(166, 23);
            cmbnumeroHabitacion.TabIndex = 18;
            cmbnumeroHabitacion.SelectedIndexChanged += cmbnumeroHabitacion_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Popup;
            label12.Font = new Font("Franklin Gothic Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(532, 82);
            label12.Name = "label12";
            label12.Size = new Size(215, 23);
            label12.TabIndex = 16;
            label12.Text = "Datos de la Habitacion:";
            // 
            // cmbTipoIdentifiacion
            // 
            cmbTipoIdentifiacion.FormattingEnabled = true;
            cmbTipoIdentifiacion.Items.AddRange(new object[] { "INE", "Pasaporte" });
            cmbTipoIdentifiacion.Location = new Point(197, 248);
            cmbTipoIdentifiacion.Name = "cmbTipoIdentifiacion";
            cmbTipoIdentifiacion.Size = new Size(183, 23);
            cmbTipoIdentifiacion.TabIndex = 15;
            // 
            // txtNumeroIdentificaion
            // 
            txtNumeroIdentificaion.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroIdentificaion.Location = new Point(220, 295);
            txtNumeroIdentificaion.Name = "txtNumeroIdentificaion";
            txtNumeroIdentificaion.Size = new Size(200, 23);
            txtNumeroIdentificaion.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(460, 209);
            label11.Name = "label11";
            label11.Size = new Size(191, 21);
            label11.TabIndex = 13;
            label11.Text = "Estado de la Habitacion:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(460, 166);
            label9.Name = "label9";
            label9.Size = new Size(155, 21);
            label9.TabIndex = 11;
            label9.Text = "Numero Habitacion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(469, 124);
            label8.Name = "label8";
            label8.Size = new Size(130, 21);
            label8.TabIndex = 10;
            label8.Text = "Tipo Habitacion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Franklin Gothic Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(117, 82);
            label7.Name = "label7";
            label7.Size = new Size(179, 23);
            label7.TabIndex = 9;
            label7.Text = "Datos del Huesped:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(197, 203);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(200, 23);
            txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(197, 158);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 23);
            txtTelefono.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 293);
            label6.Name = "label6";
            label6.Size = new Size(192, 21);
            label6.TabIndex = 7;
            label6.Text = "Numero INE/ Pasaporte:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(22, 246);
            label5.Name = "label5";
            label5.Size = new Size(170, 21);
            label5.TabIndex = 6;
            label5.Text = "Tipo de Identifiacion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 201);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 5;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 160);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Telefono:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(197, 115);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 117);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre Completo:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 62);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Franklin Gothic Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(16, 7);
            label1.Name = "label1";
            label1.Size = new Size(482, 44);
            label1.TabIndex = 9;
            label1.Text = "FORMUALRIO DE REGISTRO DE RESERVACIONES";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelGestionHabitaciones
            // 
            panelGestionHabitaciones.BackColor = Color.FromArgb(127, 140, 141);
            panelGestionHabitaciones.BorderStyle = BorderStyle.FixedSingle;
            panelGestionHabitaciones.Controls.Add(dgvHabitaciones);
            panelGestionHabitaciones.Controls.Add(panelSup4);
            panelGestionHabitaciones.Location = new Point(194, 0);
            panelGestionHabitaciones.Name = "panelGestionHabitaciones";
            panelGestionHabitaciones.Size = new Size(839, 643);
            panelGestionHabitaciones.TabIndex = 2;
            // 
            // dgvHabitaciones
            // 
            dgvHabitaciones.AllowUserToOrderColumns = true;
            dgvHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabitaciones.Location = new Point(117, 163);
            dgvHabitaciones.Name = "dgvHabitaciones";
            dgvHabitaciones.Size = new Size(614, 396);
            dgvHabitaciones.TabIndex = 2;
            // 
            // panelSup4
            // 
            panelSup4.BackColor = Color.FromArgb(44, 62, 80);
            panelSup4.Controls.Add(label22);
            panelSup4.Location = new Point(0, 0);
            panelSup4.Name = "panelSup4";
            panelSup4.Size = new Size(838, 62);
            panelSup4.TabIndex = 1;
            // 
            // label22
            // 
            label22.BackColor = Color.Transparent;
            label22.FlatStyle = FlatStyle.Popup;
            label22.Font = new Font("Franklin Gothic Medium", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Black;
            label22.Image = (Image)resources.GetObject("label22.Image");
            label22.ImageAlign = ContentAlignment.MiddleLeft;
            label22.Location = new Point(15, 17);
            label22.Name = "label22";
            label22.Size = new Size(281, 23);
            label22.TabIndex = 9;
            label22.Text = "LISTA DE HABITACIONES:";
            label22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelListaReservaciones
            // 
            panelListaReservaciones.BackColor = Color.FromArgb(127, 140, 141);
            panelListaReservaciones.BorderStyle = BorderStyle.FixedSingle;
            panelListaReservaciones.Controls.Add(panelSup3);
            panelListaReservaciones.Location = new Point(194, 0);
            panelListaReservaciones.Name = "panelListaReservaciones";
            panelListaReservaciones.Size = new Size(839, 643);
            panelListaReservaciones.TabIndex = 2;
            // 
            // panelSup3
            // 
            panelSup3.BackColor = Color.FromArgb(44, 62, 80);
            panelSup3.Location = new Point(-1, -1);
            panelSup3.Name = "panelSup3";
            panelSup3.Size = new Size(839, 62);
            panelSup3.TabIndex = 1;
            // 
            // panelReportesBasicos
            // 
            panelReportesBasicos.BackColor = Color.FromArgb(127, 140, 141);
            panelReportesBasicos.BorderStyle = BorderStyle.FixedSingle;
            panelReportesBasicos.Controls.Add(panelSup2);
            panelReportesBasicos.Location = new Point(194, 0);
            panelReportesBasicos.Name = "panelReportesBasicos";
            panelReportesBasicos.Size = new Size(839, 643);
            panelReportesBasicos.TabIndex = 2;
            // 
            // panelSup2
            // 
            panelSup2.BackColor = Color.FromArgb(44, 62, 80);
            panelSup2.Location = new Point(-1, -1);
            panelSup2.Name = "panelSup2";
            panelSup2.Size = new Size(839, 62);
            panelSup2.TabIndex = 1;
            // 
            // panelAdministracionCostos
            // 
            panelAdministracionCostos.BackColor = Color.FromArgb(127, 140, 141);
            panelAdministracionCostos.BorderStyle = BorderStyle.FixedSingle;
            panelAdministracionCostos.Controls.Add(panelSup1);
            panelAdministracionCostos.Location = new Point(194, 0);
            panelAdministracionCostos.Name = "panelAdministracionCostos";
            panelAdministracionCostos.Size = new Size(839, 643);
            panelAdministracionCostos.TabIndex = 2;
            // 
            // panelSup1
            // 
            panelSup1.BackColor = Color.FromArgb(44, 62, 80);
            panelSup1.Location = new Point(-1, -1);
            panelSup1.Name = "panelSup1";
            panelSup1.Size = new Size(839, 62);
            panelSup1.TabIndex = 0;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1033, 649);
            Controls.Add(panelRegistroReservacion);
            Controls.Add(panelGestionHabitaciones);
            Controls.Add(panelListaReservaciones);
            Controls.Add(panelReportesBasicos);
            Controls.Add(panelAdministracionCostos);
            Controls.Add(PanelMenu);
            Margin = new Padding(2);
            Name = "DashBoard";
            Text = "DashBoard";
            FormClosing += DashBoard_FormClosing;
            Load += DashBoard_Load;
            PanelMenu.ResumeLayout(false);
            PanelMenu.PerformLayout();
            panelRegistroReservacion.ResumeLayout(false);
            panelRegistroReservacion.PerformLayout();
            panel1.ResumeLayout(false);
            panelGestionHabitaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).EndInit();
            panelSup4.ResumeLayout(false);
            panelListaReservaciones.ResumeLayout(false);
            panelReportesBasicos.ResumeLayout(false);
            panelAdministracionCostos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Panel panelRegistroReservacion;
        private Panel panelGestionHabitaciones;
        private Panel panelListaReservaciones;
        private Panel panelReportesBasicos;
        private Panel panelAdministracionCostos;
        private Label lblNombreSistema;
        private Button btnReservaciones;
        private Button btnHabitaciones;
        private Button btnRegistros;
        private Button btnSalir;
        private Button btnCostos;
        private Button btnReportes;
        private Label lblMenu;
        private Panel panelSup1;
        private Panel panel1;
        private Panel panelSup4;
        private Panel panelSup3;
        private Panel panelSup2;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label label6;
        private Label label5;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cmbnumeroHabitacion;
        private TextBox txtTipoHabitacion;
        private Label label12;
        private ComboBox cmbTipoIdentifiacion;
        private TextBox txtNumeroIdentificaion;
        private Label label17;
        private Label label16;
        private Label label13;
        private Label label10;
        private TextBox txtMontoTotal;
        private ComboBox cmbMetodoPago;
        private Button btnRegistrar;
        private TextBox txtNotasHuesped;
        private TextBox txtSolicitudesEspeciales;
        private TextBox txtEstado;
        private Label label18;
        private DateTimePicker dateFechaSalida;
        private DateTimePicker dateFechaEntrada;
        private Label label19;
        private Label label15;
        private Button btnCancelar;
        private TextBox txtNumNoches;
        private Label label20;
        private Label label21;
        private ComboBox cmbEstadoPago;
        private Label label14;
        private DataGridView dgvHabitaciones;
        private Label label22;
    }
}