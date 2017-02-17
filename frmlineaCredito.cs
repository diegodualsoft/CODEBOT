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
    public partial class frmlineaCredito : Form
    {
        public frmlineaCredito()
        {
            InitializeComponent();
        }

        private void llenarDgvClientes()
        {
            string CadSql;
            CadSql = "select rut , nombres, razon_social from clientes;";

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
            finally
            {
                if (Rec != null)
                {
                    CBd.CerrarConexion();
                    Rec.Close();
                    Rec = null;
                }
            }
            


        }
        private void llenarDgvLineaCred()
        {
            string CadSql;
            CadSql = "select * from libro where estado = 'PENDIENTE' and fecha_pago = '" + dateTimePicker1.Text + "' ";

            claseBD CBd2 = new claseBD();
            int fila;
            MySqlDataReader Rec2 = null;
            try
            {

                CBd2.AbrirConexion();
                Rec2 = CBd2.EjecutarConsulta(CadSql);
                dgvCredito.RowCount = 0;
                while (Rec2.Read())
                {
                    dgvCredito.RowCount = dgvCredito.RowCount + 1;
                    fila = dgvCredito.RowCount - 1;
                    dgvCredito.Rows[fila].Cells[0].Value = Rec2["nfact"].ToString();
                    dgvCredito.Rows[fila].Cells[1].Value = Rec2["totalventa"].ToString();
                    dgvCredito.Rows[fila].Cells[2].Value = Rec2["fecha"].ToString();
                    dgvCredito.Rows[fila].Cells[3].Value = Rec2["fecha_pago"].ToString();


                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (Rec2 != null)
                {
                    Rec2.Close();
                    Rec2 = null;
                }
            }



        }

        private void frmlineaCredito_Load(object sender, EventArgs e)
        {
            llenarDgvClientes();
        }


        private void txtBuscarCLI_TextChanged(object sender, EventArgs e)
        {
            if (!txtBuscarCLI.Text.Equals("") || !txtBuscarCLI.Text.Equals(null))
            {
                if (cboBuscarCLI.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un filtro de busqueda");
                    llenarDgvClientes();
                }
                else if (cboBuscarCLI.SelectedIndex == 0)
                {
                    BuscarDGV("rut");

                }
                else if (cboBuscarCLI.SelectedIndex == 1)
                {
                    BuscarDGV("nombres");

                }
                else if (cboBuscarCLI.SelectedIndex == 2)
                {
                    BuscarDGV("razon_social");

                }

            }
            else
            {
                MessageBox.Show("Ingrese un valor para buscar");
                llenarDgvClientes();
            }
        }


            private void BuscarDGV(string dato)
            {
                string CadSql;
                CadSql = "select rut ,nombres,razon_social from clientes where  " + dato + " like '%" + txtBuscarCLI.Text + "%';";

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
                        dgvClientes.Rows[fila].Cells[2].Value = Rec["nombres"].ToString();
                        dgvClientes.Rows[fila].Cells[1].Value = Rec["razon_social"].ToString();



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

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void txtBuscarCLI_TextChanged_1(object sender, EventArgs e)
            {
                try
                {
                    llenarDgvClientes();
                }
                catch
                { }
            }

            private void button4_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                llenarDgvLineaCred();
            }

            private void button5_Click(object sender, EventArgs e)
            {
                this.Close();

            }

            private void button2_Click(object sender, EventArgs e)
            {

            }

            private void label8_Click(object sender, EventArgs e)
            {

            }

            private void label5_Click(object sender, EventArgs e)
            {

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

        
    }
}
