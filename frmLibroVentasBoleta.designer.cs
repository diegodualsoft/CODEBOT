namespace Prototipo1
{
    partial class frmLibroVentasBoleta
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
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.txtCostos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txttotventas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ivaconversion = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbtipodoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.NumeroDocumento,
            this.neto,
            this.IVA,
            this.totalcosto,
            this.totalventa,
            this.Estado});
            this.dgvLista.Location = new System.Drawing.Point(20, 101);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(766, 306);
            this.dgvLista.TabIndex = 0;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "N°BOLETA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "FECHA";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 120;
            // 
            // neto
            // 
            this.neto.HeaderText = "HORA";
            this.neto.Name = "neto";
            this.neto.ReadOnly = true;
            // 
            // IVA
            // 
            this.IVA.HeaderText = "TOTAL";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            // 
            // totalcosto
            // 
            this.totalcosto.HeaderText = "CAJERO";
            this.totalcosto.Name = "totalcosto";
            this.totalcosto.ReadOnly = true;
            // 
            // totalventa
            // 
            this.totalventa.HeaderText = "TIPO PAGO";
            this.totalventa.Name = "totalventa";
            this.totalventa.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "N°REDCOMPRA DEB";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total En Impuestos A Pagar";
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Enabled = false;
            this.txtImpuestos.Location = new System.Drawing.Point(419, 413);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(136, 20);
            this.txtImpuestos.TabIndex = 2;
            this.txtImpuestos.Text = "0";
            this.txtImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCostos
            // 
            this.txtCostos.Enabled = false;
            this.txtCostos.Location = new System.Drawing.Point(499, 490);
            this.txtCostos.Name = "txtCostos";
            this.txtCostos.Size = new System.Drawing.Size(129, 20);
            this.txtCostos.TabIndex = 3;
            this.txtCostos.Text = "0";
            this.txtCostos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostos.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Costo A Recuperar";
            this.label2.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(645, 490);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(108, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.Visible = false;
            this.txtTotal.Click += new System.EventHandler(this.txtTotal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Utilidad";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Libro De Ventas Boleta";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(20, 477);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(103, 44);
            this.cmdSalir.TabIndex = 14;
            this.cmdSalir.Text = "Cerrar";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(16, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha De Ventas";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(494, 71);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(114, 24);
            this.cmdBuscar.TabIndex = 17;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txttotventas
            // 
            this.txttotventas.Enabled = false;
            this.txttotventas.Location = new System.Drawing.Point(645, 413);
            this.txttotventas.Name = "txttotventas";
            this.txttotventas.Size = new System.Drawing.Size(108, 20);
            this.txttotventas.TabIndex = 18;
            this.txttotventas.Text = "0";
            this.txttotventas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Ventas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ivaconversion
            // 
            this.ivaconversion.AutoSize = true;
            this.ivaconversion.Location = new System.Drawing.Point(696, 28);
            this.ivaconversion.Name = "ivaconversion";
            this.ivaconversion.Size = new System.Drawing.Size(67, 13);
            this.ivaconversion.TabIndex = 21;
            this.ivaconversion.Text = "Total Ventas";
            this.ivaconversion.Visible = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(298, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 44);
            this.button2.TabIndex = 22;
            this.button2.Text = "Anular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbtipodoc
            // 
            this.cbtipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipodoc.FormattingEnabled = true;
            this.cbtipodoc.Items.AddRange(new object[] {
            "RedBank",
            "Boleta"});
            this.cbtipodoc.Location = new System.Drawing.Point(367, 74);
            this.cbtipodoc.Name = "cbtipodoc";
            this.cbtipodoc.Size = new System.Drawing.Size(121, 21);
            this.cbtipodoc.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Seleccione Tipo";
            this.label7.Visible = false;
            // 
            // frmLibroVentasBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 538);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbtipodoc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ivaconversion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotventas);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCostos);
            this.Controls.Add(this.txtImpuestos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLibroVentasBoleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libro de Ventas";
            this.Load += new System.EventHandler(this.frmLibroVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCostos;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txttotventas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label ivaconversion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn neto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ComboBox cbtipodoc;
        private System.Windows.Forms.Label label7;
    }
}