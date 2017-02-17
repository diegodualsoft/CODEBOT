namespace Prototipo1
{
    partial class frmingresoProductoEspecifico
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.gpProductos = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAgregados = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregados)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Designar Producto a Clientes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 49);
            this.panel1.TabIndex = 5;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(48, 16);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(244, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(502, 256);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(46, 24);
            this.btnQuitar.TabIndex = 8;
            this.btnQuitar.Text = "<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // gpProductos
            // 
            this.gpProductos.Controls.Add(this.dgvProductos);
            this.gpProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpProductos.Location = new System.Drawing.Point(15, 120);
            this.gpProductos.Name = "gpProductos";
            this.gpProductos.Size = new System.Drawing.Size(481, 302);
            this.gpProductos.TabIndex = 9;
            this.gpProductos.TabStop = false;
            this.gpProductos.Text = "Productos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(7, 26);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(468, 270);
            this.dgvProductos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAgregados);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(554, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 302);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos Agregados";
            // 
            // dgvAgregados
            // 
            this.dgvAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregados.Location = new System.Drawing.Point(7, 26);
            this.dgvAgregados.Name = "dgvAgregados";
            this.dgvAgregados.Size = new System.Drawing.Size(474, 270);
            this.dgvAgregados.TabIndex = 0;
            // 
            // frmingresoProductoEspecifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpProductos);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmingresoProductoEspecifico";
            this.Text = "frmingresoProductoEspecifico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmingresoProductoEspecifico_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.GroupBox gpProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAgregados;
    }
}