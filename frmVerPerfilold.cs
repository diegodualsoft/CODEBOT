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
    public partial class frmVerPerfil : Form
    {
        public frmVerPerfil()
        {
            InitializeComponent();
        }
        frmingresoProductoEspecifico fipe = new frmingresoProductoEspecifico();
        public String dato1 = null;
        public void llenarPerfil(String rut)
        {
            


            string CadSql;
            CadSql = "select a.rut,a.razon_social,a.giro,a.nombres,a.direccion,a.telefono,a.ciudad,a.comuna,a.vendedor from clientes a where a.rut='" + rut + "' ;";

            claseBD CBd = new claseBD();
           
            MySqlDataReader Rec = null;
         
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                
                while (Rec.Read())
                {
                    
                    lblRut.Text = Rec["rut"].ToString();
                   
                    lblApellidoP.Text = Rec["razon_social"].ToString();
                    lblApellidoM.Text = Rec["giro"].ToString();
                    lblNombre.Text = Rec["nombres"].ToString();
                    lblDireccion.Text = Rec["direccion"].ToString();
                    lblTelefono.Text = Rec["telefono"].ToString();
                    lblciudad.Text = Rec["ciudad"].ToString();
                    lblcomuna.Text = Rec["comuna"].ToString();
                    lblVendedor.Text = Rec["vendedor"].ToString();
                    


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
        public void llenardgvproductos()
        {
            string CadSql = "select   pes_id as id, cod_interno as codigo,  pes_rut_cliente as rut, pes_precio_especifico as Precio,  pes_margen_especifico as margen from productos_especifico where pes_id = '" + getPrecioEspecial() + "';";

            try
            {
                dgvProductosCliente.DataSource = new claseBD().Select_datatable(CadSql);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
            }
        }
        internal string getPrecioEspecial()
        {

            string CadSql;
            CadSql = "select precio_especial from clientes where rut = '" + lblRut.Text + "';";
            string cod = "";
            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;

            try
            {

                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);

                dgvnfact.RowCount = 0;
                while (Rec.Read())
                {
                    cod = Rec["precio_especial"].ToString();


                }
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
            return cod;
        }
        public void llenardgvRut()
        {
           
            string CadSql;
            CadSql = "select nfact from estadofact where rut = '"+lblRut.Text+"' and estado = 'PAGADA' ";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
          
            try


            {
               
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
             
                dgvnfact.RowCount = 0;
                while (Rec.Read())
                {
                    
                    dgvnfact.RowCount = dgvnfact.RowCount + 1;
                    fila = dgvnfact.RowCount - 1;
                    dgvnfact.Rows[fila].Cells[0].Value = Rec["nfact"].ToString();  
          

                }
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
       public void llenardgvRut2()
       {

           string CadSql;
           CadSql = "select nfact from estadofact where estado = 'PENDIENTE' and rut = '"+lblRut.Text+"'";

           claseBD CBd = new claseBD();
           int fila;
           MySqlDataReader Rec = null;
           try
           {
               CBd.AbrirConexion();
               Rec = CBd.EjecutarConsulta(CadSql);
               dgvnfact2.RowCount = 0;
               while (Rec.Read())
               {
                   dgvnfact2.RowCount = dgvnfact2.RowCount + 1;
                   fila = dgvnfact2.RowCount - 1;
                   dgvnfact2.Rows[fila].Cells[0].Value = Rec["nfact"].ToString();


               }
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

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            frmListadoClientes l = new frmListadoClientes();
            this.Hide();
            l.Show();
        }

        
        private void frmVerPerfil_Load(object sender, EventArgs e)
        {

            llenarPerfil(dato1);
            llenardgvRut2();
            llenardgvRut();
            llenardgvproductos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
    
                lblnumfact fact = new lblnumfact();

                String rut = this.lblRut.Text;
                String nfact = this.dgvnfact.CurrentRow.Cells["NumeroDeFactura"].Value.ToString();
                fact.rut1 = rut;
                fact.nfact1 = nfact;
             
                fact.Show();
            }
            catch
            {
            }
            finally
            {
 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                lblnumfact fact = new lblnumfact();
                String rut = this.lblRut.Text;
                String nfact = this.dgvnfact2.CurrentRow.Cells["Nfact"].Value.ToString();
                fact.rut1 = rut;
                fact.nfact1 = nfact;
                fact.Show();
            }
            catch
            {
            }
            finally
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Activate();
  
        }

        private void dgvnfact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvnfact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblnumfact fact = new lblnumfact();
                String rut = this.lblRut.Text;
                String nfact = this.dgvnfact.CurrentRow.Cells["NumeroDeFactura"].Value.ToString();
                fact.rut1 = rut;
                fact.nfact1 = nfact;
                fact.Show();
            }
            catch
            {
            }
            finally
            {

            }
        }
        private void dgvnfact2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblnumfact fact = new lblnumfact();
                String rut = this.lblRut.Text;
                String nfact = this.dgvnfact2.CurrentRow.Cells["Nfact"].Value.ToString();
                fact.rut1 = rut;
                fact.nfact1 = nfact;
                fact.Show();
            }
            catch
            {
            }
            finally
            {

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //ACA LLAMAMOS A LA VENTANA ESTADO DE CREDITOS Y CREDITOS
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

            fipe.Show();
            fipe.txtCliente.Text=lblNombre.Text;
            
            this.Hide();

        }
    }
}
