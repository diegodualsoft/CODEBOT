namespace Prototipo1
{
    partial class frmEliminarUsuario
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
            this.cbxUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxUsuarios
            // 
            this.cbxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsuarios.FormattingEnabled = true;
            this.cbxUsuarios.Location = new System.Drawing.Point(108, 28);
            this.cbxUsuarios.Name = "cbxUsuarios";
            this.cbxUsuarios.Size = new System.Drawing.Size(140, 21);
            this.cbxUsuarios.TabIndex = 0;
            this.cbxUsuarios.SelectedIndexChanged += new System.EventHandler(this.cbxUsuarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nivel Usuario";
            // 
            // txtNivel
            // 
            this.txtNivel.Enabled = false;
            this.txtNivel.Location = new System.Drawing.Point(108, 56);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(140, 20);
            this.txtNivel.TabIndex = 3;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(155, 93);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(93, 38);
            this.cmdEliminar.TabIndex = 4;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(15, 93);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(96, 38);
            this.cmdCancelar.TabIndex = 5;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // frmEliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 261);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxUsuarios);
            this.Name = "frmEliminarUsuario";
            this.Text = "frmEliminarUsuario";
            this.Load += new System.EventHandler(this.frmEliminarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdCancelar;
    }
}