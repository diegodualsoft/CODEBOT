namespace Prototipo1
{
    partial class frmUsuarios
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
            this.btnRegistroUs = new System.Windows.Forms.Button();
            this.btnEliminarUs = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DE USUARIOS";
            // 
            // btnRegistroUs
            // 
            this.btnRegistroUs.Location = new System.Drawing.Point(79, 45);
            this.btnRegistroUs.Name = "btnRegistroUs";
            this.btnRegistroUs.Size = new System.Drawing.Size(129, 47);
            this.btnRegistroUs.TabIndex = 1;
            this.btnRegistroUs.Text = "Registrar Usuario";
            this.btnRegistroUs.UseVisualStyleBackColor = true;
            this.btnRegistroUs.Click += new System.EventHandler(this.btnRegistroUs_Click);
            // 
            // btnEliminarUs
            // 
            this.btnEliminarUs.Location = new System.Drawing.Point(79, 99);
            this.btnEliminarUs.Name = "btnEliminarUs";
            this.btnEliminarUs.Size = new System.Drawing.Size(129, 47);
            this.btnEliminarUs.TabIndex = 2;
            this.btnEliminarUs.Text = "Eliminar Usuario";
            this.btnEliminarUs.UseVisualStyleBackColor = true;
            this.btnEliminarUs.Click += new System.EventHandler(this.btnEliminarUs_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(79, 200);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(129, 50);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Actulizar Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminarUs);
            this.Controls.Add(this.btnRegistroUs);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistroUs;
        private System.Windows.Forms.Button btnEliminarUs;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button1;

    }
}