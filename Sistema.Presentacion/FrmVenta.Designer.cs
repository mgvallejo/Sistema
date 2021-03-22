
namespace Sistema.Presentacion
{
    partial class FrmVenta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.CboComprobante = new System.Windows.Forms.ComboBox();
            this.txtNumComprobante = new System.Windows.Forms.TextBox();
            this.txtSerieComprobante = new System.Windows.Forms.TextBox();
            this.BtnAnular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.ErroIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PanelMostrar = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnCloseDetalle = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DgvMostrarDetalle = new System.Windows.Forms.DataGridView();
            this.TxtSubTotalD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtTotalD = new System.Windows.Forms.TextBox();
            this.TxtTotalImpuestoD = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PanelArticulos = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.BtnFiltrarArticulos = new System.Windows.Forms.Button();
            this.TxtBuscarArticulo = new System.Windows.Forms.TextBox();
            this.LblTotalArticulos = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnVerArticulo = new System.Windows.Forms.Button();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtTotalImpuesto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtImpuesto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnComprobante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErroIcono)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelMostrar.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalle)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.PanelArticulos.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Enabled = false;
            this.TxtNombreCliente.Location = new System.Drawing.Point(109, 27);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(623, 25);
            this.TxtNombreCliente.TabIndex = 1;
            // 
            // CboComprobante
            // 
            this.CboComprobante.FormattingEnabled = true;
            this.CboComprobante.Items.AddRange(new object[] {
            "FACTURA",
            "BOLETA",
            "TICKET",
            "GUIA"});
            this.CboComprobante.Location = new System.Drawing.Point(109, 75);
            this.CboComprobante.Name = "CboComprobante";
            this.CboComprobante.Size = new System.Drawing.Size(195, 26);
            this.CboComprobante.TabIndex = 5;
            this.CboComprobante.Text = "FACTURA";
            // 
            // txtNumComprobante
            // 
            this.txtNumComprobante.Location = new System.Drawing.Point(524, 76);
            this.txtNumComprobante.Name = "txtNumComprobante";
            this.txtNumComprobante.Size = new System.Drawing.Size(208, 25);
            this.txtNumComprobante.TabIndex = 1;
            // 
            // txtSerieComprobante
            // 
            this.txtSerieComprobante.Location = new System.Drawing.Point(310, 76);
            this.txtSerieComprobante.Name = "txtSerieComprobante";
            this.txtSerieComprobante.Size = new System.Drawing.Size(208, 25);
            this.txtSerieComprobante.TabIndex = 1;
            // 
            // BtnAnular
            // 
            this.BtnAnular.Location = new System.Drawing.Point(116, 431);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(75, 25);
            this.BtnAnular.TabIndex = 5;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.UseVisualStyleBackColor = true;
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            this.label2.Visible = false;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(320, 48);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(100, 25);
            this.TxtId.TabIndex = 6;
            this.TxtId.Visible = false;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(703, 435);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(38, 18);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "Total";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.DgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(6, 37);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(890, 388);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // ErroIcono
            // 
            this.ErroIcono.ContainerControl = this;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(6, 6);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(694, 25);
            this.TxtBuscar.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 50);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTAS";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(706, 6);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 25);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Controls.Add(this.tabPage2);
            this.tabGeneral.Location = new System.Drawing.Point(12, 62);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(910, 520);
            this.tabGeneral.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnComprobante);
            this.tabPage1.Controls.Add(this.PanelMostrar);
            this.tabPage1.Controls.Add(this.BtnAnular);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(902, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PanelMostrar
            // 
            this.PanelMostrar.BackColor = System.Drawing.Color.White;
            this.PanelMostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMostrar.Controls.Add(this.panel6);
            this.PanelMostrar.Controls.Add(this.panel5);
            this.PanelMostrar.Location = new System.Drawing.Point(78, 120);
            this.PanelMostrar.Name = "PanelMostrar";
            this.PanelMostrar.Size = new System.Drawing.Size(762, 351);
            this.PanelMostrar.TabIndex = 6;
            this.PanelMostrar.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panel6.Controls.Add(this.BtnCloseDetalle);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(760, 50);
            this.panel6.TabIndex = 15;
            // 
            // BtnCloseDetalle
            // 
            this.BtnCloseDetalle.FlatAppearance.BorderSize = 0;
            this.BtnCloseDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseDetalle.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseDetalle.Image")));
            this.BtnCloseDetalle.Location = new System.Drawing.Point(717, 11);
            this.BtnCloseDetalle.Name = "BtnCloseDetalle";
            this.BtnCloseDetalle.Size = new System.Drawing.Size(25, 25);
            this.BtnCloseDetalle.TabIndex = 4;
            this.BtnCloseDetalle.UseVisualStyleBackColor = true;
            this.BtnCloseDetalle.Click += new System.EventHandler(this.BtnCloseDetalle_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(12, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 22);
            this.label17.TabIndex = 0;
            this.label17.Text = "DETALLES DE VENTAS";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DgvMostrarDetalle);
            this.panel5.Controls.Add(this.TxtSubTotalD);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.TxtTotalD);
            this.panel5.Controls.Add(this.TxtTotalImpuestoD);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(3, 56);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(15);
            this.panel5.Size = new System.Drawing.Size(756, 292);
            this.panel5.TabIndex = 14;
            // 
            // DgvMostrarDetalle
            // 
            this.DgvMostrarDetalle.AllowUserToAddRows = false;
            this.DgvMostrarDetalle.AllowUserToDeleteRows = false;
            this.DgvMostrarDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.DgvMostrarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMostrarDetalle.Location = new System.Drawing.Point(18, 18);
            this.DgvMostrarDetalle.Name = "DgvMostrarDetalle";
            this.DgvMostrarDetalle.ReadOnly = true;
            this.DgvMostrarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMostrarDetalle.Size = new System.Drawing.Size(720, 163);
            this.DgvMostrarDetalle.TabIndex = 0;
            // 
            // TxtSubTotalD
            // 
            this.TxtSubTotalD.Enabled = false;
            this.TxtSubTotalD.Location = new System.Drawing.Point(594, 187);
            this.TxtSubTotalD.Name = "TxtSubTotalD";
            this.TxtSubTotalD.Size = new System.Drawing.Size(144, 25);
            this.TxtSubTotalD.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(489, 252);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 18);
            this.label16.TabIndex = 10;
            this.label16.Text = "Total";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(489, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 18);
            this.label14.TabIndex = 8;
            this.label14.Text = "Sub Total";
            // 
            // TxtTotalD
            // 
            this.TxtTotalD.Enabled = false;
            this.TxtTotalD.Location = new System.Drawing.Point(594, 249);
            this.TxtTotalD.Name = "TxtTotalD";
            this.TxtTotalD.Size = new System.Drawing.Size(144, 25);
            this.TxtTotalD.TabIndex = 13;
            // 
            // TxtTotalImpuestoD
            // 
            this.TxtTotalImpuestoD.Enabled = false;
            this.TxtTotalImpuestoD.Location = new System.Drawing.Point(594, 218);
            this.TxtTotalImpuestoD.Name = "TxtTotalImpuestoD";
            this.TxtTotalImpuestoD.Size = new System.Drawing.Size(144, 25);
            this.TxtTotalImpuestoD.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(489, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 18);
            this.label15.TabIndex = 9;
            this.label15.Text = "Total Impuesto";
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(16, 434);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(94, 22);
            this.ChkSeleccionar.TabIndex = 4;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.ChkSeleccionar_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PanelArticulos);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnInsertar);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(902, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelArticulos
            // 
            this.PanelArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelArticulos.Controls.Add(this.panel4);
            this.PanelArticulos.Controls.Add(this.panel3);
            this.PanelArticulos.Location = new System.Drawing.Point(127, 140);
            this.PanelArticulos.Name = "PanelArticulos";
            this.PanelArticulos.Size = new System.Drawing.Size(692, 283);
            this.PanelArticulos.TabIndex = 6;
            this.PanelArticulos.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DgvArticulos);
            this.panel4.Controls.Add(this.BtnFiltrarArticulos);
            this.panel4.Controls.Add(this.TxtBuscarArticulo);
            this.panel4.Controls.Add(this.LblTotalArticulos);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15);
            this.panel4.Size = new System.Drawing.Size(690, 231);
            this.panel4.TabIndex = 5;
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.AllowUserToAddRows = false;
            this.DgvArticulos.AllowUserToDeleteRows = false;
            this.DgvArticulos.AllowUserToOrderColumns = true;
            this.DgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.Location = new System.Drawing.Point(21, 45);
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.ReadOnly = true;
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(653, 159);
            this.DgvArticulos.TabIndex = 5;
            this.DgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArticulos_CellDoubleClick);
            // 
            // BtnFiltrarArticulos
            // 
            this.BtnFiltrarArticulos.Location = new System.Drawing.Point(577, 14);
            this.BtnFiltrarArticulos.Name = "BtnFiltrarArticulos";
            this.BtnFiltrarArticulos.Size = new System.Drawing.Size(97, 25);
            this.BtnFiltrarArticulos.TabIndex = 4;
            this.BtnFiltrarArticulos.Text = "Buscar";
            this.BtnFiltrarArticulos.UseVisualStyleBackColor = true;
            this.BtnFiltrarArticulos.Click += new System.EventHandler(this.BtnFiltrarArticulos_Click);
            // 
            // TxtBuscarArticulo
            // 
            this.TxtBuscarArticulo.Location = new System.Drawing.Point(72, 14);
            this.TxtBuscarArticulo.Name = "TxtBuscarArticulo";
            this.TxtBuscarArticulo.Size = new System.Drawing.Size(499, 25);
            this.TxtBuscarArticulo.TabIndex = 1;
            // 
            // LblTotalArticulos
            // 
            this.LblTotalArticulos.AutoSize = true;
            this.LblTotalArticulos.Location = new System.Drawing.Point(530, 207);
            this.LblTotalArticulos.Name = "LblTotalArticulos";
            this.LblTotalArticulos.Size = new System.Drawing.Size(41, 18);
            this.LblTotalArticulos.TabIndex = 0;
            this.LblTotalArticulos.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Buscar";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.BtnClose);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 50);
            this.panel3.TabIndex = 4;
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(649, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(25, 25);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "ARTÍCULOS";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(121, 451);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(97, 25);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(18, 451);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(97, 25);
            this.BtnInsertar.TabIndex = 4;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvDetalle);
            this.groupBox2.Controls.Add(this.TxtCodigo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnVerArticulo);
            this.groupBox2.Controls.Add(this.TxtSubTotal);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtTotalImpuesto);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxtTotal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(18, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(866, 305);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.AllowUserToAddRows = false;
            this.DgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalle.Location = new System.Drawing.Point(13, 56);
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDetalle.Size = new System.Drawing.Size(840, 145);
            this.DgvDetalle.TabIndex = 5;
            this.DgvDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalle_CellEndEdit);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(96, 25);
            this.TxtCodigo.MaxLength = 10;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(654, 25);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Artículos";
            // 
            // BtnVerArticulo
            // 
            this.BtnVerArticulo.Location = new System.Drawing.Point(756, 25);
            this.BtnVerArticulo.Name = "BtnVerArticulo";
            this.BtnVerArticulo.Size = new System.Drawing.Size(97, 25);
            this.BtnVerArticulo.TabIndex = 4;
            this.BtnVerArticulo.Text = "Ver";
            this.BtnVerArticulo.UseVisualStyleBackColor = true;
            this.BtnVerArticulo.Click += new System.EventHandler(this.BtnVerArticulo_Click);
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Enabled = false;
            this.TxtSubTotal.Location = new System.Drawing.Point(709, 207);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(144, 25);
            this.TxtSubTotal.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sub Total";
            // 
            // TxtTotalImpuesto
            // 
            this.TxtTotalImpuesto.Enabled = false;
            this.TxtTotalImpuesto.Location = new System.Drawing.Point(709, 238);
            this.TxtTotalImpuesto.Name = "TxtTotalImpuesto";
            this.TxtTotalImpuesto.Size = new System.Drawing.Size(144, 25);
            this.TxtTotalImpuesto.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(604, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Impuesto";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(709, 269);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(144, 25);
            this.TxtTotal.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(604, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNombreCliente);
            this.groupBox1.Controls.Add(this.CboComprobante);
            this.groupBox1.Controls.Add(this.TxtImpuesto);
            this.groupBox1.Controls.Add(this.txtNumComprobante);
            this.groupBox1.Controls.Add(this.txtSerieComprobante);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtIdCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BtnBuscarCliente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(866, 116);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            // 
            // TxtImpuesto
            // 
            this.TxtImpuesto.Location = new System.Drawing.Point(738, 76);
            this.TxtImpuesto.Name = "TxtImpuesto";
            this.TxtImpuesto.Size = new System.Drawing.Size(115, 25);
            this.TxtImpuesto.TabIndex = 1;
            this.TxtImpuesto.Text = "0,18";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(735, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Impuesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numero";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Enabled = false;
            this.TxtIdCliente.Location = new System.Drawing.Point(109, 27);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(195, 25);
            this.TxtIdCliente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cliente (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Serie";
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Location = new System.Drawing.Point(738, 27);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(97, 25);
            this.BtnBuscarCliente.TabIndex = 4;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Comprobante";
            // 
            // BtnComprobante
            // 
            this.BtnComprobante.Location = new System.Drawing.Point(787, 6);
            this.BtnComprobante.Name = "BtnComprobante";
            this.BtnComprobante.Size = new System.Drawing.Size(109, 25);
            this.BtnComprobante.TabIndex = 7;
            this.BtnComprobante.Text = "Comprobante";
            this.BtnComprobante.UseVisualStyleBackColor = true;
            this.BtnComprobante.Click += new System.EventHandler(this.BtnComprobante_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 588);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabGeneral);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErroIcono)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.PanelMostrar.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalle)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.PanelArticulos.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.ComboBox CboComprobante;
        private System.Windows.Forms.TextBox txtNumComprobante;
        private System.Windows.Forms.TextBox txtSerieComprobante;
        private System.Windows.Forms.Button BtnAnular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.ErrorProvider ErroIcono;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel PanelMostrar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnCloseDetalle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView DgvMostrarDetalle;
        private System.Windows.Forms.TextBox TxtSubTotalD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtTotalD;
        private System.Windows.Forms.TextBox TxtTotalImpuestoD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PanelArticulos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.Button BtnFiltrarArticulos;
        private System.Windows.Forms.TextBox TxtBuscarArticulo;
        private System.Windows.Forms.Label LblTotalArticulos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvDetalle;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnVerArticulo;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtTotalImpuesto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtImpuesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnComprobante;
    }
}