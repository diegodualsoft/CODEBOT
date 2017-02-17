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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdIngresarProductos = new System.Windows.Forms.Button();
            this.cmdEliminarProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.GpProductos = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.grdNombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCodInterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCodBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPrecioC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPrecioV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdCambioPrecio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdIngresarProductos
            // 
            this.cmdIngresarProductos.Location = new System.Drawing.Point(12, 598);
            this.cmdIngresarProductos.Name = "cmdIngresarProductos";
            this.cmdIngresarProductos.Size = new System.Drawing.Size(123, 44);
            this.cmdIngresarProductos.TabIndex = 2;
            this.cmdIngresarProductos.Text = "Ingresar Nuevos Productos";
            this.cmdIngresarProductos.UseVisualStyleBackColor = true;
            this.cmdIngresarProductos.Click += new System.EventHandler(this.cmdIngresarProductos_Click);
            // 
            // cmdEliminarProd
            // 
            this.cmdEliminarProd.Enabled = false;
            this.cmdEliminarProd.Location = new System.Drawing.Point(237, 598);
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
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestion Productos";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(721, 598);
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
            this.GpProductos.Location = new System.Drawing.Point(12, 68);
            this.GpProductos.Name = "GpProductos";
            this.GpProductos.Size = new System.Drawing.Size(818, 524);
            this.GpProductos.TabIndex = 7;
            this.GpProductos.TabStop = false;
            this.GpProductos.Text = "Buscar                     Filtro de Busqueda                              ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(850, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "PRODUCTOS COMPUESTOS Y AJUSTES";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(369, 23);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(150, 28);
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
            this.cboBuscar.Location = new System.Drawing.Point(162, 23);
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
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToResizeColumns = false;
            this.dgvLista.AllowUserToResizeRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdNombreP,
            this.grdCodInterno,
            this.grdCodBarra,
            this.grdPrecioC,
            this.grdPrecioV,
            this.grdStock});
            this.dgvLista.Location = new System.Drawing.Point(6, 57);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(806, 461);
            this.dgvLista.TabIndex = 0;
            // 
            // grdNombreP
            // 
            this.grdNombreP.HeaderText = "Nombre Producto";
            this.grdNombreP.Name = "grdNombreP";
            this.grdNombreP.ReadOnly = true;
            this.grdNombreP.Width = 220;
            // 
            // grdCodInterno
            // 
            this.grdCodInterno.HeaderText = "Código Interno";
            this.grdCodInterno.Name = "grdCodInterno";
            this.grdCodInterno.ReadOnly = true;
            // 
            // grdCodBarra
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCodBarra.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdCodBarra.HeaderText = "Código de Barras";
            this.grdCodBarra.Name = "grdCodBarra";
            this.grdCodBarra.ReadOnly = true;
            // 
            // grdPrecioC
            // 
            this.grdPrecioC.HeaderText = "Precio Costo";
            this.grdPrecioC.Name = "grdPrecioC";
            this.grdPrecioC.ReadOnly = true;
            this.grdPrecioC.Width = 120;
            // 
            // grdPrecioV
            // 
            this.grdPrecioV.HeaderText = "Precio Venta";
            this.grdPrecioV.Name = "grdPrecioV";
            this.grdPrecioV.ReadOnly = true;
            this.grdPrecioV.Width = 120;
            // 
            // grdStock
            // 
            this.grdStock.HeaderText = "Stock";
            this.grdStock.Name = "grdStock";
            this.grdStock.ReadOnly = true;
            this.grdStock.Width = 120;
            // 
            // cmdCambioPrecio
            // 
            this.cmdCambioPrecio.Enabled = false;
            this.cmdCambioPrecio.Location = new System.Drawing.Point(366, 598);
            this.cmdCambioPrecio.Name = "cmdCambioPrecio";
            this.cmdCambioPrecio.Size = new System.Drawing.Size(123, 44);
            this.cmdCambioPrecio.TabIndex = 17;
            this.cmdCambioPrecio.Text = "Cambiar Precio";
            this.cmdCambioPrecio.UseVisualStyleBackColor = true;
            this.cmdCambioPrecio.Click += new System.EventHandler(this.cmdCambioPrecio_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(495, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cambiar Stock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(850, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "TRASPASO MERCADERIA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(850, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 36);
            this.button3.TabIndex = 20;
            this.button3.Text = "INGRESO DE MERCADERIA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 654);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdCambioPrecio);
            this.Controls.Add(this.GpProductos);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdEliminarProd);
            this.Controls.Add(this.cmdIngresarProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Productos";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCodInterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCodBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPrecioC;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPrecioV;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdStock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}