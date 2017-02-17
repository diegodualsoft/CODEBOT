using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Prototipo1
{
    public partial class lblnumfact : Form
    {
        public lblnumfact()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        

        }
        private void llenarDgv()
        {
          
           
            string CadSql;
            CadSql = "select nombre_producto,precio_venta,cantidad,total,margen from "+rut1+"_"+nfact1+";";

            claseBD CBd = new claseBD();
            int fila;
            
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvLista.RowCount = 0;
                while (Rec.Read())
                {
                    dgvLista.RowCount = dgvLista.RowCount + 1;
                    fila = dgvLista.RowCount - 1;
                    dgvLista.Rows[fila].Cells[0].Value = Rec["nombre_producto"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["precio_venta"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["cantidad"].ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["total"].ToString();
                    dgvLista.Rows[fila].Cells[5].Value = Rec["margen"].ToString();


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
                
                    dgvLista.ClearSelection();
                }
            }
        }
        private void llenarcampos()
        {


            string CadSql;
            CadSql = "select * from " + rut1 + "_" + nfact1 + " where "+nfact1+" = numero_factura;";

            claseBD CBd = new claseBD();
            int fila;

            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvLista.RowCount = 0;
                while (Rec.Read())
                {
                    dgvLista.RowCount = dgvLista.RowCount + 1;
                    fila = dgvLista.RowCount - 1;
                    txtnombrecontacto.Text = Rec["razon_social"].ToString();
                    maskedTextBox1.Text = Rec["rut"].ToString();
                    lblnfact.Text = Rec["numero_factura"].ToString();
                    txtRazon.Text = Rec["nombre_contacto"].ToString();
                    txtDireccion.Text = Rec["direccion"].ToString();
                    txtGiro.Text = Rec["giro"].ToString();
                    txtFecha.Text = Rec["fecha"].ToString();
          
                    txtsubtotales.Text = Rec["subtotales"].ToString();
                    txtiva.Text = Rec["iva"].ToString();
                    txttotales.Text = Rec["totales"].ToString();


                
                    int  subtot;
    
                    subtot = int.Parse(txtsubtotales.Text);
                  



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

        

        public String rut1 = null;
        public String nfact1 = null;
        private void llenarcampos2()
        {


            string CadSql;
            CadSql = "select * from estadofact where nfact = '"+lblnfact.Text+"'";

            claseBD CBd = new claseBD();
            int fila;

            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvLista.RowCount = 0;
                while (Rec.Read())
                {
                    dgvLista.RowCount = dgvLista.RowCount + 1;
                    fila = dgvLista.RowCount - 1;
                    txtabono.Text = Rec["abono"].ToString();
                    txtestado.Text = Rec["estado"].ToString();
                    datepagarael.Text = Rec["fechapago"].ToString();
                    datecomprometio.Text =Rec["fechacomp"].ToString();


                }
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);
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

        private void registrar()
        {
            try
            {
                claseBD cbd = new claseBD();
                string insertar = "insert into estadofact values ('" + maskedTextBox1.Text + "','" + lblnfact.Text + "','"+txtestado.Text+"','$0','"+datecomprometio.Text+"','"+datepagarael.Text+"')";
                cbd.EjecutarIUD2(insertar);
            }
            catch
            { }
         


        }
        private void frmFacturaCliente_Load(object sender, EventArgs e)
        {
          
            llenarcampos();
            registrar();
            llenarcampos2();
            llenarDgv();
            
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvLista.ClearSelection();

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLista_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            String dato = this.dgvLista.CurrentRow.Cells["margen"].Value.ToString();
            lblmargen.Text = dato;
            

        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void dgvLista_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            String dato = this.dgvLista.CurrentRow.Cells["margen"].Value.ToString();

            lblmargen.Text = dato;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                double resporcentaje = 0, resfinal = 0,resporcant = 0;
                String dato = this.dgvLista.CurrentRow.Cells["margen"].Value.ToString();
                String canti = this.dgvLista.CurrentRow.Cells["grdCantidad"].Value.ToString();
                String precio = this.dgvLista.CurrentRow.Cells["grdPrecioVenta"].Value.ToString();
                if (dato == "")
                {
                    lblmargen.Text = "Producto No Actualizado";
                    lblmargencant.Text = "Producto No Actualizado";
                    lblmargenpesos.Text = "Producto No Actualizado";
                }
                else
                {
                    lblmargen.Text = dato + "%";
                    resporcentaje = double.Parse(precio) / 100;
                    resfinal = double.Parse(dato) * resporcentaje;
                    lblmargenpesos.Text = "$" + resfinal.ToString();
                    resporcant = double.Parse(canti) * resfinal;
                    lblmargencant.Text = "$" + resporcant.ToString();
                }
            }
            catch
            { 
            }
            
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtestado.Text != "" && txtabono.Text != "")
            {
                claseBD cbd = new claseBD();
                string actualizar = "update estadofact set fechapago='"+datepagarael.Text+"',fechacomp ='"+datecomprometio.Text+"', estado = '" + txtestado.Text + "',abono='" + txtabono.Text + "' where nfact = '"+lblnfact.Text+"'";
                cbd.EjecutarIUD(actualizar);
                frmVerPerfil fvp = new frmVerPerfil();
                MessageBox.Show("ESTADO ACTUALIZADO");
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR LOS CAMPOS DE ESTADO Y DE ABONO");
            }
        }

        private void datecomprometio_ValueChanged(object sender, EventArgs e)
        {

        }


        
    }
}
