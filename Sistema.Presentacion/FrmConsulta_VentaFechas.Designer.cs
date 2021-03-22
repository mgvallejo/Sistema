
namespace Sistema.Presentacion
{
    partial class FrmConsulta_VentaFechas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta_VentaFechas));
            this.BtnComprobante = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PanelMostrar = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DgvMostrarDetalle = new System.Windows.Forms.DataGridView();
            this.TxtSubTotalD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtTotalD = new System.Windows.Forms.TextBox();
            this.TxtTotalImpuestoD = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnCloseDetalle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelMostrar.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarDetalle)).BeginInit();
            this.SuspendLayout();
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
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(703, 457);
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
            this.DgvListado.Size = new System.Drawing.Size(890, 405);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 50);
            this.panel1.TabIndex = 11;
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
            this.tabGeneral.Location = new System.Drawing.Point(12, 65);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(910, 520);
            this.tabGeneral.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DtpFechaFin);
            this.tabPage1.Controls.Add(this.DtpFechaInicio);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.BtnComprobante);
            this.tabPage1.Controls.Add(this.PanelMostrar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
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
            this.PanelMostrar.Location = new System.Drawing.Point(49, 65);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Desde";
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicio.Location = new System.Drawing.Point(55, 8);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(118, 25);
            this.DtpFechaInicio.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta";
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFin.Location = new System.Drawing.Point(240, 8);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(118, 25);
            this.DtpFechaFin.TabIndex = 9;
            // 
            // FrmConsulta_VentaFechas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabGeneral);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsulta_VentaFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Ventas entre fechas";
            this.Load += new System.EventHandler(this.FrmConsulta_VentaFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnComprobante;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
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
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}