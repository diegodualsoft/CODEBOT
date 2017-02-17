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
    public partial class frmGuiaDespacho : Form
    {
        public frmGuiaDespacho()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
     

      
            claseBD cbd = new claseBD();
            string CadSql2;
            string calculos = "insert into grillafactura (precio_costo,subtotal,iva,totales) values('" + lblcosto.Text + "','" + msksubtotal.Text + "','" + txtIVA.Text + "','" + txtTotal.Text + "');";
            
            CadSql2 = "insert into grillafactura (cod_interno,nombre_prod,precio_venta,cantidad,total) select codigo,nombre,precio,cant,total from caja";
            cbd.EjecutarIUD(CadSql2);
            cbd.EjecutarIUD(calculos);
        //    claseBD cbd = new claseBD();
        //    string CadSql2;
        //    string calculos = "insert into grillafactura (subtotal,iva,totales) values('" + msksubtotal.Text + "','" + txtIVA.Text + "','" + txtTotal.Text + "');";
            
        //    CadSql2 = "insert into grillafactura (nombre_prod,precio_venta,cantidad,total) select nombre,precio,cant,total from caja";
        //    cbd.EjecutarIUD(CadSql2);
        //    cbd.EjecutarIUD(calculos);
            this.Hide();
            frmFactura fact = new frmFactura();
            fact.Show();

        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {

            //if (MessageBox.Show("¿Esta seguro que desea salir y eliminar todos los productos de la lista?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    do
            //    {

            //        dgvLista.Rows.RemoveAt(dgvLista.Rows.Count - 1);

            //    } while (dgvLista.Rows.Count != 0);
            //}
            if (dgvLista.Rows.Count == 0)
            {

                claseBD cbd = new claseBD();
                string eliminarcaja = "truncate table caja";
                cbd.EjecutarIUD(eliminarcaja);
                frmMenu M = new frmMenu();
                this.Hide();
                M.Show();
            }
            else
            {
                MessageBox.Show("Debe eliminar todos los datos de la lista antes de salir");
            }


        
        }
        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            
            frmBuscarProdCaja bpc = new frmBuscarProdCaja();
            bpc.Show();
            cmdConsultar.Enabled = false;
            
        }
        private void cmdCotizacion_Click(object sender, EventArgs e)
        {
            frmCotizacion cot = new frmCotizacion();
            cot.Show();
        }
        private void cmdBoleta_Click(object sender, EventArgs e)
        {
        
        }

        public int contador = 0;
        public int con2 = 0;
        private string nombreinf = null;
        private string nombrecomp = null;
      
        private void cmdConsultar_Click_1(object sender, EventArgs e)
        {
            frmBuscarProdCaja a = new frmBuscarProdCaja();
            if(con2==0) 
            {
            a.Show();

            con2++;
            }


            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(frmBuscarProdCaja)) 
                {
                    //entro a la wea
                    contador = 1;
                    break;

                }
                else
                {
                    //no entro a la wea
                    contador = 0;
                }
            }



            if (contador == 0)
            {
                  
                contador = 1;
                a.Show();
            }
            else
            {
                contador = 0;
            }

        }
        private double cant = 0;
        private double cant2 = 0;
        public void soloNumeros(KeyPressEventArgs e)
        {
            //try
            //{
            //    if (Char.IsNumber(e.KeyChar))
            //    {
            //        e.Handled = false;
            //    }
            //    else if (Char.IsControl(e.KeyChar))
            //    {
            //        e.Handled = false;
            //    }
            //    else
            //    {
            //        e.Handled = true;
            //    }
            //}
            //catch
            //{

            //}
        }
        private void ingresogrdcaja(KeyPressEventArgs e)
        {
        
            try
            {
                soloNumeros(e);
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    
                    // string opcion;
                    //  opcion = cmboxCobrosAdicionales.SelectedText.ToString();
                    // switch (opcion.ToString())            
                    if (txtCodigoBarra.Text == "" || txtCant.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar Codigo de Barras o Codigo Interno Y Cantidad Del producto");
                    }
                    else
                    {

                        #region consulta

                        string CadSql;
                        CadSql = "select nombre_prod, cod_interno, cod_barra, precio_venta, precio_costo,medida from productos where cod_interno='" + txtCodigoBarra.Text + "' or cod_barra='" + txtCodigoBarra.Text + "';";


                        claseBD CBd = new claseBD();
                        //int fila;
                        MySqlDataReader Rec = null;

                        try
                        {
                            CBd.AbrirConexion();
                            Rec = CBd.EjecutarConsulta(CadSql);
                            while (Rec.Read())
                            {

                                lblCodInternoCaptura.Text = Rec["cod_interno"].ToString();
                                lblNombreprodCaptura.Text = Rec["nombre_prod"].ToString();
                                lblCodBarraCaptura.Text = Rec["cod_barra"].ToString();
                                int.Parse(lblPrecioVentaCaptura.Text = Rec["precio_venta"].ToString());
                                int.Parse(lblPrecioCostoCaptura.Text = Rec["precio_costo"].ToString());
                                lblmedidaCaptura.Text = Rec["medida"].ToString();

                        
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
                        consultardeInforme();
                        try
                        {
                            string consultacaja = "select * from caja where nombre = '" + lblNombreprodCaptura.Text + "'";
                            CBd.AbrirConexion();
                            Rec = CBd.EjecutarConsulta(consultacaja);
                            while (Rec.Read())
                            {
                                

                                lblconsultacaja.Text = Rec["nombre"].ToString();
                                double.Parse(lbltotalprodcaja.Text = Rec["precio"].ToString());
                                double.Parse(lblcantcaja.Text = Rec["cant"].ToString());
                                double.Parse(lblcosto.Text = Rec["costo"].ToString());
                             
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
                        
                        #endregion consulta
                        #region operatoria
                        string nombreprod, codBarra, Codinterno;
                        double precioVenta, precioCosto, cantcaptura, total, totalcost;
                        nombreprod = lblNombreprodCaptura.Text;
                        codBarra = lblCodBarraCaptura.Text;
                        precioVenta = double.Parse(lblPrecioVentaCaptura.Text);
                        precioCosto = double.Parse(lblPrecioCostoCaptura.Text);
                        Codinterno = lblCodInternoCaptura.Text;
                        cantcaptura = double.Parse(txtCant.Text);
                        total = cantcaptura * precioVenta;
                        totalcost = cantcaptura * precioCosto;





                        if (Codinterno == txtCodigoBarra.Text || codBarra == txtCodigoBarra.Text)
                        {
                            //dgvLista.Rows.Add(nombreprod, codBarra, precioVenta, precioCosto, cantcaptura, total);

                            if (lblNombreprodCaptura.Text == lblconsultacaja.Text)
                            {


                                double cantcaja, rescant, preciocaja, totales, costocaja, rescantcost, rescost;
                                preciocaja = double.Parse(lbltotalprodcaja.Text);
                                cantcaja = double.Parse(lblcantcaja.Text);
                                costocaja = double.Parse(lblcosto.Text);
                                rescant = cantcaja + cantcaptura;
                                totales = rescant * preciocaja;
                                rescantcost = cantcaptura + cantcaptura;
                                rescost = rescant * precioCosto;


                                string updatecaja = "Update caja Set codigo = '" + lblCodBarraCaptura.Text + "',precio = '" + lblPrecioVentaCaptura.Text + "',cant = '" +Convert.ToDouble(rescant) + "',total = '" + totales + "',costo = '" + rescost + "' where nombre = '" + lblconsultacaja.Text + "'";
                                CBd.EjecutarIUD(updatecaja);
                                llenarDgvCaja();
                                txtCodigoBarra.Clear();
                                lblconsultacaja.Text = "";
                            }
                            else
                            {
                                string cadsql3 = "insert into caja values('" + lblNombreprodCaptura.Text + "','" + lblCodBarraCaptura.Text + "','" + lblPrecioVentaCaptura.Text + "','" +Convert.ToDouble(cantcaptura) + "','" + total + "','" + totalcost + "')";
                                CBd.EjecutarIUD(cadsql3);
                                llenarDgvCaja();
                                txtCodigoBarra.Clear();
                                lblconsultacaja.Text = "";
                            }
                            if (lblNombreprodCaptura.Text == nombreinf)
                            {
                            
                                double resinf = cant + cantcaptura;
                                string updateinforme = "Update " + dateTimePicker1.Text + "  Set cant = '" +Convert.ToDouble(resinf) + "' where nombre = '" + nombreinf.ToString() + "'";
                                CBd.EjecutarIUD(updateinforme);
                                string updatestock = "update productos set stock = stock - '"+resinf+"'";
                              
                                txtCodigoBarra.Clear();
                                llenarDgvCaja();
                                lblconsultacaja.Text = "";
                            }
    
                            else if (nombreinf != lblNombreprodCaptura.Text)
                            {
                               
                                string cadsql4 = "insert into " + dateTimePicker1.Text + " values('" + lblNombreprodCaptura.Text + "','" +Convert.ToDouble(cantcaptura) + "','" + lblmedidaCaptura.Text + "')";
                                CBd.EjecutarIUD(cadsql4);
                             
                                txtCodigoBarra.Clear();
                                llenarDgvCaja();
                                lblconsultacaja.Text = "";
                            }
                            double costo = 0, subtotal = 0, subtotcalc = 0, resultado = 0, ivam = 0, ivas = 0, mobra = 0, iva = 0, sub = 0;

                            foreach (DataGridViewRow row in dgvLista.Rows)
                            {
                                subtotal += Convert.ToDouble(row.Cells["total"].Value);
                            }
                        
                            msksubtotal.Text = Convert.ToString(subtotal);
                           
                            subtotcalc = int.Parse(msksubtotal.Text);

                            ivas = subtotcalc * 0.19;
                            ivam = mobra * 0.19;
                            iva = ivam + ivas;
                            sub = subtotal + mobra;
                            txtIVA.Text = "" + iva;
                            msksubtotal.Text = "" + sub;
                            resultado = iva + sub;
                            txtTotal.Text = "" + resultado;

              

                            foreach (DataGridViewRow row in dgvLista.Rows)
                            {

                                costo += Convert.ToDouble(row.Cells["PrecioCosto"].Value);

                            }
                   
                            lblcosto.Text = Convert.ToString(costo);

                    



                        }

                        else
                        {
                            MessageBox.Show("ERROR");
                        }

                    }

                        #endregion operatoria
                }


            }


            catch
            {
                MessageBox.Show("no existe el producto");
            }
            
        }
   
        private void consultardeInforme()
        {
            claseBD Cbd = new claseBD();
            MySqlDataReader Rec = null;

            try
            {
                string consultacaja = "select cant,nombre from "+dateTimePicker1.Text+" where nombre = '"+lblNombreprodCaptura.Text+"'";
                Cbd.AbrirConexion();
                Rec = Cbd.EjecutarConsulta(consultacaja);
                while (Rec.Read())
                {
                    cant = double.Parse(Rec["cant"].ToString());
                    nombreinf = Rec["nombre"].ToString();
                    nombrecomp = Rec["nombre"].ToString();
                   
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
       
        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            ingresogrdcaja(e);
            llenarDgvCaja();
        
           
        }
        private void llenarDgvCaja()
        {
            string CadSql;
            CadSql = "select * from caja";

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
                   
                    dgvLista.Rows[fila].Cells[0].Value = Rec["nombre"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["codigo"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["precio"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["cant"].ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["total"].ToString();
                    dgvLista.Rows[fila].Cells[5].Value = Rec["costo"].ToString();
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

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Letra = e.KeyChar;
            if (!char.IsDigit(Letra) && Letra != ',' && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
            if(txtCant.Text.Length>4)
            {
                if ( e.KeyChar != '\b')
                {
                    e.KeyChar = Convert.ToChar(0);
                }
            }

            ingresogrdcaja(e);
            llenarDgvCaja();
            
        }

        public void habilitarBoton()
        {
            this.Refresh();
            cmdConsultar.Enabled = true;
        }

        private void chBoxConfirmManoObra_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ingresogrdcaja(e);
            llenarDgvCaja();
            txtCodigoBarra.Clear();
           
        }


        private void frmGuiaDespacho_Load(object sender, EventArgs e)
        {
          
            claseBD CBd = new claseBD();
            string tablainforme = "create table " + dateTimePicker1.Text + "(nombre varchar(255) primary key, cant varchar(255), medida varchar(255))";
            CBd.EjecutarIUD2(tablainforme);
            //do
            //{
            //    dgvLista.Rows.RemoveAt(dgvLista.Rows.Count - 1);
            //} while (dgvLista.Rows.Count != 0);
            try
            {
          

            }
            catch
            {
            }
            lblverindex.Text = dgvLista.TabIndex.ToString();

            //string truncaja = "truncate table caja";
            //CBd.EjecutarIUD2(truncaja);
            llenarDgvCaja();
            //MySqlDataReader Rec = null;
            //try
            //{
            //    string CadSql;
            //    CadSql = "select * from informes";
            //    CBd.AbrirConexion();
            //    Rec = CBd.EjecutarConsulta(CadSql);


            //    while (Rec.Read())
            //    {

            //        string informe = Rec["informes"].ToString();
            //        if (informe == dateTimePicker1.Text)
            //        {
                        
            //        }
            //        else
            //        {
            //            string insertarnumero = "insert into informe values (" + dateTimePicker1.Text + ")";
            //            CBd.EjecutarIUD(insertarnumero);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    if (Rec != null)
            //    {
            //        Rec.Close();
            //        Rec = null;
            //    }
            //}
            double subtotal = 0, subtotcalc = 0, resultado = 0, ivam = 0, ivas = 0, mobra = 0, iva = 0, sub = 0;

            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["total"].Value);
            }

            msksubtotal.Text = Convert.ToString(subtotal);
        
            subtotcalc = int.Parse(msksubtotal.Text);

            ivas = subtotcalc * 0.19;
            ivam = mobra * 0.19;
            iva = ivam + ivas;
            sub = subtotal + mobra;
            txtIVA.Text = "" + iva;
            msksubtotal.Text = "" + sub;
            resultado = iva + sub;
            txtTotal.Text = "" + resultado;

            

        }
        private void consultacant()
        {
            string CadSql;
            CadSql = "select * from caja";

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

                    cant2 = double.Parse(Rec["cant"].ToString());
                   
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

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void msksubtotal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtIVA_TextChanged(object sender, EventArgs e)
        {

        }
    
        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                
                string canttt;
                double res = 0;
                String codBarra = this.dgvLista.CurrentRow.Cells["codigo"].Value.ToString();
                String cantidad = this.dgvLista.CurrentRow.Cells["Cantidad"].Value.ToString();
                String nombreupd = this.dgvLista.CurrentRow.Cells["nombre"].Value.ToString();
                double cantidaddecimal = double.Parse(cantidad);
                claseBD CBd = new claseBD();
                MySqlDataReader Rec = null;
                string cons = "select cant from " + dateTimePicker1.Text + " where nombre = '" + nombreupd + "'";
 


                try
                {

                    CBd.AbrirConexion();
                    Rec = CBd.EjecutarConsulta(cons);

                    while (Rec.Read())
                    {

                        canttt = Rec["cant"].ToString();

                        
                        res = double.Parse(canttt) - cantidaddecimal;
                        


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(" Debe  seleccionar  un  Producto  de  la  lista ", " ERROR ");
                }
                finally
                {
                    if (Rec != null)
                    {
                        Rec.Close();
                        Rec = null;
                    }

                }
          
                string updateinforme = "update " + dateTimePicker1.Text + " set cant =  '" + res.ToString() + "' where nombre = '" + nombreupd + "'";
                CBd.EjecutarIUD(updateinforme);
                string updatecaja = "delete from caja where codigo = '" + codBarra + "'";
                CBd.EjecutarIUD(updatecaja);

                llenarDgvCaja();


                double subtotal = 0, subtotcalc = 0, resultado = 0, ivam = 0, ivas = 0, mobra = 0, iva = 0, sub = 0;

                foreach (DataGridViewRow row in dgvLista.Rows)
                {
                    subtotal += Convert.ToDouble(row.Cells["total"].Value);
                }

                msksubtotal.Text = Convert.ToString(subtotal);

                subtotcalc = int.Parse(msksubtotal.Text);

                ivas = subtotcalc * 0.19;
                ivam = mobra * 0.19;
                iva = ivam + ivas;
                sub = subtotal + mobra;
                txtIVA.Text = "" + iva;
                msksubtotal.Text = "" + sub;
                resultado = iva + sub;
                txtTotal.Text = "" + resultado;
            }
            catch
            {
 
            }


            
           
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void eliminarporindex()
        {
 
        }
        private void dgvLista_SelectionChanged(object sender, EventArgs e)
        {
            //lblverindex.Text = dgvLista.CurrentRow.Index.ToString();
           

        }

        private void lblconsultacaja_Click(object sender, EventArgs e)
        {

        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {

        }

       


    }
}
