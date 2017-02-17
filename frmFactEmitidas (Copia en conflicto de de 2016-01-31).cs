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
    public partial class frmFactEmitidas : Form
    {
        public frmFactEmitidas()
        {
            InitializeComponent();
        }
        private void llenarDgv()
        {


            string CadSql;
            CadSql = "select * from emision where fecha = '"+dateTimePicker1.Text+"'";

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
                    dgvLista.Rows[fila].Cells[0].Value = Rec["fecha"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["nfact"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["monto"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["rut"].ToString();
                


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

        private void frmFactEmitidas_Load(object sender, EventArgs e)
        {
            llenarDgv();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            llenarDgv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nfact = dgvLista.CurrentRow.Cells["grdnfact"].Value.ToString();
            string rut = dgvLista.CurrentRow.Cells["rutcli"].Value.ToString();

            string CadSql;
            CadSql = "select * from "+rut+"_"+nfact+"";

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
                    dgvLista1.RowCount = dgvLista1.RowCount + 1;
                    fila = dgvLista1.RowCount - 1;
                    dgvLista1.Rows[fila].Cells[0].Value = Rec["nombre_producto"].ToString();
                    dgvLista1.Rows[fila].Cells[1].Value = Rec["precio_venta"].ToString();
                    dgvLista1.Rows[fila].Cells[2].Value = Rec["cantidad"].ToString();
                    dgvLista1.Rows[fila].Cells[3].Value = Rec["total"].ToString();
                    lblcliente.Text = Rec["razon_social"].ToString();
                    lblfecha.Text = Rec["fecha"].ToString();
                    txtneto.Text = Rec["subtotales"].ToString();
                    txtiva.Text = Rec["iva"].ToString();
                    txttotal.Text = Rec["totales"].ToString();
                    numfact.Text = Rec["numero_factura"].ToString();
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbmediopago.Text != "Seleccione...." && txtneto.Text != "0" && txtiva.Text != "0" && txttotal.Text != "0" && txtmontocaja.Text != "")
            {
                
                if (MessageBox.Show("Cuadratura realizada correctamente con restantes de caja en valor = $"+txtrestante.Text, "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string delete = "delete from emision where nfact = '"+numfact.Text+"'";
                    claseBD cbd = new claseBD();
                    cbd.EjecutarIUD(delete);
                    string insert = "insert into factcuad values ('"+numfact.Text+"','" + txtmontocaja.Text + "','" + txtrestante.Text + "','" + cbmediopago.Text + "','" + lblcliente.Text + "','"+dateTimePicker1.Text+"','"+txttotal.Text+"')";
                    cbd.EjecutarIUD(insert);
                    lblcliente.Text = "";
                    lblfecha.Text = "";
                    txtiva.Text = "0";
                    txtmontocaja.Clear();
                    txtneto.Text = "0"; ;
                    txtrestante.Text = "0";
                    numfact.Text = "";
                    txttotal.Text="0";
                    cbmediopago.Text = "Seleccione....";
                    do
                    {
                        dgvLista1.Rows.RemoveAt(dgvLista1.Rows.Count - 1);
                    } while (dgvLista1.Rows.Count != 0);
                    llenarDgv();
                }
                else
                {
                    
                    
                }
            }
            else
            {
                MessageBox.Show("Debe Completar Los Campos");
            }


        }

        private void txtrestante_TextChanged(object sender, EventArgs e)
        {
    
       
        }

        private void txtmontocaja_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void txtmontocaja_TextAlignChanged(object sender, EventArgs e)
        {
  
        }

        private void txtmontocaja_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtmontocaja_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
         

        }

        private void txtmontocaja_TextChanged_1(object sender, EventArgs e)
        {
            if (txtmontocaja.Text != "")
            {
                double caja = 0, total = 0, res = 0;
                caja = Convert.ToDouble(txtmontocaja.Text);
                total = Convert.ToDouble(txttotal.Text);
                Convert.ToDouble(total);
                Convert.ToDouble(caja);
                res = total - caja;
                txtrestante.Text = "" + res.ToString();

            }
            else
            {
                txtmontocaja.Clear();
                txtrestante.Text = txttotal.Text;
                //int.Parse(txtmontocaja.Text = "0");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFacturasCuadradas fc =new frmFacturasCuadradas();
            fc.Show();
        }

      }
    
}
