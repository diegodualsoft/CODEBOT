﻿using System;
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
        internal DataTable crearTablaColumnas()
        {
            DataTable alfa = new DataTable();
            alfa.Columns.Add("Selecionar", typeof(bool)).ReadOnly = false;
            alfa.Columns.Add("Columnas", typeof(string)).ReadOnly = true;
            alfa.Columns.Add("Tipo", typeof(string)).ReadOnly = true;
            alfa.Columns.Add("Unique", typeof(string)).ReadOnly = true;
            return alfa;
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
                    alfa.Columns.Add("Unique", typeof(string)).ReadOnly = true;
                    while (Rec.Read())
                    {
                        DataRow beta =  alfa.NewRow();
                        beta["Columnas"] = Rec["Field"].ToString();
                        beta["Tipo"] = Rec["Type"].ToString();
                        beta["Unique"] = Rec["Key"].ToString();
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
            checkBox5.Checked = false;
        }

        private void dgvtablas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarDgvColumns();
            lbltabla.Text = dgvtablas.CurrentRow.Cells["TABLA"].Value.ToString();
            checkBox5.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (chkSelect.Checked || chkdelete.Checked || chkupdate.Checked || chkinsert.Checked)
            {
                SelecionDeFunciones(chkinsert.Checked, chkdelete.Checked, chkSelect.Checked, chkupdate.Checked);
            }
            else
            {
                MessageBox.Show("Debe Selecionar Funcion");
            }
        }
        internal void SelecionDeFunciones(bool insert, bool delete, bool select, bool update)
        {
            string codigo = "";
            if (insert)
            {
                setFuncion("insert");
                codigo += code.Text + "\r\n";
                code.Clear();
            }
            if (select)
            {
                setFuncion("select");
                codigo += code.Text + "\r\n";
                code.Clear();
            }
            if (delete)
            {
                setFuncion("delete");
                codigo += code.Text + "\r\n";
                code.Clear();
            }
            if (update)
            {
                setFuncion("update");
                codigo += code.Text + "\r\n";
                code.Clear();
            }
            code.Text = codigo;
        }
        internal void setFuncion(string who) {
            switch (who)
            {
                case "select" :
                    crearSelect();
                    break;
                case "delete":
                    crearDelete();
                    break;
                case "update":
                    crearUpdate();
                    break;
                case "insert":
                    crearInsert();
                    break;
            }
        }
        #region Funciones
        internal void crearInsert()
        {
            //crear metedo de insercion dinamica mediante la metologia de parametros 
            string parametros = "";
            string campos = "";
            string valores = "";

            /**
 * 
 * crear los reader correcto para la ejecucion de codigo
 * 
 * */
            string completemento = " MySqlCommand comando = Conexion.getConecta().ConexionMySql.CreateCommand(); ";
            string  ejecuta = "command.ExecuteNonQuery();";
            string rec = "while(Filas.Read()){"; string endread = "}";
            string commando = "command.Parameters.AddWithValue(";
            string colaComando = ");";
            string linea = "";
            string ClaseData = "public class " + lbltabla.Text + "{//Clase Para Manipulacion de datos De forma Dinamica";
            string dataTipe = "";
            string instanciaClase = lbltabla.Text + " datos = new " + lbltabla.Text + "();";
            DataTable datos = (DataTable)dgvcolumnas.DataSource;
            int salto = 0;
            foreach (DataRow dr in datos.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(dr["Selecionar"].ToString()) != false)
                    {
                        campos += "" + dr["Columnas"] + ",";

                        parametros += new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + ",";

                        dataTipe += "public " + new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + "{get; set;}\r\n";

                        valores += "@" + dr["Columnas"] + ",";

                        linea += (salto < 1 ? "\r" : "") + commando + "\"@" + dr["Columnas"] + "\",datos." + dr["Columnas"] + colaComando + "\r";
                        salto++;
                    }
                    else
                    {
                    }
                }
                catch { }
            }
            //se eliminan caracteres sobrantes
            valores = valores.Substring(0, valores.Length - 1);
            parametros = parametros.Substring(0, parametros.Length - 1);
            campos = campos.Substring(0, campos.Length - 1);
            //se arma el metodo a usar 
            code.Text =
            "\r\n\r\n\r\npublic "/* + lbltabla.Text */+ " Insertar" + lbltabla.Text + "( " + lbltabla.Text
             + " datos )\r\n{\r\n" /*+ instanciaClase */+
            ///tipo de query
            " string query = \r\n\" insert into "
            ///
            + lbltabla.Text +
            " (" + campos + ")\r\nvalues (" +
            valores
            + ");\";\r\n" + completemento + "\r\n" + linea + "\r\n" +
            ejecuta + /*"\r\n" + rec + endread + captura + "\r\n return datos;*/"\r\n}";
            //se genera la clase de dato a usarse en el objeto que se lleva de aqui
            ClassDat.Text = ClaseData + "\r\n" + dataTipe + endread;
        }
        internal void crearSelect()
        {
            string parametros = "";
            string campos = "";
            string valores = "";

            /**
 * 
 * crear los reader correcto para la ejecucion de codigo
 * 
 * */
            string completemento = " MySqlCommand comando = Conexion.getConecta().ConexionMySql.CreateCommand(); ";
            string ejecuta = "Filas = Comando.ExecuteReader();";
            string rec = "while(Filas.Read()){"; string endread = "}";
            string commando = "command.Parameters.AddWithValue(";
            string colaComando = ");";
            string trys = "try{";
            string captura = "}catch(Exception ex){MessageBox.show(ex.message);}";
            string linea = "";
            string ClaseData = "public class "+lbltabla.Text+"{//Clase Para Manipulacion de datos De forma Dinamica";
            string dataTipe = "";
            string instanciaClase = lbltabla.Text +" datos = new "+lbltabla.Text+"();";
            DataTable datos = (DataTable)dgvcolumnas.DataSource;
            int salto = 0;
            foreach (DataRow dr in datos.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(dr["Selecionar"].ToString()) != false)
                    {
                        campos += "" + dr["Columnas"] + ",";

                        parametros += new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + ",";

                        dataTipe += "public "+ new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + "{get; set;}\r\n";

                        valores += "@" + dr["Columnas"] + ",";

                        linea += (salto < 1 ? "\r" : "") +commando + "\"@" + dr["Columnas"] + "\",datos." + dr["Columnas"] + colaComando + "\r";

                        //convert automaticos

                        string convert = (new DicDatos().tipoData(dr["Tipo"].ToString()) == "int"  ? "Convert.ToInt32(" : "");

                        //para los select
                        rec += (salto <1 ? "\r":"")+ "datos."+dr["Columnas"] +"= "+
                            convert+" Filas[\"" + dr["Columnas"] + "\"].ToString()"+
                            (convert.Length >0 ? ")":"")+";\r";
                        salto++;
                    }
                    else
                    {
                    }
                }
                catch { }
            }
            //se eliminan caracteres sobrantes
            valores = valores.Substring(0, valores.Length - 1);
            parametros = parametros.Substring(0, parametros.Length - 1);
            campos = campos.Substring(0, campos.Length - 1);
            //se arma el metodo a usar 
            code.Text =
            "\r\n\r\n\r\npublic " + lbltabla.Text+ " Selecionar" + lbltabla.Text + "(" + /*
            parametros + */")\r\n{\r\n" + trys + "\r\n" +instanciaClase +
            ///tipo de query
            " string query = \" select * from " 
            ///
            + lbltabla.Text/* +
            " (" + campos + ")\r\nvalues (" +
            valores*/
            + "\";\r\n" + completemento + "\r\n" +/* linea + "\r\n" +*/
            ejecuta +"\r\n"+ rec + endread +  captura + "\r\n return datos;\r\n}"; 
            //se genera la clase de dato a usarse en el objeto que se lleva de aqui
            ClassDat.Text= ClaseData + "\r\n" + dataTipe + endread;
        }
        internal void crearUpdate()
        {
            //crear metodo 
            //Crear metodo de eliminacion mediante la  primary key
            //crear metedo de insercion dinamica mediante la metologia de parametros 
            string parametros = "";
            string campos = "";
            string valores = "";
            string valoresWhere = "";

            /**
 * 
 * crear los reader correcto para la ejecucion de codigo
 * 
 * */
            string completemento = " MySqlCommand comando = Conexion.getConecta().ConexionMySql.CreateCommand(); ";
            string ejecuta = " command.ExecuteNonQuery();";
            string commando = "command.Parameters.AddWithValue(";
            string colaComando = ");";
            string linea = "";
            string ClaseData = "public class " + lbltabla.Text + "{//Clase Para Manipulacion de datos De forma Dinamica";
            string dataTipe = "";
            string instanciaClase = lbltabla.Text + " datos = new " + lbltabla.Text + "();";
            DataTable datos = (DataTable)dgvcolumnas.DataSource;
            int salto = 0;
            foreach (DataRow dr in datos.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(dr["Selecionar"].ToString()) != false && dr["Unique"].ToString() == "PRI")
                    {
                        campos += "" + dr["Columnas"] + ",";

                        parametros += new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + ",";

                        dataTipe += "public " + new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + "{get; set;}\r\n";

                        valoresWhere += (dr["Unique"].ToString() == "PRI" ? dr["Columnas"] + "= @" + dr["Columnas"] : "") + ",";
                        valores += dr["Columnas"] + "= @" + dr["Columnas"] + ",";
                        linea += (salto < 1 ? "\r" : "") + commando + "\"@" + dr["Columnas"] + "\",datos." + dr["Columnas"] + colaComando + "\r";
                        salto++;
                    }
                    else
                    {
                        campos += "" + dr["Columnas"] + ",";

                        parametros += new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + ",";

                        dataTipe += "public " + new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + "{get; set;}\r\n";

                        valores += dr["Columnas"] + "= @" + dr["Columnas"] + ",";

                        linea += (salto < 1 ? "\r" : "") + commando + "\"@" + dr["Columnas"] + "\",datos." + dr["Columnas"] + colaComando + "\r";

                        salto++;
                    }
                }
                catch { }
            }
            //se eliminan caracteres sobrantes
            valores = valores.Substring(0, valores.Length - 1);
            parametros = parametros.Substring(0, parametros.Length - 1);
            campos = campos.Substring(0, campos.Length - 1);
            valoresWhere = valoresWhere.Substring(0, valoresWhere.Length - 1);
            //se arma el metodo a usar 
            code.Text =
            "\r\n\r\n\r\npublic "/* + lbltabla.Text*/ + "void Update"+ lbltabla.Text+" (" +
            lbltabla.Text + " Datos)\r\n{\r\n"  +
            ///tipo de query
            " string query = \" update  "
            ///
            + lbltabla.Text +
            " set "+ valores+" where " +
            valoresWhere
            + ";\";\r\n" + completemento + "\r\n" + linea + "\r\n" +
            ejecuta +"\r\n}";
            ClassDat.Text = ClaseData + "\r\n" + dataTipe ;
        }
        internal void crearDelete()
        {
            //Crear metodo de eliminacion mediante la  primary key
            //crear metedo de insercion dinamica mediante la metologia de parametros 
            string parametros = "";
            string campos = "";
            string valores = "";

            /**
 * 
 * crear los reader correcto para la ejecucion de codigo
 * 
 * */
            string completemento = " MySqlCommand comando = Conexion.getConecta().ConexionMySql.CreateCommand(); ";
            string ejecuta = "command.ExecuteNonQuery();";
            string rec = "while(Filas.Read()){"; string endread = "}";
            string commando = "command.Parameters.AddWithValue(";
            string colaComando = ");";
            string trys = "try{";
            string captura = "}catch(Exception ex){MessageBox.show(ex.message);}";
            string linea = "";
            string ClaseData = "public class " + lbltabla.Text + "{//Clase Para Manipulacion de datos De forma Dinamica";
            string dataTipe = "";
            string instanciaClase = lbltabla.Text + " datos = new " + lbltabla.Text + "();";
            DataTable datos = (DataTable)dgvcolumnas.DataSource;
            int salto = 0;
            foreach (DataRow dr in datos.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(dr["Selecionar"].ToString()) != false && dr["Unique"].ToString() == "PRI")
                    {
                        campos += "" + dr["Columnas"] + ",";

                        parametros += new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + ",";

                        dataTipe += "public " + new DicDatos().tipoData(dr["Tipo"].ToString()) + " " + dr["Columnas"] + "{get; set;}\r\n";

                        valores += (dr["Unique"].ToString() == "PRI" ?   "@" + dr["Columnas"] : "") + ",";

                        linea += (salto < 1 ? "\r" : "") + commando + "\"@" + dr["Columnas"] + "\"," + dr["Columnas"] + colaComando + "\r";

                        //convert automaticos

                        // string convert = (new DicDatos().tipoData(dr["Tipo"].ToString()) == "int" ? "Convert.ToInt32(" : "");

                        //para los select
                        //rec += (salto < 1 ? "\r" : "") + "datos." + dr["Columnas"] + "= " +
                        //    convert + " Filas[\"" + dr["Columnas"] + "\"].ToString()" +
                        //    (convert.Length > 0 ? ")" : "") + ";\r";
                        salto++;
                    }
                    else
                    {
                    }
                }
                catch { }
            }
            //se eliminan caracteres sobrantes
            valores = valores.Substring(0, valores.Length - 1);
            parametros = parametros.Substring(0, parametros.Length - 1);
            campos = campos.Substring(0, campos.Length - 1);
            //se arma el metodo a usar 
            code.Text =
            "\r\n\r\n\r\npublic "/* + lbltabla.Text*/ + "void Eliminar(" +
            parametros + ")\r\n{\r\n" + trys + "\r\n" + instanciaClase +
            ///tipo de query
            "\r\n string query = \" Delete from  "
            ///
            + lbltabla.Text +
            " where " + campos + " = " +
            valores
            + ";\";\r\n" + completemento + "\r\n" + linea + "\r\n" +
            ejecuta + /*"\r\n" + rec + endread + captura + "\r\n return datos;*/"\r\n}";
            //se genera la clase de dato a usarse en el objeto que se lleva de aqui
            ClassDat.Text = ClaseData + "\r\n" + dataTipe;
        }
        #endregion
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
           
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            string texto2 = new StreamReader("TextFile2.txt").ReadToEnd();
            fastColoredTextBox2.Text = texto2;
        }

        private void fastColoredTextBox2_Load(object sender, EventArgs e)
        {
            string texto2 = new StreamReader("TextFile2.txt").ReadToEnd();
            fastColoredTextBox2.Text = texto2;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable temp = (DataTable)dgvcolumnas.DataSource;
                if (checkBox5.Checked)
                {
                    DataTable outT = crearTablaColumnas();
                    foreach (DataRow a in temp.Rows)
                    {
                        outT.Rows.Add(true, a[1], a[2], a[3]);
                    }
                    dgvcolumnas.DataSource = outT;
                }
                else
                {
                    DataTable outT = crearTablaColumnas();
                    foreach (DataRow a in temp.Rows)
                    {
                        outT.Rows.Add(false, a[1], a[2],a[3]);
                    }
                    dgvcolumnas.DataSource = outT;
                }
            }
            catch { }
        }
    }
}
