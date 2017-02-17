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
    public partial class frmGestionProductos : Form
    {
        public frmGestionProductos()
        {
            InitializeComponent();
        }
        claseBD CBd = new claseBD();
        private void frmGestionProductos_Load(object sender, EventArgs e)
        {
            llenarDgv();
        }


        private void llenarDgv()
        {
            string CadSql;
            CadSql = "select nombre_prod,cod_interno,cod_barra, precio_costo, precio_venta from productos ;";

            
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
                    dgvLista.Rows[fila].Cells[2].Value = Rec["cod_barra"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["precio_costo"].ToString() ;
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

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            frmMenu M = new frmMenu();
            M.Show();
            this.Hide();
        }

        private void cmdIngresarProductos_Click(object sender, EventArgs e)
        {
            frmAgregarProducto AP = new frmAgregarProducto();
            AP.Show();
            this.Hide();
            
        }

        private void ingresogrdcaja(KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                llenarDgv();
            }
        }

        private void cmdCambioPrecio_Click(object sender, EventArgs e)
        {

            String dato = this.dgvLista.CurrentRow.Cells["grdCodInterno"].Value.ToString();
            if (!dato.Equals("") || !dato.Equals(null))
            {
                frmActualizaPreciocs l = new frmActualizaPreciocs();
                l.dato = dato;
                l.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un producto de la lista", "ERROR");
            }
           
        }

        private void busca(string dato)
        {
            string CadSql;
            CadSql = "select nombre_prod, cod_interno, cod_barra, precio_costo, precio_venta from productos where  " + dato + " like '%" + txtBuscar.Text + "%';";

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
                    dgvLista.Rows[fila].Cells[2].Value = Rec["cod_barra"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["precio_costo"].ToString() ;
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
                else if (cboBuscar.SelectedIndex == 3)
                {
                    busca("precio_costo");

                }
                else if (cboBuscar.SelectedIndex == 4)
                {
                    busca("precio_venta");

                }


            }
            else
            {
                MessageBox.Show("Ingrese un valor para buscar");
                llenarDgv();
            }
        }

        private void cmdEliminarProd_Click(object sender, EventArgs e)
        {
            string CadSql;
            String dato = this.dgvLista.CurrentRow.Cells["grdCodInterno"].Value.ToString();
            CadSql = "delete from productos where cod_interno='" + dato + "';";



            try
            {
                if (CBd.EjecutarIUD(CadSql) > 0)
                {
                    MessageBox.Show("Producto Eliminado", "Listo");



                }
                else
                {
                    MessageBox.Show("Producto NO Eliminado", "ERROR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                llenarDgv();
            }

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ingresogrdcaja(e);
        }
    }
}
