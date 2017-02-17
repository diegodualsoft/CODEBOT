namespace Prototipo1
{
    partial class frmkit
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.pnlPrinicpal = new System.Windows.Forms.Panel();
            this.gpIngredientes = new System.Windows.Forms.GroupBox();
            this.lstComponentes = new System.Windows.Forms.ListBox();
            this.gpProductos = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pnlAgregarKit = new System.Windows.Forms.Panel();
            this.pnlCantidades = new System.Windows.Forms.Panel();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvActuales = new System.Windows.Forms.DataGridView();
            this.dgvNuevos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlcantidad = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlPrinicpal.SuspendLayout();
            this.gpIngredientes.SuspendLayout();
            this.gpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlAgregarKit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevos)).BeginInit();
            this.pnlcantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION PRODUCTOS COMPUESTOS";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(621, 459);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(124, 43);
            this.btnAgregarProducto.TabIndex = 3;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // pnlPrinicpal
            // 
            this.pnlPrinicpal.Controls.Add(this.gpIngredientes);
            this.pnlPrinicpal.Controls.Add(this.gpProductos);
            this.pnlPrinicpal.Location = new System.Drawing.Point(12, 58);
            this.pnlPrinicpal.Name = "pnlPrinicpal";
            this.pnlPrinicpal.Size = new System.Drawing.Size(757, 400);
            this.pnlPrinicpal.TabIndex = 4;
            // 
            // gpIngredientes
            // 
            this.gpIngredientes.Controls.Add(this.lstComponentes);
            this.gpIngredientes.Location = new System.Drawing.Point(515, 37);
            this.gpIngredientes.Name = "gpIngredientes";
            this.gpIngredientes.Size = new System.Drawing.Size(231, 334);
            this.gpIngredientes.TabIndex = 4;
            this.gpIngredientes.TabStop = false;
            this.gpIngredientes.Text = "Componentes";
            // 
            // lstComponentes
            // 
            this.lstComponentes.FormattingEnabled = true;
            this.lstComponentes.Location = new System.Drawing.Point(6, 19);
            this.lstComponentes.Name = "lstComponentes";
            this.lstComponentes.Size = new System.Drawing.Size(220, 316);
            this.lstComponentes.TabIndex = 1;
            // 
            // gpProductos
            // 
            this.gpProductos.Controls.Add(this.dgvProductos);
            this.gpProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpProductos.Location = new System.Drawing.Point(2, 20);
            this.gpProductos.Name = "gpProductos";
            this.gpProductos.Size = new System.Drawing.Size(507, 360);
            this.gpProductos.TabIndex = 3;
            this.gpProductos.TabStop = false;
            this.gpProductos.Text = "Producto Compuesto";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(7, 26);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProductos.ShowCellErrors = false;
            this.dgvProductos.ShowCellToolTips = false;
            this.dgvProductos.ShowEditingIcon = false;
            this.dgvProductos.ShowRowErrors = false;
            this.dgvProductos.Size = new System.Drawing.Size(494, 328);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProductos_CellPainting);
            // 
            // pnlAgregarKit
            // 
            this.pnlAgregarKit.Controls.Add(this.pnlcantidad);
            this.pnlAgregarKit.Controls.Add(this.btnEliminar);
            this.pnlAgregarKit.Controls.Add(this.btnAgregar);
            this.pnlAgregarKit.Controls.Add(this.groupBox2);
            this.pnlAgregarKit.Controls.Add(this.groupBox1);
            this.pnlAgregarKit.Location = new System.Drawing.Point(15, 32);
            this.pnlAgregarKit.Name = "pnlAgregarKit";
            this.pnlAgregarKit.Size = new System.Drawing.Size(757, 400);
            this.pnlAgregarKit.TabIndex = 5;
            // 
            // pnlCantidades
            // 
            this.pnlCantidades.Location = new System.Drawing.Point(9, 38);
            this.pnlCantidades.Name = "pnlCantidades";
            this.pnlCantidades.Size = new System.Drawing.Size(757, 400);
            this.pnlCantidades.TabIndex = 5;
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Location = new System.Drawing.Point(56, 9);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(35, 13);
            this.lbl_producto.TabIndex = 6;
            this.lbl_producto.Text = "label2";
            this.lbl_producto.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvActuales);
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNuevos);
            this.groupBox2.Location = new System.Drawing.Point(429, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 347);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgvActuales
            // 
            this.dgvActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActuales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActuales.Location = new System.Drawing.Point(3, 16);
            this.dgvActuales.Name = "dgvActuales";
            this.dgvActuales.Size = new System.Drawing.Size(266, 328);
            this.dgvActuales.TabIndex = 0;
            // 
            // dgvNuevos
            // 
            this.dgvNuevos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNuevos.Location = new System.Drawing.Point(3, 16);
            this.dgvNuevos.Name = "dgvNuevos";
            this.dgvNuevos.Size = new System.Drawing.Size(266, 328);
            this.dgvNuevos.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(318, 126);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "<";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(318, 172);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = ">";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // pnlcantidad
            // 
            this.pnlcantidad.Controls.Add(this.button4);
            this.pnlcantidad.Controls.Add(this.button3);
            this.pnlcantidad.Controls.Add(this.label2);
            this.pnlcantidad.Controls.Add(this.textBox1);
            this.pnlcantidad.Location = new System.Drawing.Point(184, 210);
            this.pnlcantidad.Name = "pnlcantidad";
            this.pnlcantidad.Size = new System.Drawing.Size(383, 136);
            this.pnlcantidad.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese cantidad a usar";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(347, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 514);
            this.Controls.Add(this.pnlAgregarKit);
            this.Controls.Add(this.pnlPrinicpal);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.pnlCantidades);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label1);
            this.Name = "frmkit";
            this.Text = "GESTION PRODUCTOS COMPUESTOS";
            this.Load += new System.EventHandler(this.frmkit_Load);
            this.pnlPrinicpal.ResumeLayout(false);
            this.gpIngredientes.ResumeLayout(false);
            this.gpProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlAgregarKit.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevos)).EndInit();
            this.pnlcantidad.ResumeLayout(false);
            this.pnlcantidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Panel pnlPrinicpal;
        private System.Windows.Forms.Panel pnlAgregarKit;
        private System.Windows.Forms.Panel pnlCantidades;
        private System.Windows.Forms.GroupBox gpIngredientes;
        private System.Windows.Forms.GroupBox gpProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ListBox lstComponentes;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Panel pnlcantidad;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNuevos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvActuales;
    }
}