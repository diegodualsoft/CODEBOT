using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototipo1
{
    public partial class frmProductoLibroVenta : Form
    {
        private DataGridView dgvLista;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn PrecioCosto;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label lblnfact;
    
        public frmProductoLibroVenta()
        {
            InitializeComponent();
        }
        public String dato1 = null;
        public String dato2 = null;
        public int fila2 = 0;
        public double res = 0;
        public string codprod = null;
        public double cant = 0;
        public double stock = 0;
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnfact = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.codigo,
            this.precio,
            this.Cantidad,
            this.total,
            this.PrecioCosto});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLista.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLista.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLista.Location = new System.Drawing.Point(12, 88);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(618, 245);
            this.dgvLista.TabIndex = 5;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.DividerWidth = 1;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.DividerWidth = 1;
            this.codigo.HeaderText = "Codigo ";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 185;
            // 
            // precio
            // 
            this.precio.DividerWidth = 1;
            this.precio.HeaderText = "Precio Unitario";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
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
            this.total.Width = 130;
            // 
            // PrecioCosto
            // 
            this.PrecioCosto.HeaderText = "preciocosto";
            this.PrecioCosto.Name = "PrecioCosto";
            this.PrecioCosto.ReadOnly = true;
            this.PrecioCosto.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Se devolveran los siguientes productos a stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(236, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "FACTURA N°";
            // 
            // lblnfact
            // 
            this.lblnfact.AutoSize = true;
            this.lblnfact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnfact.ForeColor = System.Drawing.Color.Red;
            this.lblnfact.Location = new System.Drawing.Point(373, 45);
            this.lblnfact.Name = "lblnfact";
            this.lblnfact.Size = new System.Drawing.Size(18, 20);
            this.lblnfact.TabIndex = 10;
            this.lblnfact.Text = "0";
            // 
            // frmProductoLibroVenta
            // 
            this.ClientSize = new System.Drawing.Size(643, 404);
            this.Controls.Add(this.lblnfact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLista);
            this.Name = "frmProductoLibroVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anulacion de factura ( Devolver Productos a Stock )";
            this.Load += new System.EventHandler(this.frmProductoLibroVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void anulafactura(String nfactanular)
        {
            try
            {
                string consulta2 = "update libro set impuestos = '0',estado = 'NULA',totalventa = '0',costos = '0' where nfact = '" + nfactanular + "'";
                string updateventa = "update informevent set neto = '0',total = '0' where nfact = '" + nfactanular + "'";
                claseBD cbd = new claseBD();
                cbd.EjecutarIUD(consulta2);
                cbd.EjecutarIUD(updateventa);
        
                MessageBox.Show("Factura Anulada correctamente.");
            }
            catch (Exception esx)
            {
                MessageBox.Show("ERROR :" + esx);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                llenarDgvCajaParaDevolver();
                anulafactura(dato1);

                frmLibroVentas lib = new frmLibroVentas();

                this.Hide();
                lib.Show();

            }
            catch
            {
 
            }

        }
        private void llenarDgvCajaParaDevolver()
        {

            string consulta = "select Stock from productos";
            claseBD CBd = new claseBD();
            int fila = 0;
            MySqlDataReader Rec = null;
            try
            {

                do
                {
                    //1.- obtiene el total de la fila del indice como un identificador de datos nulos
                    string identificador = dgvLista.Rows[fila].Cells["total"].Value.ToString();
                    if (identificador == null || identificador == "")
                    {
                        //2.-si la fila no presenta datos aumenta en 1 , ya que no puede operar con datos vacios y tampoco reconoce datos vacios
                        // y si la fila no tiene datos pero se muestra como indice , el bucle no termina.
                        fila = fila + 1;
                    }
                    else
                    {
                        //3.- obtiene los datos necesarios de la fila del dataGridView Para hacer la consulta correspondiente
                        codprod = dgvLista.Rows[fila].Cells["codigo"].Value.ToString();

                        cant = double.Parse(dgvLista.Rows[fila].Cells["Cantidad"].Value.ToString());
                        //4.- obtiene el stock actual de productos de la base de datos
                        Rec = CBd.EjecutarConsulta2("select Stock from productos where cod_interno = '" + codprod + "'");
                        Rec.Read(); // 5.-ejecuta la consulta y abre coneccion
                        stock = double.Parse(Rec["Stock"].ToString());
                        Rec.Close(); //6.-cierra la coneccion para evitar choque de coneccion con la consulta "updatestock"

                        res = stock + cant; //<--Sobre las variables son Datos Globales declarados arriva **//7.- suma el stock de la base de datos con los de la fila del datagrid
                        //8.-  update
                        string updatestock = "update productos set Stock = '" + res.ToString() + "' where cod_interno =" + codprod + "";
                        //9.- ejecuta consulta
                        CBd.EjecutarIUD(updatestock);
                        //10.- aumenta en uno la fila, para leer la siguiente o terminar el Do While
                        fila = fila + 1;



                    }

                }
                while (dgvLista.RowCount > fila); //condicion de Termino (hacer hasta que fila sea mayor al total de filas del dataGridView)


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                }
            }
        }

        public void llenarPerfil(String nfact,String rut)
        {
            string CadSql;
            CadSql = "select * from "+rut+"_"+nfact+"";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;

            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);

                while (Rec.Read())
                {
                    dgvLista.RowCount = dgvLista.RowCount + 1;
                    fila = dgvLista.RowCount - 1;
                           dgvLista.Rows[fila].Cells[0].Value = Rec["nombre_producto"].ToString();
                           dgvLista.Rows[fila].Cells[1].Value = Rec["codigo"].ToString();
                           dgvLista.Rows[fila].Cells[2].Value = Rec["precio_venta"].ToString();
                           dgvLista.Rows[fila].Cells[3].Value = Rec["cantidad"].ToString();
                           dgvLista.Rows[fila].Cells[4].Value = Rec["total"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                }
            }


        }

        private void frmProductoLibroVenta_Load(object sender, EventArgs e)
        {
            llenarPerfil(dato1,dato2);
            lblnfact.Text = ""+dato1;
        }
       
        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLibroVentas lib = new frmLibroVentas();

            this.Hide();
            lib.Show();
        }
    }
}
