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
    public partial class frmAgregarProducto : Form
    {
        public frmAgregarProducto()
        {
            InitializeComponent();
        }
        claseBD CBd = new claseBD();
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if(dgvingredientes.RowCount > 0)
            {
                MessageBox.Show("DEBE ELIMINAR LOS INGREDIENTES ANTES DE SALIR");
            }
            else
            {
                frmGestionProductos gpss = new frmGestionProductos();
                gpss.Show();
                this.Hide();
            }
        }
        public void sumatoria()
        {
            double subtotal = 0;

            foreach (DataGridViewRow row in dgvingredientes.Rows)
            {

                subtotal += Convert.ToDouble(row.Cells["costoing"].Value);
            }

            txtPrecioCosto.Text = Convert.ToString(subtotal);

        }
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (datosCompletos())
            {
                if (txtNombreProducto.Text != "")
                {
                    if (checkBox1.Checked)
                    {

                        string CadSql, si = "si";
                        CadSql = "insert into productos values('" + txtNombreProducto.Text.Trim().ToUpper() + "','" + txtCodigoInterno.Text.Trim() +
                            "','" + txtCodigoDeBarras.Text.Trim() + "','" + txtPrecioCosto.Text.Trim() + "','" + txtPrecioVenta.Text.Trim() + "','" + txtstock.Text.Trim() + "','"+ txtDescripcionProducto.Text.Trim() +"','"+ txttipomedida.Text.Trim() + "','" + si.ToString() + "','" + txtmargen.Text + "',0);";

                        try
                        {
                            if (CBd.EjecutarIUD(CadSql) > 0)
                            {
                                MessageBox.Show("Producto Registrado", "Listo");

                                limpiar();
                                llenarcodigo();
                            }
                            else
                            {
                                MessageBox.Show("Producto NO Registrado", "ERROR");
                            }
                        }
                        catch (Exception ex)
                        {
                         //   MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        string CadSql, no = "no";
                        CadSql = "insert into productos values('" + txtNombreProducto.Text.Trim().ToUpper() + "','" + txtCodigoInterno.Text.Trim() +
                            "','" + txtCodigoDeBarras.Text.Trim() + "','" + txtPrecioCosto.Text.Trim() + "','" + txtPrecioVenta.Text.Trim() + "','" + txtstock.Text.Trim() + "','" + txtDescripcionProducto.Text.Trim() + "','" + txttipomedida.Text.Trim() + "','" + no.ToString() + "','" + txtmargen.Text + "',0);";


                        try
                        {
                            if (CBd.EjecutarIUD(CadSql) > 0)
                            {
                                MessageBox.Show("Producto Registrado", "Listo");

                                limpiar();
                                llenarcodigo();
                                dgvingredientes.Rows.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Producto NO Registrado", "ERROR");
                            }
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.Message);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("FALTA NOMBRE PRODUCTO","DATOS FALTANTES");
                    txtNombreProducto.Focus();
                }


            }
        }

        private void limpiar()
        {
            lblPrecioMasIva.Text = "= $ 0";
            lblTipoMedida.Text = txttipomedida.Text;
            txtNombreProducto.Clear();
            txtCodigoInterno.Clear();
            txtmargen.Text = "0%";
            checkBox1.Checked = false;
            txtCodigoDeBarras.Clear();
            txtPrecioCosto.Text = "0";
            txtPrecioVenta.Text = "0";
            txtstock.Clear();
        }

        private bool datosCompletos()
        {
            bool verifica = true;

            if (txtNombreProducto.Equals("") || txtNombreProducto.Equals(null))
            {
                verifica = false;
            }
            else if (txtCodigoInterno.Equals("") || txtCodigoInterno.Equals(null))
            {
                verifica = false;
            }
            else if (txtCodigoDeBarras.Equals("") || txtCodigoDeBarras.Equals(null))
            {
                verifica = false;
            }
            else if (txtPrecioCosto.Equals("") || txtPrecioCosto.Equals(null))
            {
                verifica = false;
            }
            else if (txtPrecioVenta.Equals("") || txtPrecioVenta.Equals(null))
            {
                verifica = false;
            }

                return verifica;
        }
        string multparabd = null;
        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            txttipomedida.SelectedIndex = 1;
            cbtipomedida.SelectedIndex = 1;
            lblTipoMedida.Text = cbtipomedida.Text;
            txtcostoingrediente.Text = "0";
            txtcantigrediente.Text = "0";
            txtNombreIngrediente.Text = "";
            llenarcodigo();
            if (chkhabilitareceta.Checked == true)
            {
                groupBox1.Enabled = true;
                dgvingredientes.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
                dgvingredientes.Enabled = false;
            }
            txtmargen.Text = "0";
        }
        
        private void llenarcodigo()
        {

            string CadSql;
            CadSql = "select cod_interno from productos ;";

            claseBD CBd = new claseBD();
            
            MySqlDataReader Rec = null;
           
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
         
                while (Rec.Read())
                {
                    
                    double nf;
                    
                    nf = double.Parse(Rec["cod_interno"].ToString());
                    Convert.ToInt32(nf);
                    nf = nf + 1;
                    double.Parse(txtCodigoInterno.Text=""+nf);
                    double.Parse(txtCodigoDeBarras.Text = "" + nf);
          
                }
            }
            catch (Exception e)
            {
             //   MessageBox.Show(e.Message);
            }
            finally
            {
                if (Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                
                }
            }
            txtPrecioCosto.Text = "0";
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
           
            if (txtPrecioVenta.Text != "")
            {
                double netomasiva =0,masiva = 0,costo = 0, venta = 0, util = 0, res = 0, multiplicador = 0;
                costo = double.Parse(txtPrecioCosto.Text);
                venta = double.Parse(txtPrecioVenta.Text);
                
                util = venta - costo;
               
                res = util / costo;
                multiplicador = res * 100;
          
                txtmargen.Text = Convert.ToString(multiplicador.ToString("#.##"));
                if (chkautoiva.Checked == true)
                {
                    masiva = venta * 0.19;
                    netomasiva = venta + masiva;
                    lblPrecioMasIva.Text = "= $" + netomasiva.ToString();
                }
                else
                { }
            }
            else
            {
                txtPrecioVenta.Text = "0";
         

            }
            
            
        }

        private void txtPrecioCosto_TextChanged(object sender, EventArgs e)
        {
            txtPrecioVenta.Text = "0";
            if (txtPrecioCosto.Text != "")
            {
                double  costo = 0, venta = 0, util = 0, res = 0,  multiplicador = 0;
                costo = double.Parse(txtPrecioCosto.Text);
                venta = double.Parse(txtPrecioVenta.Text);
                util = venta - costo;
                res = util / costo;
                multiplicador = res * 100;       
                txtmargen.Text = Convert.ToString(multiplicador.ToString("#.##"));
            }
            else
            {
                txtPrecioCosto.Text = "0";
            }
            
        }


        private void txtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void chkhabilitareceta_CheckedChanged(object sender, EventArgs e)
        {
            if(chkhabilitareceta.Checked == true)
            {
                groupBox1.Enabled = true;
                dgvingredientes.Enabled = true;
                llenarDgvIngrediente();
                sumatoria();
                cbtipomedida.SelectedIndex = 1;
                if (dgvingredientes.RowCount > 0)
                {
                 MessageBox.Show("DEBIDO A ALGUN INCIDENTE, QUEDO REGISTRO EN EL ULTIMO INGRESO DE INGREDIENTES POR RAZONES DE SEGURIDAD, PARA EL PRODUCTO, CODIGO INTERNO : " + txtCodigoInterno.Text + " , SI DESEA VOLVER A GENERAR RECETA SOLO BORRE LOS INGREDIENTES DEL ULIMO REGITRO", "¡ AVISO !");
                }
                else
                { }
            }
            else
            {
                groupBox1.Enabled = false;
                dgvingredientes.Enabled = false;
            }
        }
        private void llenarDgvIngrediente()
        {
            
            string CadSql3;
            CadSql3 = "select * from ingredientes where cod_interno = "+txtCodigoInterno.Text;
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql3);
                dgvingredientes.RowCount = 0;
                while (Rec.Read())
                {
                    dgvingredientes.RowCount = dgvingredientes.RowCount + 1;
                    fila = dgvingredientes.RowCount - 1;
                    dgvingredientes.Rows[fila].Cells[0].Value = Rec["ing_id"].ToString();
                    dgvingredientes.Rows[fila].Cells[1].Value = Rec["ing_nombre"].ToString();
                    dgvingredientes.Rows[fila].Cells[2].Value = Rec["ing_costo"].ToString();
                    dgvingredientes.Rows[fila].Cells[3].Value = Rec["ing_cant"].ToString();
                    dgvingredientes.Rows[fila].Cells[4].Value = Rec["ing_tipo_medida"].ToString();
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
        private void cmdañadirigrediente_Click(object sender, EventArgs e)
        {
            if(txtNombreIngrediente.Text == "" || txtcantigrediente.Text == "0"  || txtcostoingrediente.Text == "0" )
            {
                MessageBox.Show("DEBE INGRESAR ALMENOS UN INGREDIENTE");
            }
            else
            {
                string CadSql = "insert into ingredientes (ing_nombre,ing_cant,ing_costo,ing_tipo_medida,cod_interno) values('" + txtNombreIngrediente.Text + "','" + txtcantigrediente.Text + "','" + txtcostoingrediente.Text + "','" + cbtipomedida.Text + "','" + txtCodigoInterno.Text + "');";
                try
                {
                    
                    if (CBd.EjecutarIUD(CadSql) > 0)
                    {
                           
                        txtcostoingrediente.Text = "0";
                        txtcantigrediente.Text = "0";
                        txtNombreIngrediente.Text = "";
                        llenarDgvIngrediente();
                        sumatoria();
                        txtNombreIngrediente.Focus();

                    }
                    else
                    {
                        MessageBox.Show("EL INGREDIENTE NO SE INGRESO", "ERROR");
                    }
                }
                catch (Exception ex)
                {
                    //// MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String ingid = this.dgvingredientes.CurrentRow.Cells["iding"].Value.ToString();
            string updatecaja = "delete from ingredientes where ing_id = '" + ingid + "'";
            CBd.EjecutarIUD(updatecaja);
            llenarDgvIngrediente();
        }
        private void txttipomedida_TextChanged(object sender, EventArgs e)
        {
        }

        private void txttipomedida_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void txttipomedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTipoMedida.Text = txttipomedida.Text;
        }

        private void txttipomedida_MouseClick(object sender, MouseEventArgs e)
        {
        }

        }

    
}
