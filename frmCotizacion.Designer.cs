namespace Prototipo1
{
    partial class frmCotizacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Imprimir = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.Cotización = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtManoDeObra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // Imprimir
            // 
            this.Imprimir.Location = new System.Drawing.Point(394, 481);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(89, 42);
            this.Imprimir.TabIndex = 1;
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.UseVisualStyleBackColor = true;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Location = new System.Drawing.Point(301, 481);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(87, 42);
            this.cmdCerrar.TabIndex = 2;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            // 
            // Cotización
            // 
            this.Cotización.AutoSize = true;
            this.Cotización.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Cotización.Location = new System.Drawing.Point(13, 25);
            this.Cotización.Name = "Cotización";
            this.Cotización.Size = new System.Drawing.Size(132, 29);
            this.Cotización.TabIndex = 3;
            this.Cotización.Text = "Cotización";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(172, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "MANO DE OBRA:";
            // 
            // txtManoDeObra
            // 
            this.txtManoDeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtManoDeObra.Location = new System.Drawing.Point(324, 340);
            this.txtManoDeObra.Name = "txtManoDeObra";
            this.txtManoDeObra.Size = new System.Drawing.Size(153, 29);
            this.txtManoDeObra.TabIndex = 23;
            this.txtManoDeObra.Text = "no se si se cobra iva ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(249, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtTotal.Location = new System.Drawing.Point(323, 445);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(153, 29);
            this.txtTotal.TabIndex = 21;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtIVA.Location = new System.Drawing.Point(324, 410);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(153, 29);
            this.txtIVA.TabIndex = 20;
            this.txtIVA.Text = "no editable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(278, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "IVA:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtSubTotal.Location = new System.Drawing.Point(323, 375);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(153, 29);
            this.txtSubTotal.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(210, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "SUB TOTAL:";
            // 
            // frmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 535);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtManoDeObra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cotización);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCotizacion";
            this.Text = "frmCotizacion";
            this.Load += new System.EventHandler(this.frmCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Label Cotización;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtManoDeObra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label3;
    }
}