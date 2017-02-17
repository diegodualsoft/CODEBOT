namespace Prototipo1
{
    partial class frmFacturaDeCompra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblnfact = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsubtotales = new System.Windows.Forms.TextBox();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.txttotales = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnombrecontacto = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.grdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblnfact);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtsubtotales);
            this.panel1.Controls.Add(this.txtiva);
            this.panel1.Controls.Add(this.txttotales);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtnombrecontacto);
            this.panel1.Controls.Add(this.dgvLista);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtGiro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtRazon);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 487);
            this.panel1.TabIndex = 91;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(390, 76);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(170, 20);
            this.txtFecha.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 83;
            this.label1.Text = "GIRO:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(42, 128);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label16.Location = new System.Drawing.Point(9, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 12);
            this.label16.TabIndex = 43;
            this.label16.Text = "RUT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(57, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 69;
            this.label7.Text = "FACTURA N°";
            // 
            // lblnfact
            // 
            this.lblnfact.AutoSize = true;
            this.lblnfact.Location = new System.Drawing.Point(87, 36);
            this.lblnfact.Name = "lblnfact";
            this.lblnfact.Size = new System.Drawing.Size(55, 13);
            this.lblnfact.TabIndex = 66;
            this.lblnfact.Text = "lblnumfact";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "TOTALES:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "IVA:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "NETO:";
            // 
            // txtsubtotales
            // 
            this.txtsubtotales.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtsubtotales.Location = new System.Drawing.Point(442, 390);
            this.txtsubtotales.Name = "txtsubtotales";
            this.txtsubtotales.ReadOnly = true;
            this.txtsubtotales.Size = new System.Drawing.Size(100, 20);
            this.txtsubtotales.TabIndex = 60;
            // 
            // txtiva
            // 
            this.txtiva.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtiva.Location = new System.Drawing.Point(442, 421);
            this.txtiva.Name = "txtiva";
            this.txtiva.ReadOnly = true;
            this.txtiva.Size = new System.Drawing.Size(100, 20);
            this.txtiva.TabIndex = 59;
            // 
            // txttotales
            // 
            this.txttotales.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txttotales.Location = new System.Drawing.Point(442, 451);
            this.txttotales.Name = "txttotales";
            this.txttotales.ReadOnly = true;
            this.txttotales.Size = new System.Drawing.Size(100, 20);
            this.txttotales.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label10.Location = new System.Drawing.Point(9, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 12);
            this.label10.TabIndex = 54;
            this.label10.Text = "RAZON SOCIAL:";
            // 
            // txtnombrecontacto
            // 
            this.txtnombrecontacto.Location = new System.Drawing.Point(94, 102);
            this.txtnombrecontacto.Name = "txtnombrecontacto";
            this.txtnombrecontacto.Size = new System.Drawing.Size(258, 20);
            this.txtnombrecontacto.TabIndex = 53;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdNombre,
            this.grdPrecioVenta,
            this.grdCantidad,
            this.grdPrecioCosto,
            this.total,
            this.margen});
            this.dgvLista.Location = new System.Drawing.Point(4, 168);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(554, 191);
            this.dgvLista.TabIndex = 51;
            // 
            // grdNombre
            // 
            this.grdNombre.HeaderText = "Nombre";
            this.grdNombre.Name = "grdNombre";
            this.grdNombre.ReadOnly = true;
            // 
            // grdPrecioVenta
            // 
            this.grdPrecioVenta.HeaderText = "Precio de Venta";
            this.grdPrecioVenta.Name = "grdPrecioVenta";
            this.grdPrecioVenta.ReadOnly = true;
            // 
            // grdCantidad
            // 
            this.grdCantidad.HeaderText = "Cantidad";
            this.grdCantidad.Name = "grdCantidad";
            this.grdCantidad.ReadOnly = true;
            // 
            // grdPrecioCosto
            // 
            this.grdPrecioCosto.HeaderText = "Precio de Costo";
            this.grdPrecioCosto.Name = "grdPrecioCosto";
            this.grdPrecioCosto.ReadOnly = true;
            this.grdPrecioCosto.Visible = false;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // margen
            // 
            this.margen.HeaderText = "Margen";
            this.margen.Name = "margen";
            this.margen.ReadOnly = true;
            this.margen.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label5.Location = new System.Drawing.Point(336, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 48;
            this.label5.Text = "FECHA:";
            // 
            // txtGiro
            // 
            this.txtGiro.Location = new System.Drawing.Point(51, 76);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(203, 20);
            this.txtGiro.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label3.Location = new System.Drawing.Point(160, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 12);
            this.label3.TabIndex = 45;
            this.label3.Text = "DIRECCIÓN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label2.Location = new System.Drawing.Point(361, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 44;
            this.label2.Text = "CORREO:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(228, 128);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(332, 20);
            this.txtDireccion.TabIndex = 42;
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(412, 102);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(148, 20);
            this.txtRazon.TabIndex = 41;
            // 
            // frmFacturaDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 521);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturaDeCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturaDeCompra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblnfact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsubtotales;
        private System.Windows.Forms.TextBox txtiva;
        private System.Windows.Forms.TextBox txttotales;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnombrecontacto;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn margen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRazon;
    }
}