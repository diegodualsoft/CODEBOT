namespace Prototipo1
{
    partial class frmAdministracion
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdLibroDeVentas = new System.Windows.Forms.Button();
            this.cmdProductos = new System.Windows.Forms.Button();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administración ";
            // 
            // cmdLibroDeVentas
            // 
            this.cmdLibroDeVentas.Location = new System.Drawing.Point(47, 80);
            this.cmdLibroDeVentas.Name = "cmdLibroDeVentas";
            this.cmdLibroDeVentas.Size = new System.Drawing.Size(131, 47);
            this.cmdLibroDeVentas.TabIndex = 17;
            this.cmdLibroDeVentas.Text = "Libro de ventas";
            this.cmdLibroDeVentas.UseVisualStyleBackColor = true;
            this.cmdLibroDeVentas.Click += new System.EventHandler(this.cmdLibroDeVentas_Click);
            // 
            // cmdProductos
            // 
            this.cmdProductos.Location = new System.Drawing.Point(47, 167);
            this.cmdProductos.Name = "cmdProductos";
            this.cmdProductos.Size = new System.Drawing.Size(131, 44);
            this.cmdProductos.TabIndex = 19;
            this.cmdProductos.Text = "Productos";
            this.cmdProductos.UseVisualStyleBackColor = true;
            this.cmdProductos.Click += new System.EventHandler(this.cmdProductos_Click);
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(183, 97);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(100, 13);
            this.lblLibro.TabIndex = 24;
            this.lblLibro.Text = "Abrir libro de ventas";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(184, 183);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(106, 13);
            this.lblProductos.TabIndex = 23;
            this.lblProductos.Text = "Vistaso de productos";
            // 
            // frmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(504, 307);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.cmdProductos);
            this.Controls.Add(this.cmdLibroDeVentas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdLibroDeVentas;
        private System.Windows.Forms.Button cmdProductos;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblProductos;
    }
}