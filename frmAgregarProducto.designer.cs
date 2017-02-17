namespace Prototipo1
{
    partial class frmAgregarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarProducto));
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoInterno = new System.Windows.Forms.TextBox();
            this.txtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.txttipomedida = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblnumprod = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmargen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkhabilitareceta = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdañadirigrediente = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvingredientes = new System.Windows.Forms.DataGridView();
            this.iding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipomedidaing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.cbtipomedida = new System.Windows.Forms.ComboBox();
            this.txtcostoingrediente = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNombreIngrediente = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtcantigrediente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.chkautoiva = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTipoMedida = new System.Windows.Forms.Label();
            this.lblPrecioMasIva = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvingredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(24, 71);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(164, 20);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // txtCodigoInterno
            // 
            this.txtCodigoInterno.Enabled = false;
            this.txtCodigoInterno.Location = new System.Drawing.Point(194, 71);
            this.txtCodigoInterno.Name = "txtCodigoInterno";
            this.txtCodigoInterno.Size = new System.Drawing.Size(73, 20);
            this.txtCodigoInterno.TabIndex = 1;
            this.txtCodigoInterno.Text = "1";
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(276, 71);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(107, 20);
            this.txtCodigoDeBarras.TabIndex = 2;
            this.txtCodigoDeBarras.Text = "1";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(143, 111);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(98, 20);
            this.txtPrecioVenta.TabIndex = 6;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(34, 111);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(87, 20);
            this.txtPrecioCosto.TabIndex = 5;
            this.txtPrecioCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioCosto.TextChanged += new System.EventHandler(this.txtPrecioCosto_TextChanged);
            this.txtPrecioCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCosto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo Interno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codigo De Barras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Precio Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Precio Venta Neto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(20, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ingresar Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "$";
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(143, 535);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(104, 34);
            this.cmdAceptar.TabIndex = 17;
            this.cmdAceptar.Text = "Ingresar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(305, 535);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(103, 34);
            this.cmdCancelar.TabIndex = 18;
            this.cmdCancelar.Text = "Salir";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // txttipomedida
            // 
            this.txttipomedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttipomedida.FormattingEnabled = true;
            this.txttipomedida.Items.AddRange(new object[] {
            "Gr",
            "Kg",
            "Lt",
            "Un",
            "Hrs"});
            this.txttipomedida.Location = new System.Drawing.Point(397, 71);
            this.txttipomedida.Name = "txttipomedida";
            this.txttipomedida.Size = new System.Drawing.Size(133, 21);
            this.txttipomedida.TabIndex = 4;
            this.txttipomedida.SelectedIndexChanged += new System.EventHandler(this.txttipomedida_SelectedIndexChanged);
            this.txttipomedida.SelectedValueChanged += new System.EventHandler(this.txttipomedida_SelectedValueChanged);
            this.txttipomedida.TextChanged += new System.EventHandler(this.txttipomedida_TextChanged);
            this.txttipomedida.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttipomedida_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tipo de Medida";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(117, 511);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(100, 20);
            this.txtstock.TabIndex = 15;
            this.txtstock.Text = "0";
            this.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstock_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Stock:";
            // 
            // lblnumprod
            // 
            this.lblnumprod.AutoSize = true;
            this.lblnumprod.Location = new System.Drawing.Point(323, 125);
            this.lblnumprod.Name = "lblnumprod";
            this.lblnumprod.Size = new System.Drawing.Size(0, 13);
            this.lblnumprod.TabIndex = 27;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(326, 113);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Producto Pesable";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 514);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Margen de Utilidad :";
            // 
            // txtmargen
            // 
            this.txtmargen.Enabled = false;
            this.txtmargen.Location = new System.Drawing.Point(343, 511);
            this.txtmargen.MaxLength = 3;
            this.txtmargen.Name = "txtmargen";
            this.txtmargen.Size = new System.Drawing.Size(98, 20);
            this.txtmargen.TabIndex = 16;
            this.txtmargen.Text = "0";
            this.txtmargen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 514);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "%";
            // 
            // chkhabilitareceta
            // 
            this.chkhabilitareceta.AutoSize = true;
            this.chkhabilitareceta.Location = new System.Drawing.Point(442, 114);
            this.chkhabilitareceta.Name = "chkhabilitareceta";
            this.chkhabilitareceta.Size = new System.Drawing.Size(87, 17);
            this.chkhabilitareceta.TabIndex = 8;
            this.chkhabilitareceta.Text = "Receta base";
            this.chkhabilitareceta.UseVisualStyleBackColor = true;
            this.chkhabilitareceta.CheckedChanged += new System.EventHandler(this.chkhabilitareceta_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmdañadirigrediente);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dgvingredientes);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbtipomedida);
            this.groupBox1.Controls.Add(this.txtcostoingrediente);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtNombreIngrediente);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtcantigrediente);
            this.groupBox1.Location = new System.Drawing.Point(24, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 290);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receta del producto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 22);
            this.button1.TabIndex = 14;
            this.button1.Text = "Eliminar Seleccion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdañadirigrediente
            // 
            this.cmdañadirigrediente.Location = new System.Drawing.Point(395, 77);
            this.cmdañadirigrediente.Name = "cmdañadirigrediente";
            this.cmdañadirigrediente.Size = new System.Drawing.Size(104, 22);
            this.cmdañadirigrediente.TabIndex = 13;
            this.cmdañadirigrediente.Text = "Añadir";
            this.cmdañadirigrediente.UseVisualStyleBackColor = true;
            this.cmdañadirigrediente.Click += new System.EventHandler(this.cmdañadirigrediente_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "LISTA INGREDIENTES";
            // 
            // dgvingredientes
            // 
            this.dgvingredientes.AllowUserToAddRows = false;
            this.dgvingredientes.AllowUserToDeleteRows = false;
            this.dgvingredientes.AllowUserToResizeColumns = false;
            this.dgvingredientes.AllowUserToResizeRows = false;
            this.dgvingredientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvingredientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvingredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvingredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iding,
            this.nombreing,
            this.costoing,
            this.cantidading,
            this.tipomedidaing});
            this.dgvingredientes.Location = new System.Drawing.Point(20, 118);
            this.dgvingredientes.Name = "dgvingredientes";
            this.dgvingredientes.ReadOnly = true;
            this.dgvingredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvingredientes.Size = new System.Drawing.Size(466, 138);
            this.dgvingredientes.TabIndex = 49;
            // 
            // iding
            // 
            this.iding.HeaderText = "ID INGREDIENTE";
            this.iding.Name = "iding";
            this.iding.ReadOnly = true;
            this.iding.Width = 80;
            // 
            // nombreing
            // 
            this.nombreing.HeaderText = "NOMBRE INGREDIENTE";
            this.nombreing.Name = "nombreing";
            this.nombreing.ReadOnly = true;
            this.nombreing.Width = 80;
            // 
            // costoing
            // 
            this.costoing.HeaderText = "COSTO INGREDIENTE";
            this.costoing.Name = "costoing";
            this.costoing.ReadOnly = true;
            // 
            // cantidading
            // 
            this.cantidading.HeaderText = "CANTIDAD INGREDIENTE";
            this.cantidading.Name = "cantidading";
            this.cantidading.ReadOnly = true;
            this.cantidading.Width = 80;
            // 
            // tipomedidaing
            // 
            this.tipomedidaing.HeaderText = "MEDIDA";
            this.tipomedidaing.Name = "tipomedidaing";
            this.tipomedidaing.ReadOnly = true;
            this.tipomedidaing.Width = 80;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(248, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 48;
            this.label17.Text = "Tipo de Medida";
            // 
            // cbtipomedida
            // 
            this.cbtipomedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipomedida.FormattingEnabled = true;
            this.cbtipomedida.Items.AddRange(new object[] {
            "Gr",
            "Kg",
            "Lt",
            "Un",
            "Hrs"});
            this.cbtipomedida.Location = new System.Drawing.Point(251, 78);
            this.cbtipomedida.Name = "cbtipomedida";
            this.cbtipomedida.Size = new System.Drawing.Size(133, 21);
            this.cbtipomedida.TabIndex = 12;
            // 
            // txtcostoingrediente
            // 
            this.txtcostoingrediente.Location = new System.Drawing.Point(16, 79);
            this.txtcostoingrediente.Name = "txtcostoingrediente";
            this.txtcostoingrediente.Size = new System.Drawing.Size(120, 20);
            this.txtcostoingrediente.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Nombre Ingrediente";
            // 
            // txtNombreIngrediente
            // 
            this.txtNombreIngrediente.Location = new System.Drawing.Point(16, 39);
            this.txtNombreIngrediente.Name = "txtNombreIngrediente";
            this.txtNombreIngrediente.Size = new System.Drawing.Size(483, 20);
            this.txtNombreIngrediente.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "Precio Costo Ingrediente";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(149, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Cantidad";
            // 
            // txtcantigrediente
            // 
            this.txtcantigrediente.Location = new System.Drawing.Point(152, 79);
            this.txtcantigrediente.Name = "txtcantigrediente";
            this.txtcantigrediente.Size = new System.Drawing.Size(93, 20);
            this.txtcantigrediente.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Descripción del Producto";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(23, 189);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(506, 20);
            this.txtDescripcionProducto.TabIndex = 43;
            // 
            // chkautoiva
            // 
            this.chkautoiva.AutoSize = true;
            this.chkautoiva.Location = new System.Drawing.Point(247, 113);
            this.chkautoiva.Name = "chkautoiva";
            this.chkautoiva.Size = new System.Drawing.Size(75, 17);
            this.chkautoiva.TabIndex = 44;
            this.chkautoiva.Text = "+ IVA 19%";
            this.chkautoiva.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "VENTA NETO + IVA / *  ";
            // 
            // lblTipoMedida
            // 
            this.lblTipoMedida.AutoSize = true;
            this.lblTipoMedida.Location = new System.Drawing.Point(140, 143);
            this.lblTipoMedida.Name = "lblTipoMedida";
            this.lblTipoMedida.Size = new System.Drawing.Size(10, 13);
            this.lblTipoMedida.TabIndex = 46;
            this.lblTipoMedida.Text = "-";
            // 
            // lblPrecioMasIva
            // 
            this.lblPrecioMasIva.AutoSize = true;
            this.lblPrecioMasIva.Location = new System.Drawing.Point(156, 143);
            this.lblPrecioMasIva.Name = "lblPrecioMasIva";
            this.lblPrecioMasIva.Size = new System.Drawing.Size(22, 13);
            this.lblPrecioMasIva.TabIndex = 47;
            this.lblPrecioMasIva.Text = "= $";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 588);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // frmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(558, 581);
            this.Controls.Add(this.lblPrecioMasIva);
            this.Controls.Add(this.lblTipoMedida);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.chkautoiva);
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkhabilitareceta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtmargen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblnumprod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttipomedida);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecioCosto);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtCodigoDeBarras);
            this.Controls.Add(this.txtCodigoInterno);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Productos";
            this.Load += new System.EventHandler(this.frmAgregarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvingredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoInterno;
        private System.Windows.Forms.TextBox txtCodigoDeBarras;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.ComboBox txttipomedida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblnumprod;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmargen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkhabilitareceta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdañadirigrediente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbtipomedida;
        private System.Windows.Forms.TextBox txtcostoingrediente;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNombreIngrediente;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtcantigrediente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvingredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn iding;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreing;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidading;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipomedidaing;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.CheckBox chkautoiva;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTipoMedida;
        private System.Windows.Forms.Label lblPrecioMasIva;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}