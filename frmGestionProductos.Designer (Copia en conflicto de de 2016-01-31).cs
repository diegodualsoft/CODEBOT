namespace Prototipo1
{
    partial class frmGestionProductos
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
            this.cmdIngresarProductos = new System.Windows.Forms.Button();
            this.cmdEliminarProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.GpProductos = new System.Windows.Forms.GroupBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.grdNombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCodInterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCodBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPrecioC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPrecioV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdCambioPrecio = new System.Windows.Forms.Button();
            this.GpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdIngresarProductos
            // 
            this.cmdIngresarProductos.Location = new System.Drawing.Point(24, 476);
            this.cmdIngresarProductos.Name = "cmdIngresarProductos";
            this.cmdIngresarProductos.Size = new System.Drawing.Size(123, 44);
            this.cmdIngresarProductos.TabIndex = 2;
            this.cmdIngresarProductos.Text = "Ingresar Productos";
            this.cmdIngresarProductos.UseVisualStyleBackColor = true;
            this.cmdIngresarProductos.Click += new System.EventHandler(this.cmdIngresarProductos_Click);
            // 
            // cmdEliminarProd
            // 
            this.cmdEliminarProd.Location = new System.Drawing.Point(153, 476);
            this.cmdEliminarProd.Name = "cmdEliminarProd";
            this.cmdEliminarProd.Size = new System.Drawing.Size(123, 44);
            this.cmdEliminarProd.TabIndex = 3;
            this.cmdEliminarProd.Text = "Eliminar Productos";
            this.cmdEliminarProd.UseVisualStyleBackColor = true;
            this.cmdEliminarProd.Click += new System.EventHandler(this.cmdEliminarProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestion Productos";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(439, 476);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(103, 44);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "Cerrar";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // GpProductos
            // 
            this.GpProductos.Controls.Add(this.cmdBuscar);
            this.GpProductos.Controls.Add(this.cboBuscar);
            this.GpProductos.Controls.Add(this.txtBuscar);
            this.GpProductos.Controls.Add(this.dgvLista);
            this.GpProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.GpProductos.Location = new System.Drawing.Point(24, 96);
            this.GpProductos.Name = "GpProductos";
            this.GpProductos.Size = new System.Drawing.Size(818, 374);
            this.GpProductos.TabIndex = 7;
            this.GpProductos.TabStop = false;
            this.GpProductos.Text = "Buscar                     Filtro de Busqueda                              ";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(434, 13);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(173, 51);
            this.cmdBuscar.TabIndex = 3;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "Nombre",
            "Codigo Interno",
            "Codigo De Barras",
            "Precio Costo",
            "Precio Venta"});
            this.cboBuscar.Location = new System.Drawing.Point(171, 23);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(192, 28);
            this.cboBuscar.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(150, 26);
            this.txtBuscar.TabIndex = 1;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdNombreP,
            this.grdCodInterno,
            this.grdCodBarra,
            this.grdPrecioC,
            this.grdPrecioV});
            this.dgvLista.Location = new System.Drawing.Point(6, 80);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(793, 288);
            this.dgvLista.TabIndex = 0;
            // 
            // grdNombreP
            // 
            this.grdNombreP.HeaderText = "Nombre Producto";
            this.grdNombreP.Name = "grdNombreP";
            this.grdNombreP.ReadOnly = true;
            this.grdNombreP.Width = 150;
            // 
            // grdCodInterno
            // 
            this.grdCodInterno.HeaderText = "Código Interno";
            this.grdCodInterno.Name = "grdCodInterno";
            this.grdCodInterno.ReadOnly = true;
            this.grdCodInterno.Width = 150;
            // 
            // grdCodBarra
            // 
            this.grdCodBarra.HeaderText = "Código de Barras";
            this.grdCodBarra.Name = "grdCodBarra";
            this.grdCodBarra.ReadOnly = true;
            this.grdCodBarra.Width = 150;
            // 
            // grdPrecioC
            // 
            this.grdPrecioC.HeaderText = "Precio Costo";
            this.grdPrecioC.Name = "grdPrecioC";
            this.grdPrecioC.ReadOnly = true;
            this.grdPrecioC.Width = 150;
            // 
            // grdPrecioV
            // 
            this.grdPrecioV.HeaderText = "Precio Venta";
            this.grdPrecioV.Name = "grdPrecioV";
            this.grdPrecioV.ReadOnly = true;
            this.grdPrecioV.Width = 150;
            // 
            // cmdCambioPrecio
            // 
            this.cmdCambioPrecio.Location = new System.Drawing.Point(282, 476);
            this.cmdCambioPrecio.Name = "cmdCambioPrecio";
            this.cmdCambioPrecio.Size = new System.Drawing.Size(123, 44);
            this.cmdCambioPrecio.TabIndex = 17;
            this.cmdCambioPrecio.Text = "Cambiar Precio";
            this.cmdCambioPrecio.UseVisualStyleBackColor = true;
            this.cmdCambioPrecio.Click += new System.EventHandler(this.cmdCambioPrecio_Click);
            // 
            // frmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 551);
            this.Controls.Add(this.cmdCambioPrecio);
            this.Controls.Add(this.GpProductos);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdEliminarProd);
            this.Controls.Add(this.cmdIngresarProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm";
            this.Load += new System.EventHandler(this.frmGestionProductos_Load);
            this.GpProductos.ResumeLayout(false);
            this.GpProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdIngresarProductos;
        private System.Windows.Forms.Button cmdEliminarProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.GroupBox GpProductos;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Button cmdCambioPrecio;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCodInterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCodBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPrecioC;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPrecioV;
    }
}