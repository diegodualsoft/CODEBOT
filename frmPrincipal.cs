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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        frmMenu M = new frmMenu();
        //frmInicioSesion IS = new frmInicioSesion();

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void cmdInicio_Click(object sender, EventArgs e)
        {
            M.Show();
            this.Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //this.timer1.Start();


        }
        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void llenarDgvColumns()
        {
            string CadSql;
            CadSql = "show fields from " + txtdb.Text + "." + dgvtablas.CurrentRow.Cells["TABLA"].Value.ToString() + " ";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);


                dgvcolumnas.RowCount = 0;
                while (Rec.Read())
                {
                    dgvcolumnas.RowCount = dgvcolumnas.RowCount + 1;
                    fila = dgvcolumnas.RowCount - 1;
                    dgvcolumnas.Rows[fila].Cells[0].Value = Rec["Field"].ToString();


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
        //claseBD cbd = new claseBD();
        //        string insertar = "insert into estadofact values ('" + mskRUT.Text + "','" + lblNumFact.Text + "','"+comboBox2.Text+"','$0','" + dateTimePicker1.Text+ "','" + txtVencimiento.Text + "')";
        //        cbd.EjecutarIUD2(insertar);
        private void llenarDgv()
        {
            string CadSql;
            CadSql = "show tables from " + txtdb.Text + "";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);


                dgvtablas.RowCount = 0;
                while (Rec.Read())
                {
                    dgvtablas.RowCount = dgvtablas.RowCount + 1;
                    fila = dgvtablas.RowCount - 1;
                    dgvtablas.Rows[fila].Cells[0].Value = Rec["Tables_in_db_super_fernandez"].ToString();


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
        private void button2_Click(object sender, EventArgs e)
        {
            llenarDgv();
        }

        private void dgvtablas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarDgvColumns();
            lbltabla.Text = dgvtablas.CurrentRow.Cells["TABLA"].Value.ToString();
        }

        private void dgvtablas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvcolumnas.RowCount > 0)

            txtcode.Text =
            "claseBD cbd = new claseBD();\n"+
            
            " string insertar = \" insert into " + lbltabla.Text +
            "(" + dgvcolumnas.Rows[0].Cells[0].Value.ToString() + ","
                + dgvcolumnas.Rows[1].Cells[0].Value.ToString() + ","
                + dgvcolumnas.Rows[2].Cells[0].Value.ToString() + ","
                + dgvcolumnas.Rows[3].Cells[0].Value.ToString() +
          ") values \"+control+\",\"+control+\",\"+control+\",\"+control+\";\"; \n";
         
        }
    }
}
