namespace Prototipo1
{
    partial class frmFactura
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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.lblNumFact = new System.Windows.Forms.Label();
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
            this.txtnombrecontacto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblcostofact = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalesSinIva = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcomuna = new System.Windows.Forms.TextBox();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPalabras = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.mskRUT = new System.Windows.Forms.TextBox();
            this.txtPalabras2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblLetras = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lblletras3 = new System.Windows.Forms.Label();
            this.cmdverstock = new System.Windows.Forms.Button();
            this.dtpkMesAño = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lblinicial = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
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
            this.txtRazon.Location = new System.Drawing.Point(123, 47);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(187, 20);
            this.txtRazon.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(104, 133);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(204, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "RUT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOMBRE CONTACTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DIRECCIÓN:";
            // 
            // txtGiro
            // 
            this.txtGiro.Location = new System.Drawing.Point(64, 79);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(108, 20);
            this.txtGiro.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 12);
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
            this.dgvLista.Location = new System.Drawing.Point(32, 217);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(630, 241);
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
            this.grdPrecioVenta.HeaderText = "Precio de Venta";
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
            // lblNumFact
            // 
            this.lblNumFact.AutoSize = true;
            this.lblNumFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFact.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNumFact.Location = new System.Drawing.Point(162, 6);
            this.lblNumFact.Name = "lblNumFact";
            this.lblNumFact.Size = new System.Drawing.Size(21, 24);
            this.lblNumFact.TabIndex = 21;
            this.lblNumFact.Text = "1";
            // 
            // tipdoc
            // 
            this.tipdoc.AutoSize = true;
            this.tipdoc.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipdoc.Location = new System.Drawing.Point(25, 6);
            this.tipdoc.Name = "tipdoc";
            this.tipdoc.Size = new System.Drawing.Size(131, 23);
            this.tipdoc.TabIndex = 22;
            this.tipdoc.Text = "FACTURA N°";
            // 
            // txttotales
            // 
            this.txttotales.Enabled = false;
            this.txttotales.Location = new System.Drawing.Point(253, 491);
            this.txttotales.Name = "txttotales";
            this.txttotales.ReadOnly = true;
            this.txttotales.Size = new System.Drawing.Size(100, 20);
            this.txttotales.TabIndex = 23;
            // 
            // txtiva
            // 
            this.txtiva.Enabled = false;
            this.txtiva.Location = new System.Drawing.Point(148, 491);
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
            this.label7.Location = new System.Drawing.Point(499, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "TOTAL:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "IVA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "TOTALES:";
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Location = new System.Drawing.Point(61, 498);
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
            this.lblCantidad.Location = new System.Drawing.Point(130, 484);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblCantidad.TabIndex = 34;
            // 
            // gpbusquedacli
            // 
            this.gpbusquedacli.Controls.Add(this.dgvClientes);
            this.gpbusquedacli.Location = new System.Drawing.Point(692, 39);
            this.gpbusquedacli.Name = "gpbusquedacli";
            this.gpbusquedacli.Size = new System.Drawing.Size(595, 435);
            this.gpbusquedacli.TabIndex = 35;
            this.gpbusquedacli.TabStop = false;
            this.gpbusquedacli.Text = "Seleccionar Clientes";
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
            this.dgvClientes.Size = new System.Drawing.Size(563, 400);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentDoubleClick);
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
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 230;
            // 
            // grdApellidoP
            // 
            this.grdApellidoP.HeaderText = "Razon Social";
            this.grdApellidoP.Name = "grdApellidoP";
            this.grdApellidoP.ReadOnly = true;
            this.grdApellidoP.Width = 190;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(1155, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnombrecontacto
            // 
            this.txtnombrecontacto.Location = new System.Drawing.Point(145, 107);
            this.txtnombrecontacto.Name = "txtnombrecontacto";
            this.txtnombrecontacto.Size = new System.Drawing.Size(100, 20);
            this.txtnombrecontacto.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "RAZON SOCIAL:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd_MM_yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(348, 6);
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
            this.label6.Location = new System.Drawing.Point(29, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "DETALLE PRODUCTOS";
            // 
            // txtTotalesSinIva
            // 
            this.txtTotalesSinIva.Enabled = false;
            this.txtTotalesSinIva.Location = new System.Drawing.Point(41, 491);
            this.txtTotalesSinIva.Name = "txtTotalesSinIva";
            this.txtTotalesSinIva.ReadOnly = true;
            this.txtTotalesSinIva.Size = new System.Drawing.Size(100, 20);
            this.txtTotalesSinIva.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "TOTAL NETO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "GIRO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "COMUNA:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(410, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "CIUDAD:";
            // 
            // txtcomuna
            // 
            this.txtcomuna.Location = new System.Drawing.Point(304, 107);
            this.txtcomuna.Name = "txtcomuna";
            this.txtcomuna.Size = new System.Drawing.Size(100, 20);
            this.txtcomuna.TabIndex = 50;
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(461, 107);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(201, 20);
            this.txtciudad.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(332, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "VENDEDOR:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "NF:";
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(338, 133);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(324, 20);
            this.txtNF.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(384, 494);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Monto en Palabras :";
            // 
            // txtPalabras
            // 
            this.txtPalabras.Enabled = false;
            this.txtPalabras.Location = new System.Drawing.Point(544, 491);
            this.txtPalabras.MaxLength = 35;
            this.txtPalabras.Name = "txtPalabras";
            this.txtPalabras.Size = new System.Drawing.Size(269, 20);
            this.txtPalabras.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(479, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 58;
            this.label17.Text = "FECHA VCTO:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(403, 47);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 61;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(330, 50);
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
            "Razón Social",
            "Nombre"});
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
            this.mskRUT.Location = new System.Drawing.Point(210, 79);
            this.mskRUT.Name = "mskRUT";
            this.mskRUT.Size = new System.Drawing.Size(100, 20);
            this.mskRUT.TabIndex = 65;
            // 
            // txtPalabras2
            // 
            this.txtPalabras2.Enabled = false;
            this.txtPalabras2.Location = new System.Drawing.Point(544, 517);
            this.txtPalabras2.MaxLength = 35;
            this.txtPalabras2.Name = "txtPalabras2";
            this.txtPalabras2.Size = new System.Drawing.Size(269, 20);
            this.txtPalabras2.TabIndex = 66;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(497, 494);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 67;
            this.label20.Text = "Linea 1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(497, 517);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 13);
            this.label21.TabIndex = 68;
            this.label21.Text = "Linea 2";
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.CustomFormat = "dd_MM_yyyy";
            this.txtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtVencimiento.Location = new System.Drawing.Point(562, 5);
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(100, 20);
            this.txtVencimiento.TabIndex = 69;
            // 
            // lblLetras
            // 
            this.lblLetras.AutoSize = true;
            this.lblLetras.Location = new System.Drawing.Point(362, 556);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Size = new System.Drawing.Size(41, 13);
            this.lblLetras.TabIndex = 71;
            this.lblLetras.Text = "label22";
            this.lblLetras.Visible = false;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(403, 77);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtVendedor.TabIndex = 72;
            // 
            // lblletras3
            // 
            this.lblletras3.AutoSize = true;
            this.lblletras3.Location = new System.Drawing.Point(57, 555);
            this.lblletras3.Name = "lblletras3";
            this.lblletras3.Size = new System.Drawing.Size(41, 13);
            this.lblletras3.TabIndex = 73;
            this.lblletras3.Text = "letras 2";
            this.lblletras3.Visible = false;
            // 
            // cmdverstock
            // 
            this.cmdverstock.BackColor = System.Drawing.Color.Red;
            this.cmdverstock.Enabled = false;
            this.cmdverstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdverstock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmdverstock.Location = new System.Drawing.Point(42, 543);
            this.cmdverstock.Name = "cmdverstock";
            this.cmdverstock.Size = new System.Drawing.Size(376, 35);
            this.cmdverstock.TabIndex = 74;
            this.cmdverstock.Text = "VER STOCK FALTANTE";
            this.cmdverstock.UseVisualStyleBackColor = false;
            this.cmdverstock.Visible = false;
            this.cmdverstock.Click += new System.EventHandler(this.cmdverstock_Click);
            // 
            // dtpkMesAño
            // 
            this.dtpkMesAño.CustomFormat = "MM_yyyy";
            this.dtpkMesAño.Enabled = false;
            this.dtpkMesAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkMesAño.Location = new System.Drawing.Point(1223, 12);
            this.dtpkMesAño.Name = "dtpkMesAño";
            this.dtpkMesAño.Size = new System.Drawing.Size(64, 20);
            this.dtpkMesAño.TabIndex = 75;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1142, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 13);
            this.label22.TabIndex = 76;
            this.label22.Text = "Mes de venta:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(538, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 13);
            this.label23.TabIndex = 79;
            this.label23.Text = "TIPO DE PAGO";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EFECTIVO",
            "CHEQUE",
            "CREDITO"});
            this.comboBox1.Location = new System.Drawing.Point(541, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 80;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Items.AddRange(new object[] {
            "PAGADA",
            "SOLO EMITIDA",
            "PENDIENTE"});
            this.comboBox2.Location = new System.Drawing.Point(541, 159);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 81;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(278, 160);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(261, 16);
            this.label24.TabIndex = 82;
            this.label24.Text = "GUARDAR ESTADO DE FACTURA COMO:";
            // 
            // lblinicial
            // 
            this.lblinicial.AutoSize = true;
            this.lblinicial.Location = new System.Drawing.Point(698, 217);
            this.lblinicial.Name = "lblinicial";
            this.lblinicial.Size = new System.Drawing.Size(0, 13);
            this.lblinicial.TabIndex = 83;
            this.lblinicial.Visible = false;
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Location = new System.Drawing.Point(698, 245);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(0, 13);
            this.lblfinal.TabIndex = 84;
            this.lblfinal.Visible = false;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 622);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblinicial);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dtpkMesAño);
            this.Controls.Add(this.cmdverstock);
            this.Controls.Add(this.lblletras3);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.lblLetras);
            this.Controls.Add(this.txtVencimiento);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtPalabras2);
            this.Controls.Add(this.mskRUT);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPalabras);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtNF);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.txtcomuna);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotalesSinIva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblcostofact);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtnombrecontacto);
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
            this.Controls.Add(this.lblNumFact);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGiro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.cmdGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactura";
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
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lblNumFact;
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
        private System.Windows.Forms.TextBox txtnombrecontacto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblcostofact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalesSinIva;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcomuna;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPalabras;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox mskRUT;
        private System.Windows.Forms.TextBox txtPalabras2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker txtVencimiento;
        private System.Windows.Forms.Label lblLetras;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label lblletras3;
        private System.Windows.Forms.Button cmdverstock;
        private System.Windows.Forms.DateTimePicker dtpkMesAño;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblinicial;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdRut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdApellidoP;
    }
}