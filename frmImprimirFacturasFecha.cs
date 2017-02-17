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
    public partial class frmImprimirFacturasFecha : Form
    {
        public frmImprimirFacturasFecha()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void llenard()
        {
            string CadSql;
            CadSql = "select * from nfactimpresion where fecha = '"+dateTimePicker1.Text+"';";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {

                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dataGridView2.RowCount = 0;
                while (Rec.Read())
                {
                    dataGridView2.RowCount = dataGridView2.RowCount + 1;
                    fila = dataGridView2.RowCount - 1;
                    dataGridView2.Rows[fila].Cells[0].Value = Rec["rut"].ToString();
                    dataGridView2.Rows[fila].Cells[1].Value = Rec["n_fact"].ToString();
                    dataGridView2.Rows[fila].Cells[2].Value = Rec["fecha"].ToString();
                    dataGridView2.Rows[fila].Cells[3].Value = Rec["razon"].ToString();

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
        
        
        private void Form2_Load(object sender, EventArgs e)
        {
            llenard();
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void llenardgvfacts()
        {
            string CadSql;
            CadSql = "select * from nfactimpresion where fecha = '"+dateTimePicker1.Text+"';";
            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {                
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dataGridView2.RowCount = 0;
                while (Rec.Read())
                {
                    dataGridView2.RowCount = dataGridView2.RowCount + 1;
                    fila = dataGridView2.RowCount - 1;
                    dataGridView2.Rows[fila].Cells[0].Value = Rec["rut"].ToString();
                    dataGridView2.Rows[fila].Cells[1].Value = Rec["n_fact"].ToString();  
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
        private void impresiongrafhoja(System.Drawing.Printing.PrintPageEventArgs e)
        {
            int b = -3, c = -3, x = 0, y = 0;
            int z = 0, v = 0;
            int aument = 0;

            
            for (int i = 0; i < 86; i++)
            {
               
                e.Graphics.DrawString(z.ToString(), new Font("Arial", 6), Brushes.Black, new Point(b+y+aument,c));
                e.Graphics.DrawString(v.ToString(), new Font("Arial", 6), Brushes.Black, new Point(b, c+x+aument));
                aument = aument + 100;
                z = z + 1;
                v = v + 1;
                y = y + 100;
                x = x + 50;

            }
         
          
            
        }
        private void impresionproductos(System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            string CadSql;
            CadSql = "select rut,nombre_contacto,numero_factura,razon_social,direccion,comuna,ciudad,giro,fecha,subtotales,iva,totales,codigo,nombre_producto,precio_venta,cantidad,total,vendedor,palabras,palabras2,vcto,NF,telefono from " + r + "_" + nd + " ;";

            claseBD CBd = new claseBD();
            int y = 0;
            
            
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);

                while (Rec.Read())
                {

                    int ladoa = 51, altob = 13, altoa = 6, ladob = 56;
                    string b1, b2, b3, b4, b5;

                    string precioenletras2,nf,rut,razon,direccion,ciudad,comuna,giro,fono,nfactura,fechafact,vcto,vendedor,totales,iva,neto,exento,precioenletras;
                        
                    razon = Rec["razon_social"].ToString();
                    direccion = Rec["direccion"].ToString();
                    ciudad = Rec["ciudad"].ToString();
                    comuna = Rec["comuna"].ToString();
                    giro = Rec["giro"].ToString();
                    fono = Rec["telefono"].ToString();
                    nfactura =Rec["numero_factura"].ToString();
                    fechafact =Rec["fecha"].ToString();
                    nf = Rec["NF"].ToString();
                    vcto = Rec["vcto"].ToString();                   
                    vendedor= Rec["vendedor"].ToString();
                    totales = Rec["totales"].ToString();
                    totales = "$"+totales;
                    precioenletras2 = Rec["palabras2"].ToString();
                    iva = Rec["iva"].ToString();
                    iva = "$" + iva;
                    neto = Rec["subtotales"].ToString();
                    neto = "$" + neto;
                    precioenletras = Rec["palabras"].ToString();
                    b1 = Rec["nombre_producto"].ToString();
                    b2 = Rec["precio_venta"].ToString();
                    b3 = Rec["cantidad"].ToString();
                    b4 = Rec["total"].ToString();
                    b5 = Rec["codigo"].ToString();
                    rut = Rec["rut"].ToString();
        

                    if (b5 == "" && b2 == "" && b4 == "")
                    {
                       
                       
                        string rutFormateado = String.Empty;

                        //obtengo la parte numerica del RUT
                        string rutTemporal = r.Substring(0, r.Length - 1);

                        //obtengo el Digito Verificador del RUT
                        string dv = r.Substring(r.Length - 1, 1);

                        Int64 rutin;

                        //aqui convierto a un numero el RUT si ocurre un error lo deja en CERO
                        if (!Int64.TryParse(rutTemporal, out rutin))
                        {
                            rutin = 0;
                        }

                        //este comando es el que formatea con los separadores de miles
                        rutFormateado = rutin.ToString("N0");

                        if (rutFormateado.Equals("0"))
                        {
                            rutFormateado = string.Empty;
                        }
                        else
                        {
                            //si no hubo problemas con el formateo agrego el DV a la salida
                            rutFormateado += "-" + dv;

                            //y hago este replace por si el servidor tuviese configuracion anglosajona y reemplazo las comas por puntos
                            rutFormateado = rutFormateado.Replace(",", ".");
                        }
 

                        e.Graphics.DrawString("N/F : " + nf, new Font("Arial", 7), Brushes.Black, new Point(56 - ladob + 1, 212 - altoa + 1));
                        e.Graphics.DrawString(precioenletras, new Font("Arial", 10), Brushes.Black, new Point(5, 459));
                        e.Graphics.DrawString(precioenletras2, new Font("Arial", 10), Brushes.Black, new Point(5, 479));
                        e.Graphics.DrawString(fono, new Font("Arial", 7), Brushes.Black, new Point(246 - ladob + 1, 158 - altoa + 1));
                        e.Graphics.DrawString(vendedor, new Font("Arial", 7), Brushes.Black, new Point(717 - ladob + 1, 232 - altoa + 1));
                        e.Graphics.DrawString(vcto, new Font("Arial", 7), Brushes.Black, new Point(626 - ladob + 1, 232 - altoa + 1));
                        e.Graphics.DrawString("0", new Font("Arial", 12), Brushes.Black, new Point(444 - ladob + 1, 476 - altoa + 1));
                        e.Graphics.DrawString(fechafact, new Font("Arial", 7), Brushes.Black, new Point(525 - ladob + 1, 230 - altoa + 1));
                        e.Graphics.DrawString(nfactura, new Font("Arial", 7), Brushes.Black, new Point(430 - ladob + 1, 230 - altoa + 1));
                        e.Graphics.DrawString(razon, new Font("Arial", 7), Brushes.Black, new Point(82 - ladob + 1, 106 - altoa + 1));
                        e.Graphics.DrawString(rutFormateado, new Font("Arial", 7), Brushes.Black, new Point(61 - ladob + 1, 123 - altoa + 1));
                        e.Graphics.DrawString(direccion, new Font("Arial", 7), Brushes.Black, new Point(80 - ladob + 1, 141 - altoa + 1));
                        e.Graphics.DrawString(ciudad, new Font("Arial", 7), Brushes.Black, new Point(69 - ladob + 1, 158 - altoa + 1));
                        e.Graphics.DrawString(comuna, new Font("Arial", 7), Brushes.Black, new Point(78 - ladob + 1, 175 - altoa + 1));
                        e.Graphics.DrawString(giro, new Font("Arial", 7), Brushes.Black, new Point(56 - ladob + 1, 195 - altoa + 1));
                        e.Graphics.DrawString(b5, new Font("Arial", 12), Brushes.Black, new Point(50 - ladoa + 1, 275 + y - altob + 1));
                        e.Graphics.DrawString("" + b2, new Font("Arial", 12), Brushes.Black, new Point(595 - ladoa + 1, 275 + y - altob + 1));
                        e.Graphics.DrawString(b1, new Font("Arial", 12), Brushes.Black, new Point(180 - ladoa + 1, 275 + y - altob + 1));
                        e.Graphics.DrawString(b3, new Font("Arial", 12), Brushes.Black, new Point(120 - ladoa + 1, 275 + y - altob + 1));
                        e.Graphics.DrawString("" + b4, new Font("Arial", 12), Brushes.Black, new Point(695 - ladoa + 1, 275 + y - altob + 1));
                        e.Graphics.DrawString(totales, new Font("Arial", 12), Brushes.Black, new Point(709 - ladob + 1, 476 - altoa + 1));
                        e.Graphics.DrawString(iva, new Font("Arial", 12), Brushes.Black, new Point(609 - ladob + 1, 476 - altoa + 1));
                        e.Graphics.DrawString(neto, new Font("Arial", 12), Brushes.Black, new Point(509 - ladob + 1, 476 - altoa + 1));
                        y = y + 16;
                    }
                    else
                    {
                     
                        string rutFormateado = String.Empty;

                        //obtengo la parte numerica del RUT
                        string rutTemporal = r.Substring(0, r.Length - 1);

                        //obtengo el Digito Verificador del RUT
                        string dv = r.Substring(r.Length - 1, 1);

                        Int64 rutin;

                        //aqui convierto a un numero el RUT si ocurre un error lo deja en CERO
                        if (!Int64.TryParse(rutTemporal, out rutin))
                        {
                            rutin = 0;
                        }

                        //este comando es el que formatea con los separadores de miles
                        rutFormateado = rutin.ToString("N0");

                        if (rutFormateado.Equals("0"))
                        {
                            rutFormateado = string.Empty;
                        }
                        else
                        {
                            //si no hubo problemas con el formateo agrego el DV a la salida
                            rutFormateado += "-" + dv;

                            //y hago este replace por si el servidor tuviese configuracion anglosajona y reemplazo las comas por puntos
                            rutFormateado = rutFormateado.Replace(",", ".");
                        }
 

                        //sdgsdgsdtgsdgbhdfhdfhfd dfh dfhdfh dfh dfhd f hdfhdfh dfhdf hdfh dfh dfh dfh dh d
                        e.Graphics.DrawString(precioenletras2, new Font("Arial", 10), Brushes.Black, new Point(5, 479));

                        e.Graphics.DrawString(precioenletras, new Font("Arial", 10), Brushes.Black, new Point(5, 459));
                        e.Graphics.DrawString(fono, new Font("Arial", 7), Brushes.Black, new Point(246 - ladob + 1, 158 - altoa + 1));
                        e.Graphics.DrawString(vendedor, new Font("Arial", 7), Brushes.Black, new Point(717 - ladob + 1, 232 - altoa + 1));
                        e.Graphics.DrawString(vcto, new Font("Arial", 7), Brushes.Black, new Point(626 - ladob + 1, 232 - altoa + 1));
                        e.Graphics.DrawString("0", new Font("Arial", 12), Brushes.Black, new Point(444 - ladob + 1, 476 - altoa + 1));
                        e.Graphics.DrawString(fechafact, new Font("Arial", 7), Brushes.Black, new Point(525 - ladob + 1, 230 - altoa + 1));
                        e.Graphics.DrawString(nfactura, new Font("Arial", 7), Brushes.Black, new Point(430 - ladob + 1, 230 - altoa + 1));
                        e.Graphics.DrawString(razon, new Font("Arial", 7), Brushes.Black, new Point(82 - ladob + 1, 106 - altoa + 1));
                        e.Graphics.DrawString(rutFormateado, new Font("Arial", 7), Brushes.Black, new Point(61 - ladob + 1, 123 - altoa + 1));
                        e.Graphics.DrawString(direccion, new Font("Arial", 7), Brushes.Black, new Point(80 - ladob + 1, 141 - altoa + 1));
                        e.Graphics.DrawString(ciudad, new Font("Arial", 7), Brushes.Black, new Point(69 - ladob + 1, 158 - altoa + 1));
                        e.Graphics.DrawString(comuna, new Font("Arial", 7), Brushes.Black, new Point(78 - ladob + 1, 175 - altoa + 1));
                        e.Graphics.DrawString("N/F : " + nf, new Font("Arial", 7), Brushes.Black, new Point(56 - ladob + 1, 212 - altoa + 1));
                        e.Graphics.DrawString(giro, new Font("Arial", 7), Brushes.Black, new Point(56 - ladob + 1, 195 - altoa + 1));
                        e.Graphics.DrawString(b5, new Font("Arial", 12), Brushes.Black, new Point(50 - ladoa + 1, 275 + y - altob + 1));
                        e.Graphics.DrawString("$" + b2, new Font("Arial", 12), Brushes.Black, new Point(595 - ladoa + 1, 275 + y - altob + 1));
                        e.Graphics.DrawString(b1, new Font("Arial", 12), Brushes.Black, new Point(180 - ladoa + 1, 275 + y - altob + 1));
                        e.Graphics.DrawString(b3, new Font("Arial", 12), Brushes.Black, new Point(120 - ladoa + 1, 275 + y - altob + 1));
                        e.Graphics.DrawString("$" + b4, new Font("Arial", 12), Brushes.Black, new Point(695 - ladoa + 1, 275 + y - altob + 1));
                        e.Graphics.DrawString(totales, new Font("Arial", 12), Brushes.Black, new Point(709 - ladob + 1, 476 - altoa + 1));
                        e.Graphics.DrawString(iva, new Font("Arial", 12), Brushes.Black, new Point(609 - ladob + 1, 476 - altoa + 1));
                        e.Graphics.DrawString(neto, new Font("Arial", 12), Brushes.Black, new Point(509 - ladob + 1, 476 - altoa + 1));
                        y = y + 16;
                       
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(dataGridView2.RowCount > 2)
                {
             
                }
                if (Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                
                }
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
      
                impresionproductos(e);
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            printDocument1.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {



                    int contador = dataGridView2.RowCount;
                    int fila = -1;
                    do
                    {
                        try
                        {
                            fila = fila + 1;

                            r = this.dataGridView2.Rows[fila].Cells["rut"].Value.ToString();
                            nd = this.dataGridView2.Rows[fila].Cells["nfactura"].Value.ToString();
                            printDocument1.Print();
                            //printPreviewDialog1.Document = printDocument1;
                            //printPreviewDialog1.ShowDialog();

                        }
                        catch
                        {

                        }

                    }
                    while (dataGridView2.RowCount > fila);
                }
                catch
                {

                }
                finally
                {
                    this.Close();
                }
            
            claseBD cbd = new claseBD();
            cbd.AbrirConexion();
            string truncaja = "truncate table nfactimpresion";
            cbd.EjecutarIUD(truncaja);
            this.Close();
        }
           
        }
        public String r = null;
        public String nd = null;
        private void button1_Click_2(EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            llenard();
        }
    }
}
