using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Prototipo1
{
    class claseBDremota
    {
        public string _base = "";
        public string _server = "";
        public string _user= "";
        public string _pass ="";
        public string _port = "";
        public void cargarDatosConexion()
        {
            try
            {
                DataSet data = new DataSet();
                data.ReadXml("c:\\pos\\conf.xml");
                DataRow[] row = data.Tables["Conexion"].Select();
                this._base = row[0]["Base"].ToString();
                this._pass = (row[0]["Pass"].ToString().Length > 0 ? row[0]["Pass"].ToString() : "");
                this._port = row[0]["Port"].ToString();
                this._server = row[0]["Server"].ToString();
                this._user = row[0]["User"].ToString();
                string cadena_coneccion = "Data Source=" + _server + ";Database=" + _base + ";Uid=" + _user + ";Pwd='" + _pass + "';port=" + _port;
                conex = new MySqlConnection(cadena_coneccion);

            }
            catch { }
        }
        public static MySqlConnection conex = new MySqlConnection("Server=192.168.0.110;Database=bdfrutosdelpais;Uid=dualsoft;Pwd='76552'");
       // public static MySqlConnection conex;// new MySqlConnection("Server=;Database=db_patagonia;Uid=root;Pwd=''");
        public MySqlCommand Comando = new MySqlCommand();
        public MySqlDataReader Rec;
        //public ClaseBDremota()
        //{
        //    cargarDatosConexion();
        //    if (conex.State == ConnectionState.Open)
        //    {
        //        conex.Close();
        //    }
        //    conex.Open();
           
        //}
        public void AbrirConexion()
        {
            //cargarDatosConexion();
            if (conex.State == System.Data.ConnectionState.Closed)
            {
                conex.Open();
                //MessageBox.Show("Conexión Establecida");
            }
            //else if (conex.State == ConnectionState.Open)
            //{
            //    conex.Close();
            //   // conex.Open();
            //}
        }
        public void CerrarConexion()
        {
            if (conex.State == System.Data.ConnectionState.Open)
            {
                conex.Close();
            }
        }

        public int EjecutarIUD(string CadSql)
        {
            int Filas = 0;
            try
            {
                AbrirConexion();
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.Connection = conex;
                Comando.CommandText = CadSql;
                Filas = Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CerrarConexion();

            }


            return (Filas);


        }

        public int EjecutarIUD2(string CadSql)
        {
            int Filas = 0;
            try
            {
                AbrirConexion();
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.Connection = conex;
                Comando.CommandText = CadSql;
                Filas = Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                CerrarConexion();

            }


            return (Filas);


        }
     
        public MySqlDataReader EjecutarConsulta(String CadSql)
        {
            try
            {
                AbrirConexion();
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.Connection = conex;
                Comando.CommandText = CadSql;
                Rec = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Rec = null;
            }
            return (Rec);

        }
        public MySqlDataReader EjecutarConsulta2(String CadSql)
        {
            try
            {
                AbrirConexion();
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.Connection = conex;
                Comando.CommandText = CadSql;
                Rec = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {
               
                Rec = null;
            }
            return (Rec);

        }

       
    }
}
