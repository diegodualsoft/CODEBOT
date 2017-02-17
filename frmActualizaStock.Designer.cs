namespace Prototipo1
{
    partial class frmActualizaStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizaStock));
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdActualizar = new System.Windows.Forms.Button();
            this.txtStockNuevo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Modificar stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(15, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Stock";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(100, 95);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(52, 17);
            this.lblStock.TabIndex = 20;
            this.lblStock.Text = "label4";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdCancelar.Location = new System.Drawing.Point(451, 9);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(35, 27);
            this.cmdCancelar.TabIndex = 19;
            this.cmdCancelar.Text = "X";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdActualizar
            // 
            this.cmdActualizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdActualizar.Location = new System.Drawing.Point(288, 76);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(127, 27);
            this.cmdActualizar.TabIndex = 18;
            this.cmdActualizar.Text = "Actualizar";
            this.cmdActualizar.UseVisualStyleBackColor = false;
            this.cmdActualizar.Click += new System.EventHandler(this.cmdActualizar_Click);
            // 
            // txtStockNuevo
            // 
            this.txtStockNuevo.Location = new System.Drawing.Point(18, 182);
            this.txtStockNuevo.Name = "txtStockNuevo";
            this.txtStockNuevo.Size = new System.Drawing.Size(100, 20);
            this.txtStockNuevo.TabIndex = 14;
            this.txtStockNuevo.TextChanged += new System.EventHandler(this.txtStockNuevo_TextChanged);
            this.txtStockNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockNuevo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Opciones Stock";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblcod.Location = new System.Drawing.Point(100, 66);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(69, 17);
            this.lblcod.TabIndex = 29;
            this.lblcod.Text = "CODIGO";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblnom.Location = new System.Drawing.Point(99, 42);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(79, 24);
            this.lblnom.TabIndex = 30;
            this.lblnom.Text = "Nombre";
            this.lblnom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(14, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Modificar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(288, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 27);
            this.button1.TabIndex = 34;
            this.button1.Text = "Establecer stock en 0";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -536);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 797);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // frmActualizaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(507, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdActualizar);
            this.Controls.Add(this.txtStockNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActualizaStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Stock";
            this.Load += new System.EventHandler(this.frmActualizaStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdActualizar;
        private System.Windows.Forms.TextBox txtStockNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}