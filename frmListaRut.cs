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
    public partial class frmListaRut : Form
    {
        public frmListaRut()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            String dato = this.dgvClientes.CurrentRow.Cells["grdRUT"].Value.ToString();
            
            
        }

        private void frmListaRut_Load(object sender, EventArgs e)
        {
            
            llenarDgv();
            if (dgvClientes.Rows.Count == 0)
            {
                dgvClientes.Enabled = false;
            }
           
        }

        private void llenarDgv()
        {
            string CadSql;
            CadSql = "select rut ,nombres,razon_social from clientes a;";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvClientes.RowCount = 0;
                while (Rec.Read())
                {
                    dgvClientes.RowCount = dgvClientes.RowCount + 1;
                    fila = dgvClientes.RowCount - 1;
                    dgvClientes.Rows[fila].Cells[0].Value = Rec["rut"].ToString();
                    dgvClientes.Rows[fila].Cells[1].Value = Rec["nombres"].ToString();
                    dgvClientes.Rows[fila].Cells[2].Value = Rec["razon_social"].ToString();
                    

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

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            
          
        }

        
        private void llenarcbo(string tabla)
        {

            string CadSql;
            CadSql = "select rut ,nombres,razon_social from clientes where  " + tabla + " like '%" + txtBusqueda.Text + "%';";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvClientes.RowCount = 0;
                while (Rec.Read())
                {
                    dgvClientes.RowCount = dgvClientes.RowCount + 1;
                    fila = dgvClientes.RowCount - 1;
                    dgvClientes.Rows[fila].Cells[0].Value = Rec["rut"].ToString();
                    dgvClientes.Rows[fila].Cells[1].Value = Rec["nombres"].ToString();
                    dgvClientes.Rows[fila].Cells[2].Value = Rec["razon_social"].ToString();
                    

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
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if(!txtBusqueda.Text.Equals(""))
            {

                if (cboFiltro.SelectedIndex == -1)
                {

                    MessageBox.Show("Seleccione filtro de busqueda","ERROR");
                    llenarDgv();

                } 
                else if(cboFiltro.SelectedIndex==0)
                {

                    llenarcbo("rut");
            
                } 
                else if(cboFiltro.SelectedIndex==1)
                {
                    llenarcbo("nombres");
            
                }
            
            
            }
            else
            {
                MessageBox.Show("Ingrese un valor a la busqueda","ERROR");
                llenarDgv();
            }
        }

        }

        


    }

