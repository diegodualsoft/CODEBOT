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
    public partial class frmLibroVentasBoleta : Form
    {
        public frmLibroVentasBoleta()
        {
            InitializeComponent();
        }
        public int fila2 = 0;
        public double res = 0;
        public string codprod = null;
        public double cant = 0;
        public double stock = 0;
        int totalint = 0;       
        private void sumaiva()
        {
            double iva = 0.19,resiva =0,masiva;
            int res = 0;
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
               res += totalint;
            }
            txttotventas.Text = totalint.ToString();
            txttotventas.Text = Convert.ToDouble(txttotventas.Text).ToString("c", CultureInfo.CreateSpecificCulture("es-CL"));
            resiva = iva * totalint;
            txtImpuestos.Text = resiva.ToString();
            txtImpuestos.Text = Convert.ToDouble(txtImpuestos.Text).ToString("c", CultureInfo.CreateSpecificCulture("es-CL"));
        }
        string CadSqlll = null;
        private void llenarDGV()
        {
            if (cbtipodoc.Text == "RedBank")
            {
                CadSqlll = "select * from boleta where bol_fecha = '" + dateTimePicker1.Text + "' and tipo = 'Debito' or tipo = 'Credito' order by bol_folio_credito ";
            }
            else
            {
                CadSqlll = "select * from boleta where bol_fecha = '" + dateTimePicker1.Text + "' and tipo = 'Boleta' order by bol_numero";
            }
            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSqlll);                
                dgvLista.RowCount = 0;
                while (Rec.Read())
                {
                    dgvLista.RowCount = dgvLista.RowCount +1;
                    fila = dgvLista.RowCount - 1;
                    dgvLista.Rows[fila].Cells[0].Value = Rec["bol_numero"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["bol_fecha"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["bol_hora"].ToString();
                    string money = Rec["bol_total_boleta"].ToString();
                    totalint = int.Parse(Rec["bol_total_boleta"].ToString());
                    money = Convert.ToDouble(money).ToString("c", CultureInfo.CreateSpecificCulture("es-CL"));
                    dgvLista.Rows[fila].Cells[3].Value = money.ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["bol_cajero"].ToString();  
                    dgvLista.Rows[fila].Cells[5].Value = Rec["tipo"].ToString();
                    dgvLista.Rows[fila].Cells[6].Value = Rec["folio_credito"].ToString();
                    sumaiva();
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

        private void frmLibroVentas_Load(object sender, EventArgs e)
        {
            cbtipodoc.SelectedIndex = 0;
            txtCostos.Text = "0";
            txtImpuestos.Text = "0";
            txtTotal.Text = "0";
            txttotventas.Text = "0";
            llenarDGV();
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            this.Hide();
            m.Show();
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            llenarDGV();
        }
        private void anulardecuenta()
        {
            try
            {
                String datoe = this.dgvLista.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
                string consulta = "update nfact set n_fact ='NULA' where n_fact = '" + datoe + "' ";
                claseBD cbd = new claseBD();
                cbd.EjecutarIUD(consulta);
            }
            catch (Exception esx)
            {
                MessageBox.Show("ERROR :"+esx);
            }
        }
        private void cmdAnular_Click(object sender, EventArgs e)
        {
            anulardecuenta();
            String dato = this.dgvLista.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
            String CadSql;
            String dato2 = dato + "-nula";
            CadSql = "update  libro set nfact='"+dato2+"',impuestos=0,costos=0,totalventa=0 where nfact='"+dato+"';";

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
                    dgvLista.Rows[fila].Cells[2].Value = Rec["impuestos"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["costos"].ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["totalventa"].ToString();
                    
                
                    sumaiva();


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
                llenarDGV();
             
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void impresionproductos(System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            int filaimp = 0;
            int y = 0;
            try
            {

                do
                {
                    string b1, b2,b5,b6,b7;
                    double b3 = 0,b4 = 0, b8 = 0;
                    b1 = dgvLista.Rows[filaimp].Cells["fecha"].Value.ToString();
                    b2 = dgvLista.Rows[filaimp].Cells["NumeroDocumento"].Value.ToString();
                    b3 = double.Parse(dgvLista.Rows[filaimp].Cells["IVA"].Value.ToString());       
                    b4 = double.Parse(dgvLista.Rows[filaimp].Cells["totalventa"].Value.ToString());
                    b5 = dgvLista.Rows[filaimp].Cells["Estado"].Value.ToString();
                    b6 = dgvLista.Rows[filaimp].Cells["cliente"].Value.ToString();
                    b7 = dgvLista.Rows[filaimp].Cells["rut"].Value.ToString();
                    b8 = double.Parse(dgvLista.Rows[filaimp].Cells["neto"].Value.ToString());
                    e.Graphics.DrawString("HOJA DE VENTA:  FECHA : " + dateTimePicker1.Text + "", new Font("Arial", 12), Brushes.Black, new Point(10, 3));
                    e.Graphics.DrawString(" TOTAL ", new Font("Arial Black", 7), Brushes.Black, new Point(420, 50));
                    e.Graphics.DrawString(" ESTADO ", new Font("Arial Black", 7), Brushes.Black, new Point(560, 50));
                    e.Graphics.DrawString(" CLIENTE ", new Font("Arial Black", 7), Brushes.Black, new Point(630, 50));
                    e.Graphics.DrawString(" NETO ", new Font("Arial Black", 7), Brushes.Black, new Point(310, 50));
                    e.Graphics.DrawString(" RUT ", new Font("Arial Black", 7), Brushes.Black, new Point(720, 50));
                    e.Graphics.DrawString("IMPUESTOS (IVA)", new Font("Arial Black", 7), Brushes.Black, new Point(210, 50));
                    e.Graphics.DrawString("N°FACTURA", new Font("Arial Black", 7), Brushes.Black, new Point(130, 50));
                    e.Graphics.DrawString("FECHA DE EMISION", new Font("Arial Black", 7), Brushes.Black, new Point(8, 50));
                    e.Graphics.DrawString(b4.ToString("C", CultureInfo.CreateSpecificCulture("es-CL")), new Font("Arial", 8), Brushes.Black, new Point(420, 75 + y));
                    e.Graphics.DrawString(b3.ToString("C", CultureInfo.CreateSpecificCulture("es-CL")), new Font("Arial", 8), Brushes.Black, new Point(210, 75 + y));
                    e.Graphics.DrawString(b2, new Font("Arial", 8), Brushes.Black, new Point(132, 75 + y));
                    e.Graphics.DrawString(b1, new Font("Arial", 8), Brushes.Black, new Point(10, 75 + y));
                    e.Graphics.DrawString(b5, new Font("Arial", 8), Brushes.Black, new Point(560, 75 + y));
                    e.Graphics.DrawString(b8.ToString("C", CultureInfo.CreateSpecificCulture("es-CL")), new Font("Arial", 8), Brushes.Black, new Point(310, 75 + y));
                    if (b6.Length < 9)
                    {
                        if (b6.Length < 8)
                        {
                            if (b6.Length < 7)
                            {
                                if (b6.Length < 6)
                                {
                                    if (b6.Length < 5)
                                    {
                                        e.Graphics.DrawString(b6.Substring(0, 4), new Font("Arial", 8), Brushes.Black, new Point(630, 75 + y));
                                    }
                                    else
                                    {
                                        e.Graphics.DrawString(b6.Substring(0, 5), new Font("Arial", 8), Brushes.Black, new Point(630, 75 + y));
                                    }
                                }
                                else
                                {
                                    e.Graphics.DrawString(b6.Substring(0, 6), new Font("Arial", 8), Brushes.Black, new Point(630, 75 + y));
                                }

                            }
                            else
                            {
                                e.Graphics.DrawString(b6.Substring(0, 7), new Font("Arial", 8), Brushes.Black, new Point(630, 75 + y));
                            }
                        }
                        else
                        {
                            e.Graphics.DrawString(b6.Substring(0, 8), new Font("Arial", 8), Brushes.Black, new Point(630, 75 + y));
                        }
                    }
                    else
                    {
                        e.Graphics.DrawString(b6.Substring(0, 9), new Font("Arial", 8), Brushes.Black, new Point(630, 75 + y)); 
                    }
                    e.Graphics.DrawString(b7, new Font("Arial", 8), Brushes.Black, new Point(730, 75 + y));
                    y = y + 13;
                    filaimp = filaimp + 1;
                }
                while (dgvLista.RowCount > filaimp);
            }
            catch
            { }
        }
        int i = 0;
        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                //usar hoja_trabajo.Close

                hoja_trabajo.Cells[1, 1] = " N°BOLETA";
                hoja_trabajo.Cells[1, 2] = " FECHA EMISION";
                hoja_trabajo.Cells[1, 3] = " HORA EMISION";
                hoja_trabajo.Cells[1, 4] = " TOTAL VENTA";
                hoja_trabajo.Cells[1, 5] = " CAJERO";
                hoja_trabajo.Cells[1, 6] = " BOLETA TIPO";
                hoja_trabajo.Cells[1, 7] = " N°BOLETA REDBANK";


                for ( i = 1; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                hoja_trabajo.Cells[i+1, 1] = "TOTALES = ";
                hoja_trabajo.Cells[i+1, 2] = txttotventas.Text;
                libros_trabajo.SaveAs(fichero.FileName,
                Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvLista);
            //printDialog1.Document = printDocument1;
            //if (printDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    printDocument1.Print();
            //}
            //else
            //{ }
            //printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          
           impresionproductos(e);
        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            llenarDGV();
        }
        private void llenarDgvCajaParaDevolver()
        {

          //  string consulta = "select a.codigo,a.cantidad,b.Stock,b.cod_interno from nc_" + lblnumnc.Text + " a, productos b";


            claseBD CBd = new claseBD();
            int fila = 0;
            MySqlDataReader Rec = null;
            try
            {

                do
                {
                    //1.- obtiene el total de la fila del indice como un identificador de datos nulos
                    string identificador = dgvLista.Rows[fila].Cells["total"].Value.ToString();
                    if (identificador == null || identificador == "")
                    {
                        //2.-si la fila no presenta datos aumenta en 1 , ya que no puede operar con datos vacios y tampoco reconoce datos vacios
                        // y si la fila no tiene datos pero se muestra como indice , el bucle no termina.
                        fila = fila + 1;
                    }
                    else
                    {
                        //3.- obtiene los datos necesarios de la fila del dataGridView Para hacer la consulta correspondiente
                        codprod = dgvLista.Rows[fila].Cells["codigo"].Value.ToString();

                        cant = double.Parse(dgvLista.Rows[fila].Cells["Cantidad"].Value.ToString());
                        //4.- obtiene el stock actual de productos de la base de datos
                        Rec = CBd.EjecutarConsulta2("select Stock from productos where cod_interno = '" + codprod + "'");
                        Rec.Read(); // 5.-ejecuta la consulta y abre coneccion
                        stock = double.Parse(Rec["Stock"].ToString());
                        Rec.Close(); //6.-cierra la coneccion para evitar choque de coneccion con la consulta "updatestock"

                        res = stock + cant; //<--Sobre las variables son Datos Globales declarados arriva **//7.- suma el stock de la base de datos con los de la fila del datagrid
                        //8.-  update
                        string updatestock = "update productos set Stock = '" + res.ToString() + "' where cod_interno =" + codprod + "";
                        //9.- ejecuta consulta
                        CBd.EjecutarIUD(updatestock);
                        //10.- aumenta en uno la fila, para leer la siguiente o terminar el Do While
                        fila = fila + 1;
                    }

                }
                while (dgvLista.RowCount > fila); //condicion de Termino (hacer hasta que fila sea mayor al total de filas del dataGridView)

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
        public void obtiene()
        {
            frmProductoLibroVenta v = new frmProductoLibroVenta();
            try
            {
                String dato = this.dgvLista.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
                String rut = this.dgvLista.CurrentRow.Cells["rut"].Value.ToString();
                v.dato1 = dato;
                v.dato2 = rut;
                v.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string datoe = this.dgvLista.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
            string estado = dgvLista.CurrentRow.Cells["Estado"].Value.ToString();
            if (estado == "NULA")
            {
                MessageBox.Show("Esta factura ya se encuentra Nula, Imposible Anular Nuevamente");
            }
            else
            {
               
                if (MessageBox.Show("¿Desea anular la factura N° " + datoe + " ? , Precione NO para cancelar.", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    obtiene();
                }
                else
                {
                    MessageBox.Show("Operacion cancelada por el Usuario.");
                }
            }
        }

        private void txtTotal_Click(object sender, EventArgs e)
        {
            
        }

       
           
        
        
    }
}
