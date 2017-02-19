using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Codebot
{
    public class DBCLass
    {
        public string database { get; set; }
        public string servidor { get; set; }
        public string password { get; set; }
        public string usuario { get; set; }
        public string puerto { get; set; }
        public static MySqlConnection conex;// new MySqlConnection("Server=;Database=db_patagonia;Uid=root;Pwd=''");
        public MySqlCommand Comando = new MySqlCommand();
        public MySqlDataReader Rec;
        public DBCLass()
        {
            GestionConeccion();
        }
        internal void GestionConeccion()
        {
            if (servidor == null || database == null || usuario == null || password == null || puerto == null)
            {
                cargarDatosConexionXML();
            }
            string cadena_coneccion = "Data Source=" + servidor + ";Database=" + database + ";Uid=" + usuario + ";Pwd='" + password + "';port=" + puerto + ";";
            conex = new MySqlConnection(cadena_coneccion);
        }
        public void cargarDatosConexionXML()
        {
            try
            {
                DataSet data = new DataSet();
                data.ReadXml("c:\\pos\\conf.xml");
                DataRow[] row = data.Tables["Conexion"].Select();
                database = row[0]["Base"].ToString();
                password = (row[0]["Pass"].ToString().Length > 0 ? row[0]["Pass"].ToString() : "");
                puerto = row[0]["Port"].ToString();
                servidor = row[0]["Server"].ToString();
                usuario = row[0]["User"].ToString();
            }
            catch { }
        }
        public DataTable Select_datatable(string sql)
        {
            DataTable dataTable = new DataTable();
            try
            {
                AbrirConexion();
                MySqlCommand command = conex.CreateCommand();
                ((DbCommand)command).CommandText = sql;
                ((DbDataAdapter)new MySqlDataAdapter(command)).Fill(dataTable);
                CerrarConexion();
            }
            catch (Exception ex)
            {
            }
            return dataTable;
        }
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
                CerrarConexion();
            }
            return (Rec);

        }


    }
}
