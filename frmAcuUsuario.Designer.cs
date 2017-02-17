namespace Prototipo1
{
    partial class frmAcuUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomUsNuevo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.id_usu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACTULIZAR USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmar Contraseña";
            // 
            // txtNomUsNuevo
            // 
            this.txtNomUsNuevo.Location = new System.Drawing.Point(127, 38);
            this.txtNomUsNuevo.Name = "txtNomUsNuevo";
            this.txtNomUsNuevo.Size = new System.Drawing.Size(154, 20);
            this.txtNomUsNuevo.TabIndex = 4;
            this.txtNomUsNuevo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomUsNuevo_KeyDown);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(127, 62);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(154, 20);
            this.txtContraseña.TabIndex = 5;
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Location = new System.Drawing.Point(127, 88);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '*';
            this.txtContraseña2.Size = new System.Drawing.Size(154, 20);
            this.txtContraseña2.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(169, 162);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 41);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Actualizar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 162);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 41);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo Usuario";
            // 
            // cbxTipoUsuario
            // 
            this.cbxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoUsuario.FormattingEnabled = true;
            this.cbxTipoUsuario.Items.AddRange(new object[] {
            "CAJA",
            "ADMINISTRACION",
            "JUNIOR",
            "SUPREMO"});
            this.cbxTipoUsuario.Location = new System.Drawing.Point(127, 117);
            this.cbxTipoUsuario.Name = "cbxTipoUsuario";
            this.cbxTipoUsuario.Size = new System.Drawing.Size(154, 21);
            this.cbxTipoUsuario.TabIndex = 12;
            // 
            // id_usu
            // 
            this.id_usu.AutoSize = true;
            this.id_usu.Location = new System.Drawing.Point(13, 9);
            this.id_usu.Name = "id_usu";
            this.id_usu.Size = new System.Drawing.Size(35, 13);
            this.id_usu.TabIndex = 13;
            this.id_usu.Text = "label6";
            this.id_usu.Visible = false;
            // 
            // frmAcuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 220);
            this.Controls.Add(this.id_usu);
            this.Controls.Add(this.cbxTipoUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNomUsNuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAcuUsuario";
            this.Text = "actualizar";
            this.Load += new System.EventHandler(this.frmRegistroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomUsNuevo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTipoUsuario;
        private System.Windows.Forms.Label id_usu;
    }
}