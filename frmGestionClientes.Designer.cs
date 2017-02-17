namespace Prototipo1
{
    partial class frmGestionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionClientes));
            this.cmdIngreso = new System.Windows.Forms.Button();
            this.cmdGestionClientes = new System.Windows.Forms.Button();
            this.frmVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdIngreso
            // 
            this.cmdIngreso.Location = new System.Drawing.Point(86, 41);
            this.cmdIngreso.Name = "cmdIngreso";
            this.cmdIngreso.Size = new System.Drawing.Size(116, 46);
            this.cmdIngreso.TabIndex = 1;
            this.cmdIngreso.Text = "Ingreso Clientes";
            this.cmdIngreso.UseVisualStyleBackColor = true;
            this.cmdIngreso.Click += new System.EventHandler(this.cmdIngreso_Click);
            // 
            // cmdGestionClientes
            // 
            this.cmdGestionClientes.Location = new System.Drawing.Point(86, 93);
            this.cmdGestionClientes.Name = "cmdGestionClientes";
            this.cmdGestionClientes.Size = new System.Drawing.Size(116, 46);
            this.cmdGestionClientes.TabIndex = 2;
            this.cmdGestionClientes.Text = "Clientes";
            this.cmdGestionClientes.UseVisualStyleBackColor = true;
            this.cmdGestionClientes.Click += new System.EventHandler(this.cmdGestionClientes_Click);
            // 
            // frmVolver
            // 
            this.frmVolver.Location = new System.Drawing.Point(86, 145);
            this.frmVolver.Name = "frmVolver";
            this.frmVolver.Size = new System.Drawing.Size(116, 44);
            this.frmVolver.TabIndex = 3;
            this.frmVolver.Text = "Volver";
            this.frmVolver.UseVisualStyleBackColor = true;
            this.frmVolver.Click += new System.EventHandler(this.frmVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-17, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 308);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 228);
            this.Controls.Add(this.frmVolver);
            this.Controls.Add(this.cmdGestionClientes);
            this.Controls.Add(this.cmdIngreso);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Clientes";
            this.Load += new System.EventHandler(this.frmGestionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdIngreso;
        private System.Windows.Forms.Button cmdGestionClientes;
        private System.Windows.Forms.Button frmVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}