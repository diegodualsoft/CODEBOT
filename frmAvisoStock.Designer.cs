namespace Prototipo1
{
    partial class frmAvisoStock
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.grdNombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCodInterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCodBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPrecioC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPrecioV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
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
            this.dgvLista.Location = new System.Drawing.Point(26, 102);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(793, 288);
            this.dgvLista.TabIndex = 1;
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
            this.grdPrecioC.HeaderText = "Stock Restante";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(158, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRODUCTOS FALTANTES EN STOCK DE PRODUCTOS";
            // 
            // frmAvisoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(840, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAvisoStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAvisoStock";
            this.Load += new System.EventHandler(this.frmAvisoStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCodInterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCodBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPrecioC;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPrecioV;
    }
}