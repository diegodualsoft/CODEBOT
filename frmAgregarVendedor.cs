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
    public partial class frmAgregarVendedor : Form
    {
        public frmAgregarVendedor()
        {
            InitializeComponent();
        }
        claseBD CBd = new claseBD();
        private void llenarDgv()
        {
            string CadSql;
            CadSql = "select des_ven,nom_ven from vendedores";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvVendedores.RowCount = 0;
                while (Rec.Read())
                {
                    dgvVendedores.RowCount = dgvVendedores.RowCount + 1;
                    fila = dgvVendedores.RowCount - 1;
                    dgvVendedores.Rows[fila].Cells[0].Value = Rec["nom_ven"].ToString();
                    dgvVendedores.Rows[fila].Cells[1].Value = Rec["des_ven"].ToString();
                    

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

        private void limpiar()
        {
            txtIniciales.Text = "";
            txtNombreVendedor.Text = "";
        }

        private void BuscarDGV()
        {
            string CadSql;
            CadSql = "select nom_ven,des_ven from vendedores where  nom_ven like '%" + txtBuscar.Text + "%';";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvVendedores.RowCount = 0;
                while (Rec.Read())
                {
                    dgvVendedores.RowCount = dgvVendedores.RowCount + 1;
                    fila = dgvVendedores.RowCount - 1;
                    dgvVendedores.Rows[fila].Cells[0].Value = Rec["nom_ven"].ToString();
                    dgvVendedores.Rows[fila].Cells[1].Value = Rec["des_ven"].ToString();
                    



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

        private void frmAgregarVendedor_Load(object sender, EventArgs e)
        {
            llenarDgv();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                BuscarDGV();
            }
            else
            {
                llenarDgv();
            }
            
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreVendedor.Text != "" && txtIniciales.Text !="")
            {
                
                string CadSql;
                CadSql = "insert into vendedores values('" + txtIniciales.Text.ToUpper() + "','" + txtNombreVendedor.Text.ToUpper() + "');";

               
                try
                {
                    if (CBd.EjecutarIUD(CadSql) > 0)
                    {
                        MessageBox.Show("Vendedor Registrado", "Listo");
                        limpiar();

                    }
                    else
                    {
                        MessageBox.Show("Vendedor NO Registrado", "ERROR");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los datos para ingresarlos");
            }
            llenarDgv();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string CadSql;
            String dato = this.dgvVendedores.CurrentRow.Cells["grdNombre"].Value.ToString();

            try
            {
                CadSql = "delete from vendedores where nom_ven='" + dato + "';";



                try
                {
                    if (CBd.EjecutarIUD(CadSql) > 0)
                    {
                        MessageBox.Show("Vendedor Eliminado");
                        limpiar();


                    }
                    else
                    {
                        MessageBox.Show("Vendedor NO Eliminado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dato = "";
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un vendedor desde la tabla para eliminarlo");
            }
            
            llenarDgv();
}

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            frmAdministracion n = new frmAdministracion();
            n.Show();
            this.Close();
        }

        

        


    }
}
