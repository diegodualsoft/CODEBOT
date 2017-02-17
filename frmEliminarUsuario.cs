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
    public partial class frmEliminarUsuario : Form
    {
        public frmEliminarUsuario()
        {
            InitializeComponent();
        }
        claseBD cbd = new claseBD();
        string tipousu;

        private void frmEliminarUsuario_Load(object sender, EventArgs e)
        {

            DataTable d = llenarCbx("Select usu_nombre, usu_id from usuarios;");
            cbxUsuarios.DataSource = d;
            cbxUsuarios.DisplayMember = "usu_nombre";
            cbxUsuarios.ValueMember = "usu_id";
            cbxUsuarios.SelectedIndex = -1;
            
        }

        private DataTable llenarCbx(string sql)
        {
            cbd.AbrirConexion();
            string str=sql;
            DataTable dt=new DataTable();
            MySqlCommand cmd=claseBD.conex.CreateCommand();
            ((DbCommand)cmd).CommandText=str;
            ((DbDataAdapter)new MySqlDataAdapter(cmd)).Fill(dt);
            cbd.CerrarConexion();
            return dt;
        }

        private void cbxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxUsuarios.SelectedIndex>0)
            {
                selectIndex();
            }
        }
        private void selectIndex()
        {
            string CadSql;
            CadSql = "Select usu_tipo from usuarios where usu_id=" + cbxUsuarios.SelectedValue.ToString() + ";";
            MySqlDataReader Rec = null;
            Rec= cbd.EjecutarConsulta(CadSql);
            while (Rec.Read())
            {
                tipousu = Rec["usu_tipo"].ToString();
            }
            txtNivel.Text = tipousu;
            Rec.Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            this.Close();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            string CadSql;
            CadSql = "Delete from Usuarios where usu_id="+cbxUsuarios.SelectedValue.ToString()+";";
            try
            {
                if (cbd.EjecutarIUD(CadSql) > 0)
                {
                    MessageBox.Show("Usuario Eliminado");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
             private void limpiar()
        {
            cbxUsuarios.SelectedIndex=-1;
            txtNivel.Text="";
        }

            

        }
    
}
