using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Prototipo1
{
    class claseBD
    {

      /*  public static MySqlConnection conex = new MySqlConnection("Server=192.168.0.110;Database=bdfrutosdelpais;Uid=dualsoft;Pwd='76552'");*/
        public static MySqlConnection conex = new MySqlConnection("Server=127.0.0.1;Database=db_patagonia;Uid=root;Pwd=''");
        public MySqlCommand Comando = new MySqlCommand("", conex);
        public MySqlDataReader Rec;
        public void AbrirConexion()
        {
            if (conex.State == System.Data.ConnectionState.Closed)
            {
                conex.Open();
                //MessageBox.Show("Conexión Establecida");
            }
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
