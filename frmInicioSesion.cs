using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Security.Cryptography;

namespace Prototipo1
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }
        frmMenu M = new frmMenu();
        public string idusu = null;
        public string passusu = null;
        public string nombreusu = null;
        public string tipousu = null;
        public static string Desencriptar(string textoEncriptado, string key)
        {
            try
            {
                byte[] keyArray;
                byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);

                //algoritmo MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();

                byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);

                tdes.Clear();
                textoEncriptado = UTF8Encoding.UTF8.GetString(resultArray);

            }
            catch (Exception)
            {

            }
            return textoEncriptado;
        }
        public void obtieneUsu()
        {
            string CadSql;
            CadSql = "select * from usuarios where usu_nombre ='" + txtUsuario.Text + "' ";

            claseBD CBd = new claseBD();
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                while (Rec.Read())
                {
                    idusu = Rec["usu_id"].ToString();
                    tipousu = Rec["usu_tipo"].ToString();
                    passusu = Desencriptar( Rec["usu_llave"].ToString(), "dualsoft");
                    nombreusu = Rec["usu_nombre"].ToString();
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //public DataTable datos_DB(string sql)
        //{
        //    MySqlConnection alfa = new MySqlConnection("Server=localhost;Database=bdfrutosdelpais;Uid=root;Pwd='root'");

        //    if (alfa.State == ConnectionState.Closed)
        //    {
        //        alfa.Open();
        //    }
        //    else
        //    {
        //        alfa.Close();
        //        alfa.Open();
        //    }
        //    DataTable dataTable = new DataTable();
        //    MySqlCommand command = alfa.CreateCommand();
        //    ((DbCommand)command).CommandText = sql;
        //    ((DbDataAdapter)new MySqlDataAdapter(command)).Fill(dataTable);
        //    return dataTable;
        //}
        //internal void login()
        //{
        //    select(txtUsuario.Text, txtContraseña.Text);
        //}

        //internal void select(string user, string pass)
        //{
        //    try
        //    {
        //        MySqlConnection alfa = new MySqlConnection("Server=localhost;Database=bdfrutosdelpais;Uid=root;Pwd='root'");

        //        if (alfa.State == ConnectionState.Closed)
        //        {
        //            alfa.Open();
        //        }
        //        else
        //        {
        //            alfa.Close();
        //            alfa.Open();
        //        }

        //        string sql = "select * from usuarios where usu_nombre ='" + user + "';";
        //        DataTable datos = datos_DB(sql);
        //        bool existe = false;
        //        if (datos.Rows.Count > 0)
        //        {
        //            foreach (DataRow a in datos.Rows)
        //            {
        //                if (a["usu_nombre"].Equals(user) && a["usu_llave"].Equals(pass))
        //                {
        //                    IngresarHistorialUsuario(user,a["usu_id"].ToString());
        //                    M.Show();
        //                    M.txtUsuario.Text = user;
        //                    this.Hide();
        //                    existe = true;
        //                    break;
        //                }
        //            }
        //            if (!existe)
        //            {
        //                MessageBox.Show("usuario o contraseña erroneas");
        //            }
                   
        //        }
        //        else { MessageBox.Show("usuario o contraseña erroneas"); }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        
        //}
        private void IngresarHistorialUsuario(string user,string id)
        {
            claseBD cbsd = new claseBD();
            string cadsqlusu = "insert into ingreso_usuario_caja (usu_id,iuc_nombre,iuc_datos_entrada,iuc_seccion_frm,iuc_caja_numero) values(" + id +",'" + user + "','" + DateTime.Now.ToString() + "','caja',1)";
            cbsd.EjecutarConsulta(cadsqlusu);
            cbsd.CerrarConexion();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            claseBD cbd = new claseBD();
            cbd.cargarDatosConexion();
            obtieneUsu();
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese un Usuario Valido");
                txtUsuario.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(txtContraseña.Text))
                {
                    MessageBox.Show("Ingrese una contraseña valida");
                    txtContraseña.Focus();
                }
                else
                {
                    //login();
                    if (txtUsuario.Text.Equals(nombreusu) && txtContraseña.Text.Equals(passusu))
                    {
                      
                        IngresarHistorialUsuario(nombreusu, idusu);
                        new login()
                        {
                            tip = tipousu,
                            usu = nombreusu
                        }.Serializar();
                        M.Show();
                        M.txtUsuario.Text = nombreusu.ToUpper();
                        M.txtTipoUs.Text = tipousu.ToUpper();
                        M.controlUsuario(tipousu);

                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña no valido");

                    }
                    }
                    

                }
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
       
        }
        }
    }

