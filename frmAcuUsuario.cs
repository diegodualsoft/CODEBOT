using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Collections;

namespace Prototipo1
{
    public partial class frmAcuUsuario : Form
    {
        public frmAcuUsuario()
        {
            InitializeComponent();
        }
        claseBD CBd = new claseBD();

        public string nombreusu = null;
        bool existe = false;
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validacionUsuario()
        {
            string CadSql;
            CadSql = "select * from usuarios where usu_nombre ='" + txtNomUsNuevo.Text + "'; ";
            
            claseBD CBd = new claseBD();
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                while (Rec.Read())
                {
                    nombreusu = Rec["usu_nombre"].ToString();
                    break;
                }
                if (nombreusu==null)
                {
                    existe = false;
                }
                else
                {
                    existe = true;
                }
                CBd.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return existe;
        }
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
        private void button1_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(txtNomUsNuevo.Text.Trim()))
                {

                    MessageBox.Show("Debe completar la informacion");
                    txtNomUsNuevo.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtContraseña.Text.Trim()))
                    {
                        MessageBox.Show("Debe completar la informacion");
                        txtContraseña.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtContraseña2.Text.Trim()))
                        {
                            MessageBox.Show("Debe completar la informacion");
                            txtContraseña2.Focus();
                        }
                        else
                        {
                            if (cbxTipoUsuario.SelectedIndex == -1)
                            {
                                MessageBox.Show("Debe completar la informacion");
                                cbxTipoUsuario.Focus();
                            }
                            else
                            {
                                if (txtContraseña.Text.Trim() == txtContraseña2.Text.Trim())
                                {
                                    try
                                    {
                                        string nom_us = txtNomUsNuevo.Text.Trim();
                                        string pass = txtContraseña.Text.Trim();
                                        string tipo_us = cbxTipoUsuario.SelectedItem.ToString().ToLower();
                                        pass = Encriptar(pass, "dualsoft");
                                        string CadSql;
                                        CadSql = "update usuarios set  usu_tipo='" + tipo_us + "' , usu_llave ='" + pass + "', usu_nombre='" + nom_us + "' where usu_id= " + id_usu.Text + ";";
                                        if (nombreusu == null)
                                        {
                                            try
                                            {
                                                if (CBd.EjecutarIUD(CadSql) > 0)
                                                {
                                                    MessageBox.Show("Usuario actulizado", "Listo");
                                                    limpiar();
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Usuario No actulizado");
                                            txtNomUsNuevo.Focus();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                        }
                    }
                }
        }
        public static string Encriptar(string texto, string key)
        {
            try
            {

                //string key = "lin"; //llave para encriptar datos

                byte[] keyArray;

                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);

                //Se utilizan las clases de encriptación MD5

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                //Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();

                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);

                tdes.Clear();

                //se regresa el resultado en forma de una cadena
                texto = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);

            }
            catch (Exception)
            {

            }
            return texto;
        }
        private void limpiar()
        {
            txtNomUsNuevo.Text = "";
            txtContraseña.Text = "";
            txtContraseña2.Text = "";
            cbxTipoUsuario.SelectedIndex = -1;
        }

        private void frmRegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtNomUsNuevo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar(txtNomUsNuevo.Text);
            }
        }
        private void buscar(string nombre)
        {
            try
            {
                string sql = "select * from usuarios where usu_nombre = '" + nombre + "';";
                DataTable datos = new claseBD().Select_datatable(sql);
                DataRow row = datos.Rows[0];
                id_usu.Text = row["usu_id"].ToString();
                txtNomUsNuevo.Text = row["usu_nombre"].ToString();
                txtContraseña.Text = Desencriptar( row["usu_llave"].ToString(), "dualsoft");
                txtContraseña2.Text = Desencriptar(row["usu_llave"].ToString(), "dualsoft");
                /*
                 * 
                 * CAJA
    ADMINISTRACION
    JUNIOR
    SUPREMO*/
                string tipo = row["usu_tipo"].ToString();
                if (tipo == ("CAJA").ToLower()) { cbxTipoUsuario.SelectedIndex = 0; }
                else if (tipo == ("ADMINISTRACION").ToLower()) { cbxTipoUsuario.SelectedIndex = 1; }
                else if (tipo == ("JUNIOR").ToLower()) { cbxTipoUsuario.SelectedIndex = 2; }
                else if (tipo == ("SUPREMO").ToLower()) { cbxTipoUsuario.SelectedIndex = 3; }

            }
            catch { MessageBox.Show("no existe usuario");

            txtContraseña.Clear();
            txtContraseña2.Clear();
            txtNomUsNuevo.Clear();
            cbxTipoUsuario.SelectedIndex = -1;
            }

        }



    }
}
