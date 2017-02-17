using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;


namespace Prototipo1
{
    public partial class frmInformeDeCompra : Form
    {
        public frmInformeDeCompra()
        {
            InitializeComponent();
        }

        claseBD CBd = new claseBD();

        private void llenarDgv()
        {
            string CadSql;
            CadSql = "select * from informecompra where fecha_mes_año = '"+dateTimePicker1.Text+"' ;";


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
                    dgvLista.Rows[fila].Cells[0].Value = Rec["fecha_completa"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["iva"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["totales"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["nfact"].ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["proveedor"].ToString();
                    dgvLista.Rows[fila].Cells[5].Value = Rec["rut"].ToString();


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

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            frmAdministracion admi = new frmAdministracion();
            this.Hide();
            admi.Show();
        }

        private void frmInformeDeCompra_Load(object sender, EventArgs e)
        {
            llenarDgv();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            llenarDgv();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

  
                    int filaimp = 0;
                    int y = 0;
                    try
                    {

                        do
                        {
                            string b1, b2, b6, b7;
                            double b3 = 0, b4 = 0;
                            b1 = dgvLista.Rows[filaimp].Cells["grdFecha"].Value.ToString();
                            b2 = dgvLista.Rows[filaimp].Cells["grdNfact"].Value.ToString();
                            b3 = double.Parse(dgvLista.Rows[filaimp].Cells["grdIVA"].Value.ToString());
                            b4 = double.Parse(dgvLista.Rows[filaimp].Cells["grdTotales"].Value.ToString());
                           // b5 = dgvLista.Rows[filaimp].Cells["Estado"].Value.ToString();
                            b6 = dgvLista.Rows[filaimp].Cells["grdProveedor"].Value.ToString();
                            b7 = dgvLista.Rows[filaimp].Cells["grdRut"].Value.ToString();
                           // b8 = double.Parse(dgvLista.Rows[filaimp].Cells["neto"].Value.ToString());
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
                           
                           //e.Graphics.DrawString(b5, new Font("Arial", 8), Brushes.Black, new Point(560, 75 + y));
                           //e.Graphics.DrawString(b8.ToString("C", CultureInfo.CreateSpecificCulture("es-CL")), new Font("Arial", 8), Brushes.Black, new Point(310, 75 + y));
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

        private void button1_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            else
            { }
        }
    }
}
