using System;
using System.Windows.Forms;

namespace Desafio1_DAS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

        //Variables nuevas
      
       

        //private System.Windows.Forms.TextBox txtUsuarioId;
        //private System.Windows.Forms.TextBox txtNombreUsuario;
        //private System.Windows.Forms.TextBox txtEmailUsuario;

        //private System.Windows.Forms.TextBox txtUsuarioIdPrestamo;
        //private System.Windows.Forms.TextBox txtISBNPrestamo;
        //private System.Windows.Forms.TextBox txtPrestamoId;
   

        //private System.Windows.Forms.DataGridView dgvLibros;
        //private System.Windows.Forms.DataGridView dgvUsuarios;
        //private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.TabPage tabLibros;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.prestamos = new System.Windows.Forms.TabPage();
            this.dgvHistorialLibro = new System.Windows.Forms.DataGridView();
            this.fecha_devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_prestamo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarPrestamo = new System.Windows.Forms.Button();
            this.cmbUsuarioPrestamo = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.colFechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrestamoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbUsuarioDevolucion = new System.Windows.Forms.ComboBox();
            this.txtLibroIdPrestamo = new System.Windows.Forms.TextBox();
            this.txtLibroTituloPrestamo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.txtIdUsuarioDevolucion = new System.Windows.Forms.TextBox();
            this.txtFechaPrestamo = new System.Windows.Forms.TextBox();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegistrarDevolucion = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colEmailUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtUsuarioId = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.libros = new System.Windows.Forms.TabPage();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.ColAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtIdLibro = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chartLibros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Estadisticas = new System.Windows.Forms.TabPage();
            this.prestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.Usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.libros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Estadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // prestamos
            // 
            this.prestamos.Controls.Add(this.btnRegistrarDevolucion);
            this.prestamos.Controls.Add(this.label10);
            this.prestamos.Controls.Add(this.dtpFechaDevolucion);
            this.prestamos.Controls.Add(this.txtFechaPrestamo);
            this.prestamos.Controls.Add(this.txtIdUsuarioDevolucion);
            this.prestamos.Controls.Add(this.txtLibroTituloPrestamo);
            this.prestamos.Controls.Add(this.txtLibroIdPrestamo);
            this.prestamos.Controls.Add(this.dtpFechaPrestamo);
            this.prestamos.Controls.Add(this.label12);
            this.prestamos.Controls.Add(this.label11);
            this.prestamos.Controls.Add(this.cmbUsuarioDevolucion);
            this.prestamos.Controls.Add(this.dgvPrestamos);
            this.prestamos.Controls.Add(this.button7);
            this.prestamos.Controls.Add(this.button10);
            this.prestamos.Controls.Add(this.cmbUsuarioPrestamo);
            this.prestamos.Controls.Add(this.btnAgregarPrestamo);
            this.prestamos.Controls.Add(this.dgvHistorialLibro);
            this.prestamos.Location = new System.Drawing.Point(4, 25);
            this.prestamos.Name = "prestamos";
            this.prestamos.Padding = new System.Windows.Forms.Padding(3);
            this.prestamos.Size = new System.Drawing.Size(768, 397);
            this.prestamos.TabIndex = 2;
            this.prestamos.Text = "Prestamos";
            this.prestamos.UseVisualStyleBackColor = true;
            // 
            // dgvHistorialLibro
            // 
            this.dgvHistorialLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialLibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.fecha_prestamo2,
            this.fecha_devolucion});
            this.dgvHistorialLibro.EnableHeadersVisualStyles = false;
            this.dgvHistorialLibro.Location = new System.Drawing.Point(389, 46);
            this.dgvHistorialLibro.Name = "dgvHistorialLibro";
            this.dgvHistorialLibro.RowHeadersVisible = false;
            this.dgvHistorialLibro.RowHeadersWidth = 51;
            this.dgvHistorialLibro.RowTemplate.Height = 24;
            this.dgvHistorialLibro.Size = new System.Drawing.Size(364, 216);
            this.dgvHistorialLibro.TabIndex = 9;
            this.dgvHistorialLibro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // fecha_devolucion
            // 
            this.fecha_devolucion.HeaderText = "Fecha de Devolucion";
            this.fecha_devolucion.MinimumWidth = 6;
            this.fecha_devolucion.Name = "fecha_devolucion";
            this.fecha_devolucion.ReadOnly = true;
            this.fecha_devolucion.Width = 155;
            // 
            // fecha_prestamo2
            // 
            this.fecha_prestamo2.HeaderText = "Fecha de Prestamo";
            this.fecha_prestamo2.MinimumWidth = 6;
            this.fecha_prestamo2.Name = "fecha_prestamo2";
            this.fecha_prestamo2.ReadOnly = true;
            this.fecha_prestamo2.Width = 155;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAgregarPrestamo.FlatAppearance.BorderSize = 0;
            this.btnAgregarPrestamo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(6, 330);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(96, 39);
            this.btnAgregarPrestamo.TabIndex = 10;
            this.btnAgregarPrestamo.Text = "Añadir";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = false;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // cmbUsuarioPrestamo
            // 
            this.cmbUsuarioPrestamo.FormattingEnabled = true;
            this.cmbUsuarioPrestamo.Location = new System.Drawing.Point(20, 6);
            this.cmbUsuarioPrestamo.Name = "cmbUsuarioPrestamo";
            this.cmbUsuarioPrestamo.Size = new System.Drawing.Size(325, 24);
            this.cmbUsuarioPrestamo.TabIndex = 13;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(108, 330);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 39);
            this.button10.TabIndex = 14;
            this.button10.Text = "Editar";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btnEditarPrestamo_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(210, 330);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 39);
            this.button7.TabIndex = 15;
            this.button7.Text = "Eliminar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnEliminarPrestamo_Click);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrestamoId,
            this.colLibro,
            this.colFechaPrestamo});
            this.dgvPrestamos.EnableHeadersVisualStyles = false;
            this.dgvPrestamos.Location = new System.Drawing.Point(20, 46);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.Size = new System.Drawing.Size(325, 216);
            this.dgvPrestamos.TabIndex = 16;
            // 
            // colFechaPrestamo
            // 
            this.colFechaPrestamo.DataPropertyName = "FechaPrestamo";
            this.colFechaPrestamo.HeaderText = "Fecha de Prestamo";
            this.colFechaPrestamo.MinimumWidth = 6;
            this.colFechaPrestamo.Name = "colFechaPrestamo";
            this.colFechaPrestamo.ReadOnly = true;
            this.colFechaPrestamo.Width = 157;
            // 
            // colLibro
            // 
            this.colLibro.DataPropertyName = "Libro";
            this.colLibro.HeaderText = "Libro";
            this.colLibro.MinimumWidth = 6;
            this.colLibro.Name = "colLibro";
            this.colLibro.ReadOnly = true;
            this.colLibro.Width = 115;
            // 
            // colPrestamoId
            // 
            this.colPrestamoId.DataPropertyName = "Id";
            this.colPrestamoId.HeaderText = "ID";
            this.colPrestamoId.MinimumWidth = 6;
            this.colPrestamoId.Name = "colPrestamoId";
            this.colPrestamoId.ReadOnly = true;
            this.colPrestamoId.Width = 50;
            // 
            // cmbUsuarioDevolucion
            // 
            this.cmbUsuarioDevolucion.FormattingEnabled = true;
            this.cmbUsuarioDevolucion.Location = new System.Drawing.Point(389, 6);
            this.cmbUsuarioDevolucion.Name = "cmbUsuarioDevolucion";
            this.cmbUsuarioDevolucion.Size = new System.Drawing.Size(364, 24);
            this.cmbUsuarioDevolucion.TabIndex = 17;
            // 
            // txtLibroIdPrestamo
            // 
            this.txtLibroIdPrestamo.Location = new System.Drawing.Point(21, 298);
            this.txtLibroIdPrestamo.Name = "txtLibroIdPrestamo";
            this.txtLibroIdPrestamo.Size = new System.Drawing.Size(93, 22);
            this.txtLibroIdPrestamo.TabIndex = 18;
            this.txtLibroIdPrestamo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtLibroTituloPrestamo
            // 
            this.txtLibroTituloPrestamo.Location = new System.Drawing.Point(-4, 375);
            this.txtLibroTituloPrestamo.Name = "txtLibroTituloPrestamo";
            this.txtLibroTituloPrestamo.ReadOnly = true;
            this.txtLibroTituloPrestamo.Size = new System.Drawing.Size(118, 22);
            this.txtLibroTituloPrestamo.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Escriba el libro";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(139, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Fecha de prestamo";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(142, 296);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(250, 22);
            this.dtpFechaPrestamo.TabIndex = 24;
            // 
            // txtIdUsuarioDevolucion
            // 
            this.txtIdUsuarioDevolucion.Location = new System.Drawing.Point(131, 375);
            this.txtIdUsuarioDevolucion.Name = "txtIdUsuarioDevolucion";
            this.txtIdUsuarioDevolucion.ReadOnly = true;
            this.txtIdUsuarioDevolucion.Size = new System.Drawing.Size(118, 22);
            this.txtIdUsuarioDevolucion.TabIndex = 25;
            // 
            // txtFechaPrestamo
            // 
            this.txtFechaPrestamo.Location = new System.Drawing.Point(274, 372);
            this.txtFechaPrestamo.Name = "txtFechaPrestamo";
            this.txtFechaPrestamo.ReadOnly = true;
            this.txtFechaPrestamo.Size = new System.Drawing.Size(118, 22);
            this.txtFechaPrestamo.TabIndex = 26;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(503, 298);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(250, 22);
            this.dtpFechaDevolucion.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(500, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Fecha de devolucion";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnRegistrarDevolucion
            // 
            this.btnRegistrarDevolucion.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            this.btnRegistrarDevolucion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarDevolucion.Location = new System.Drawing.Point(589, 326);
            this.btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            this.btnRegistrarDevolucion.Size = new System.Drawing.Size(96, 39);
            this.btnRegistrarDevolucion.TabIndex = 29;
            this.btnRegistrarDevolucion.Text = "Añadir";
            this.btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            this.btnRegistrarDevolucion.Click += new System.EventHandler(this.btnRegistrarDevolucion_Click_1);
            // 
            // Usuarios
            // 
            this.Usuarios.Controls.Add(this.label5);
            this.Usuarios.Controls.Add(this.label4);
            this.Usuarios.Controls.Add(this.label2);
            this.Usuarios.Controls.Add(this.txtEmailUsuario);
            this.Usuarios.Controls.Add(this.txtNombreUsuario);
            this.Usuarios.Controls.Add(this.txtUsuarioId);
            this.Usuarios.Controls.Add(this.button4);
            this.Usuarios.Controls.Add(this.button5);
            this.Usuarios.Controls.Add(this.button6);
            this.Usuarios.Controls.Add(this.dgvUsuarios);
            this.Usuarios.Location = new System.Drawing.Point(4, 25);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.Usuarios.Size = new System.Drawing.Size(768, 397);
            this.Usuarios.TabIndex = 1;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsuarioId,
            this.colNombreUsuario,
            this.colEmailUsuario});
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(21, 20);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(503, 230);
            this.dgvUsuarios.TabIndex = 5;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // colEmailUsuario
            // 
            this.colEmailUsuario.DataPropertyName = "Email";
            this.colEmailUsuario.HeaderText = "Correo Electronico";
            this.colEmailUsuario.MinimumWidth = 6;
            this.colEmailUsuario.Name = "colEmailUsuario";
            this.colEmailUsuario.ReadOnly = true;
            this.colEmailUsuario.Width = 245;
            // 
            // colNombreUsuario
            // 
            this.colNombreUsuario.DataPropertyName = "Nombre";
            this.colNombreUsuario.HeaderText = "Nombre";
            this.colNombreUsuario.MinimumWidth = 6;
            this.colNombreUsuario.Name = "colNombreUsuario";
            this.colNombreUsuario.ReadOnly = true;
            this.colNombreUsuario.Width = 205;
            // 
            // colUsuarioId
            // 
            this.colUsuarioId.DataPropertyName = "Id";
            this.colUsuarioId.HeaderText = "ID";
            this.colUsuarioId.MinimumWidth = 6;
            this.colUsuarioId.Name = "colUsuarioId";
            this.colUsuarioId.ReadOnly = true;
            this.colUsuarioId.Width = 50;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(21, 276);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 39);
            this.button6.TabIndex = 6;
            this.button6.Text = "Añadir";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(207, 276);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 39);
            this.button5.TabIndex = 7;
            this.button5.Text = "Editar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(385, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 39);
            this.button4.TabIndex = 8;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // txtUsuarioId
            // 
            this.txtUsuarioId.Location = new System.Drawing.Point(546, 67);
            this.txtUsuarioId.Name = "txtUsuarioId";
            this.txtUsuarioId.Size = new System.Drawing.Size(51, 22);
            this.txtUsuarioId.TabIndex = 9;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(546, 142);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(204, 22);
            this.txtNombreUsuario.TabIndex = 10;
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Location = new System.Drawing.Point(546, 207);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(193, 22);
            this.txtEmailUsuario.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Escriba el ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Escriba el Nombre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Escriba el Email";
            // 
            // libros
            // 
            this.libros.Controls.Add(this.label9);
            this.libros.Controls.Add(this.label8);
            this.libros.Controls.Add(this.label7);
            this.libros.Controls.Add(this.label6);
            this.libros.Controls.Add(this.txtAño);
            this.libros.Controls.Add(this.txtAutor);
            this.libros.Controls.Add(this.txtTitulo);
            this.libros.Controls.Add(this.txtIdLibro);
            this.libros.Controls.Add(this.button3);
            this.libros.Controls.Add(this.button2);
            this.libros.Controls.Add(this.button1);
            this.libros.Controls.Add(this.dgvLibros);
            this.libros.Location = new System.Drawing.Point(4, 25);
            this.libros.Name = "libros";
            this.libros.Padding = new System.Windows.Forms.Padding(3);
            this.libros.Size = new System.Drawing.Size(768, 397);
            this.libros.TabIndex = 0;
            this.libros.Text = "Libros";
            this.libros.UseVisualStyleBackColor = true;
            this.libros.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTitulo,
            this.ColAutor,
            this.ColAño});
            this.dgvLibros.EnableHeadersVisualStyles = false;
            this.dgvLibros.Location = new System.Drawing.Point(17, 23);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(503, 230);
            this.dgvLibros.TabIndex = 1;
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ColAño
            // 
            this.ColAño.DataPropertyName = "Año";
            this.ColAño.HeaderText = "Año";
            this.ColAño.MinimumWidth = 6;
            this.ColAño.Name = "ColAño";
            this.ColAño.ReadOnly = true;
            this.ColAño.Width = 125;
            // 
            // ColAutor
            // 
            this.ColAutor.DataPropertyName = "Autor";
            this.ColAutor.HeaderText = "Autor";
            this.ColAutor.MinimumWidth = 6;
            this.ColAutor.Name = "ColAutor";
            this.ColAutor.ReadOnly = true;
            this.ColAutor.Width = 125;
            // 
            // colTitulo
            // 
            this.colTitulo.DataPropertyName = "Titulo";
            this.colTitulo.HeaderText = "Título";
            this.colTitulo.MinimumWidth = 6;
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            this.colTitulo.Width = 125;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(17, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(203, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnEditarLibro_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(381, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // txtIdLibro
            // 
            this.txtIdLibro.Location = new System.Drawing.Point(548, 72);
            this.txtIdLibro.Name = "txtIdLibro";
            this.txtIdLibro.Size = new System.Drawing.Size(131, 22);
            this.txtIdLibro.TabIndex = 5;
            this.txtIdLibro.TextChanged += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(548, 126);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(131, 22);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(548, 178);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(131, 22);
            this.txtAutor.TabIndex = 7;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(548, 231);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(131, 22);
            this.txtAño.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Escriba el ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Escriba el Titulo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(553, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Escriba el Autor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Escriba el Año";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.libros);
            this.tabControl1.Controls.Add(this.Usuarios);
            this.tabControl1.Controls.Add(this.prestamos);
            this.tabControl1.Controls.Add(this.Estadisticas);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // chartLibros
            // 
            chartArea3.Name = "ChartArea1";
            this.chartLibros.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartLibros.Legends.Add(legend3);
            this.chartLibros.Location = new System.Drawing.Point(48, 74);
            this.chartLibros.Name = "chartLibros";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartLibros.Series.Add(series3);
            this.chartLibros.Size = new System.Drawing.Size(292, 261);
            this.chartLibros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 36);
            this.label3.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(461, 74);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(292, 261);
            this.chart1.TabIndex = 4;
            // 
            // Estadisticas
            // 
            this.Estadisticas.Controls.Add(this.chart1);
            this.Estadisticas.Controls.Add(this.label3);
            this.Estadisticas.Controls.Add(this.label1);
            this.Estadisticas.Controls.Add(this.chartLibros);
            this.Estadisticas.Location = new System.Drawing.Point(4, 25);
            this.Estadisticas.Name = "Estadisticas";
            this.Estadisticas.Padding = new System.Windows.Forms.Padding(3);
            this.Estadisticas.Size = new System.Drawing.Size(768, 397);
            this.Estadisticas.TabIndex = 3;
            this.Estadisticas.Text = "Estadisticas";
            this.Estadisticas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.prestamos.ResumeLayout(false);
            this.prestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.Usuarios.ResumeLayout(false);
            this.Usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.libros.ResumeLayout(false);
            this.libros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Estadisticas.ResumeLayout(false);
            this.Estadisticas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage prestamos;
        private Button btnRegistrarDevolucion;
        private Label label10;
        private DateTimePicker dtpFechaDevolucion;
        private TextBox txtFechaPrestamo;
        private TextBox txtIdUsuarioDevolucion;
        private TextBox txtLibroTituloPrestamo;
        private TextBox txtLibroIdPrestamo;
        private DateTimePicker dtpFechaPrestamo;
        private Label label12;
        private Label label11;
        private ComboBox cmbUsuarioDevolucion;
        private DataGridView dgvPrestamos;
        private DataGridViewTextBoxColumn colPrestamoId;
        private DataGridViewTextBoxColumn colLibro;
        private DataGridViewTextBoxColumn colFechaPrestamo;
        private Button button7;
        private Button button10;
        private ComboBox cmbUsuarioPrestamo;
        private Button btnAgregarPrestamo;
        private DataGridView dgvHistorialLibro;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fecha_prestamo2;
        private DataGridViewTextBoxColumn fecha_devolucion;
        private TabPage Usuarios;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txtEmailUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtUsuarioId;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn colUsuarioId;
        private DataGridViewTextBoxColumn colNombreUsuario;
        private DataGridViewTextBoxColumn colEmailUsuario;
        private TabPage libros;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtAño;
        private TextBox txtAutor;
        private TextBox txtTitulo;
        private TextBox txtIdLibro;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dgvLibros;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitulo;
        private DataGridViewTextBoxColumn ColAutor;
        private DataGridViewTextBoxColumn ColAño;
        private TabControl tabControl1;
        private TabPage Estadisticas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label3;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLibros;
    }
}