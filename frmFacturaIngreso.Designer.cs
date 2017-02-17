namespace Prototipo1
{
    partial class frmFacturaIngreso
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
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.tipdoc = new System.Windows.Forms.Label();
            this.txttotales = new System.Windows.Forms.TextBox();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.txtsubtotales = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.gpbusquedacli = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.grdRut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblcostofact = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalesSinIva = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.mskRUT = new System.Windows.Forms.TextBox();
            this.txtVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpkMesAño = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.txtnfact = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblglosa = new System.Windows.Forms.Label();
            this.Ndoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gpbusquedacli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(502, 543);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(109, 39);
            this.cmdGuardar.TabIndex = 0;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(124, 82);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(373, 20);
            this.txtRazon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "RUT:";
            // 
            // txtGiro
            // 
            this.txtGiro.Location = new System.Drawing.Point(68, 128);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(108, 20);
            this.txtGiro.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "FECHA EMISIÓN:";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.grdNombre,
            this.grdPrecioVenta,
            this.grdPrecioCosto,
            this.grdCantidad,
            this.total});
            this.dgvLista.Location = new System.Drawing.Point(32, 181);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(630, 277);
            this.dgvLista.TabIndex = 16;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // grdNombre
            // 
            this.grdNombre.HeaderText = "Nombre";
            this.grdNombre.Name = "grdNombre";
            this.grdNombre.ReadOnly = true;
            // 
            // grdPrecioVenta
            // 
            this.grdPrecioVenta.HeaderText = "Precio Costo";
            this.grdPrecioVenta.Name = "grdPrecioVenta";
            this.grdPrecioVenta.ReadOnly = true;
            // 
            // grdPrecioCosto
            // 
            this.grdPrecioCosto.HeaderText = "Precio de Costo";
            this.grdPrecioCosto.Name = "grdPrecioCosto";
            this.grdPrecioCosto.ReadOnly = true;
            this.grdPrecioCosto.Visible = false;
            // 
            // grdCantidad
            // 
            this.grdCantidad.HeaderText = "Cantidad";
            this.grdCantidad.Name = "grdCantidad";
            this.grdCantidad.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(652, 543);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(109, 39);
            this.cmdSalir.TabIndex = 17;
            this.cmdSalir.Text = "Cerrar";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // tipdoc
            // 
            this.tipdoc.AutoSize = true;
            this.tipdoc.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.tipdoc.Location = new System.Drawing.Point(36, 36);
            this.tipdoc.Name = "tipdoc";
            this.tipdoc.Size = new System.Drawing.Size(102, 17);
            this.tipdoc.TabIndex = 22;
            this.tipdoc.Text = "FACTURA N°:";
            // 
            // txttotales
            // 
            this.txttotales.Enabled = false;
            this.txttotales.Location = new System.Drawing.Point(259, 498);
            this.txttotales.Name = "txttotales";
            this.txttotales.ReadOnly = true;
            this.txttotales.Size = new System.Drawing.Size(100, 20);
            this.txttotales.TabIndex = 23;
            // 
            // txtiva
            // 
            this.txtiva.Enabled = false;
            this.txtiva.Location = new System.Drawing.Point(154, 498);
            this.txtiva.Name = "txtiva";
            this.txtiva.ReadOnly = true;
            this.txtiva.Size = new System.Drawing.Size(100, 20);
            this.txtiva.TabIndex = 24;
            // 
            // txtsubtotales
            // 
            this.txtsubtotales.Enabled = false;
            this.txtsubtotales.Location = new System.Drawing.Point(544, 458);
            this.txtsubtotales.Name = "txtsubtotales";
            this.txtsubtotales.ReadOnly = true;
            this.txtsubtotales.Size = new System.Drawing.Size(118, 20);
            this.txtsubtotales.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "SUB TOTAL:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "IVA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "TOTALES:";
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Location = new System.Drawing.Point(67, 505);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(0, 13);
            this.lblNombreProd.TabIndex = 31;
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Location = new System.Drawing.Point(167, 461);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(0, 13);
            this.lblPrecioCosto.TabIndex = 32;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(90, 532);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(0, 13);
            this.lblPrecioVenta.TabIndex = 33;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(136, 491);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblCantidad.TabIndex = 34;
            // 
            // gpbusquedacli
            // 
            this.gpbusquedacli.Controls.Add(this.dgvClientes);
            this.gpbusquedacli.Location = new System.Drawing.Point(668, 33);
            this.gpbusquedacli.Name = "gpbusquedacli";
            this.gpbusquedacli.Size = new System.Drawing.Size(515, 485);
            this.gpbusquedacli.TabIndex = 35;
            this.gpbusquedacli.TabStop = false;
            this.gpbusquedacli.Text = "Seleccionar Proveedores";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdRut,
            this.dataGridViewTextBoxColumn1,
            this.grdApellidoP});
            this.dgvClientes.Location = new System.Drawing.Point(17, 19);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(482, 406);
            this.dgvClientes.TabIndex = 1;
            // 
            // grdRut
            // 
            this.grdRut.HeaderText = "RUT";
            this.grdRut.Name = "grdRut";
            this.grdRut.ReadOnly = true;
            this.grdRut.Width = 130;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Giro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // grdApellidoP
            // 
            this.grdApellidoP.HeaderText = "Razon Social";
            this.grdApellidoP.Name = "grdApellidoP";
            this.grdApellidoP.ReadOnly = true;
            this.grdApellidoP.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "RAZON SOCIAL:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd_MM_yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // lblcostofact
            // 
            this.lblcostofact.AutoSize = true;
            this.lblcostofact.Location = new System.Drawing.Point(64, 627);
            this.lblcostofact.Name = "lblcostofact";
            this.lblcostofact.Size = new System.Drawing.Size(41, 13);
            this.lblcostofact.TabIndex = 41;
            this.lblcostofact.Text = "label12";
            this.lblcostofact.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "DETALLE PRODUCTOS";
            // 
            // txtTotalesSinIva
            // 
            this.txtTotalesSinIva.Enabled = false;
            this.txtTotalesSinIva.Location = new System.Drawing.Point(47, 498);
            this.txtTotalesSinIva.Name = "txtTotalesSinIva";
            this.txtTotalesSinIva.ReadOnly = true;
            this.txtTotalesSinIva.Size = new System.Drawing.Size(100, 20);
            this.txtTotalesSinIva.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 482);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "TOTAL NETO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "GIRO:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(314, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 58;
            this.label17.Text = "FECHA VCTO:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(397, 128);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(116, 20);
            this.txtTelefono.TabIndex = 61;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(324, 131);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 60;
            this.label18.Text = "TELEFONO:";
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "RUT",
            "Razón Social"});
            this.cboBuscar.Location = new System.Drawing.Point(996, 12);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(121, 21);
            this.cboBuscar.TabIndex = 63;
            this.cboBuscar.SelectedIndexChanged += new System.EventHandler(this.cboBuscar_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(858, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 62;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(799, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 64;
            this.label19.Text = "Buscar:";
            // 
            // mskRUT
            // 
            this.mskRUT.Location = new System.Drawing.Point(214, 130);
            this.mskRUT.Name = "mskRUT";
            this.mskRUT.Size = new System.Drawing.Size(100, 20);
            this.mskRUT.TabIndex = 65;
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.CustomFormat = "dd_MM_yyyy";
            this.txtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtVencimiento.Location = new System.Drawing.Point(397, 60);
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(100, 20);
            this.txtVencimiento.TabIndex = 69;
            // 
            // dtpkMesAño
            // 
            this.dtpkMesAño.CustomFormat = "MM_yyyy";
            this.dtpkMesAño.Enabled = false;
            this.dtpkMesAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkMesAño.Location = new System.Drawing.Point(433, 33);
            this.dtpkMesAño.Name = "dtpkMesAño";
            this.dtpkMesAño.Size = new System.Drawing.Size(64, 20);
            this.dtpkMesAño.TabIndex = 75;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(343, 36);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 76;
            this.label22.Text = "Mes de Compra:";
            // 
            // txtnfact
            // 
            this.txtnfact.Location = new System.Drawing.Point(139, 33);
            this.txtnfact.Name = "txtnfact";
            this.txtnfact.Size = new System.Drawing.Size(162, 20);
            this.txtnfact.TabIndex = 77;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Items.AddRange(new object[] {
            "PAGADA EFECTIVO",
            "PAGADA CHEQUERA"});
            this.comboBox2.Location = new System.Drawing.Point(523, 130);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 82;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "MODO DE PAGO";
            // 
            // lblglosa
            // 
            this.lblglosa.AutoSize = true;
            this.lblglosa.Location = new System.Drawing.Point(377, 158);
            this.lblglosa.Name = "lblglosa";
            this.lblglosa.Size = new System.Drawing.Size(136, 13);
            this.lblglosa.TabIndex = 84;
            this.lblglosa.Text = "N° De Glosa o Documento:";
            // 
            // Ndoc
            // 
            this.Ndoc.Location = new System.Drawing.Point(523, 155);
            this.Ndoc.Name = "Ndoc";
            this.Ndoc.Size = new System.Drawing.Size(116, 20);
            this.Ndoc.TabIndex = 85;
            // 
            // frmFacturaIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 622);
            this.Controls.Add(this.Ndoc);
            this.Controls.Add(this.lblglosa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtnfact);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dtpkMesAño);
            this.Controls.Add(this.txtVencimiento);
            this.Controls.Add(this.mskRUT);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotalesSinIva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblcostofact);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gpbusquedacli);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.lblPrecioCosto);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsubtotales);
            this.Controls.Add(this.txtiva);
            this.Controls.Add(this.txttotales);
            this.Controls.Add(this.tipdoc);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.cmdGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturaIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero de Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gpbusquedacli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label tipdoc;
        private System.Windows.Forms.TextBox txttotales;
        private System.Windows.Forms.TextBox txtiva;
        private System.Windows.Forms.TextBox txtsubtotales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.GroupBox gpbusquedacli;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblcostofact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalesSinIva;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox mskRUT;
        private System.Windows.Forms.DateTimePicker txtVencimiento;
        private System.Windows.Forms.DateTimePicker dtpkMesAño;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdRut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdApellidoP;
        private System.Windows.Forms.TextBox txtnfact;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblglosa;
        private System.Windows.Forms.TextBox Ndoc;
    }
}