namespace Prototipo1
{
    partial class frmInformeDeCompra
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
            this.cmdSalir = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.grdFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNfact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdRut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "INFORME DE COMPRA";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(814, 456);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(121, 50);
            this.cmdSalir.TabIndex = 16;
            this.cmdSalir.Text = "Cerrar";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdFecha,
            this.grdIVA,
            this.grdTotales,
            this.grdNfact,
            this.grdProveedor,
            this.grdRut});
            this.dgvLista.Location = new System.Drawing.Point(29, 91);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(906, 319);
            this.dgvLista.TabIndex = 17;
            // 
            // grdFecha
            // 
            this.grdFecha.HeaderText = "Fecha";
            this.grdFecha.Name = "grdFecha";
            this.grdFecha.ReadOnly = true;
            this.grdFecha.Width = 150;
            // 
            // grdIVA
            // 
            this.grdIVA.HeaderText = "IVA";
            this.grdIVA.Name = "grdIVA";
            this.grdIVA.ReadOnly = true;
            this.grdIVA.Width = 150;
            // 
            // grdTotales
            // 
            this.grdTotales.HeaderText = "Totales";
            this.grdTotales.Name = "grdTotales";
            this.grdTotales.ReadOnly = true;
            this.grdTotales.Width = 150;
            // 
            // grdNfact
            // 
            this.grdNfact.HeaderText = "N° Factura";
            this.grdNfact.Name = "grdNfact";
            this.grdNfact.ReadOnly = true;
            this.grdNfact.Width = 150;
            // 
            // grdProveedor
            // 
            this.grdProveedor.HeaderText = "Proveedor";
            this.grdProveedor.Name = "grdProveedor";
            this.grdProveedor.ReadOnly = true;
            this.grdProveedor.Width = 150;
            // 
            // grdRut
            // 
            this.grdRut.HeaderText = "RUT";
            this.grdRut.Name = "grdRut";
            this.grdRut.ReadOnly = true;
            this.grdRut.Width = 150;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM_yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(831, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(830, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "BUSCAR POR MES";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmInformeDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformeDeCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe de Compra";
            this.Load += new System.EventHandler(this.frmInformeDeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNfact;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdRut;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}