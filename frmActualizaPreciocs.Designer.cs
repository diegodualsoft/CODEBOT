namespace Prototipo1
{
    partial class frmActualizaPreciocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizaPreciocs));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreicioCosto = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdActualizar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tituloMargen1 = new System.Windows.Forms.Label();
            this.lblMargenAntiguo = new System.Windows.Forms.Label();
            this.tituloMargen2 = new System.Windows.Forms.Label();
            this.lblMargenNuevo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevos Precios";
            this.label1.UseWaitCursor = true;
            // 
            // txtPreicioCosto
            // 
            this.txtPreicioCosto.Location = new System.Drawing.Point(121, 278);
            this.txtPreicioCosto.Name = "txtPreicioCosto";
            this.txtPreicioCosto.Size = new System.Drawing.Size(100, 20);
            this.txtPreicioCosto.TabIndex = 1;
            this.txtPreicioCosto.UseWaitCursor = true;
            this.txtPreicioCosto.TextChanged += new System.EventHandler(this.txtPrecioCosto_TextChanged);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(354, 278);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 2;
            this.txtPrecioVenta.UseWaitCursor = true;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio Costo";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(238, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio Venta";
            this.label3.UseWaitCursor = true;
            // 
            // cmdActualizar
            // 
            this.cmdActualizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdActualizar.Location = new System.Drawing.Point(21, 358);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(129, 33);
            this.cmdActualizar.TabIndex = 5;
            this.cmdActualizar.Text = "Actualizar";
            this.cmdActualizar.UseVisualStyleBackColor = false;
            this.cmdActualizar.UseWaitCursor = true;
            this.cmdActualizar.Click += new System.EventHandler(this.cmdActualizar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmdCancelar.Location = new System.Drawing.Point(525, 12);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(24, 25);
            this.cmdCancelar.TabIndex = 6;
            this.cmdCancelar.Text = "X";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.UseWaitCursor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrecioCosto.Location = new System.Drawing.Point(148, 130);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(17, 17);
            this.lblPrecioCosto.TabIndex = 7;
            this.lblPrecioCosto.Text = "0";
            this.lblPrecioCosto.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(22, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio Costo";
            this.label5.UseWaitCursor = true;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrecioVenta.Location = new System.Drawing.Point(148, 167);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(17, 17);
            this.lblPrecioVenta.TabIndex = 9;
            this.lblPrecioVenta.Text = "0";
            this.lblPrecioVenta.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(21, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Precio Venta";
            this.label7.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Precio Actual";
            this.label9.UseWaitCursor = true;
            // 
            // tituloMargen1
            // 
            this.tituloMargen1.AutoSize = true;
            this.tituloMargen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tituloMargen1.Location = new System.Drawing.Point(21, 201);
            this.tituloMargen1.Name = "tituloMargen1";
            this.tituloMargen1.Size = new System.Drawing.Size(62, 17);
            this.tituloMargen1.TabIndex = 14;
            this.tituloMargen1.Text = "Margen";
            this.tituloMargen1.UseWaitCursor = true;
            // 
            // lblMargenAntiguo
            // 
            this.lblMargenAntiguo.AutoSize = true;
            this.lblMargenAntiguo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMargenAntiguo.Location = new System.Drawing.Point(148, 201);
            this.lblMargenAntiguo.Name = "lblMargenAntiguo";
            this.lblMargenAntiguo.Size = new System.Drawing.Size(17, 17);
            this.lblMargenAntiguo.TabIndex = 13;
            this.lblMargenAntiguo.Text = "0";
            this.lblMargenAntiguo.UseWaitCursor = true;
            // 
            // tituloMargen2
            // 
            this.tituloMargen2.AutoSize = true;
            this.tituloMargen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tituloMargen2.Location = new System.Drawing.Point(174, 323);
            this.tituloMargen2.Name = "tituloMargen2";
            this.tituloMargen2.Size = new System.Drawing.Size(226, 17);
            this.tituloMargen2.TabIndex = 16;
            this.tituloMargen2.Text = "Nuevo Margen:                   %";
            this.tituloMargen2.UseWaitCursor = true;
            // 
            // lblMargenNuevo
            // 
            this.lblMargenNuevo.AutoSize = true;
            this.lblMargenNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMargenNuevo.Location = new System.Drawing.Point(309, 323);
            this.lblMargenNuevo.Name = "lblMargenNuevo";
            this.lblMargenNuevo.Size = new System.Drawing.Size(17, 17);
            this.lblMargenNuevo.TabIndex = 15;
            this.lblMargenNuevo.Text = "0";
            this.lblMargenNuevo.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(21, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nombre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(22, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "CODIGO";
            this.label6.UseWaitCursor = true;
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblnom.Location = new System.Drawing.Point(106, 65);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(79, 24);
            this.lblnom.TabIndex = 34;
            this.lblnom.Text = "Nombre";
            this.lblnom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblnom.UseWaitCursor = true;
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblcod.Location = new System.Drawing.Point(107, 89);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(69, 17);
            this.lblcod.TabIndex = 33;
            this.lblcod.Text = "CODIGO";
            this.lblcod.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, -338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 779);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // frmActualizaPreciocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(560, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.lblMargenNuevo);
            this.Controls.Add(this.tituloMargen1);
            this.Controls.Add(this.lblMargenAntiguo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrecioCosto);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdActualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPreicioCosto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tituloMargen2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActualizaPreciocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmActualizaPreciocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreicioCosto;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdActualizar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tituloMargen1;
        private System.Windows.Forms.Label lblMargenAntiguo;
        private System.Windows.Forms.Label tituloMargen2;
        private System.Windows.Forms.Label lblMargenNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}