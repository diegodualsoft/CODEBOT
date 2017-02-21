using System;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using FastColoredTextBoxNS;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using MySql.Data.MySqlClient;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;
using System.Data;

namespace Codebot
{
    public partial class frmPrincipal : Form
    {
        private frmPrincipal instance;

        public frmPrincipal()
        {
            InitializeComponent();
        }
        //frmInicioSesion IS = new frmInicioSesion();

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void cmdInicio_Click(object sender, EventArgs e)
        {
            
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
            dgvcolumnas.DataSource = null;
            MySqlDataReader Rec = null;
            try
            {
                    Rec=   new DBCLass(txtDb.Text, txtIp.Text, txtuser.Text, txtpass.Text, txtport.Text).EjecutarConsulta("show fields from " + txtDb.Text + "." + dgvtablas.CurrentRow.Cells["TABLA"].Value.ToString() + " ");
                    DataTable alfa = new DataTable();
                    alfa.Columns.Add("Selecionar", typeof(bool)).ReadOnly = false ;
                    alfa.Columns.Add("Columnas", typeof(string)).ReadOnly = true;
                    alfa.Columns.Add("Tipo", typeof(string)).ReadOnly = true;
                    while (Rec.Read())
                    {
                        DataRow beta =  alfa.NewRow();
                        beta["Columnas"] = Rec["Field"].ToString();
                        beta["Tipo"] = Rec["Type"].ToString();
                        alfa.Rows.Add(beta);

                    }
                    dgvcolumnas.DataSource = alfa;
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
            string CadSql ="" ;

            //claseBD CBd = new claseBD() { 
            //    _base = txtDb.Text, 
            //    _pass = txtpass.Text, 
            //    _port = txtport.Text, 
            //    _server = txtIp.Text,
            //    _user = txtuser.Text
            //};
            int fila;
            DBCLass db = new DBCLass(txtDb.Text, txtIp.Text, txtuser.Text, txtpass.Text, txtport.Text);

            MySqlDataReader Rec = null;
            try
            {
                Rec =  db.EjecutarConsulta("show tables from " + txtDb.Text + "");


                dgvtablas.RowCount = 0;
                while (Rec.Read())
                {
                    dgvtablas.RowCount = dgvtablas.RowCount + 1;
                    fila = dgvtablas.RowCount - 1;
                    dgvtablas.Rows[fila].Cells[0].Value = Rec["Tables_in_"+txtDb.Text].ToString();


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
        public string cad_coneccion {get; set;}
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
                string parametros = "parametros";
                string campos = "";
                DataTable datos = (DataTable)dgvcolumnas.DataSource;
                foreach (DataRow dr in datos.Rows)
                {
                    try
                    {
                        if (Convert.ToBoolean(dr["Selecionar"].ToString()) != false)
                        {
                            campos += "'" + dr["Columnas"] + "',";
                        }
                        else
                        {
                        }
                    }
                    catch { }
                }
                string[] corte = campos.Split(',');
            int contador = 0;
            campos = "";
            foreach (string a in corte)
            {
                if (a != "" && a != null)
                {
                    if (contador != corte.Length - 1)
                    {
                        campos += a + ",";
                    }
                    else
                    {
                        campos += a;
                    }
                }
                contador++;
            }
            code.Text =
            "public void Insertar("+parametros+"){"+
            
            " string insertar = \" insert into " + lbltabla.Text +
            "("+campos+") values \"+control+\",\"+control+\",\"+control+\",\"+control+\";\"; \n}";
         
        }

        private void dgvcolumnas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDefaul_CheckedChanged(object sender, EventArgs e)
        {
            if (LoadDefaul.Checked == true)
            {
                cargarDatosConexion();
            }
            else
            {
                //txtcode.Clear();
                txtDb.Clear();
                txtIp.Clear();
                txtpass.Clear();
                txtport.Clear();
                txtuser.Clear();
            }
        }
        public void cargarDatosConexion()
        {
            try
            {
                DataSet data = new DataSet();
                data.ReadXml("c:\\pos\\conf.xml");
                DataRow[] row = data.Tables["Conexion"].Select();
                txtDb.Text = row[0]["Base"].ToString();
                txtpass.Text = (row[0]["Pass"].ToString().Length > 0 ? row[0]["Pass"].ToString() : "");
                txtport.Text= row[0]["Port"].ToString();
                txtIp.Text = row[0]["Server"].ToString();
                txtuser.Text = row[0]["User"].ToString();
            }
            catch { }
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
