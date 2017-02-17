namespace Prototipo1
{
    partial class frmGestionComercial
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdgestprov = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cuadrar Facturas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ingresar Factura Proveedor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Location = new System.Drawing.Point(82, 381);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(188, 50);
            this.cmdCerrar.TabIndex = 2;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdgestprov
            // 
            this.cmdgestprov.Location = new System.Drawing.Point(82, 287);
            this.cmdgestprov.Name = "cmdgestprov";
            this.cmdgestprov.Size = new System.Drawing.Size(188, 52);
            this.cmdgestprov.TabIndex = 3;
            this.cmdgestprov.Text = "Gestion Provedores";
            this.cmdgestprov.UseVisualStyleBackColor = true;
            this.cmdgestprov.Click += new System.EventHandler(this.cmdgestprov_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "Nota De Credito";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.Location = new System.Drawing.Point(82, 53);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(188, 53);
            this.btnRanking.TabIndex = 5;
            this.btnRanking.Text = "Ranking ";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menú Gestion Comercial";
            // 
            // frmGestionComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(356, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmdgestprov);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionComercial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Comercial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Button cmdgestprov;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Label label1;
    }
}