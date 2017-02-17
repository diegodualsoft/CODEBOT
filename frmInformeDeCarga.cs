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
    public partial class frmInformeDeCarga : Form
    {

        public frmInformeDeCarga()
        {
            InitializeComponent();
        }
        public int totalfilas;
        public int caphoja = 50;
        public int holasllenas = 0;
        public int hojafinal = 0;
        
        private void button2_Click(object sender, EventArgs e)
        {
          printDialog1.Document = printDocument1;
          if (printDialog1.ShowDialog() == DialogResult.OK)
          {

              printDocument1.Print();

              creartablaparaguardar();

              truncartablas();

              consultarango();

          }
          else
          { 

          }

          
          

        }
     
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {   
            impresionproductos(e);
        }
        private void impresionproductos(System.Drawing.Printing.PrintPageEventArgs e)
        {

            int filaimp = 0;
            int y = 0;
            try
            {

                do
                {
                    string b1, b2, b3;
                    b1 = dataGridView1.Rows[filaimp].Cells["NombreProducto"].Value.ToString();
                    b2 = dataGridView1.Rows[filaimp].Cells["Cantidad"].Value.ToString();
                    b3 = dataGridView1.Rows[filaimp].Cells["Medida"].Value.ToString();
                    e.Graphics.DrawString("PICKING : " + dateTimePicker1.Text + "", new Font("Arial", 12), Brushes.Black, new Point(50, 2));
                    e.Graphics.DrawString("FACTURAS AFECTADAS : N° " + lblrangoinicial.Text + " - N° " + lblrangofinal.Text + "", new Font("Arial", 12), Brushes.Black, new Point(50, 22));
                    e.Graphics.DrawString("MEDIDA", new Font("Arial Black", 10), Brushes.Black, new Point(610, 50));
                    e.Graphics.DrawString("CANTIDAD", new Font("Arial Black", 10), Brushes.Black, new Point(515, 50));
                    e.Graphics.DrawString("DESCRIPCION PRODUCTO", new Font("Arial Black", 10), Brushes.Black, new Point(125, 50));
                    e.Graphics.DrawString(b3, new Font("Arial", 12), Brushes.Black, new Point(620, 75 + y));
                    e.Graphics.DrawString(b2, new Font("Arial", 12), Brushes.Black, new Point(555, 75 + y));
                    e.Graphics.DrawString(b1, new Font("Arial", 12), Brushes.Black, new Point(120, 75 + y));
                    y = y + 15;
                    filaimp = filaimp + 1;
                }
                while (dataGridView1.RowCount > filaimp);
            }
            catch
            { }
        }

        private void truncartablas()
        {
            try
            {
                claseBD cbd = new claseBD();

                string cadsql = "truncate table " + dateTimePicker1.Text + " ";
                string cadsql2 = "truncate table rango";
                cbd.EjecutarIUD(cadsql);
                cbd.EjecutarIUD(cadsql2);
            }
            catch
            { 

            }
          
           
        }
        private void creartablaparaguardar()
        {
            try
            {
                claseBD cbd = new claseBD();
                string tablainforme = "create table " + dateTimePicker1.Text + "_" + lblrangoinicial.Text + "_" + lblrangofinal.Text + " (inicial varchar (255) default "+lblrangoinicial.Text+",final varchar (255) default "+lblrangofinal.Text+",nombre varchar(255), cant varchar(255), medida varchar(255))";
                cbd.EjecutarIUD2(tablainforme);
                string cadsql2 = "insert into " + dateTimePicker1.Text + "_" + lblrangoinicial.Text + "_" + lblrangofinal.Text + " (nombre,cant,medida) select nombre, cant, medida from " + dateTimePicker1.Text + " ";
                cbd.EjecutarIUD2(cadsql2);
            }
            catch
            { }
        }
        private void frmInformeDeCarga_Load(object sender, EventArgs e)
        {
            //llenarDgvClientes();
            consultarango();
            llenarDGVb();
        }
        private void consultarango()
        {
            string consulta = "select * from rango";
            claseBD CBd = new claseBD();

            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(consulta);

                while (Rec.Read())
                {


                    lblrangoinicial.Text = Rec["inicial"].ToString();
                    lblrangofinal.Text = Rec["final"].ToString();


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
        public void llenarDgvClientes()
        {
            string CadSql;
            CadSql = "select * from "+dateTimePicker1.Text+"";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta2(CadSql);
                dataGridView1.RowCount = 0;
                while (Rec.Read())
                {
                    dataGridView1.RowCount = dataGridView1.RowCount + 1;
                    fila = dataGridView1.RowCount - 1;
                    dataGridView1.Rows[fila].Cells[0].Value = Rec["nombre"].ToString();
                    dataGridView1.Rows[fila].Cells[1].Value = Rec["cant"].ToString();
                    dataGridView1.Rows[fila].Cells[2].Value = Rec["medida"].ToString();
                }

            }
            catch
            {
            }
        }
        private void llenarDGVa()
        {

            string CadSql;
            CadSql = "select * from "+dateTimePicker1.Text+"_"+txtinicial.Text+"_"+txtfinal.Text+"";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta2(CadSql);
                dataGridView1.RowCount = 0;
                while (Rec.Read()) 
                {
                    dataGridView1.RowCount = dataGridView1.RowCount + 1;
                    fila = dataGridView1.RowCount - 1;
                    dataGridView1.Rows[fila].Cells[0].Value = Rec["nombre"].ToString();
                    dataGridView1.Rows[fila].Cells[1].Value = Rec["cant"].ToString();
                    dataGridView1.Rows[fila].Cells[2].Value = Rec["medida"].ToString();
                    lblrangoinicial.Text = Rec["inicial"].ToString();
                    lblrangofinal.Text = Rec["final"].ToString();
                }
           
            }
            catch (Exception e)
            {
               //MessageBox.Show(e.Message);
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
        private void llenarDGVb()
        {

            string CadSql;
            CadSql = "select * from " + dateTimePicker1.Text + "";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta2(CadSql);
                dataGridView1.RowCount = 0;
                while (Rec.Read())
                {
                    dataGridView1.RowCount = dataGridView1.RowCount + 1;
                    fila = dataGridView1.RowCount - 1;
                    dataGridView1.Rows[fila].Cells[0].Value = Rec["nombre"].ToString();
                    dataGridView1.Rows[fila].Cells[1].Value = Rec["cant"].ToString();
                    dataGridView1.Rows[fila].Cells[2].Value = Rec["medida"].ToString();

                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
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

        private void button3_Click(object sender, EventArgs e)
        {
            llenarDGVa();
        }


    }
}
