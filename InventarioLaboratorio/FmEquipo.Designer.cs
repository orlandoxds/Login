﻿namespace InventarioLaboratorio
{
    partial class FmEquipo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmEquipo));
            this.dgvEquipo = new System.Windows.Forms.DataGridView();
            this.lstEstado = new System.Windows.Forms.ComboBox();
            this.lstLaboratorio = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblExixtencia = new System.Windows.Forms.Label();
            this.txtBscNom = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtBscrMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtBscrModelo = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtBscObserv = new System.Windows.Forms.TextBox();
            this.lblInvITT = new System.Windows.Forms.Label();
            this.txtInvITT = new System.Windows.Forms.TextBox();
            this.lblInvSEP = new System.Windows.Forms.Label();
            this.txtInvSEP = new System.Windows.Forms.TextBox();
            this.lblBscOP = new System.Windows.Forms.Label();
            this.txtBscManual = new System.Windows.Forms.TextBox();
            this.lblBscSerie = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipo
            // 
            this.dgvEquipo.AllowUserToAddRows = false;
            this.dgvEquipo.AllowUserToDeleteRows = false;
            this.dgvEquipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipo.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquipo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipo.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvEquipo.Location = new System.Drawing.Point(30, 369);
            this.dgvEquipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEquipo.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvEquipo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipo.Size = new System.Drawing.Size(1725, 615);
            this.dgvEquipo.TabIndex = 34;
            this.dgvEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipo_CellContentClick);
            // 
            // lstEstado
            // 
            this.lstEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEstado.FormattingEnabled = true;
            this.lstEstado.Items.AddRange(new object[] {
            "Activo",
            "Baja"});
            this.lstEstado.Location = new System.Drawing.Point(174, 174);
            this.lstEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstEstado.Name = "lstEstado";
            this.lstEstado.Size = new System.Drawing.Size(268, 45);
            this.lstEstado.TabIndex = 33;
            // 
            // lstLaboratorio
            // 
            this.lstLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLaboratorio.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLaboratorio.FormattingEnabled = true;
            this.lstLaboratorio.Items.AddRange(new object[] {
            "Laboratorio 1",
            "Laboratorio 2",
            "Laboratorio 3",
            "Laboratorio 4"});
            this.lstLaboratorio.Location = new System.Drawing.Point(174, 103);
            this.lstLaboratorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstLaboratorio.Name = "lstLaboratorio";
            this.lstLaboratorio.Size = new System.Drawing.Size(268, 45);
            this.lstLaboratorio.TabIndex = 32;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.Location = new System.Drawing.Point(453, 103);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 54);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(18, 183);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 37);
            this.lblEstado.TabIndex = 29;
            this.lblEstado.Text = "Estado";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(814, 35);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(130, 45);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Equipo";
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.ForeColor = System.Drawing.Color.White;
            this.lblLaboratorio.Location = new System.Drawing.Point(18, 108);
            this.lblLaboratorio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(148, 37);
            this.lblLaboratorio.TabIndex = 35;
            this.lblLaboratorio.Text = "Ubicación:";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolver.Location = new System.Drawing.Point(1562, 169);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(180, 54);
            this.btnVolver.TabIndex = 36;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(994, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 54);
            this.button1.TabIndex = 37;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Enabled = false;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExportar.Location = new System.Drawing.Point(1374, 168);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(180, 54);
            this.btnExportar.TabIndex = 41;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.Location = new System.Drawing.Point(1184, 169);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 54);
            this.btnEditar.TabIndex = 42;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.lblCerrarSesion.Location = new System.Drawing.Point(1560, 46);
            this.lblCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(182, 37);
            this.lblCerrarSesion.TabIndex = 43;
            this.lblCerrarSesion.Text = "Cerrar sesion";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(1564, 98);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(178, 44);
            this.txtEstado.TabIndex = 85;
            // 
            // lblExixtencia
            // 
            this.lblExixtencia.AutoSize = true;
            this.lblExixtencia.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExixtencia.ForeColor = System.Drawing.Color.White;
            this.lblExixtencia.Location = new System.Drawing.Point(1370, 103);
            this.lblExixtencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExixtencia.Name = "lblExixtencia";
            this.lblExixtencia.Size = new System.Drawing.Size(185, 37);
            this.lblExixtencia.TabIndex = 84;
            this.lblExixtencia.Text = "En existencia:";
            // 
            // txtBscNom
            // 
            this.txtBscNom.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBscNom.Location = new System.Drawing.Point(30, 311);
            this.txtBscNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBscNom.Name = "txtBscNom";
            this.txtBscNom.Size = new System.Drawing.Size(200, 36);
            this.txtBscNom.TabIndex = 86;
            this.txtBscNom.Visible = false;
            this.txtBscNom.TextChanged += new System.EventHandler(this.txtBscNom_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(32, 271);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(106, 30);
            this.lblNombre.TabIndex = 87;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Visible = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(236, 274);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(83, 30);
            this.lblMarca.TabIndex = 89;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.Visible = false;
            // 
            // txtBscrMarca
            // 
            this.txtBscrMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBscrMarca.Location = new System.Drawing.Point(242, 311);
            this.txtBscrMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBscrMarca.Name = "txtBscrMarca";
            this.txtBscrMarca.Size = new System.Drawing.Size(200, 36);
            this.txtBscrMarca.TabIndex = 88;
            this.txtBscrMarca.Visible = false;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(447, 274);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(101, 30);
            this.lblModelo.TabIndex = 91;
            this.lblModelo.Text = "Modelo:";
            this.lblModelo.Visible = false;
            // 
            // txtBscrModelo
            // 
            this.txtBscrModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBscrModelo.Location = new System.Drawing.Point(453, 311);
            this.txtBscrModelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBscrModelo.Name = "txtBscrModelo";
            this.txtBscrModelo.Size = new System.Drawing.Size(200, 36);
            this.txtBscrModelo.TabIndex = 90;
            this.txtBscrModelo.Visible = false;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.ForeColor = System.Drawing.Color.White;
            this.lblObservacion.Location = new System.Drawing.Point(1504, 271);
            this.lblObservacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(150, 30);
            this.lblObservacion.TabIndex = 93;
            this.lblObservacion.Text = "Observacion:";
            this.lblObservacion.Visible = false;
            // 
            // txtBscObserv
            // 
            this.txtBscObserv.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBscObserv.Location = new System.Drawing.Point(1510, 311);
            this.txtBscObserv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBscObserv.Name = "txtBscObserv";
            this.txtBscObserv.Size = new System.Drawing.Size(238, 36);
            this.txtBscObserv.TabIndex = 92;
            this.txtBscObserv.Visible = false;
            // 
            // lblInvITT
            // 
            this.lblInvITT.AutoSize = true;
            this.lblInvITT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvITT.ForeColor = System.Drawing.Color.White;
            this.lblInvITT.Location = new System.Drawing.Point(658, 274);
            this.lblInvITT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvITT.Name = "lblInvITT";
            this.lblInvITT.Size = new System.Drawing.Size(133, 30);
            this.lblInvITT.TabIndex = 97;
            this.lblInvITT.Text = "No. Inv ITT:";
            this.lblInvITT.Visible = false;
            // 
            // txtInvITT
            // 
            this.txtInvITT.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvITT.Location = new System.Drawing.Point(664, 311);
            this.txtInvITT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInvITT.Name = "txtInvITT";
            this.txtInvITT.Size = new System.Drawing.Size(200, 36);
            this.txtInvITT.TabIndex = 96;
            this.txtInvITT.Visible = false;
            // 
            // lblInvSEP
            // 
            this.lblInvSEP.AutoSize = true;
            this.lblInvSEP.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvSEP.ForeColor = System.Drawing.Color.White;
            this.lblInvSEP.Location = new System.Drawing.Point(870, 274);
            this.lblInvSEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvSEP.Name = "lblInvSEP";
            this.lblInvSEP.Size = new System.Drawing.Size(139, 30);
            this.lblInvSEP.TabIndex = 99;
            this.lblInvSEP.Text = "No. Inv SEP:";
            this.lblInvSEP.Visible = false;
            // 
            // txtInvSEP
            // 
            this.txtInvSEP.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvSEP.Location = new System.Drawing.Point(876, 311);
            this.txtInvSEP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInvSEP.Name = "txtInvSEP";
            this.txtInvSEP.Size = new System.Drawing.Size(200, 36);
            this.txtInvSEP.TabIndex = 98;
            this.txtInvSEP.Visible = false;
            // 
            // lblBscOP
            // 
            this.lblBscOP.AutoSize = true;
            this.lblBscOP.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBscOP.ForeColor = System.Drawing.Color.White;
            this.lblBscOP.Location = new System.Drawing.Point(1082, 274);
            this.lblBscOP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBscOP.Name = "lblBscOP";
            this.lblBscOP.Size = new System.Drawing.Size(133, 30);
            this.lblBscOP.TabIndex = 101;
            this.lblBscOP.Text = "Manual op:";
            this.lblBscOP.Visible = false;
            // 
            // txtBscManual
            // 
            this.txtBscManual.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBscManual.Location = new System.Drawing.Point(1088, 311);
            this.txtBscManual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBscManual.Name = "txtBscManual";
            this.txtBscManual.Size = new System.Drawing.Size(200, 36);
            this.txtBscManual.TabIndex = 100;
            this.txtBscManual.Visible = false;
            // 
            // lblBscSerie
            // 
            this.lblBscSerie.AutoSize = true;
            this.lblBscSerie.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBscSerie.ForeColor = System.Drawing.Color.White;
            this.lblBscSerie.Location = new System.Drawing.Point(1293, 274);
            this.lblBscSerie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBscSerie.Name = "lblBscSerie";
            this.lblBscSerie.Size = new System.Drawing.Size(136, 30);
            this.lblBscSerie.TabIndex = 103;
            this.lblBscSerie.Text = "Num. Serie:";
            this.lblBscSerie.Visible = false;
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(1299, 311);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(200, 36);
            this.txtSerie.TabIndex = 102;
            this.txtSerie.Visible = false;
            // 
            // FmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1776, 1017);
            this.Controls.Add(this.lblBscSerie);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblBscOP);
            this.Controls.Add(this.txtBscManual);
            this.Controls.Add(this.lblInvSEP);
            this.Controls.Add(this.txtInvSEP);
            this.Controls.Add(this.lblInvITT);
            this.Controls.Add(this.txtInvITT);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.txtBscObserv);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtBscrModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtBscrMarca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBscNom);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblExixtencia);
            this.Controls.Add(this.lblCerrarSesion);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.dgvEquipo);
            this.Controls.Add(this.lstEstado);
            this.Controls.Add(this.lstLaboratorio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FmEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Activo Fijo";
            this.Load += new System.EventHandler(this.FmEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquipo;
        private System.Windows.Forms.ComboBox lstEstado;
        private System.Windows.Forms.ComboBox lstLaboratorio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblExixtencia;
        private System.Windows.Forms.TextBox txtBscNom;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBscrMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtBscrModelo;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtBscObserv;
        private System.Windows.Forms.Label lblInvITT;
        private System.Windows.Forms.TextBox txtInvITT;
        private System.Windows.Forms.Label lblInvSEP;
        private System.Windows.Forms.TextBox txtInvSEP;
        private System.Windows.Forms.Label lblBscOP;
        private System.Windows.Forms.TextBox txtBscManual;
        private System.Windows.Forms.Label lblBscSerie;
        private System.Windows.Forms.TextBox txtSerie;
    }
}