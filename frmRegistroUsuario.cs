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

namespace Prototipo1
{
    public partial class frmRegistroUsuario : Form
    {
        public frmRegistroUsuario()
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
 
                                validacionUsuario();
                                if(existe==false)
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
                                        CadSql = "Insert into usuarios(usu_tipo,usu_llave,usu_nombre) values('" + tipo_us + "','" + pass + "','" + nom_us + "');";

                                       if (nombreusu == null)
                                        {
                                            try
                                            {
                                                if (CBd.EjecutarIUD(CadSql) > 0)
                                                {
                                                    MessageBox.Show("Usuario Registrado", "Listo");
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
                                            MessageBox.Show("Usuario No Registrado");
                                            txtNomUsNuevo.Focus();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                }
                                else
                                {
                                    MessageBox.Show("El usuario ya existe");
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



    }
}
