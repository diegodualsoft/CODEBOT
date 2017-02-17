namespace Prototipo1
{
    partial class frmBuscarProdCaja
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
            this.GpProductos = new System.Windows.Forms.GroupBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvListaBuscar = new System.Windows.Forms.DataGridView();
            this.grdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCodigoInterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // GpProductos
            // 
            this.GpProductos.Controls.Add(this.cboBuscar);
            this.GpProductos.Controls.Add(this.cmdBuscar);
            this.GpProductos.Controls.Add(this.txtBuscar);
            this.GpProductos.Controls.Add(this.dgvListaBuscar);
            this.GpProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.GpProductos.Location = new System.Drawing.Point(12, 75);
            this.GpProductos.Name = "GpProductos";
            this.GpProductos.Size = new System.Drawing.Size(645, 369);
            this.GpProductos.TabIndex = 8;
            this.GpProductos.TabStop = false;
            this.GpProductos.Text = "Buscar                     Filtro de Busqueda                              ";
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "Nombre",
            "Codigo Interno",
            "Codigo De Barras"});
            this.cboBuscar.Location = new System.Drawing.Point(163, 22);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(156, 28);
            this.cboBuscar.TabIndex = 2;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(334, 22);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(109, 28);
            this.cmdBuscar.TabIndex = 10;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(7, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(150, 26);
            this.txtBuscar.TabIndex = 1;
            // 
            // dgvListaBuscar
            // 
            this.dgvListaBuscar.AllowUserToAddRows = false;
            this.dgvListaBuscar.AllowUserToDeleteRows = false;
            this.dgvListaBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdNombre,
            this.grdCodigoInterno,
            this.grdCodigoBarra,
            this.grdStock});
            this.dgvListaBuscar.Location = new System.Drawing.Point(7, 57);
            this.dgvListaBuscar.Name = "dgvListaBuscar";
            this.dgvListaBuscar.ReadOnly = true;
            this.dgvListaBuscar.RowHeadersVisible = false;
            this.dgvListaBuscar.Size = new System.Drawing.Size(615, 291);
            this.dgvListaBuscar.TabIndex = 0;
            // 
            // grdNombre
            // 
            this.grdNombre.HeaderText = "Nombre";
            this.grdNombre.Name = "grdNombre";
            this.grdNombre.ReadOnly = true;
            this.grdNombre.Width = 250;
            // 
            // grdCodigoInterno
            // 
            this.grdCodigoInterno.HeaderText = "Código Interno";
            this.grdCodigoInterno.Name = "grdCodigoInterno";
            this.grdCodigoInterno.ReadOnly = true;
            this.grdCodigoInterno.Width = 120;
            // 
            // grdCodigoBarra
            // 
            this.grdCodigoBarra.HeaderText = "Código de Barras";
            this.grdCodigoBarra.Name = "grdCodigoBarra";
            this.grdCodigoBarra.ReadOnly = true;
            this.grdCodigoBarra.Width = 120;
            // 
            // grdStock
            // 
            this.grdStock.HeaderText = "Stock";
            this.grdStock.Name = "grdStock";
            this.grdStock.ReadOnly = true;
            this.grdStock.Width = 120;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(519, 450);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(109, 44);
            this.cmdAceptar.TabIndex = 9;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdObtener_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar Productos Caja";
            // 
            // frmBuscarProdCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.GpProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBuscarProdCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Productos en Caja";
            this.Load += new System.EventHandler(this.frmBuscarProdCaja_Load);
            this.GpProductos.ResumeLayout(false);
            this.GpProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GpProductos;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvListaBuscar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCodigoInterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdStock;

    }
}