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
    public partial class frmBuscarProdCaja : Form
    {
        public frmBuscarProdCaja()
        {
            InitializeComponent();
        }

        private void llenarDGV()
        {
            string CadSql;
            CadSql = "select nombre_prod,cod_interno,cod_barra,Stock from productos ;";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvListaBuscar.RowCount = 0;
                while (Rec.Read())
                {
                    dgvListaBuscar.RowCount = dgvListaBuscar.RowCount + 1;
                    fila = dgvListaBuscar.RowCount - 1;
                    dgvListaBuscar.Rows[fila].Cells[0].Value = Rec["nombre_prod"].ToString();
                    dgvListaBuscar.Rows[fila].Cells[1].Value = Rec["cod_interno"].ToString();
                    dgvListaBuscar.Rows[fila].Cells[2].Value = Rec["cod_barra"].ToString();
                    dgvListaBuscar.Rows[fila].Cells[3].Value = Rec["Stock"].ToString();


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

        private void cmdObtener_Click(object sender, EventArgs e)
        {
          
            
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (!txtBuscar.Text.Equals("") || !txtBuscar.Text.Equals(null))
            {
                if (cboBuscar.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un filtro de busqueda");
                    llenarDGV();
                }
                else if (cboBuscar.SelectedIndex == 0)
                {
                    busca("nombre_prod");

                }
                else if (cboBuscar.SelectedIndex == 1)
                {
                    busca("cod_interno");

                }
                else if (cboBuscar.SelectedIndex == 2)
                {
                    busca("cod_barra");

                }



            }
            else
            {
                MessageBox.Show("Ingrese un valor para buscar");
                llenarDGV();
            }
        }

        private void frmBuscarProdCaja_Load(object sender, EventArgs e)
        {
            llenarDGV();
        }

        private void busca(string dato)
        {
            string CadSql;
            CadSql = "select nombre_prod, cod_interno, cod_barra from productos where  " + dato + " like '%" + txtBuscar.Text + "%';";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvListaBuscar.RowCount = 0;
                while (Rec.Read())
                {
                    dgvListaBuscar.RowCount = dgvListaBuscar.RowCount + 1;
                    fila = dgvListaBuscar.RowCount - 1;
                    dgvListaBuscar.Rows[fila].Cells[0].Value = Rec["nombre_prod"].ToString();
                    dgvListaBuscar.Rows[fila].Cells[1].Value = Rec["cod_interno"].ToString();
                    dgvListaBuscar.Rows[fila].Cells[2].Value = Rec["cod_barra"].ToString();
                    


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

       
    }
}
