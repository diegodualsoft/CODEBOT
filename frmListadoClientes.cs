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
    public partial class frmListadoClientes : Form
    {
        claseBD CBd = new claseBD();
        public frmListadoClientes()
        {
            InitializeComponent();
        }
     
        

        private void cmdAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ventana de Ayuda");
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu F = new frmMenu();
            F.Show();
        }

       

        private void cmdVerPerfil_Click(object sender, EventArgs e)
        {
            frmVerPerfil v = new frmVerPerfil();
            try
            {
                
                String dato = this.dgvListaCLI.CurrentRow.Cells["grdRUT"].Value.ToString();
                
                
                v.dato1 = dato;
                v.Show();

                this.Hide();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {

            llenarDgv();
            if (dgvListaCLI.Rows.Count == 0)
            {
                dgvListaCLI.Enabled = false;
            }

        }

        private void llenarDgv ()
        {
             string CadSql;
            CadSql = "select a.rut,a.razon_social,a.giro,a.nombres,a.direccion,a.telefono,a.comuna,a.ciudad,a.vendedor,a.NF from clientes a";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvListaCLI.RowCount = 0;
                while (Rec.Read())
                {
                    dgvListaCLI.RowCount = dgvListaCLI.RowCount + 1;
                    fila = dgvListaCLI.RowCount - 1;
                    dgvListaCLI.Rows[fila].Cells[0].Value = Rec["rut"].ToString();
                    dgvListaCLI.Rows[fila].Cells[1].Value = Rec["razon_social"].ToString();
                    dgvListaCLI.Rows[fila].Cells[2].Value = Rec["giro"].ToString();
                    dgvListaCLI.Rows[fila].Cells[3].Value = Rec["nombres"].ToString();
                    dgvListaCLI.Rows[fila].Cells[4].Value = Rec["direccion"].ToString();
                    dgvListaCLI.Rows[fila].Cells[5].Value = Rec["telefono"].ToString();
                    dgvListaCLI.Rows[fila].Cells[6].Value = Rec["comuna"].ToString();
                    dgvListaCLI.Rows[fila].Cells[7].Value = Rec["ciudad"].ToString();
                    dgvListaCLI.Rows[fila].Cells[8].Value = Rec["vendedor"].ToString();
                    dgvListaCLI.Rows[fila].Cells[9].Value = Rec["NF"].ToString();
                    
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
            if (!txtBuscar.Text.Equals("") || !txtBuscar.Text.Equals(null))
            {
                if (cboBuscar.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un filtro de busqueda");
                    llenarDgv();
                }
                else if (cboBuscar.SelectedIndex == 0)
                {
                    BuscarDGV("rut");

                }
                else if (cboBuscar.SelectedIndex == 1)
                {
                    BuscarDGV("razon_social");

                }
                else if (cboBuscar.SelectedIndex == 2)
                {
                    BuscarDGV("giro");

                }
                else if (cboBuscar.SelectedIndex == 3)
                {
                    BuscarDGV("nombres");

                }
                else if (cboBuscar.SelectedIndex == 4)
                {
                    BuscarDGV("direccion");

                }
                else if (cboBuscar.SelectedIndex == 5)
                {
                    BuscarDGV("telefono");

                }
                else if (cboBuscar.SelectedIndex == 6)
                {
                    BuscarDGV("comuna");

                }
                else if (cboBuscar.SelectedIndex == 7)
                {
                    BuscarDGV("ciudad");
                    
                }
                else if (cboBuscar.SelectedIndex == 8)
                {
                    BuscarDGV("vendedor");

                }
                else if (cboBuscar.SelectedIndex == 9)
                {
                    BuscarDGV("NF");

                }



            }
            else
            {
                MessageBox.Show("Ingrese un valor para buscar");
                llenarDgv();
            }

        }

        private void BuscarDGV(string dato)
        {
            string CadSql;
            CadSql = "select rut ,nombres,razon_social,giro,direccion,telefono,comuna,ciudad,vendedor,NF from clientes where  " + dato + " like '%" + txtBuscar.Text + "%';";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvListaCLI.RowCount = 0;
                while (Rec.Read())
                {
                    dgvListaCLI.RowCount = dgvListaCLI.RowCount + 1;
                    fila = dgvListaCLI.RowCount - 1;
                    dgvListaCLI.Rows[fila].Cells[0].Value = Rec["rut"].ToString();
                    dgvListaCLI.Rows[fila].Cells[1].Value = Rec["razon_social"].ToString();
                    dgvListaCLI.Rows[fila].Cells[2].Value = Rec["giro"].ToString();
                    dgvListaCLI.Rows[fila].Cells[3].Value = Rec["nombres"].ToString();
                    dgvListaCLI.Rows[fila].Cells[4].Value = Rec["direccion"].ToString();
                    dgvListaCLI.Rows[fila].Cells[5].Value = Rec["telefono"].ToString();
                    dgvListaCLI.Rows[fila].Cells[6].Value = Rec["comuna"].ToString();
                    dgvListaCLI.Rows[fila].Cells[7].Value = Rec["ciudad"].ToString();
                    dgvListaCLI.Rows[fila].Cells[8].Value = Rec["vendedor"].ToString();
                    dgvListaCLI.Rows[fila].Cells[9].Value = Rec["NF"].ToString();


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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                llenarDgv();
            }
        }

        private void dgvListaCLI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIngresoCLI f = new frmIngresoCLI();
            f.Show();
            this.Hide();
        }

        
    }
}
