namespace Prototipo1
{
    partial class frmFacturasCuadradas
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
            this.grdnfact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdmonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdtipopago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotefectivo = new System.Windows.Forms.TextBox();
            this.txttotcheques = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txttotaltotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdnfact,
            this.grfecha,
            this.grdmonto,
            this.grdtipopago,
            this.encaja,
            this.restante});
            this.dgvLista.Location = new System.Drawing.Point(12, 32);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(693, 353);
            this.dgvLista.TabIndex = 0;
            // 
            // grdnfact
            // 
            this.grdnfact.HeaderText = "N°FACTURA";
            this.grdnfact.Name = "grdnfact";
            this.grdnfact.ReadOnly = true;
            // 
            // grfecha
            // 
            this.grfecha.HeaderText = "FECHA";
            this.grfecha.Name = "grfecha";
            this.grfecha.ReadOnly = true;
            this.grfecha.Width = 130;
            // 
            // grdmonto
            // 
            this.grdmonto.HeaderText = "MONTO";
            this.grdmonto.Name = "grdmonto";
            this.grdmonto.ReadOnly = true;
            // 
            // grdtipopago
            // 
            this.grdtipopago.HeaderText = "TIPO DE PAGO";
            this.grdtipopago.Name = "grdtipopago";
            this.grdtipopago.ReadOnly = true;
            this.grdtipopago.Width = 120;
            // 
            // encaja
            // 
            this.encaja.HeaderText = "EN CAJA";
            this.encaja.Name = "encaja";
            this.encaja.ReadOnly = true;
            // 
            // restante
            // 
            this.restante.HeaderText = "RESTANTE";
            this.restante.Name = "restante";
            this.restante.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd_MM_yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL EFECTIVO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(21, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar Por Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TOTAL CHEQUES";
            // 
            // txttotefectivo
            // 
            this.txttotefectivo.Location = new System.Drawing.Point(111, 426);
            this.txttotefectivo.Name = "txttotefectivo";
            this.txttotefectivo.Size = new System.Drawing.Size(127, 20);
            this.txttotefectivo.TabIndex = 9;
            this.txttotefectivo.Text = "0";
            this.txttotefectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttotcheques
            // 
            this.txttotcheques.Location = new System.Drawing.Point(282, 426);
            this.txttotcheques.Name = "txttotcheques";
            this.txttotcheques.Size = new System.Drawing.Size(124, 20);
            this.txttotcheques.TabIndex = 11;
            this.txttotcheques.Text = "0";
            this.txttotcheques.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttotaltotal
            // 
            this.txttotaltotal.Location = new System.Drawing.Point(459, 426);
            this.txttotaltotal.Name = "txttotaltotal";
            this.txttotaltotal.Size = new System.Drawing.Size(124, 20);
            this.txttotaltotal.TabIndex = 14;
            this.txttotaltotal.Text = "0";
            this.txttotaltotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "TOTAL ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "$";
            // 
            // frmFacturasCuadradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 483);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttotaltotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttotcheques);
            this.Controls.Add(this.txttotefectivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvLista);
            this.Name = "frmFacturasCuadradas";
            this.Text = " Facturas  Cuadradas";
            this.Load += new System.EventHandler(this.frmFacturasCuadradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttotefectivo;
        private System.Windows.Forms.TextBox txttotcheques;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdnfact;
        private System.Windows.Forms.DataGridViewTextBoxColumn grfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdmonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdtipopago;
        private System.Windows.Forms.DataGridViewTextBoxColumn encaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn restante;
        private System.Windows.Forms.TextBox txttotaltotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}