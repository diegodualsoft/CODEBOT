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
    public partial class frmActualizaStock : Form
    {
        public frmActualizaStock()
        {
            InitializeComponent();
        }


        private void precioActual()
        {
            string CadSql;
            CadSql = "select * from productos where  " + dato + " = cod_barra;";
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                while (Rec.Read())
                {
                    lblStock.Text = Rec["Stock"].ToString();
                    lblnom.Text = Rec["nombre_prod"].ToString();
                    lblcod.Text = Rec["cod_barra"].ToString();
                    stock = double.Parse(lblStock.Text);
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
                txtStockNuevo.Text = "";
            }
        }
        public string dato;
        public double stock;
        claseBD CBd = new claseBD();
        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            string CadSql;
            double dato2 = double.Parse(dato);
            double stockNuevo = double.Parse(txtStockNuevo.Text);
            double stockFinal = stock + stockNuevo;
            CadSql = "update productos set  Stock='" + stockFinal.ToString() + "' where cod_barra='" + dato2.ToString() + "';";
            try
            {
                if (CBd.EjecutarIUD(CadSql) > 0)
                {
                    MessageBox.Show("Stock Modificado", "Listo");
                }
                else
                {
                    MessageBox.Show("Stock NO Modificado", "ERROR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                precioActual();
            }
        }

            private void frmActualizaStock_Load(object sender, EventArgs e)
            {
                precioActual();
            }

            private void cmdCancelar_Click(object sender, EventArgs e)
            {
                frmGestionProductos l = new frmGestionProductos();
                l.Show();
                this.Close();
            }

            private void txtStockNuevo_KeyPress(object sender, KeyPressEventArgs e)
            {
                
            }

            private void txtStockNuevo_TextChanged(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {

                string CadSql;
                double dato2 = double.Parse(dato);
                CadSql = "update productos set  Stock='0' where cod_barra='" + dato2.ToString() + "';";
                try
                {
                    if (CBd.EjecutarIUD(CadSql) > 0)
                    {
                        MessageBox.Show("Stock Reestablecido en 0", "Listo");
                    }
                    else
                    {
                        MessageBox.Show("Stock NO Modificado", "ERROR");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    precioActual();
                }
            }
        }
    }

