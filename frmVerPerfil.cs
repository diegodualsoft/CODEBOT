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

        //public void llenardgvproductos()
        //{
        //    string CadSql = "select   pes_id as id, cod_interno as codigo,  pes_rut_cliente as rut, pes_precio_especifico as Precio,  pes_margen_especifico as margen from productos_especifico where pes_id = '" + getPrecioEspecial() + "';";

        //    try
        //    {
        //        dgvLista.DataSource = new claseBD().Select_datatable(CadSql);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    finally
        //    {
        //    }
        //}
        internal string getPrecioEspecial()
        {

            string CadSql;
            CadSql = "select precio_especial from clientes where rut = '" + lblRut.Text + "';";
            string cod = "";
            claseBD CBd3 = new claseBD();
            int fila;
            MySqlDataReader Rec = null;

            try
            {

                CBd3.AbrirConexion();
                Rec = CBd3.EjecutarConsulta(CadSql);

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
        private void llenardgvRut()
        {
           
            string CadSql;
            CadSql = "select nfact from estadofact where rut = '"+lblRut.Text+"' and estado = 'PAGADA' ";

            claseBD CBd2 = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
          
            try


            {
               
                CBd2.AbrirConexion();
                Rec = CBd2.EjecutarConsulta(CadSql);
             
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
        private void muestraproducto(KeyPressEventArgs e)
        {
            string CadSql;
            CadSql = "select * from productos where cod_interno = "+txtCodProd.Text+" ";
            claseBD CBd4 = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd4.AbrirConexion();
                Rec = CBd4.EjecutarConsulta(CadSql);
                dgvnfact.RowCount = 0;
                while (Rec.Read())
                {
                    lblnombreprod.Text = Rec["nombre_prod"].ToString();
                    lblmargen.Text = Rec["margen"].ToString();
                    lblprecio.Text = Rec["precio_venta"].ToString();
                    lblcostoprod.Text = Rec["precio_costo"].ToString();
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
        private void llenarDgv()
        {
            claseBD CBd5 = new claseBD();
            string CadSql;
            CadSql = "select cod_interno,pes_nombre_producto as nombpr,pes_precio_especifico from productos_especifico where pes_rut_cliente = "+lblRut.Text+" ";
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd5.AbrirConexion();
                Rec = CBd5.EjecutarConsulta(CadSql);
                dgvLista.RowCount = 0;
                while (Rec.Read())
                {
                    dgvLista.RowCount = dgvLista.RowCount + 1;
                    fila = dgvLista.RowCount - 1;
                    dgvLista.Rows[fila].Cells[0].Value = Rec["cod_interno"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["nombpr"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["pes_precio_especifico"].ToString();
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
       private void llenardgvRut2()
       {

           string CadSql;
           CadSql = "select nfact from estadofact where estado = 'PENDIENTE' and rut = '"+lblRut.Text+"'";

           claseBD CBd6 = new claseBD();
           int fila;
           MySqlDataReader Rec = null;
           try
           {
               CBd6.AbrirConexion();
               Rec = CBd6.EjecutarConsulta(CadSql);
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
        private void insertaensespecifico()
        {
            claseBD cbd = new claseBD();
            string insertaesp = "insert into productos_especifico (pes_rut_cliente,cod_interno,pes_nombre_producto,pes_precio_especifico,pes_margen_especifico) values('"+lblRut.Text+"',"+txtCodProd.Text+",'"+lblnombreprod.Text+"',"+txtprecioespecial.Text+",'"+lblMargenNuevo.Text+"')";
            cbd.EjecutarIUD(insertaesp);
            cbd.CerrarConexion();
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            frmListadoClientes l = new frmListadoClientes();
            this.Hide();
            l.Show();
        }
        private void frmVerPerfil_Load(object sender, EventArgs e)
        {
            lblMargenNuevo.Text = "0%";
            lblnombreprod.Text = "";
            lblprecio.Text = "0";
            lblmargen.Text = "0%";
            lblcostoprod.Text = "0";
            txtCodProd.Text = "";
            txtprecioespecial.Text = "";
            llenarPerfil(dato1);
            llenardgvRut2();
            llenardgvRut();
            llenarDgv();
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
            this.Hide();
            new frmingresoProductoEspecifico().ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            claseBD cbdd = new claseBD();
            string updatefrm = "update frmparametros set frm_abierto = 'si' where frm_id = 2";
            frmBuscarProdCaja bsc = new frmBuscarProdCaja();
            bsc.Show();   
        } 
        private void txtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void txtCodProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprecioespecial_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            insertaensespecifico();
            llenarDgv();
            lblMargenNuevo.Text = "0%";
            lblnombreprod.Text = "";
            lblprecio.Text = "0";
            lblmargen.Text = "0%";
            lblcostoprod.Text = "0";
            txtCodProd.Text = "";
            txtprecioespecial.Text = "";
        }

        private void txtCodProd_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtCodProd_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                muestraproducto(e);
                llenardgvRut();
                llenardgvRut2();
                llenarDgv();
            }
        }

        private void txtprecioespecial_TextChanged_1(object sender, EventArgs e)
        {
            if (txtprecioespecial.Text != "")
            {
                double costo = 0, venta = 0, util = 0, res = 0, multiplicador = 0;
                costo = double.Parse(lblcostoprod.Text);
                venta = double.Parse(txtprecioespecial.Text);
                util = venta - costo;
                res = util / costo;
                multiplicador = res * 100;
                lblMargenNuevo.Text = Convert.ToString(multiplicador.ToString("#.##"));
            }
            else
            {
                txtprecioespecial.Text = "0";
            }
        }
    }
}
