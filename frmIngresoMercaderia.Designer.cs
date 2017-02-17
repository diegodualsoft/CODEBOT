namespace Prototipo1
{
    partial class frmIngresoMercaderia
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
            this.txtNDoc = new System.Windows.Forms.TextBox();
            this.grupDocumentos = new System.Windows.Forms.GroupBox();
            this.txtGiro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtFactura = new System.Windows.Forms.RadioButton();
            this.rbtGuia = new System.Windows.Forms.RadioButton();
            this.gpbProductos = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImpCarn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsubtotales = new System.Windows.Forms.TextBox();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.txttotales = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gpbusquedacli = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.grdRut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtGuiatraspaso = new System.Windows.Forms.RadioButton();
            this.gruptraspasos = new System.Windows.Forms.GroupBox();
            this.dtpfecha2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNtraspaso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupDocumentos.SuspendLayout();
            this.gpbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gpbusquedacli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gruptraspasos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO DE MERCADERIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° Documento";
            // 
            // txtNDoc
            // 
            this.txtNDoc.Location = new System.Drawing.Point(93, 15);
            this.txtNDoc.Name = "txtNDoc";
            this.txtNDoc.Size = new System.Drawing.Size(98, 20);
            this.txtNDoc.TabIndex = 3;
            // 
            // grupDocumentos
            // 
            this.grupDocumentos.Controls.Add(this.gruptraspasos);
            this.grupDocumentos.Controls.Add(this.txtGiro);
            this.grupDocumentos.Controls.Add(this.label6);
            this.grupDocumentos.Controls.Add(this.txtRut);
            this.grupDocumentos.Controls.Add(this.label5);
            this.grupDocumentos.Controls.Add(this.dtpfecha);
            this.grupDocumentos.Controls.Add(this.label4);
            this.grupDocumentos.Controls.Add(this.txtProveedor);
            this.grupDocumentos.Controls.Add(this.label3);
            this.grupDocumentos.Controls.Add(this.label2);
            this.grupDocumentos.Controls.Add(this.txtNDoc);
            this.grupDocumentos.Location = new System.Drawing.Point(21, 74);
            this.grupDocumentos.Name = "grupDocumentos";
            this.grupDocumentos.Size = new System.Drawing.Size(509, 129);
            this.grupDocumentos.TabIndex = 4;
            this.grupDocumentos.TabStop = false;
            this.grupDocumentos.Text = "Datos del Documento";
            this.grupDocumentos.Visible = false;
            // 
            // txtGiro
            // 
            this.txtGiro.Location = new System.Drawing.Point(215, 93);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(262, 20);
            this.txtGiro.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giro";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(67, 93);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(110, 20);
            this.txtRut.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "R.U.T";
            // 
            // dtpfecha
            // 
            this.dtpfecha.CustomFormat = "yyyy-MM-dd";
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(67, 41);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(125, 20);
            this.dtpfecha.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(67, 67);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(410, 20);
            this.txtProveedor.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Proveedor";
            // 
            // rbtFactura
            // 
            this.rbtFactura.AutoSize = true;
            this.rbtFactura.Location = new System.Drawing.Point(449, 51);
            this.rbtFactura.Name = "rbtFactura";
            this.rbtFactura.Size = new System.Drawing.Size(61, 17);
            this.rbtFactura.TabIndex = 5;
            this.rbtFactura.TabStop = true;
            this.rbtFactura.Text = "Factura";
            this.rbtFactura.UseVisualStyleBackColor = true;
            this.rbtFactura.CheckedChanged += new System.EventHandler(this.rbtFactura_CheckedChanged);
            // 
            // rbtGuia
            // 
            this.rbtGuia.AutoSize = true;
            this.rbtGuia.Location = new System.Drawing.Point(349, 51);
            this.rbtGuia.Name = "rbtGuia";
            this.rbtGuia.Size = new System.Drawing.Size(86, 17);
            this.rbtGuia.TabIndex = 4;
            this.rbtGuia.TabStop = true;
            this.rbtGuia.Text = "Guia Externa";
            this.rbtGuia.UseVisualStyleBackColor = true;
            this.rbtGuia.CheckedChanged += new System.EventHandler(this.rbtGuia_CheckedChanged);
            // 
            // gpbProductos
            // 
            this.gpbProductos.Controls.Add(this.label7);
            this.gpbProductos.Controls.Add(this.txtImpCarn);
            this.gpbProductos.Controls.Add(this.label9);
            this.gpbProductos.Controls.Add(this.label8);
            this.gpbProductos.Controls.Add(this.label10);
            this.gpbProductos.Controls.Add(this.txtsubtotales);
            this.gpbProductos.Controls.Add(this.txtiva);
            this.gpbProductos.Controls.Add(this.txttotales);
            this.gpbProductos.Controls.Add(this.dgvLista);
            this.gpbProductos.Location = new System.Drawing.Point(21, 207);
            this.gpbProductos.Name = "gpbProductos";
            this.gpbProductos.Size = new System.Drawing.Size(509, 393);
            this.gpbProductos.TabIndex = 5;
            this.gpbProductos.TabStop = false;
            this.gpbProductos.Text = "Datos de los Productos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "IMP CARN:";
            // 
            // txtImpCarn
            // 
            this.txtImpCarn.Enabled = false;
            this.txtImpCarn.Location = new System.Drawing.Point(371, 295);
            this.txtImpCarn.Name = "txtImpCarn";
            this.txtImpCarn.ReadOnly = true;
            this.txtImpCarn.Size = new System.Drawing.Size(118, 20);
            this.txtImpCarn.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "TOTALES:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "IVA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "SUB TOTAL:";
            // 
            // txtsubtotales
            // 
            this.txtsubtotales.Enabled = false;
            this.txtsubtotales.Location = new System.Drawing.Point(371, 271);
            this.txtsubtotales.Name = "txtsubtotales";
            this.txtsubtotales.ReadOnly = true;
            this.txtsubtotales.Size = new System.Drawing.Size(118, 20);
            this.txtsubtotales.TabIndex = 50;
            // 
            // txtiva
            // 
            this.txtiva.Enabled = false;
            this.txtiva.Location = new System.Drawing.Point(371, 321);
            this.txtiva.Name = "txtiva";
            this.txtiva.ReadOnly = true;
            this.txtiva.Size = new System.Drawing.Size(118, 20);
            this.txtiva.TabIndex = 49;
            // 
            // txttotales
            // 
            this.txttotales.Enabled = false;
            this.txttotales.Location = new System.Drawing.Point(371, 347);
            this.txttotales.Name = "txttotales";
            this.txttotales.ReadOnly = true;
            this.txttotales.Size = new System.Drawing.Size(118, 20);
            this.txttotales.TabIndex = 48;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.PrecioVenta,
            this.PrecioCosto,
            this.Cantidad,
            this.total});
            this.dgvLista.Location = new System.Drawing.Point(14, 16);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(481, 249);
            this.dgvLista.TabIndex = 47;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(698, 613);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 29);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(553, 613);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 68;
            this.label19.Text = "Buscar:";
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "RUT",
            "Razón Social"});
            this.cboBuscar.Location = new System.Drawing.Point(211, 27);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(121, 21);
            this.cboBuscar.TabIndex = 67;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(73, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(132, 20);
            this.txtBuscar.TabIndex = 66;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // gpbusquedacli
            // 
            this.gpbusquedacli.Controls.Add(this.label11);
            this.gpbusquedacli.Controls.Add(this.label19);
            this.gpbusquedacli.Controls.Add(this.cboBuscar);
            this.gpbusquedacli.Controls.Add(this.dgvClientes);
            this.gpbusquedacli.Controls.Add(this.txtBuscar);
            this.gpbusquedacli.Location = new System.Drawing.Point(536, 47);
            this.gpbusquedacli.Name = "gpbusquedacli";
            this.gpbusquedacli.Size = new System.Drawing.Size(515, 553);
            this.gpbusquedacli.TabIndex = 65;
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
            this.dgvClientes.Location = new System.Drawing.Point(17, 59);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(482, 451);
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
            // rbtGuiatraspaso
            // 
            this.rbtGuiatraspaso.AutoSize = true;
            this.rbtGuiatraspaso.Location = new System.Drawing.Point(249, 51);
            this.rbtGuiatraspaso.Name = "rbtGuiatraspaso";
            this.rbtGuiatraspaso.Size = new System.Drawing.Size(94, 17);
            this.rbtGuiatraspaso.TabIndex = 66;
            this.rbtGuiatraspaso.TabStop = true;
            this.rbtGuiatraspaso.Text = "Guia Traspaso";
            this.rbtGuiatraspaso.UseVisualStyleBackColor = true;
            this.rbtGuiatraspaso.CheckedChanged += new System.EventHandler(this.rbtGuiatraspaso_CheckedChanged);
            // 
            // gruptraspasos
            // 
            this.gruptraspasos.Controls.Add(this.dtpfecha2);
            this.gruptraspasos.Controls.Add(this.label13);
            this.gruptraspasos.Controls.Add(this.txtDesde);
            this.gruptraspasos.Controls.Add(this.label14);
            this.gruptraspasos.Controls.Add(this.label15);
            this.gruptraspasos.Controls.Add(this.txtNtraspaso);
            this.gruptraspasos.Location = new System.Drawing.Point(0, 1);
            this.gruptraspasos.Name = "gruptraspasos";
            this.gruptraspasos.Size = new System.Drawing.Size(509, 129);
            this.gruptraspasos.TabIndex = 15;
            this.gruptraspasos.TabStop = false;
            this.gruptraspasos.Text = "Datos Traspaso";
            // 
            // dtpfecha2
            // 
            this.dtpfecha2.CustomFormat = "yyyy-MM-dd";
            this.dtpfecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha2.Location = new System.Drawing.Point(271, 19);
            this.dtpfecha2.Name = "dtpfecha2";
            this.dtpfecha2.Size = new System.Drawing.Size(125, 20);
            this.dtpfecha2.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Fecha Traspaso";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(79, 45);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(317, 20);
            this.txtDesde.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Desde";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "N°Traspaso";
            // 
            // txtNtraspaso
            // 
            this.txtNtraspaso.Location = new System.Drawing.Point(79, 19);
            this.txtNtraspaso.Name = "txtNtraspaso";
            this.txtNtraspaso.Size = new System.Drawing.Size(98, 20);
            this.txtNtraspaso.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(421, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "*PRESIONE (DOBLE CLICK) SOBRE EL CLIENTE PARA PASAR DATOS A INGRESO";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Costo";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // PrecioCosto
            // 
            this.PrecioCosto.HeaderText = "Precio de Costo";
            this.PrecioCosto.Name = "PrecioCosto";
            this.PrecioCosto.ReadOnly = true;
            this.PrecioCosto.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // frmIngresoMercaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 663);
            this.Controls.Add(this.rbtGuiatraspaso);
            this.Controls.Add(this.gpbProductos);
            this.Controls.Add(this.gpbusquedacli);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grupDocumentos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtGuia);
            this.Controls.Add(this.rbtFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngresoMercaderia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresoProducto";
            this.Load += new System.EventHandler(this.frmIngresoMercaderia_Load);
            this.grupDocumentos.ResumeLayout(false);
            this.grupDocumentos.PerformLayout();
            this.gpbProductos.ResumeLayout(false);
            this.gpbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gpbusquedacli.ResumeLayout(false);
            this.gpbusquedacli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gruptraspasos.ResumeLayout(false);
            this.gruptraspasos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNDoc;
        private System.Windows.Forms.GroupBox grupDocumentos;
        private System.Windows.Forms.RadioButton rbtFactura;
        private System.Windows.Forms.RadioButton rbtGuia;
        private System.Windows.Forms.GroupBox gpbProductos;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox gpbusquedacli;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdRut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdApellidoP;
        private System.Windows.Forms.TextBox txtGiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImpCarn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsubtotales;
        private System.Windows.Forms.TextBox txtiva;
        private System.Windows.Forms.TextBox txttotales;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.RadioButton rbtGuiatraspaso;
        private System.Windows.Forms.GroupBox gruptraspasos;
        private System.Windows.Forms.DateTimePicker dtpfecha2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNtraspaso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}