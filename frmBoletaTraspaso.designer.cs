namespace Prototipo1
{
    partial class frmBoletaTraspaso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stnumeroboleta = new System.Windows.Forms.Label();
            this.lblNumFact = new System.Windows.Forms.Label();
            this.stTIPOPAGO = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codinterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttotal = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.txtcredito = new System.Windows.Forms.TextBox();
            this.txtdebito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.cbxDesde = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxHacia = new System.Windows.Forms.ComboBox();
            this.txtGuiaRef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblidLocal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // stnumeroboleta
            // 
            this.stnumeroboleta.AutoSize = true;
            this.stnumeroboleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.stnumeroboleta.Location = new System.Drawing.Point(23, 9);
            this.stnumeroboleta.Name = "stnumeroboleta";
            this.stnumeroboleta.Size = new System.Drawing.Size(153, 29);
            this.stnumeroboleta.TabIndex = 0;
            this.stnumeroboleta.Text = "Traspaso N°";
            // 
            // lblNumFact
            // 
            this.lblNumFact.AutoSize = true;
            this.lblNumFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblNumFact.Location = new System.Drawing.Point(194, 9);
            this.lblNumFact.Name = "lblNumFact";
            this.lblNumFact.Size = new System.Drawing.Size(27, 29);
            this.lblNumFact.TabIndex = 1;
            this.lblNumFact.Text = "0";
            this.lblNumFact.Click += new System.EventHandler(this.lblboleta_Click);
            // 
            // stTIPOPAGO
            // 
            this.stTIPOPAGO.AutoSize = true;
            this.stTIPOPAGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stTIPOPAGO.Location = new System.Drawing.Point(65, 505);
            this.stTIPOPAGO.Name = "stTIPOPAGO";
            this.stTIPOPAGO.Size = new System.Drawing.Size(195, 29);
            this.stTIPOPAGO.TabIndex = 2;
            this.stTIPOPAGO.Text = "TIPO DE PAGO";
            this.stTIPOPAGO.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(571, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.codigo,
            this.precio,
            this.Cantidad,
            this.total,
            this.PrecioCosto,
            this.codinterno,
            this.margen});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLista.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLista.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLista.Location = new System.Drawing.Point(17, 150);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(670, 265);
            this.dgvLista.TabIndex = 55;
            // 
            // nombre
            // 
            this.nombre.DividerWidth = 1;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 230;
            // 
            // codigo
            // 
            this.codigo.DividerWidth = 1;
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
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
            // codinterno
            // 
            this.codinterno.HeaderText = "codinterno";
            this.codinterno.Name = "codinterno";
            this.codinterno.ReadOnly = true;
            this.codinterno.Visible = false;
            // 
            // margen
            // 
            this.margen.HeaderText = "margen";
            this.margen.Name = "margen";
            this.margen.ReadOnly = true;
            this.margen.Visible = false;
            // 
            // sttotal
            // 
            this.sttotal.AutoSize = true;
            this.sttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.sttotal.Location = new System.Drawing.Point(394, 612);
            this.sttotal.Name = "sttotal";
            this.sttotal.Size = new System.Drawing.Size(132, 38);
            this.sttotal.TabIndex = 57;
            this.sttotal.Text = "TOTAL:";
            this.sttotal.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(487, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // txtefectivo
            // 
            this.txtefectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtefectivo.Location = new System.Drawing.Point(177, 540);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.Size = new System.Drawing.Size(127, 26);
            this.txtefectivo.TabIndex = 59;
            this.txtefectivo.Text = "0";
            this.txtefectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtefectivo.Visible = false;
            this.txtefectivo.TextChanged += new System.EventHandler(this.txtefectivo_TextChanged);
            this.txtefectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtefectivo_KeyPress);
            // 
            // txtcredito
            // 
            this.txtcredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtcredito.Location = new System.Drawing.Point(177, 621);
            this.txtcredito.Name = "txtcredito";
            this.txtcredito.Size = new System.Drawing.Size(127, 26);
            this.txtcredito.TabIndex = 60;
            this.txtcredito.Text = "0";
            this.txtcredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcredito.Visible = false;
            this.txtcredito.TextChanged += new System.EventHandler(this.txtcredito_TextChanged);
            // 
            // txtdebito
            // 
            this.txtdebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtdebito.Location = new System.Drawing.Point(177, 582);
            this.txtdebito.Name = "txtdebito";
            this.txtdebito.Size = new System.Drawing.Size(127, 26);
            this.txtdebito.TabIndex = 61;
            this.txtdebito.Text = "0";
            this.txtdebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdebito.Visible = false;
            this.txtdebito.Click += new System.EventHandler(this.txtdebito_Click);
            this.txtdebito.TextChanged += new System.EventHandler(this.txtdebito_TextChanged);
            this.txtdebito.Enter += new System.EventHandler(this.txtdebito_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(34, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "DEBITO";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(34, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 63;
            this.label2.Text = "CREDITO";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(34, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 64;
            this.label3.Text = "EFECTIVO";
            this.label3.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(444, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 53);
            this.button2.TabIndex = 65;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(29, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 66;
            this.label4.Text = "DETALLE TRASPASO";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(532, 614);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(166, 35);
            this.txttotal.TabIndex = 68;
            this.txttotal.Text = "0";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttotal.Visible = false;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbltotal.Location = new System.Drawing.Point(528, 587);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(20, 24);
            this.lbltotal.TabIndex = 69;
            this.lbltotal.Text = "0";
            this.lbltotal.Visible = false;
            // 
            // cbxDesde
            // 
            this.cbxDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDesde.FormattingEnabled = true;
            this.cbxDesde.Location = new System.Drawing.Point(66, 54);
            this.cbxDesde.Name = "cbxDesde";
            this.cbxDesde.Size = new System.Drawing.Size(243, 21);
            this.cbxDesde.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Hacia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Desde";
            // 
            // cbxHacia
            // 
            this.cbxHacia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHacia.FormattingEnabled = true;
            this.cbxHacia.Location = new System.Drawing.Point(356, 54);
            this.cbxHacia.Name = "cbxHacia";
            this.cbxHacia.Size = new System.Drawing.Size(251, 21);
            this.cbxHacia.TabIndex = 73;
            this.cbxHacia.SelectedValueChanged += new System.EventHandler(this.cbxHacia_SelectedValueChanged);
            // 
            // txtGuiaRef
            // 
            this.txtGuiaRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtGuiaRef.Location = new System.Drawing.Point(129, 81);
            this.txtGuiaRef.Name = "txtGuiaRef";
            this.txtGuiaRef.Size = new System.Drawing.Size(180, 26);
            this.txtGuiaRef.TabIndex = 74;
            this.txtGuiaRef.Text = "0";
            this.txtGuiaRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "N° Guia Referencia";
            // 
            // lblidLocal
            // 
            this.lblidLocal.AutoSize = true;
            this.lblidLocal.Location = new System.Drawing.Point(575, 78);
            this.lblidLocal.Name = "lblidLocal";
            this.lblidLocal.Size = new System.Drawing.Size(15, 13);
            this.lblidLocal.TabIndex = 76;
            this.lblidLocal.Text = "id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(519, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "ID Local:";
            // 
            // frmBoletaTraspaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(729, 730);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblidLocal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGuiaRef);
            this.Controls.Add(this.cbxHacia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxDesde);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdebito);
            this.Controls.Add(this.txtcredito);
            this.Controls.Add(this.txtefectivo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sttotal);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stTIPOPAGO);
            this.Controls.Add(this.lblNumFact);
            this.Controls.Add(this.stnumeroboleta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBoletaTraspaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar Venta";
            this.Load += new System.EventHandler(this.frmBoleta_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmBoleta_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stnumeroboleta;
        private System.Windows.Forms.Label lblNumFact;
        private System.Windows.Forms.Label stTIPOPAGO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label sttotal;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.TextBox txtcredito;
        private System.Windows.Forms.TextBox txtdebito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.ComboBox cbxDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxHacia;
        private System.Windows.Forms.TextBox txtGuiaRef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codinterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn margen;
        private System.Windows.Forms.Label lblidLocal;
        private System.Windows.Forms.Label label9;
    }
}