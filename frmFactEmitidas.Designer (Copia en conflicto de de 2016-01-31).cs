namespace Prototipo1
{
    partial class frmFactEmitidas
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
            this.grdnfact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutcli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvLista1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtrestante = new System.Windows.Forms.TextBox();
            this.cbmediopago = new System.Windows.Forms.ComboBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.txtneto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label11 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numfact = new System.Windows.Forms.Label();
            this.txtmontocaja = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.grdnfact,
            this.grdtotal,
            this.rutcli});
            this.dgvLista.Location = new System.Drawing.Point(12, 77);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(502, 484);
            this.dgvLista.TabIndex = 0;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 180;
            // 
            // grdnfact
            // 
            this.grdnfact.HeaderText = "FACTURA N°";
            this.grdnfact.Name = "grdnfact";
            this.grdnfact.ReadOnly = true;
            this.grdnfact.Width = 78;
            // 
            // grdtotal
            // 
            this.grdtotal.HeaderText = "MONTO TOTAL";
            this.grdtotal.Name = "grdtotal";
            this.grdtotal.ReadOnly = true;
            this.grdtotal.Width = 120;
            // 
            // rutcli
            // 
            this.rutcli.HeaderText = "RUT CLIENTE";
            this.rutcli.Name = "rutcli";
            this.rutcli.ReadOnly = true;
            this.rutcli.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Facturas Por Fechas:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver Facturas Cuadradas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 66);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cuadrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(50, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "FACTURAS EMITIDAS";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd_MM_yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvLista1
            // 
            this.dgvLista1.AllowUserToAddRows = false;
            this.dgvLista1.AllowUserToDeleteRows = false;
            this.dgvLista1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.precio,
            this.cantidad,
            this.total});
            this.dgvLista1.Location = new System.Drawing.Point(738, 141);
            this.dgvLista1.Name = "dgvLista1";
            this.dgvLista1.ReadOnly = true;
            this.dgvLista1.RowHeadersVisible = false;
            this.dgvLista1.Size = new System.Drawing.Size(404, 242);
            this.dgvLista1.TabIndex = 8;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // txtrestante
            // 
            this.txtrestante.Location = new System.Drawing.Point(820, 505);
            this.txtrestante.Name = "txtrestante";
            this.txtrestante.Size = new System.Drawing.Size(121, 20);
            this.txtrestante.TabIndex = 9;
            this.txtrestante.Text = "0";
            this.txtrestante.TextChanged += new System.EventHandler(this.txtrestante_TextChanged);
            // 
            // cbmediopago
            // 
            this.cbmediopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmediopago.FormattingEnabled = true;
            this.cbmediopago.Items.AddRange(new object[] {
            "EFECTIVO",
            "CREDITO",
            "CHEQUE\t"});
            this.cbmediopago.Location = new System.Drawing.Point(966, 503);
            this.cbmediopago.Name = "cbmediopago";
            this.cbmediopago.Size = new System.Drawing.Size(121, 21);
            this.cbmediopago.TabIndex = 11;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(1021, 439);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(121, 20);
            this.txttotal.TabIndex = 12;
            this.txttotal.Text = "0";
            // 
            // txtiva
            // 
            this.txtiva.Location = new System.Drawing.Point(1021, 413);
            this.txtiva.Name = "txtiva";
            this.txtiva.Size = new System.Drawing.Size(121, 20);
            this.txtiva.TabIndex = 13;
            this.txtiva.Text = "0";
            // 
            // txtneto
            // 
            this.txtneto.Location = new System.Drawing.Point(1021, 387);
            this.txtneto.Name = "txtneto";
            this.txtneto.Size = new System.Drawing.Size(121, 20);
            this.txtneto.TabIndex = 14;
            this.txtneto.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(836, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "RESTANTES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(963, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "TIPO DE PAGO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "MONTO EN CAJA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(978, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "NETO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(991, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "IVA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(959, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "TOTALES";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1103, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Aceptar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1229, 575);
            this.shapeContainer1.TabIndex = 27;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.Location = new System.Drawing.Point(1087, 62);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(119, 57);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(666, 31);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(556, 529);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(671, 472);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(545, 66);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(701, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "FECHA:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(752, 107);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(44, 13);
            this.lblfecha.TabIndex = 31;
            this.lblfecha.Text = "lblfecha";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblcliente.Location = new System.Drawing.Point(767, 60);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(75, 20);
            this.lblcliente.TabIndex = 32;
            this.lblcliente.Text = "lblcliente";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label14.Location = new System.Drawing.Point(677, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "CLIENTE:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1112, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "FACTURA N°";
            // 
            // numfact
            // 
            this.numfact.AutoSize = true;
            this.numfact.Location = new System.Drawing.Point(1141, 93);
            this.numfact.Name = "numfact";
            this.numfact.Size = new System.Drawing.Size(55, 13);
            this.numfact.TabIndex = 35;
            this.numfact.Text = "lblnumfact";
            // 
            // txtmontocaja
            // 
            this.txtmontocaja.Location = new System.Drawing.Point(687, 505);
            this.txtmontocaja.Mask = "999999999999999999";
            this.txtmontocaja.Name = "txtmontocaja";
            this.txtmontocaja.Size = new System.Drawing.Size(100, 20);
            this.txtmontocaja.TabIndex = 36;
            this.txtmontocaja.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtmontocaja_MaskInputRejected);
            this.txtmontocaja.TextChanged += new System.EventHandler(this.txtmontocaja_TextChanged_1);
            // 
            // frmFactEmitidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 575);
            this.Controls.Add(this.txtmontocaja);
            this.Controls.Add(this.numfact);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtneto);
            this.Controls.Add(this.txtiva);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.cbmediopago);
            this.Controls.Add(this.txtrestante);
            this.Controls.Add(this.dgvLista1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frmFactEmitidas";
            this.Load += new System.EventHandler(this.frmFactEmitidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvLista1;
        private System.Windows.Forms.TextBox txtrestante;
        private System.Windows.Forms.ComboBox cbmediopago;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtiva;
        private System.Windows.Forms.TextBox txtneto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label numfact;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdnfact;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutcli;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.MaskedTextBox txtmontocaja;
    }
}