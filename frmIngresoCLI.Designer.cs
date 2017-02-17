namespace Prototipo1
{
    partial class frmIngresoCLI
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskRUT = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrazonsocial = new System.Windows.Forms.TextBox();
            this.txtgiro = new System.Windows.Forms.TextBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdVerificar = new System.Windows.Forms.Button();
            this.txtcomuna = new System.Windows.Forms.TextBox();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.grdRUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdRazon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdGiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.smdSeleccionar = new System.Windows.Forms.Button();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO DE CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(119, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Contacto";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNombre.Location = new System.Drawing.Point(306, 380);
            this.txtNombre.MaxLength = 255;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(369, 29);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "RUT";
            // 
            // mskRUT
            // 
            this.mskRUT.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskRUT.Location = new System.Drawing.Point(182, 33);
            this.mskRUT.Mask = "########A";
            this.mskRUT.Name = "mskRUT";
            this.mskRUT.Size = new System.Drawing.Size(210, 40);
            this.mskRUT.TabIndex = 1;
            this.mskRUT.TextChanged += new System.EventHandler(this.mskRUT_TextChanged);
            this.mskRUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskRUT_KeyPress);
            this.mskRUT.Leave += new System.EventHandler(this.mskRUT_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(119, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDireccion.Location = new System.Drawing.Point(306, 426);
            this.txtDireccion.MaxLength = 255;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(369, 29);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(119, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtTelefono.Location = new System.Drawing.Point(306, 466);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(196, 29);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(119, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Razon Social";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(119, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giro";
            // 
            // txtrazonsocial
            // 
            this.txtrazonsocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtrazonsocial.Location = new System.Drawing.Point(306, 285);
            this.txtrazonsocial.MaxLength = 255;
            this.txtrazonsocial.Name = "txtrazonsocial";
            this.txtrazonsocial.Size = new System.Drawing.Size(369, 29);
            this.txtrazonsocial.TabIndex = 2;
            this.txtrazonsocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoP_KeyPress);
            // 
            // txtgiro
            // 
            this.txtgiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtgiro.Location = new System.Drawing.Point(306, 332);
            this.txtgiro.MaxLength = 255;
            this.txtgiro.Name = "txtgiro";
            this.txtgiro.Size = new System.Drawing.Size(196, 29);
            this.txtgiro.TabIndex = 3;
            this.txtgiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoM_KeyPress);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(272, 644);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(121, 50);
            this.cmdSalir.TabIndex = 16;
            this.cmdSalir.Text = "Cerrar";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(865, 504);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(89, 50);
            this.cmdModificar.TabIndex = 13;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(969, 504);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(91, 50);
            this.cmdEliminar.TabIndex = 14;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(865, 433);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(195, 53);
            this.cmdGuardar.TabIndex = 12;
            this.cmdGuardar.Text = "GUARDAR";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdVerificar);
            this.panel1.Controls.Add(this.mskRUT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(123, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 91);
            this.panel1.TabIndex = 1;
            // 
            // cmdVerificar
            // 
            this.cmdVerificar.Location = new System.Drawing.Point(420, 33);
            this.cmdVerificar.Name = "cmdVerificar";
            this.cmdVerificar.Size = new System.Drawing.Size(131, 40);
            this.cmdVerificar.TabIndex = 1;
            this.cmdVerificar.Text = "Verificar";
            this.cmdVerificar.UseVisualStyleBackColor = true;
            this.cmdVerificar.Click += new System.EventHandler(this.cmdVerificar_Click);
            // 
            // txtcomuna
            // 
            this.txtcomuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtcomuna.Location = new System.Drawing.Point(306, 512);
            this.txtcomuna.MaxLength = 255;
            this.txtcomuna.Name = "txtcomuna";
            this.txtcomuna.Size = new System.Drawing.Size(196, 29);
            this.txtcomuna.TabIndex = 9;
            // 
            // txtciudad
            // 
            this.txtciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtciudad.Location = new System.Drawing.Point(609, 513);
            this.txtciudad.MaxLength = 255;
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(196, 29);
            this.txtciudad.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.Location = new System.Drawing.Point(119, 518);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Comuna";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label9.Location = new System.Drawing.Point(511, 518);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ciudad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label10.Location = new System.Drawing.Point(508, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Vendedor";
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(865, 567);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(195, 29);
            this.cmdLimpiar.TabIndex = 15;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label11.Location = new System.Drawing.Point(119, 562);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "Nombre de Fantasía";
            // 
            // txtNF
            // 
            this.txtNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNF.Location = new System.Drawing.Point(306, 559);
            this.txtNF.MaxLength = 255;
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(369, 29);
            this.txtNF.TabIndex = 11;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdRUT,
            this.grdRazon,
            this.grdNombre,
            this.grdGiro});
            this.dgvLista.Location = new System.Drawing.Point(767, 113);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.ShowEditingIcon = false;
            this.dgvLista.Size = new System.Drawing.Size(403, 223);
            this.dgvLista.TabIndex = 28;
            // 
            // grdRUT
            // 
            this.grdRUT.Frozen = true;
            this.grdRUT.HeaderText = "RUT";
            this.grdRUT.Name = "grdRUT";
            this.grdRUT.ReadOnly = true;
            this.grdRUT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // grdRazon
            // 
            this.grdRazon.Frozen = true;
            this.grdRazon.HeaderText = "Razón Social";
            this.grdRazon.Name = "grdRazon";
            this.grdRazon.ReadOnly = true;
            this.grdRazon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // grdNombre
            // 
            this.grdNombre.Frozen = true;
            this.grdNombre.HeaderText = "Nombre";
            this.grdNombre.Name = "grdNombre";
            this.grdNombre.ReadOnly = true;
            this.grdNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // grdGiro
            // 
            this.grdGiro.Frozen = true;
            this.grdGiro.HeaderText = "Giro";
            this.grdGiro.Name = "grdGiro";
            this.grdGiro.ReadOnly = true;
            this.grdGiro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(813, 87);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 29;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(764, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Buscar:";
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "RUT",
            "Razón Social",
            "Nombre",
            "Giro"});
            this.cboBuscar.Location = new System.Drawing.Point(1008, 87);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(121, 21);
            this.cboBuscar.TabIndex = 31;
            this.cboBuscar.SelectedIndexChanged += new System.EventHandler(this.cboBuscar_SelectedIndexChanged);
            // 
            // smdSeleccionar
            // 
            this.smdSeleccionar.Location = new System.Drawing.Point(767, 342);
            this.smdSeleccionar.Name = "smdSeleccionar";
            this.smdSeleccionar.Size = new System.Drawing.Size(403, 23);
            this.smdSeleccionar.TabIndex = 32;
            this.smdSeleccionar.Text = "SELECCIONAR";
            this.smdSeleccionar.UseVisualStyleBackColor = true;
            this.smdSeleccionar.Click += new System.EventHandler(this.smdSeleccionar_Click);
            // 
            // cboVendedor
            // 
            this.cboVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(611, 472);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(196, 24);
            this.cboVendedor.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label13.Location = new System.Drawing.Point(513, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 24);
            this.label13.TabIndex = 35;
            this.label13.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtSaldo.Location = new System.Drawing.Point(609, 332);
            this.txtSaldo.MaxLength = 255;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(124, 29);
            this.txtSaldo.TabIndex = 4;
            // 
            // frmIngresoCLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1287, 706);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.cboVendedor);
            this.Controls.Add(this.smdSeleccionar);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNF);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.txtcomuna);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.txtgiro);
            this.Controls.Add(this.txtrazonsocial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngresoCLI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresoCLI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIngresoCLI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskRUT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrazonsocial;
        private System.Windows.Forms.TextBox txtgiro;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcomuna;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdVerificar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdRUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdRazon;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdGiro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Button smdSeleccionar;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSaldo;
    }
}