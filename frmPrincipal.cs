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
                string parametros = "";
                string campos = "";
                string valores = "";


                string completemento = "AbrirConexion();\r\n" +
                    "Comando.CommandType = System.Data.CommandType.Text;\r\n" +
                    "Comando.Connection = CadenaConeccion;\r\n" +
                    "Comando.CommandText = query;\r\n";
                string ejecuta = "Filas = Comando.ExecuteNonQuery();";
                string rec = "";
                string commando = "command.Parameters.AddWithValue(";
                string colaComando = ");";
                string trys = "try{";
                string captura = "}catch(Exception ex){\r\nMessageBox.show(ex.message);\r\n}";
                string linea = "";
                DataTable datos = (DataTable)dgvcolumnas.DataSource;
                foreach (DataRow dr in datos.Rows)
                {
                    try
                    {
                        if (Convert.ToBoolean(dr["Selecionar"].ToString()) != false)
                        {
                            campos += "`" + dr["Columnas"] + "`,";
                            parametros += new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + ",";
                            valores += "`@" + dr["Columnas"] + "`,";
                            linea += commando + "\"@" + dr["Columnas"] + "\", " + dr["Columnas"] +colaComando+"\r\n";
                            //para los select
                            rec += "Filas[\"" + dr["Columnas"] + "\"];\n\r";
                        }
                        else
                        {
                        }
                    }
                    catch { }
                }
                valores = valores.Substring(0, valores.Length - 1);
                parametros = parametros.Substring(0, parametros.Length - 1);
            campos = campos.Substring(0, campos.Length-1);
            code.Text =
            "public void Insertar("+parametros+")\r\n{\r\n"+trys+"\r\n"+
            " string query = \r\n\" insert into `" + lbltabla.Text +
            "` (" + campos + ")\r\nvalues ("+
            valores
            +");\";\r\n"+completemento+"\r\n"+linea+"\r\n"+ejecuta+"\r\n"+captura+"}";



         

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

        private void code_Load(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {
            string texto = new StreamReader("TextFile1.txt").ReadToEnd();
            fastColoredTextBox1.Text = texto;
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            string texto = new StreamReader("TextFile1.txt").ReadToEnd();
            fastColoredTextBox1.Text = texto;
            string texto2 = new StreamReader("TextFile2.txt").ReadToEnd();
            fastColoredTextBox2.Text = texto2;
        }

        private void fastColoredTextBox2_Load(object sender, EventArgs e)
        {
            string texto2 = new StreamReader("TextFile2.txt").ReadToEnd();
            fastColoredTextBox2.Text = texto2;
        }
    }
}
