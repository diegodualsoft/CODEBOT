using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototipo1
{
    public partial class frmAvisoStock : Form
    {
        public frmAvisoStock()
        {
            InitializeComponent();
        }
        private void llenarDgv()
        {
            string CadSql;
            CadSql = "select * from productos where Stock < 0 ;";
            claseBD CBd = new claseBD();

            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvLista.RowCount = 0;
                while (Rec.Read())
                {
                    dgvLista.RowCount = dgvLista.RowCount + 1;
                    fila = dgvLista.RowCount - 1;
                    dgvLista.Rows[fila].Cells[0].Value = Rec["nombre_prod"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["cod_interno"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["cod_interno"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["Stock"].ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["precio_venta"].ToString();


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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAvisoStock_Load(object sender, EventArgs e)
        {

            llenarDgv();
        }
    }
}
