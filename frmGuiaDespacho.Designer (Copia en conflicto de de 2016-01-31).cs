namespace Prototipo1
{
    partial class frmGuiaDespacho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.cmdFactura = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lblNombreprodCaptura = new System.Windows.Forms.Label();
            this.lblCodBarraCaptura = new System.Windows.Forms.Label();
            this.lblPrecioVentaCaptura = new System.Windows.Forms.Label();
            this.lblPrecioCostoCaptura = new System.Windows.Forms.Label();
            this.lblCodInternoCaptura = new System.Windows.Forms.Label();
            this.msksubtotal = new System.Windows.Forms.MaskedTextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblconsultacaja = new System.Windows.Forms.Label();
            this.lblcantcaja = new System.Windows.Forms.Label();
            this.lbltotalprodcaja = new System.Windows.Forms.Label();
            this.ncaja = new System.Windows.Forms.Label();
            this.nconlbl = new System.Windows.Forms.Label();
            this.lblmedidaCaptura = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.lblverindex = new System.Windows.Forms.Label();
            this.lblcosto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.codigo,
            this.precio,
            this.Cantidad,
            this.total,
            this.PrecioCosto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLista.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLista.Location = new System.Drawing.Point(50, 165);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(659, 263);
            this.dgvLista.TabIndex = 1;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            this.dgvLista.SelectionChanged += new System.EventHandler(this.dgvLista_SelectionChanged);
            // 
            // nombre
            // 
            this.nombre.DividerWidth = 1;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.DividerWidth = 1;
            this.codigo.HeaderText = "Codigo de Barra";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 185;
            // 
            // precio
            // 
            this.precio.DividerWidth = 1;
            this.precio.HeaderText = "Precio Unitario";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 130;
            // 
            // PrecioCosto
            // 
            this.PrecioCosto.HeaderText = "preciocosto";
            this.PrecioCosto.Name = "PrecioCosto";
            this.PrecioCosto.ReadOnly = true;
            this.PrecioCosto.Visible = false;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(761, 70);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(142, 39);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "BUSCAR PRODUCTOS";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click_1);
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtCodigoBarra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodigoBarra.Location = new System.Drawing.Point(529, 128);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(180, 29);
            this.txtCodigoBarra.TabIndex = 0;
            this.txtCodigoBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarra_KeyPress);
            // 
            // cmdFactura
            // 
            this.cmdFactura.Location = new System.Drawing.Point(761, 23);
            this.cmdFactura.Name = "cmdFactura";
            this.cmdFactura.Size = new System.Drawing.Size(142, 39);
            this.cmdFactura.TabIndex = 6;
            this.cmdFactura.Text = "Emitir Factura";
            this.cmdFactura.UseVisualStyleBackColor = true;
            this.cmdFactura.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(490, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "NETO:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(510, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "IVA:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtIVA.Location = new System.Drawing.Point(556, 474);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(153, 29);
            this.txtIVA.TabIndex = 11;
            this.txtIVA.TextChanged += new System.EventHandler(this.txtIVA_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtTotal.Location = new System.Drawing.Point(556, 516);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(154, 29);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(482, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "TOTAL:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(761, 115);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(142, 39);
            this.cmdSalir.TabIndex = 18;
            this.cmdSalir.Text = "Cerrar";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lblNombreprodCaptura
            // 
            this.lblNombreprodCaptura.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblNombreprodCaptura.AutoSize = true;
            this.lblNombreprodCaptura.Location = new System.Drawing.Point(215, 431);
            this.lblNombreprodCaptura.Name = "lblNombreprodCaptura";
            this.lblNombreprodCaptura.Size = new System.Drawing.Size(0, 13);
            this.lblNombreprodCaptura.TabIndex = 21;
            this.lblNombreprodCaptura.Visible = false;
            // 
            // lblCodBarraCaptura
            // 
            this.lblCodBarraCaptura.AutoSize = true;
            this.lblCodBarraCaptura.Location = new System.Drawing.Point(215, 450);
            this.lblCodBarraCaptura.Name = "lblCodBarraCaptura";
            this.lblCodBarraCaptura.Size = new System.Drawing.Size(0, 13);
            this.lblCodBarraCaptura.TabIndex = 23;
            this.lblCodBarraCaptura.Visible = false;
            // 
            // lblPrecioVentaCaptura
            // 
            this.lblPrecioVentaCaptura.AutoSize = true;
            this.lblPrecioVentaCaptura.Location = new System.Drawing.Point(215, 474);
            this.lblPrecioVentaCaptura.Name = "lblPrecioVentaCaptura";
            this.lblPrecioVentaCaptura.Size = new System.Drawing.Size(0, 13);
            this.lblPrecioVentaCaptura.TabIndex = 25;
            this.lblPrecioVentaCaptura.Visible = false;
            // 
            // lblPrecioCostoCaptura
            // 
            this.lblPrecioCostoCaptura.AutoSize = true;
            this.lblPrecioCostoCaptura.Location = new System.Drawing.Point(215, 497);
            this.lblPrecioCostoCaptura.Name = "lblPrecioCostoCaptura";
            this.lblPrecioCostoCaptura.Size = new System.Drawing.Size(0, 13);
            this.lblPrecioCostoCaptura.TabIndex = 27;
            this.lblPrecioCostoCaptura.Visible = false;
            // 
            // lblCodInternoCaptura
            // 
            this.lblCodInternoCaptura.AutoSize = true;
            this.lblCodInternoCaptura.Location = new System.Drawing.Point(212, 525);
            this.lblCodInternoCaptura.Name = "lblCodInternoCaptura";
            this.lblCodInternoCaptura.Size = new System.Drawing.Size(0, 13);
            this.lblCodInternoCaptura.TabIndex = 28;
            this.lblCodInternoCaptura.Visible = false;
            // 
            // msksubtotal
            // 
            this.msksubtotal.Culture = new System.Globalization.CultureInfo("en-US");
            this.msksubtotal.Enabled = false;
            this.msksubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.msksubtotal.Location = new System.Drawing.Point(556, 434);
            this.msksubtotal.Name = "msksubtotal";
            this.msksubtotal.Size = new System.Drawing.Size(154, 26);
            this.msksubtotal.TabIndex = 29;
            this.msksubtotal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msksubtotal_MaskInputRejected);
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtCant.Location = new System.Drawing.Point(177, 130);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(85, 29);
            this.txtCant.TabIndex = 1;
            this.txtCant.Text = "1";
            this.txtCant.TextChanged += new System.EventHandler(this.txtCant_TextChanged);
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblCantidad.Location = new System.Drawing.Point(47, 132);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(124, 25);
            this.lblCantidad.TabIndex = 33;
            this.lblCantidad.Text = "CANTIDAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(268, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "CODIGO DE PRODUCTO";
            // 
            // lblconsultacaja
            // 
            this.lblconsultacaja.AutoSize = true;
            this.lblconsultacaja.Location = new System.Drawing.Point(47, 76);
            this.lblconsultacaja.Name = "lblconsultacaja";
            this.lblconsultacaja.Size = new System.Drawing.Size(35, 13);
            this.lblconsultacaja.TabIndex = 36;
            this.lblconsultacaja.Text = "label2";
            this.lblconsultacaja.Visible = false;
            this.lblconsultacaja.Click += new System.EventHandler(this.lblconsultacaja_Click);
            // 
            // lblcantcaja
            // 
            this.lblcantcaja.AutoSize = true;
            this.lblcantcaja.Location = new System.Drawing.Point(47, 46);
            this.lblcantcaja.Name = "lblcantcaja";
            this.lblcantcaja.Size = new System.Drawing.Size(35, 13);
            this.lblcantcaja.TabIndex = 37;
            this.lblcantcaja.Text = "label2";
            this.lblcantcaja.Visible = false;
            // 
            // lbltotalprodcaja
            // 
            this.lbltotalprodcaja.AutoSize = true;
            this.lbltotalprodcaja.Location = new System.Drawing.Point(50, 13);
            this.lbltotalprodcaja.Name = "lbltotalprodcaja";
            this.lbltotalprodcaja.Size = new System.Drawing.Size(35, 13);
            this.lbltotalprodcaja.TabIndex = 38;
            this.lbltotalprodcaja.Text = "label6";
            this.lbltotalprodcaja.Visible = false;
            // 
            // ncaja
            // 
            this.ncaja.AutoSize = true;
            this.ncaja.Location = new System.Drawing.Point(137, 46);
            this.ncaja.Name = "ncaja";
            this.ncaja.Size = new System.Drawing.Size(13, 13);
            this.ncaja.TabIndex = 39;
            this.ncaja.Text = "1";
            this.ncaja.Visible = false;
            // 
            // nconlbl
            // 
            this.nconlbl.AutoSize = true;
            this.nconlbl.Location = new System.Drawing.Point(119, 13);
            this.nconlbl.Name = "nconlbl";
            this.nconlbl.Size = new System.Drawing.Size(31, 13);
            this.nconlbl.TabIndex = 40;
            this.nconlbl.Text = "ncon";
            this.nconlbl.Visible = false;
            // 
            // lblmedidaCaptura
            // 
            this.lblmedidaCaptura.AutoSize = true;
            this.lblmedidaCaptura.Location = new System.Drawing.Point(59, 108);
            this.lblmedidaCaptura.Name = "lblmedidaCaptura";
            this.lblmedidaCaptura.Size = new System.Drawing.Size(0, 13);
            this.lblmedidaCaptura.TabIndex = 44;
            this.lblmedidaCaptura.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd_M_yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(509, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "FECHA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 33);
            this.label6.TabIndex = 47;
            this.label6.Text = "GUÍA DE DESPACHO";
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.Location = new System.Drawing.Point(49, 429);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(194, 39);
            this.cmdeliminar.TabIndex = 48;
            this.cmdeliminar.Text = "Eliminar Producto Seleccionado";
            this.cmdeliminar.UseVisualStyleBackColor = true;
            this.cmdeliminar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lblverindex
            // 
            this.lblverindex.AutoSize = true;
            this.lblverindex.Enabled = false;
            this.lblverindex.Location = new System.Drawing.Point(325, 539);
            this.lblverindex.Name = "lblverindex";
            this.lblverindex.Size = new System.Drawing.Size(35, 13);
            this.lblverindex.TabIndex = 49;
            this.lblverindex.Text = "label7";
            this.lblverindex.Visible = false;
            // 
            // lblcosto
            // 
            this.lblcosto.AutoSize = true;
            this.lblcosto.Enabled = false;
            this.lblcosto.Location = new System.Drawing.Point(243, 79);
            this.lblcosto.Name = "lblcosto";
            this.lblcosto.Size = new System.Drawing.Size(0, 13);
            this.lblcosto.TabIndex = 51;
            this.lblcosto.Visible = false;
            // 
            // frmGuiaDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(930, 598);
            this.Controls.Add(this.lblcosto);
            this.Controls.Add(this.lblverindex);
            this.Controls.Add(this.cmdeliminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblmedidaCaptura);
            this.Controls.Add(this.nconlbl);
            this.Controls.Add(this.ncaja);
            this.Controls.Add(this.lbltotalprodcaja);
            this.Controls.Add(this.lblcantcaja);
            this.Controls.Add(this.lblconsultacaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.msksubtotal);
            this.Controls.Add(this.lblCodInternoCaptura);
            this.Controls.Add(this.lblPrecioCostoCaptura);
            this.Controls.Add(this.lblPrecioVentaCaptura);
            this.Controls.Add(this.lblCodBarraCaptura);
            this.Controls.Add(this.lblNombreprodCaptura);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdFactura);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.dgvLista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGuiaDespacho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guía de Despacho";
            this.Load += new System.EventHandler(this.frmGuiaDespacho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdFactura;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lblNombreprodCaptura;
        private System.Windows.Forms.Label lblCodBarraCaptura;
        private System.Windows.Forms.Label lblPrecioVentaCaptura;
        private System.Windows.Forms.Label lblPrecioCostoCaptura;
        private System.Windows.Forms.Label lblCodInternoCaptura;
        private System.Windows.Forms.MaskedTextBox msksubtotal;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblconsultacaja;
        private System.Windows.Forms.Label lblcantcaja;
        private System.Windows.Forms.Label lbltotalprodcaja;
        private System.Windows.Forms.Label ncaja;
        private System.Windows.Forms.Label nconlbl;
        private System.Windows.Forms.Label lblmedidaCaptura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdeliminar;
        private System.Windows.Forms.Label lblverindex;
        private System.Windows.Forms.Label lblcosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCosto;
    }
}