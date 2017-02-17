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
    public partial class frmActualizaPreciocs : Form
    {
        public frmActualizaPreciocs()
        {
            InitializeComponent();
        }

        public string dato;

        claseBD CBd = new claseBD();

        private void precioActual()
        {
            string CadSql;
            CadSql = "select * from productos where  " + dato + " = cod_interno;";

            
            
            MySqlDataReader Rec = null;
            try
            {

                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                
                while (Rec.Read())
                {
                    lblnom.Text = Rec["nombre_prod"].ToString();
                    lblcod.Text = Rec["cod_barra"].ToString();
                    lblPrecioCosto.Text = Rec["precio_costo"].ToString();
                    lblPrecioVenta.Text = Rec["precio_venta"].ToString();
                    lblMargenAntiguo.Text = Rec["margen"].ToString();
                    if (lblMargenAntiguo.Text.Equals(""))
                    {
                        tituloMargen1.Visible = false;
                    }
                    else
                    {
                        
                        tituloMargen1.Visible = true;
                    }



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


        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {

            if (txtPrecioVenta.Text != "" )
            {
                double costo = 0, venta = 0, util = 0, res = 0, multiplicador = 0;
                costo = double.Parse(txtPreicioCosto.Text);
                venta = double.Parse(txtPrecioVenta.Text);
                util = venta - costo;

                res = util / costo;
                multiplicador = res * 100;

                lblMargenNuevo.Text = Convert.ToString(multiplicador.ToString("#.##"));
            }
            else
            {
                txtPrecioVenta.Text = "0";


            }


        }

        private void txtPrecioCosto_TextChanged(object sender, EventArgs e)
        {
            txtPrecioVenta.Text = "0";
            if (txtPreicioCosto.Text != "")
            {
                double costo = 0, venta = 0, util = 0, res = 0, multiplicador = 0;
                costo = double.Parse(txtPreicioCosto.Text);
                venta = double.Parse(txtPrecioVenta.Text);
                util = venta - costo;
                res = util / costo;
                multiplicador = res * 100;
                lblMargenNuevo.Text = Convert.ToString(multiplicador.ToString("#.##"));
            }
            else
            {
                txtPreicioCosto.Text = "0";
            }

        }


        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            string CadSql;
            double dato2 = double.Parse(dato);
            CadSql = "update productos set precio_costo='" + txtPreicioCosto.Text + "',margen='"+lblMargenNuevo.Text+"', precio_venta='" + txtPrecioVenta.Text + "' where cod_interno=" + dato2 + "";
            
            try
            {
                if (CBd.EjecutarIUD(CadSql) > 0)
                {
                    MessageBox.Show("Producto Modificado", "Listo");



                }
                else
                {
                    MessageBox.Show("Producto NO Modificado", "ERROR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            frmGestionProductos l = new frmGestionProductos();
            l.Show();
            this.Hide();

        }

        private void frmActualizaPreciocs_Load(object sender, EventArgs e)
        {
            lblMargenAntiguo.Text = "";
            lblMargenNuevo.Text = "";
            precioActual();
            
        }

    }
}
