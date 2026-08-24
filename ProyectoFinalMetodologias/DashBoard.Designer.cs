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
            panel1 = new Panel();
            panelGestionHabitaciones = new Panel();
            panelSup4 = new Panel();
            panelListaReservaciones = new Panel();
            panelSup3 = new Panel();
            panelReportesBasicos = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelSup2 = new Panel();
            label1 = new Label();
            panelAdministracionCostos = new Panel();
            panelSup1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            colFecha = new DataGridViewTextBoxColumn();
            colReservaciones = new DataGridViewTextBoxColumn();
            colCancelaciones = new DataGridViewTextBoxColumn();
            colIngresos = new DataGridViewTextBoxColumn();
            txtOcupacionActual = new TextBox();
            txtReservacionesActivas = new TextBox();
            txtCancelaciones = new TextBox();
            txtIngresos = new TextBox();
            label8 = new Label();
            txtBuscador = new TextBox();
            btnBuscar = new Button();
            label9 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dataGridView2 = new DataGridView();
            btnEditar = new Button();
            btnCancelarReservacion = new Button();
            btnExportarExcel2 = new Button();
            colIDReserva = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colHabitacion = new DataGridViewTextBoxColumn();
            colEntrada = new DataGridViewTextBoxColumn();
            colSalida = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            PanelMenu.SuspendLayout();
            panelRegistroReservacion.SuspendLayout();
            panelGestionHabitaciones.SuspendLayout();
            panelListaReservaciones.SuspendLayout();
            panelSup3.SuspendLayout();
            panelReportesBasicos.SuspendLayout();
            panelSup2.SuspendLayout();
            panelAdministracionCostos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            panelRegistroReservacion.Controls.Add(panel1);
            panelRegistroReservacion.Location = new Point(194, 3);
            panelRegistroReservacion.Name = "panelRegistroReservacion";
            panelRegistroReservacion.Size = new Size(839, 643);
            panelRegistroReservacion.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 62);
            panel1.TabIndex = 1;
            // 
            // panelGestionHabitaciones
            // 
            panelGestionHabitaciones.BackColor = Color.FromArgb(127, 140, 141);
            panelGestionHabitaciones.BorderStyle = BorderStyle.FixedSingle;
            panelGestionHabitaciones.Controls.Add(panelSup4);
            panelGestionHabitaciones.Location = new Point(194, 0);
            panelGestionHabitaciones.Name = "panelGestionHabitaciones";
            panelGestionHabitaciones.Size = new Size(839, 643);
            panelGestionHabitaciones.TabIndex = 2;
            // 
            // panelSup4
            // 
            panelSup4.BackColor = Color.FromArgb(44, 62, 80);
            panelSup4.Location = new Point(0, 0);
            panelSup4.Name = "panelSup4";
            panelSup4.Size = new Size(838, 62);
            panelSup4.TabIndex = 1;
            // 
            // panelListaReservaciones
            // 
            panelListaReservaciones.BackColor = Color.FromArgb(127, 140, 141);
            panelListaReservaciones.BorderStyle = BorderStyle.FixedSingle;
            panelListaReservaciones.Controls.Add(btnExportarExcel2);
            panelListaReservaciones.Controls.Add(btnCancelarReservacion);
            panelListaReservaciones.Controls.Add(btnEditar);
            panelListaReservaciones.Controls.Add(dataGridView2);
            panelListaReservaciones.Controls.Add(comboBox2);
            panelListaReservaciones.Controls.Add(comboBox1);
            panelListaReservaciones.Controls.Add(label10);
            panelListaReservaciones.Controls.Add(label9);
            panelListaReservaciones.Controls.Add(btnBuscar);
            panelListaReservaciones.Controls.Add(txtBuscador);
            panelListaReservaciones.Controls.Add(panelSup3);
            panelListaReservaciones.Location = new Point(194, 0);
            panelListaReservaciones.Name = "panelListaReservaciones";
            panelListaReservaciones.Size = new Size(839, 643);
            panelListaReservaciones.TabIndex = 2;
            // 
            // panelSup3
            // 
            panelSup3.BackColor = Color.FromArgb(44, 62, 80);
            panelSup3.Controls.Add(label8);
            panelSup3.Location = new Point(-1, -1);
            panelSup3.Name = "panelSup3";
            panelSup3.Size = new Size(839, 62);
            panelSup3.TabIndex = 1;
            // 
            // panelReportesBasicos
            // 
            panelReportesBasicos.BackColor = Color.FromArgb(127, 140, 141);
            panelReportesBasicos.BorderStyle = BorderStyle.FixedSingle;
            panelReportesBasicos.Controls.Add(txtIngresos);
            panelReportesBasicos.Controls.Add(txtCancelaciones);
            panelReportesBasicos.Controls.Add(txtReservacionesActivas);
            panelReportesBasicos.Controls.Add(txtOcupacionActual);
            panelReportesBasicos.Controls.Add(dataGridView1);
            panelReportesBasicos.Controls.Add(button2);
            panelReportesBasicos.Controls.Add(button1);
            panelReportesBasicos.Controls.Add(dateTimePicker2);
            panelReportesBasicos.Controls.Add(dateTimePicker1);
            panelReportesBasicos.Controls.Add(label7);
            panelReportesBasicos.Controls.Add(label6);
            panelReportesBasicos.Controls.Add(label5);
            panelReportesBasicos.Controls.Add(label4);
            panelReportesBasicos.Controls.Add(label3);
            panelReportesBasicos.Controls.Add(label2);
            panelReportesBasicos.Controls.Add(panelSup2);
            panelReportesBasicos.Location = new Point(194, 0);
            panelReportesBasicos.Name = "panelReportesBasicos";
            panelReportesBasicos.Size = new Size(839, 643);
            panelReportesBasicos.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(653, 104);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 5;
            label5.Text = "Ingresos del Día:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 104);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 4;
            label4.Text = "Cancelaciones: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 104);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 3;
            label3.Text = "Reservaciones Activas: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 104);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 2;
            label2.Text = "Ocupacion Actual: ";
            // 
            // panelSup2
            // 
            panelSup2.BackColor = Color.FromArgb(44, 62, 80);
            panelSup2.Controls.Add(label1);
            panelSup2.Location = new Point(-1, -1);
            panelSup2.Name = "panelSup2";
            panelSup2.Size = new Size(839, 62);
            panelSup2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Franklin Gothic Medium", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(26, 18);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 0;
            label1.Text = "Reportes Básicos";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 506);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 6;
            label6.Text = "Desde: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(465, 503);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 7;
            label7.Text = "Hasta: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 500);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 23);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.Value = new DateTime(2026, 8, 23, 18, 4, 0, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(514, 500);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(232, 23);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.Value = new DateTime(2026, 8, 25, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.Location = new Point(312, 587);
            button1.Name = "button1";
            button1.Size = new Size(107, 25);
            button1.TabIndex = 10;
            button1.Text = "  Generar Reporte";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(425, 587);
            button2.Name = "button2";
            button2.Size = new Size(107, 25);
            button2.TabIndex = 11;
            button2.Text = "Exportar Excel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colFecha, colReservaciones, colCancelaciones, colIngresos });
            dataGridView1.Location = new Point(83, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(663, 257);
            dataGridView1.TabIndex = 12;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.Width = 120;
            // 
            // colReservaciones
            // 
            colReservaciones.HeaderText = "Reservaciones";
            colReservaciones.Name = "colReservaciones";
            colReservaciones.Width = 150;
            // 
            // colCancelaciones
            // 
            colCancelaciones.HeaderText = "Cancelaciones";
            colCancelaciones.Name = "colCancelaciones";
            colCancelaciones.Width = 150;
            // 
            // colIngresos
            // 
            colIngresos.HeaderText = "Ingresos";
            colIngresos.Name = "colIngresos";
            colIngresos.Width = 200;
            // 
            // txtOcupacionActual
            // 
            txtOcupacionActual.Location = new Point(83, 135);
            txtOcupacionActual.Name = "txtOcupacionActual";
            txtOcupacionActual.Size = new Size(108, 23);
            txtOcupacionActual.TabIndex = 13;
            // 
            // txtReservacionesActivas
            // 
            txtReservacionesActivas.Location = new Point(279, 135);
            txtReservacionesActivas.Name = "txtReservacionesActivas";
            txtReservacionesActivas.Size = new Size(128, 23);
            txtReservacionesActivas.TabIndex = 14;
            // 
            // txtCancelaciones
            // 
            txtCancelaciones.Location = new Point(491, 135);
            txtCancelaciones.Name = "txtCancelaciones";
            txtCancelaciones.Size = new Size(89, 23);
            txtCancelaciones.TabIndex = 15;
            // 
            // txtIngresos
            // 
            txtIngresos.Location = new Point(653, 135);
            txtIngresos.Name = "txtIngresos";
            txtIngresos.Size = new Size(93, 23);
            txtIngresos.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Franklin Gothic Medium", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(26, 18);
            label8.Name = "label8";
            label8.Size = new Size(187, 23);
            label8.TabIndex = 1;
            label8.Text = "Lista de Reservaciones";
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(44, 80);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(300, 23);
            txtBuscador.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(350, 80);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 143);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 4;
            label9.Text = "Filtrar por Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(241, 143);
            label10.Name = "label10";
            label10.Size = new Size(103, 15);
            label10.TabIndex = 5;
            label10.Text = "Filtrar por Fechas: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(44, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(241, 164);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 7;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colIDReserva, colCliente, colHabitacion, colEntrada, colSalida, colEstado, colMonto });
            dataGridView2.Location = new Point(8, 240);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(818, 297);
            dataGridView2.TabIndex = 8;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(11, 546);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 35);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarReservacion
            // 
            btnCancelarReservacion.Location = new Point(130, 546);
            btnCancelarReservacion.Name = "btnCancelarReservacion";
            btnCancelarReservacion.Size = new Size(180, 35);
            btnCancelarReservacion.TabIndex = 10;
            btnCancelarReservacion.Text = "Cancelar Reservacion";
            btnCancelarReservacion.UseVisualStyleBackColor = true;
            // 
            // btnExportarExcel2
            // 
            btnExportarExcel2.Location = new Point(327, 546);
            btnExportarExcel2.Name = "btnExportarExcel2";
            btnExportarExcel2.Size = new Size(160, 35);
            btnExportarExcel2.TabIndex = 11;
            btnExportarExcel2.Text = "Exportar Excel";
            btnExportarExcel2.UseVisualStyleBackColor = true;
            // 
            // colIDReserva
            // 
            colIDReserva.HeaderText = "ID Reserva";
            colIDReserva.Name = "colIDReserva";
            colIDReserva.Width = 65;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";
            colCliente.Width = 170;
            // 
            // colHabitacion
            // 
            colHabitacion.HeaderText = "Habitación ";
            colHabitacion.Name = "colHabitacion";
            colHabitacion.Width = 80;
            // 
            // colEntrada
            // 
            colEntrada.HeaderText = "Fecha Entrada";
            colEntrada.Name = "colEntrada";
            colEntrada.Width = 130;
            // 
            // colSalida
            // 
            colSalida.HeaderText = "Fecha Salida";
            colSalida.Name = "colSalida";
            colSalida.Width = 130;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            // 
            // colMonto
            // 
            colMonto.HeaderText = "Monto";
            colMonto.Name = "colMonto";
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1033, 649);
            Controls.Add(panelReportesBasicos);
            Controls.Add(panelListaReservaciones);
            Controls.Add(panelGestionHabitaciones);
            Controls.Add(panelRegistroReservacion);
            Controls.Add(panelAdministracionCostos);
            Controls.Add(PanelMenu);
            Margin = new Padding(2);
            Name = "DashBoard";
            Text = "DashBoard";
            Load += DashBoard_Load;
            PanelMenu.ResumeLayout(false);
            PanelMenu.PerformLayout();
            panelRegistroReservacion.ResumeLayout(false);
            panelGestionHabitaciones.ResumeLayout(false);
            panelListaReservaciones.ResumeLayout(false);
            panelListaReservaciones.PerformLayout();
            panelSup3.ResumeLayout(false);
            panelSup3.PerformLayout();
            panelReportesBasicos.ResumeLayout(false);
            panelReportesBasicos.PerformLayout();
            panelSup2.ResumeLayout(false);
            panelSup2.PerformLayout();
            panelAdministracionCostos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colReservaciones;
        private DataGridViewTextBoxColumn colCancelaciones;
        private DataGridViewTextBoxColumn colIngresos;
        private TextBox txtIngresos;
        private TextBox txtCancelaciones;
        private TextBox txtReservacionesActivas;
        private TextBox txtOcupacionActual;
        private Label label8;
        private TextBox txtBuscador;
        private Label label10;
        private Label label9;
        private Button btnBuscar;
        private DataGridView dataGridView2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button btnExportarExcel2;
        private Button btnCancelarReservacion;
        private Button btnEditar;
        private DataGridViewTextBoxColumn colIDReserva;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colHabitacion;
        private DataGridViewTextBoxColumn colEntrada;
        private DataGridViewTextBoxColumn colSalida;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colMonto;
    }
}