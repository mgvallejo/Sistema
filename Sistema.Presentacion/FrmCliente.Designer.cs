
namespace Sistema.Presentacion
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.ErroIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNumDocumento = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ErroIcono)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErroIcono
            // 
            this.ErroIcono.ContainerControl = this;
            // 
            // CboTipoDocumento
            // 
            this.CboTipoDocumento.FormattingEnabled = true;
            this.CboTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "RUC",
            "CEDULA",
            "PASAPORTE",
            "OTROS"});
            this.CboTipoDocumento.Location = new System.Drawing.Point(392, 90);
            this.CboTipoDocumento.Name = "CboTipoDocumento";
            this.CboTipoDocumento.Size = new System.Drawing.Size(337, 26);
            this.CboTipoDocumento.TabIndex = 5;
            this.CboTipoDocumento.Text = "DNI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(392, 190);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(337, 25);
            this.TxtEmail.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtEmail);
            this.tabPage2.Controls.Add(this.CboTipoDocumento);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnActualizar);
            this.tabPage2.Controls.Add(this.BtnInsertar);
            this.tabPage2.Controls.Add(this.TxtDireccion);
            this.tabPage2.Controls.Add(this.TxtNumDocumento);
            this.tabPage2.Controls.Add(this.TxtTelefono);
            this.tabPage2.Controls.Add(this.TxtNombre);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage2.Size = new System.Drawing.Size(752, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Email";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(128, 279);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(97, 25);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(26, 279);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(97, 25);
            this.BtnActualizar.TabIndex = 4;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(25, 279);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(97, 25);
            this.BtnInsertar.TabIndex = 4;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(23, 190);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(342, 25);
            this.TxtDireccion.TabIndex = 1;
            // 
            // TxtNumDocumento
            // 
            this.TxtNumDocumento.Location = new System.Drawing.Point(23, 141);
            this.TxtNumDocumento.Name = "TxtNumDocumento";
            this.TxtNumDocumento.Size = new System.Drawing.Size(340, 25);
            this.TxtNumDocumento.TabIndex = 1;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(392, 141);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(337, 25);
            this.TxtTelefono.TabIndex = 1;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(23, 90);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(340, 25);
            this.TxtNombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.label5.Location = new System.Drawing.Point(20, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "(*) Indica que el campo es obligatorio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tipo de documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Número de Documento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre (*)";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(23, 41);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(100, 25);
            this.TxtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
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
            this.DgvListado.Size = new System.Drawing.Size(740, 247);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnEliminar);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(106, 290);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 25);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(6, 293);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(94, 22);
            this.ChkSeleccionar.TabIndex = 4;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.ChkSeleccionar_CheckedChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(671, 6);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 25);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(6, 6);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(659, 25);
            this.TxtBuscar.TabIndex = 2;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(586, 294);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(38, 18);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "Total";
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Controls.Add(this.tabPage2);
            this.tabGeneral.Location = new System.Drawing.Point(12, 56);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(760, 355);
            this.tabGeneral.TabIndex = 7;
            // 
            // FrmCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabGeneral);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErroIcono)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErroIcono;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.ComboBox CboTipoDocumento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNumDocumento;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label2;
    }
}