using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Prototipo1
{
    public partial class frmCajaTraspaso : Form
    {
        public frmCajaTraspaso()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //generainforme();
            if (dgvLista.RowCount > 0) 
            {     
                this.Hide();
                frmBoletaTraspaso bol = new frmBoletaTraspaso();
                bol.Show();
            }
            else
            {
                MessageBox.Show("INGRESE EL DETALLE PARA GENERAR LA BOLETA");
            }

        }
        private string idusu = null;
        public string bolid = null;
        public string nombreusu = null;
        private string idinf = null;
        private string idinftrue = null;
        private void obtieneidbol()
        {
            string CadSql222;
            CadSql222 = "Select tra_numero as tra_id from traspasos order by tra_id DESC LIMIT 1";

            claseBD CBd = new claseBD();
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql222);
                while (Rec.Read())
                {
                    bolid = Rec["tra_id"].ToString();
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
        //private void obtieneinformecajacontrue()
        //{
        //    string CadSql;
        //    CadSql = "select * from informe_caja where inf_impresion = 'true' order by inf_id DESC LIMIT 1";
        //    claseBD CBd = new claseBD();
        //    MySqlDataReader Rec = null;
        //    try
        //    {
        //        CBd.AbrirConexion();
        //        Rec = CBd.EjecutarConsulta(CadSql);
        //        while (Rec.Read())
        //        {
        //            idinftrue = Rec["inf_id"].ToString();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    finally
        //    {
        //        if (Rec != null)
        //        {
        //            Rec.Close();
        //            Rec = null;
        //        }
        //    }
        //}
        //private void obtieneinformecaja()
        //{
        //    string CadSql;
        //    CadSql = "select * from informe_caja where inf_fecha = '" + dateTimePicker1.Text + "' and inf_impresion = 'false' order by inf_id DESC LIMIT 1";
        //    claseBD CBd = new claseBD();
        //    MySqlDataReader Rec = null;
        //    try
        //    {
        //        CBd.AbrirConexion();
        //        Rec = CBd.EjecutarConsulta(CadSql);
        //        while (Rec.Read())
        //        {
        //            idinf = Rec["inf_id"].ToString();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    finally
        //    {
        //        if (Rec != null)
        //        {
        //            Rec.Close();
        //            Rec = null;
        //        }
        //    }
        //}
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count == 0)
            {

                claseBD cbd = new claseBD();
                string eliminarcaja = "truncate table caja";
                cbd.EjecutarIUD(eliminarcaja);
                frmGestionProductos gpp = new frmGestionProductos();
                gpp.Show();
                this.Hide();

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
        public string nombreprod, codBarra, Codinterno;
        public double total2 = 0,precioVenta = 0, precioCosto = 0, cantcaptura = 0, totalcost = 0, stock = 0, resstock = 0;
        public string CadSql;                    
        private double cant = 0;
        private double cant2 = 0;
        private void ingresogrdcaja(KeyPressEventArgs e)
        {
            try
            {       
                    if (txtCodigoBarra.Text == "")
                    {
                        
                    }

                    else
                    {

                        #region consulta
                        //Aqui hacer una operacion capturar el lenght del sato cod. Barra



                        //MessageBox.Show("LARGO ACTUAL DEL TEXTO EN EL CONTROL " + txtCodigoBarra.TextLength.ToString() + "Y EL SUBTRING ESTA EN : " + txtCodigoBarra.Text.Substring(0,7).ToString()); 
                        if (txtCodigoBarra.TextLength > 7)
                        {
                            if (txtCodigoBarra.TextLength > 7) //<-- EJEMPLO:  (txtCodigoBarra.Text.Subtring(2500001025)
                            {
                                CadSql = "select nombre_prod, cod_interno, cod_barra, precio_venta, precio_costo,medida,Stock,margen from productos where cod_barra= " + txtCodigoBarra.Text.Substring(0, 7) + " ";
                                txtCant.Text = txtCodigoBarra.Text.Substring(7);
                                
                            }
                            else if (txtCodigoBarra.TextLength > 8) //<-- EJEMPLO:  (txtCodigoBarra.Text.Subtring(25000010256)
                            {
                                CadSql = "select nombre_prod, cod_interno, cod_barra, precio_venta, precio_costo,medida,Stock,margen from productos where cod_barra= " + txtCodigoBarra.Text.Substring(0, 7) + " ";
                                txtCant.Text = txtCodigoBarra.Text.Substring(7);
                            }
                            else if (txtCodigoBarra.TextLength > 9) //<-- EJEMPLO:  (txtCodigoBarra.Text.Subtring(250000102567)
                            {
                                CadSql = "select nombre_prod, cod_interno, cod_barra, precio_venta, precio_costo,medida,Stock,margen from productos where cod_barra= " + txtCodigoBarra.Text.Substring(0, 7) + " ";
                                txtCant.Text = txtCodigoBarra.Text.Substring(7);
                            }
                            
                        }
                        else
                        {
                            CadSql = "select nombre_prod, cod_interno, cod_barra, precio_venta, precio_costo,medida,Stock,margen from productos where cod_interno= " + txtCodigoBarra.Text + " ";
                        }
                        //MessageBox.Show(CadSql.ToString());
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
                                double.Parse(lblPrecioVentaCaptura.Text = Rec["precio_venta"].ToString());
                                double.Parse(lblPrecioCostoCaptura.Text = Rec["precio_costo"].ToString());
                                lblmedidaCaptura.Text = Rec["medida"].ToString();
                                double.Parse(lblStockCaptura.Text = Rec["Stock"].ToString());
                                lblmargen.Text = Rec["margen"].ToString();



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
                        try
                        {
                            string consultacaja = "select * from caja_traspaso where nombre = '" + lblNombreprodCaptura.Text + "' ";
                            CBd.AbrirConexion();
                            Rec = CBd.EjecutarConsulta(consultacaja);
                            while (Rec.Read())
                            {
                                lblconsultacaja.Text = Rec["nombre"].ToString();
                                double.Parse(lbltotalprodcaja.Text = Rec["precio"].ToString());
                                double.Parse(lblcantcaja.Text = Rec["cant"].ToString());
                                double.Parse(lblcosto.Text = Rec["costo"].ToString());                          
                            }
                            nombreprod = lblNombreprodCaptura.Text;
                            codBarra = lblCodBarraCaptura.Text;
                            precioVenta = double.Parse(lblPrecioVentaCaptura.Text);
                            precioCosto = double.Parse(lblPrecioCostoCaptura.Text);
                            stock = double.Parse(lblStockCaptura.Text);
                            Codinterno = lblCodInternoCaptura.Text;
                            cantcaptura = double.Parse(txtCant.Text);
                            total2 = cantcaptura * precioVenta;
                            totalcost = cantcaptura * precioCosto;
                            resstock = stock - cantcaptura;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("EL PRODUCTO NO EXISTE");
                        }
                        finally
                        {
                            if (Rec != null)
                            {
                                Rec.Close();
                                Rec = null;
                            }
                        }
                       
                       int uno = 0;
                       if (Codinterno == txtCodigoBarra.Text || codBarra == txtCodigoBarra.Text.Substring(0,7))
                        {
                            

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


                                string updatecaja = "Update caja_traspaso Set cod_barra = '" + lblCodBarraCaptura.Text + "',precio = '" + lblPrecioCostoCaptura.Text + "',cant = '" + Convert.ToDouble(rescant) + "',total = '" + totales.ToString() + "',costo = '" + rescost + "' , margen = '" + lblmargen.Text + "' where nombre = '" + lblconsultacaja.Text + "' ";
                                CBd.EjecutarIUD(updatecaja);
                                //MessageBox.Show(updatecaja.ToString());
                                string updatestock = "update productos set Stock = '" + resstock.ToString() + "' where nombre_prod = '" + lblconsultacaja.Text + "' ";
                                CBd.EjecutarIUD(updatestock);
                                //MessageBox.Show(updatestock.ToString());
                                llenarDgvCaja();
                                txtCodigoBarra.Clear();
                                lblconsultacaja.Text = "";
                            }
                            else
                            {
                                string cadsql3 = "insert into caja_traspaso values('" + lblNombreprodCaptura.Text + "','" + lblCodInternoCaptura.Text + "','" + lblCodBarraCaptura.Text + "','" + lblPrecioCostoCaptura.Text + "','" + Convert.ToDouble(cantcaptura) + "','" + total2.ToString() + "','" + totalcost + "','" + lblmargen.Text + "')";
                                CBd.EjecutarIUD(cadsql3);
                                string updatestock = "update productos set Stock =  '" + resstock.ToString() + "' where nombre_prod = '" + lblNombreprodCaptura.Text + "' ";
                                CBd.EjecutarIUD(updatestock);
                                llenarDgvCaja();
                                txtCodigoBarra.Clear();
                                lblconsultacaja.Text = "";
                               
                            }
                            double costo = 0, subtotal = 0, subtotcalc = 0, resultado = 0, ivam = 0, ivas = 0, mobra = 0, iva = 0, sub = 0;

                            foreach (DataGridViewRow row in dgvLista.Rows)
                            {
                                subtotal += Convert.ToDouble(row.Cells["total"].Value);
                            }
                        
                            msksubtotal.Text = Convert.ToString(subtotal);
                           
                            subtotcalc = double.Parse(msksubtotal.Text);

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
                            lblprecioculture.Text = Convert.ToDouble(msksubtotal.Text).ToString("c", CultureInfo.CreateSpecificCulture("es-CL"));
                        }

                        else
                        {
                            txtCodigoBarra.Text = "";
                        }

                    }

                        #endregion operatoria
                }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }   
        }
        //private void consultardeInforme()
        //{
        //    claseBD Cbd = new claseBD();
        //    MySqlDataReader Rec = null;

        //    try
        //    {
        //        string consultacaja = "select cant,nombre from "+dateTimePicker1.Text+" where nombre = '"+lblNombreprodCaptura.Text+"' ";
        //        Cbd.AbrirConexion();
        //        Rec = Cbd.EjecutarConsulta(consultacaja);
        //        while (Rec.Read())
        //        {
        //            cant = double.Parse(Rec["cant"].ToString());
        //            nombreinf = Rec["nombre"].ToString();
        //            nombrecomp = Rec["nombre"].ToString();
                   
                 
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
               
        //        if (Rec != null)
        //        {
        //            Rec.Close();
        //            Rec = null;
        //        }
        //    }
        //}       
        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {            
            ingresogrdcaja(e);
            llenarDgvCaja();
        }
        private void llenarDgvCaja()
        {
            string CadSql;
            CadSql = "select * from caja_traspaso";

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
                    dgvLista.Rows[fila].Cells[1].Value = Rec["cod_barra"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["precio"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["cant"].ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["costo"].ToString();
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
        public int id = 0;
        private void frmGuiaDespacho_Load(object sender, EventArgs e)
        {
            txtCodigoBarra.Focus();
            obtieneUsu2();
            lblverindex.Text = dgvLista.TabIndex.ToString();
            llenarDgvCaja();
            double subtotal = 0, subtotcalc = 0, resultado = 0, ivam = 0, ivas = 0, mobra = 0, iva = 0, sub = 0;

            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["total"].Value);
            }

            msksubtotal.Text = Convert.ToString(subtotal);
        
            subtotcalc = double.Parse(msksubtotal.Text);

            ivas = subtotcalc * 0.19;
            ivam = mobra * 0.19;
            iva = ivam + ivas;
            sub = subtotal + mobra;
            txtIVA.Text = "" + iva;
            msksubtotal.Text = "" + sub;
            resultado = iva + sub;
            txtTotal.Text = "" + resultado;
            lblprecioculture.Text = Convert.ToDouble(msksubtotal.Text).ToString("c", CultureInfo.CreateSpecificCulture("es-CL"));

        }
        private void consultacant()
        {
            string CadSql;
            CadSql = "select * from caja_traspaso";

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

       
        
        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                
                string canttt;
                string stockstring;
                double res = 0,resstock = 0,stock;
                String codBarra = this.dgvLista.CurrentRow.Cells["codigo"].Value.ToString();
                String cantidad = this.dgvLista.CurrentRow.Cells["Cantidad"].Value.ToString();
                String nombreupd = this.dgvLista.CurrentRow.Cells["nombre"].Value.ToString();
                double cantidaddecimal = double.Parse(cantidad);
                claseBD CBd = new claseBD();
                MySqlDataReader Rec = null;
                string cons = "select * from productos where cod_barra = "+codBarra+" " ;
               


                try
                {

                    CBd.AbrirConexion();
                    Rec = CBd.EjecutarConsulta(cons);

                    while (Rec.Read())
                    {

                        stockstring = Rec["Stock"].ToString();
                        


                        resstock = cantidaddecimal + double.Parse(stockstring);

                        

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



                string updatestock = "update productos set Stock = '" + resstock.ToString() + "' where nombre_prod = '" + nombreupd + "' ";
                CBd.EjecutarIUD(updatestock);
         

                string updatecaja = "delete from caja_traspaso where cod_barra = '" + codBarra + "'";
                CBd.EjecutarIUD(updatecaja);

                llenarDgvCaja();


                double subtotal = 0, subtotcalc = 0, resultado = 0, ivam = 0, ivas = 0, mobra = 0, iva = 0, sub = 0;
                if (dgvLista.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvLista.Rows)
                    {
                        subtotal += Convert.ToDouble(row.Cells["total"].Value);
                    }

                    msksubtotal.Text = subtotal.ToString();

                    subtotcalc = double.Parse(msksubtotal.Text);

                    ivas = subtotcalc * 0.19;
                    ivam = mobra * 0.19;
                    iva = ivam + ivas;
                    sub = subtotal + mobra;
                    txtIVA.Text = "" + iva;
                    msksubtotal.Text = "" + sub;
                    resultado = iva + sub;
                    txtTotal.Text = "" + resultado;
                    lblprecioculture.Text = Convert.ToDouble(msksubtotal.Text).ToString("c", CultureInfo.CreateSpecificCulture("es-CL"));
                }
                else
                {
                    lblprecioculture.Text = Convert.ToDouble("0").ToString("c", CultureInfo.CreateSpecificCulture("es-CL"));
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR DE SISTEMA ::" + ex.ToString());
            }
         
           
        }

        private void txtCodigoBarra_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoBarra.TextLength > 12)
            {
                SendKeys.Send("{ENTER}");
            }
            else
            { }
        }

        private void txtCodigoBarra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //if(txtCodigoBarra.TextLength > 12)
            //{
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                if (dgvLista.RowCount > 0)
                {
                    this.Hide();
                    frmBoletaTraspaso bol = new frmBoletaTraspaso();
                    bol.Show();
                }
                else
                {
                    MessageBox.Show("INGRESE EL DETALLE PARA GENERAR LA BOLETA");
                }
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ingresogrdcaja(e);
                llenarDgvCaja();
                try
                {
                    lblprecioculture.Text = Convert.ToInt32(msksubtotal.Text).ToString("c", CultureInfo.CreateSpecificCulture("es-CL"));
                    txtCant.Text = "";
                }
                catch
                {
                    lblprecioculture.Text = Convert.ToDouble(msksubtotal.Text).ToString("c", CultureInfo.CreateSpecificCulture("es-CL"));
                }
                txtCodigoBarra.Focus();
            }
            //}
            //else
            //{}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void obtieneUsu2()
        {
            string CadSql222;
            CadSql222 = "Select * from ingreso_usuario_caja order by iuc_id DESC LIMIT 1";

            claseBD CBd = new claseBD();
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql222);
                while (Rec.Read())
                {
                    idusu = Rec["usu_id"].ToString();
                    nombreusu = Rec["iuc_nombre"].ToString();
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
        //private void impresionproductos(System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    obtieneUsu2();
        //    string CadSql;
        //    CadSql = "select * from informe_caja where inf_fecha = '"+dateTimePicker1.Text+"' and inf_impresion = 'false' order by inf_id DESC LIMIT 1";

        //    claseBD CBd = new claseBD();
        //    int y = 0;


        //    MySqlDataReader Rec = null;
        //    try
        //    {
        //        CBd.AbrirConexion();
        //        Rec = CBd.EjecutarConsulta(CadSql);

        //        while (Rec.Read())
        //        {

        //            int ladoa = 51, altob = 13, altoa = 6, ladob = 56;
        //            string ef, cr, db, tt,idd,bolini,bolfin;

        //            string precioenletras2, nf, rut, razon, direccion, ciudad, comuna, giro, fono, nfactura, fechafact, vcto, vendedor, totales, iva, neto, exento, precioenletras;
        //            ef = Rec["inf_efectivo"].ToString();
        //            db = Rec["inf_debito"].ToString();
        //            cr = Rec["inf_credito"].ToString();
        //            tt = Rec["inf_total"].ToString();
        //            bolini = Rec["inf_boleta_inicio"].ToString();                    
        //            bolfin = Rec["inf_boleta_final"].ToString();
        //            if (bolfin == "0")
        //            {
        //                bolfin = Rec["inf_boleta_inicio"].ToString();
        //            }
        //            else
        //            {
        //                bolfin = Rec["inf_boleta_final"].ToString();
        //            }
        //            idd = Rec["inf_id"].ToString();
        //            idinf = Rec["inf_id"].ToString();
        //            e.Graphics.DrawString(" INFORME DE CAJA  " + dateTimePicker1.Text, new Font("Arial ", 12), Brushes.Black, new Point(2, 0));
        //            e.Graphics.DrawString(" VENTAS DEBITO    $" + db, new Font("Arial", 12), Brushes.Black, new Point(2, 60));
        //            e.Graphics.DrawString(" VENTAS EFECTIVO  $" + ef, new Font("Arial ", 12), Brushes.Black, new Point(2, 90));
        //            e.Graphics.DrawString(" VENTAS CREDITO   $" + cr, new Font("Arial ", 12), Brushes.Black, new Point(2, 120));
        //            e.Graphics.DrawString(" VENTAS TOTALES   $" + tt, new Font("Arial Black", 12), Brushes.Black, new Point(2, 150));
        //            e.Graphics.DrawString("CAJERO: " + nombreusu + " , ID: " +idusu.ToString(), new Font("Arial Black", 12), Brushes.Black, new Point(2, 180));
        //            e.Graphics.DrawString("Informe N°: "+idinf, new Font("Arial Black", 12), Brushes.Black, new Point(420, 90));
        //            e.Graphics.DrawString("Fecha y Hora: " + DateTime.Now.ToString(), new Font("Arial", 12), Brushes.Black, new Point(420, 120));
        //            e.Graphics.DrawString("BOLETA INICIAL:" + bolini + " , BOLETA FINAL:" + bolfin, new Font("Arial", 12), Brushes.Black, new Point(420, 150));
        //        }

        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {

        //        if (Rec != null)
        //        {
        //            Rec.Close();
        //            Rec = null;
        //        }
                
        //    }
        //}
        //private void generainforme()
        //{
        //    obtieneidbol();
        //    //obtieneinformecajacontrue();
        //    try
        //    {
        //        claseBD cbdd = new claseBD();
        //        string consqlinforme = "INSERT INTO informe_caja(inf_fecha,inf_boleta_inicio) SELECT '" + dateTimePicker1.Text + "',"+int.Parse(bolid)+" FROM dual WHERE NOT EXISTS (SELECT inf_id FROM informe_caja WHERE inf_id = "+int.Parse(idinftrue)+"+1  LIMIT 1)";
        //        cbdd.EjecutarConsulta2(consqlinforme);
        //        cbdd.CerrarConexion();
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("AQUI" + ex.ToString());
        //    }
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            ////generainforme();
            //if (printDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    printDocument1.Print();
            //}
            //else
            //{
 
            //}
        }
        //private void updateinforme()
        //{
        //    if (idinf == null)
        //    {
        //        generainforme();
        //    }
        //    else
        //    {
        //        claseBD cbd = new claseBD();
        //        string efect = "update informe_caja set inf_impresion = 'true' where inf_id = " + int.Parse(idinf) + " and inf_impresion = 'false' ";
        //        cbd.EjecutarIUD(efect);
        //        cbd.CerrarConexion();
        //    }
        //}
        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{           
        //    obtieneUsu2();
        //    obtieneinformecaja();
        //    impresionproductos(e);
        //    updateinforme();
        //}

        private void frmGuiaDespacho_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmGuiaDespacho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (dgvLista.RowCount > 0)
                {
                    this.Hide();
                    frmBoletaTraspaso bol = new frmBoletaTraspaso();
                    bol.Show();
                }
                else
                {
                    MessageBox.Show("INGRESE EL DETALLE PARA GENERAR LA BOLETA");
                }
            }
        }

        private void dgvLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                if (dgvLista.RowCount > 0)
                {
                    this.Hide();

                    frmBoletaTraspaso bol = new frmBoletaTraspaso();
                    bol.Show();
                }
                else
                {
                    MessageBox.Show("INGRESE EL DETALLE PARA GENERAR LA BOLETA");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            claseBD cbd = new claseBD();
            string updimp = "update impresion_parametros set imp_alto = "+txtimpre.Text+" ";
            cbd.EjecutarIUD(updimp);
            cbd.CerrarConexion();
        }

        private void frmGuiaDespacho_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}
