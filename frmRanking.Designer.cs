namespace Prototipo1
{
    partial class frmRanking
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
            this.grdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.lblcantidadproducto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblnombreproducto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpfinal = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLista.ColumnHeadersHeight = 33;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdProducto});
            this.dgvLista.Location = new System.Drawing.Point(28, 149);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(655, 112);
            this.dgvLista.TabIndex = 24;
            // 
            // grdProducto
            // 
            this.grdProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdProducto.HeaderText = "Producto";
            this.grdProducto.Name = "grdProducto";
            this.grdProducto.ReadOnly = true;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(28, 326);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(655, 38);
            this.cmdBuscar.TabIndex = 23;
            this.cmdBuscar.Text = "BUSCAR";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // lblcantidadproducto
            // 
            this.lblcantidadproducto.AutoSize = true;
            this.lblcantidadproducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadproducto.Location = new System.Drawing.Point(361, 430);
            this.lblcantidadproducto.Name = "lblcantidadproducto";
            this.lblcantidadproducto.Size = new System.Drawing.Size(67, 16);
            this.lblcantidadproducto.TabIndex = 22;
            this.lblcantidadproducto.Text = "producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cantidad vendida a la fecha";
            // 
            // lblnombreproducto
            // 
            this.lblnombreproducto.AutoSize = true;
            this.lblnombreproducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreproducto.Location = new System.Drawing.Point(361, 405);
            this.lblnombreproducto.Name = "lblnombreproducto";
            this.lblnombreproducto.Size = new System.Drawing.Size(67, 16);
            this.lblnombreproducto.TabIndex = 20;
            this.lblnombreproducto.Text = "producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Producto ";
            // 
            // txtproducto
            // 
            this.txtproducto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtproducto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtproducto.Location = new System.Drawing.Point(246, 279);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(437, 27);
            this.txtproducto.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(35, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Producto Seleccionado";
            // 
            // dtpfinal
            // 
            this.dtpfinal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.dtpfinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfinal.Location = new System.Drawing.Point(461, 106);
            this.dtpfinal.Name = "dtpfinal";
            this.dtpfinal.Size = new System.Drawing.Size(124, 27);
            this.dtpfinal.TabIndex = 16;
            // 
            // dtpinicio
            // 
            this.dtpinicio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpinicio.Location = new System.Drawing.Point(160, 106);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(124, 27);
            this.dtpinicio.TabIndex = 15;
            this.dtpinicio.ValueChanged += new System.EventHandler(this.dtpinicio_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(344, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hasta :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(67, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Del :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(21, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 39);
            this.label5.TabIndex = 25;
            this.label5.Text = "RANKING";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(285, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = ":";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(541, 467);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(142, 57);
            this.cmdVolver.TabIndex = 28;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 546);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.lblcantidadproducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblnombreproducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpfinal);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking de Productos";
            this.Load += new System.EventHandler(this.frmRanking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Label lblcantidadproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblnombreproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfinal;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdVolver;
    }
}