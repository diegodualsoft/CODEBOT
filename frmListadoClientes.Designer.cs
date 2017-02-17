namespace Prototipo1
{
    partial class frmListadoClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaCLI = new System.Windows.Forms.DataGridView();
            this.grdRUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdVerPerfil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCLI)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Clientes";
            // 
            // dgvListaCLI
            // 
            this.dgvListaCLI.AllowUserToAddRows = false;
            this.dgvListaCLI.AllowUserToDeleteRows = false;
            this.dgvListaCLI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCLI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdRUT,
            this.grdApellidoP,
            this.grdApellidoM,
            this.grdNombres,
            this.grdDireccion,
            this.grdTelefono,
            this.comuna,
            this.ciudad,
            this.grdVendedor,
            this.grdNF});
            this.dgvListaCLI.Location = new System.Drawing.Point(12, 188);
            this.dgvListaCLI.MultiSelect = false;
            this.dgvListaCLI.Name = "dgvListaCLI";
            this.dgvListaCLI.ReadOnly = true;
            this.dgvListaCLI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvListaCLI.RowHeadersVisible = false;
            this.dgvListaCLI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCLI.Size = new System.Drawing.Size(1127, 495);
            this.dgvListaCLI.TabIndex = 1;
            this.dgvListaCLI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCLI_CellContentClick);
            // 
            // grdRUT
            // 
            this.grdRUT.HeaderText = "RUT";
            this.grdRUT.Name = "grdRUT";
            this.grdRUT.ReadOnly = true;
            this.grdRUT.Width = 70;
            // 
            // grdApellidoP
            // 
            this.grdApellidoP.HeaderText = "Razón Social";
            this.grdApellidoP.Name = "grdApellidoP";
            this.grdApellidoP.ReadOnly = true;
            this.grdApellidoP.Width = 160;
            // 
            // grdApellidoM
            // 
            this.grdApellidoM.HeaderText = "Giro";
            this.grdApellidoM.Name = "grdApellidoM";
            this.grdApellidoM.ReadOnly = true;
            // 
            // grdNombres
            // 
            this.grdNombres.HeaderText = "Nombre";
            this.grdNombres.Name = "grdNombres";
            this.grdNombres.ReadOnly = true;
            this.grdNombres.Width = 160;
            // 
            // grdDireccion
            // 
            this.grdDireccion.HeaderText = "Dirección";
            this.grdDireccion.Name = "grdDireccion";
            this.grdDireccion.ReadOnly = true;
            this.grdDireccion.Width = 140;
            // 
            // grdTelefono
            // 
            this.grdTelefono.HeaderText = "Teléfono";
            this.grdTelefono.Name = "grdTelefono";
            this.grdTelefono.ReadOnly = true;
            this.grdTelefono.Width = 70;
            // 
            // comuna
            // 
            this.comuna.HeaderText = "Comuna";
            this.comuna.Name = "comuna";
            this.comuna.ReadOnly = true;
            // 
            // ciudad
            // 
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.Name = "ciudad";
            this.ciudad.ReadOnly = true;
            // 
            // grdVendedor
            // 
            this.grdVendedor.HeaderText = "Vendedor";
            this.grdVendedor.Name = "grdVendedor";
            this.grdVendedor.ReadOnly = true;
            // 
            // grdNF
            // 
            this.grdNF.HeaderText = "Nombre de Fantasía";
            this.grdNF.Name = "grdNF";
            this.grdNF.ReadOnly = true;
            this.grdNF.Width = 130;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(1155, 286);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(150, 62);
            this.cmdSalir.TabIndex = 2;
            this.cmdSalir.Text = "Cerrar";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdVerPerfil
            // 
            this.cmdVerPerfil.Location = new System.Drawing.Point(1155, 198);
            this.cmdVerPerfil.Name = "cmdVerPerfil";
            this.cmdVerPerfil.Size = new System.Drawing.Size(150, 67);
            this.cmdVerPerfil.TabIndex = 29;
            this.cmdVerPerfil.Text = "Ver Perfil";
            this.cmdVerPerfil.UseVisualStyleBackColor = true;
            this.cmdVerPerfil.Click += new System.EventHandler(this.cmdVerPerfil_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdBuscar);
            this.panel1.Controls.Add(this.cboBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(41, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 78);
            this.panel1.TabIndex = 30;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(665, 13);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(166, 47);
            this.cmdBuscar.TabIndex = 3;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "RUT   ",
            "Razon Social",
            "Giro",
            "Nombre",
            "Dirección",
            "Teléfono",
            "Comuna",
            "Ciudad",
            "Vendedor"});
            this.cboBuscar.Location = new System.Drawing.Point(378, 27);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(166, 27);
            this.cboBuscar.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(181, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(153, 27);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1155, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 67);
            this.button1.TabIndex = 31;
            this.button1.Text = "Agregar Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 732);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdVerPerfil);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.dgvListaCLI);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListadoClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCLI)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaCLI;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdVerPerfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdRUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdApellidoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn comuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNF;
        private System.Windows.Forms.Button button1;
    }
}