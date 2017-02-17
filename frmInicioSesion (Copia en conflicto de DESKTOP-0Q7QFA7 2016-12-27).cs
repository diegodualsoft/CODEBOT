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
                    passusu = Rec["usu_llave"].ToString();
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
        
        private void IngresarHistorialUsuario(string user,string id)
        {
            claseBD cbsd = new claseBD();
            string cadsqlusu = "insert into ingreso_usuario_caja (usu_id,iuc_nombre,iuc_datos_entrada,iuc_seccion_frm,iuc_caja_numero) values(" + id +",'" + user + "','" + DateTime.Now.ToString() + "','caja',1)";
            cbsd.EjecutarConsulta(cadsqlusu);
            cbsd.CerrarConexion();
        }
       
        private void btnIniciar_Click(object sender, EventArgs e)
        {
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
        }
    }

