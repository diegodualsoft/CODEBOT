using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using System.Data.Common;

namespace Prototipo1
{
    public partial class frmBoletaTraspaso : Form
    {
        public frmBoletaTraspaso()
        {
            InitializeComponent();
        }
        private void lblboleta_Click(object sender, EventArgs e)
        {

        }
        public string idusu = null;
        public string nombreusu = null;
        public string idinf = null;
        public int altoa = -100;
        private DataTable llenarCbx(string sql)
        {
            claseBD cbd = new claseBD();
            cbd.AbrirConexion();
            string str = sql;
            DataTable dt = new DataTable();
            MySqlCommand cmd = claseBD.conex.CreateCommand();
            ((DbCommand)cmd).CommandText = str;
            ((DbDataAdapter)new MySqlDataAdapter(cmd)).Fill(dt);
            cbd.CerrarConexion();
            return dt;
        }
        private void impresionproductos(System.Drawing.Printing.PrintPageEventArgs e)
        {
            double canttraspaso = 0, costotraspaso = 0;
            string CadSql;
            CadSql = "select * from caja_traspaso";
            claseBD CBd = new claseBD();
            int y = 0;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                while (Rec.Read())
                {
                    int ladoa = 51, altob = 6, ladob = 56;
                    
                    string b1, b2, b3, b4, b5,fecha;
                    string precioenletras2, nf, rut, razon, direccion, ciudad, comuna, giro, fono, nfactura, fechafact, vcto, vendedor, totales, iva, neto, exento, precioenletras;
                    totales = lbltotal.Text;
                    b1 = Rec["nombre"].ToString();
                    b2 = Rec["costo"].ToString();
                    b3 = Rec["cant"].ToString();
                    b4 = Rec["total"].ToString();
                    b5 = Rec["cod_barra"].ToString();
                    costotraspaso = costotraspaso + double.Parse(Rec["costo"].ToString());
                    canttraspaso = canttraspaso + double.Parse(Rec["cant"].ToString());
                    fecha = DateTime.Now.ToShortDateString();
                    //e.PageSettings.PaperSize.Height = 140;
                    //e.PageSettings.PaperSize.Width = 140;
                    //e.PageSettings.PaperSize.RawKind =  (int)PaperKind.Custom;
                    e.Graphics.DrawString(" TRASPASO DE MERCADERIA  " + fecha + " ,   GUIA REF N° " + txtGuiaRef.Text +", TRASPASO N°"+lblNumFact.Text, new Font("Arial Black", 12), Brushes.Black, new Point(2, 5)); //aqui
                    e.Graphics.DrawString(" CODIGO | NOMBRE PRODUCTO  | CANTIDAD | COSTO TRASPASO ", new Font("Arial", 13), Brushes.Black, new Point(4, 80)); //aqui
                    e.Graphics.DrawString("DESDE: " + cbxDesde.Text +" -> HACIA: " + cbxHacia.Text, new Font("Arial", 13), Brushes.Black, new Point(4, 40)); //aqui
                    e.Graphics.DrawString(b1, new Font("Arial", 12), Brushes.Black, new Point(120, 205 + y + altoa));
                    e.Graphics.DrawString(b3, new Font("Arial", 12), Brushes.Black, new Point(210, 205 + y+altoa));
                    e.Graphics.DrawString(b5, new Font("Arial", 12), Brushes.Black, new Point(22, 205 + y + altoa));
                    e.Graphics.DrawString("$" + b2, new Font("Arial", 12), Brushes.Black, new Point(450, 205 + y + altoa));
                   
                    y = y + 16;

                   ////segundo respaldo de impresion 

                   // totales = lbltotal.Text;
                   // b1 = Rec["nombre"].ToString();
                   // b2 = Rec["costo"].ToString();
                   // b3 = Rec["cant"].ToString();
                   // b4 = Rec["total"].ToString();
                   // b5 = Rec["cod_barra"].ToString();
                   // costotraspaso = Rec["sumcost"].ToString();
                   // fecha = DateTime.Now.ToShortDateString();
                   // //e.PageSettings.PaperSize.Height = 140;
                   // //e.PageSettings.PaperSize.Width = 140;
                   // //e.PageSettings.PaperSize.RawKind =  (int)PaperKind.Custom;
                   // e.Graphics.DrawString(" TRASPASO DE MERCADERIA  " + fecha, new Font("Arial", 13), Brushes.Black, new Point(4, 5+500)); //aqui
                   // e.Graphics.DrawString(" CANTIDAD | CODIGO  | NOBRE/COSTO KG  |      COSTO TRASPASO ", new Font("Arial", 13), Brushes.Black, new Point(4, 70+500)); //aqui
                   // e.Graphics.DrawString("DESDE: " + cbxDesde.Text + " -> HACIA: " + cbxHacia.Text, new Font("Arial", 13), Brushes.Black, new Point(4, 30+500)); //aqui
                   // e.Graphics.DrawString(b5, new Font("Arial", 12), Brushes.Black, new Point(90, 220 + y + altoa+500));
                   // e.Graphics.DrawString(b1 + " x  $" + b2 + "kg", new Font("Arial", 12), Brushes.Black, new Point(180, 220 + y + altoa+500));
                   // e.Graphics.DrawString(b3, new Font("Arial", 12), Brushes.Black, new Point(8, 220 + y + altoa+500));
                   // e.Graphics.DrawString("$" + b4, new Font("Arial", 12), Brushes.Black, new Point(450, 220 + y + altoa+500));
                   // e.Graphics.DrawString("COSTO TOTAL TRASPASO $ " + costotraspaso, new Font("Arial", 12), Brushes.Black, new Point(16, 260+y + altoa+500));
                   // y = y + 16;
                }
                e.Graphics.DrawString("CANTIDAD TOTAL TRASPASO : " + canttraspaso, new Font("Arial Black", 12), Brushes.Black, new Point(16, 220+y + altoa));
                e.Graphics.DrawString("__________________" , new Font("Arial Black", 12), Brushes.Black, new Point(16, 260 + y + altoa));
                e.Graphics.DrawString("FIRMA : " + nombreusu, new Font("Arial Black", 12), Brushes.Black, new Point(16, 285 + y + altoa));
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
        public int bolid;
        private void frmBoleta_Load(object sender, EventArgs e)
        {
            DataTable d = llenarCbx("Select loc_id, loc_direccion from locales;");
            cbxDesde.DataSource = d;
            cbxDesde.DisplayMember = "loc_id"+"loc_direccion";
            cbxDesde.ValueMember = "loc_direccion";
            cbxDesde.SelectedIndex = 0;
            DataTable h = llenarCbx("Select loc_id, loc_direccion from locales;");
            cbxHacia.DataSource = h;
            cbxHacia.DisplayMember = "loc_id"+"loc_direccion";
            cbxHacia.ValueMember = "loc_direccion";
            cbxHacia.SelectedIndex = 0;
            obtieneidbol();
            llenarDGV();                    
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
        string locdir = null;
        private void obtieneidlocaldestino()
        {
            string CadSql222;
            CadSql222 = "Select loc_id from locales where loc_direccion = '"+cbxHacia.Text+"' ";

            claseBD CBd = new claseBD();
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql222);
                while (Rec.Read())
                {
                    locdir = Rec["loc_id"].ToString();
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
            lblidLocal.Text = locdir;
        }
        private void obtieneidbol()
        {
            string CadSql222;
            CadSql222 = "Select tra_id from traspasos order by tra_id DESC LIMIT 1";

            claseBD CBd = new claseBD();
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql222);
                while (Rec.Read())
                {
                    bolid = int.Parse(Rec["tra_id"].ToString());
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
            lblNumFact.Text = bolid.ToString(); 
        }
        private void llenarDGV()
        {
            string CadSql;
            CadSql = "select * from caja_traspaso ";
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
                    dgvLista.Rows[fila].Cells[6].Value = Rec["cod_interno"].ToString();
                    dgvLista.Rows[fila].Cells[7].Value = Rec["margen"].ToString();
                    
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
            try
            {
                double subtotal = 0;
                foreach (DataGridViewRow row in dgvLista.Rows)
                {
                    subtotal += Convert.ToDouble(row.Cells["total"].Value);
                    txtefectivo.Text = Convert.ToInt32(subtotal).ToString();
                    lbltotal.Text = Convert.ToInt32(subtotal).ToString();
                    txttotal.Text = Convert.ToInt32(subtotal).ToString("c", CultureInfo.CreateSpecificCulture("es-CL"));
                }
            }
            catch
            {
 
            }

        }
        public string vari = null;
        private void agregarankdetalle()
        {
            try
            {
                claseBD.conex = new MySqlConnection("Server=dualsoft.ddns.net;Database=db_patagonia;Uid=admin;Pwd='admin'");
                claseBD cbBd = new claseBD();
                foreach (DataGridViewRow row2 in dgvLista.Rows)
                {
                    string insertadetalle = "insert into traspasos_detalle(tra_numero,trd_cant,trd_precio_producto,trd_nombre_producto,trd_codigo,trd_codigo_interno,trd_valor_total,trd_precio_costo,trd_margen,trd_destino_loc_id) values (" + bolid + ",'" + row2.Cells["Cantidad"].Value.ToString() + "','" + double.Parse(row2.Cells["precio"].Value.ToString()) + "','" + row2.Cells["nombre"].Value.ToString() + "','" + row2.Cells["codigo"].Value.ToString() + "',"+row2.Cells["codinterno"].Value.ToString()+",'" + row2.Cells["total"].Value.ToString() + "','" + row2.Cells["PrecioCosto"].Value.ToString() + "','"+row2.Cells["margen"].Value.ToString()+"','"+lblidLocal.Text+"') ";
                    cbBd.EjecutarIUD(insertadetalle);
                }
                cbBd.CerrarConexion();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void truncajaygrillas()
        {
            claseBD cbd = new claseBD();
            string truncaja = "truncate table caja_traspaso";
            string trungrilla = "truncate table grillafactura";
            cbd.EjecutarIUD(truncaja);
            cbd.EjecutarIUD(trungrilla);
        }
        private void insertboleta()
        {
            bolid = bolid + 1; 
            claseBD.conex = new MySqlConnection("Server=dualsoft.ddns.net;Database=db_patagonia;Uid=admin;Pwd='admin'");
            claseBD cbdremoto = new claseBD();
            string csql = "insert into traspasos (tra_numero,tra_fecha,tra_hora,tra_total_traspaso,tra_cajero,tra_caja,tra_destino,tra_desde,tra_numero_guia) values (" + bolid + ",'" + dateTimePicker1.Text + "','" + DateTime.Now.ToShortTimeString() + "','" + lbltotal.Text + "','" + nombreusu + "',1,'"+cbxHacia.Text+"','"+cbxDesde.Text+"','"+txtGuiaRef.Text+"')";
            cbdremoto.EjecutarConsulta(csql);
            cbdremoto.CerrarConexion();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            obtieneUsu2();
            insertboleta();
            obtieneidbol();
            agregarankdetalle();
            printDocument1.Print();
            truncajaygrillas(); 
            this.Hide();
            
            frmCajaTraspaso cj = new frmCajaTraspaso();
            cj.Show();            
        }   
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            impresionproductos(e);
        }

        private void txtefectivo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtefectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void frmBoleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //efectivo
            if (e.KeyChar == Convert.ToChar(Keys.F1))
            {
                
                txtefectivo.Text = txttotal.Text;
            }
            //debito
            if (e.KeyChar == Convert.ToChar(Keys.F2))
            {
                txttotal.Text = txtdebito.Text;
            }
            //credito
            if (e.KeyChar == Convert.ToChar(Keys.F1))
            {
                txttotal.Text = txtcredito.Text;
            }
        }

        private void txtdebito_TextChanged(object sender, EventArgs e)
        {
            if (txtdebito.Text == "")
            {
                txtdebito.Text = "0";
            }
            if(txtcredito.Text == "")
            {
                txtcredito.Text = "0";
            }
            int a=0, b=0, c = 0, res;
            double subtotal = 0;
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["total"].Value);
                txtefectivo.Text = Convert.ToInt32(subtotal).ToString();
                lbltotal.Text = Convert.ToInt32(subtotal).ToString();
                txttotal.Text = Convert.ToInt32(subtotal).ToString("c", CultureInfo.CreateSpecificCulture("es-CL"));
            }

            a = Convert.ToInt32(subtotal);
            b = int.Parse(txtdebito.Text);
            c = int.Parse(txtcredito.Text);
          
            res = a-b-c;

            int.Parse(txtefectivo.Text = ""+res);


        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcredito_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtdebito.Text == "")
                {
                    txtdebito.Text = "0";

                }
                if (txtcredito.Text == "")
                {
                    txtcredito.Text = "0";
                }
                int a = 0, b = 0, c = 0, res;
                double subtotal = 0;
                foreach (DataGridViewRow row in dgvLista.Rows)
                {
                    subtotal += Convert.ToDouble(row.Cells["total"].Value);
                    txtefectivo.Text = Convert.ToInt32(subtotal).ToString();
                    lbltotal.Text = Convert.ToInt32(subtotal).ToString();
                    txttotal.Text = Convert.ToInt32(subtotal).ToString("c", CultureInfo.CreateSpecificCulture("es-CL"));
                }
                a = Convert.ToInt32(subtotal);
                b = int.Parse(txtdebito.Text);
                c = int.Parse(txtcredito.Text);
                res = a - b - c;
                int.Parse(txtefectivo.Text = "" + res);
            }
            catch
            {
 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            frmCajaTraspaso fgp = new frmCajaTraspaso();
            fgp.Show();
        }

        private void txtdebito_Enter(object sender, EventArgs e)
        {
            txtdebito.SelectAll();
        }

        private void txtdebito_Click(object sender, EventArgs e)
        {
                txtdebito.SelectAll();
        }

        private void cbxHacia_SelectedValueChanged(object sender, EventArgs e)
        {
            obtieneidlocaldestino();
        }
    }
}
