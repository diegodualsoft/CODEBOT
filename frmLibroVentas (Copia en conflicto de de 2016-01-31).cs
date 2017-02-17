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
    public partial class frmLibroVentas : Form
    {
        public frmLibroVentas()
        {
            InitializeComponent();
        }
        private void sumaiva()
        {

            double totaliva = 0;
                    foreach (DataGridViewRow row in dgvLista.Rows)
                    {
                        totaliva += Convert.ToDouble(row.Cells["IVA"].Value);
                    }
                    txtImpuestos.Text = Convert.ToString(totaliva);

                    double totalcosto = 0;
                    foreach (DataGridViewRow row in dgvLista.Rows)
                    {
                        totalcosto += Convert.ToDouble(row.Cells["totalcosto"].Value);
                    }
                    txtCostos.Text = Convert.ToString(totalcosto);
                    double totalventa = 0, resultado = 0;
                    foreach (DataGridViewRow row in dgvLista.Rows)
                    {
                        totalventa += Convert.ToDouble(row.Cells["totalventa"].Value);
                    }
                    txttotventas.Text = totalventa.ToString();
                    resultado = totalventa - totalcosto;
                    txtTotal.Text = resultado.ToString();
                    

                    

 

       
        }
        private void llenarDGV()
        {

            string CadSql;
            CadSql = "select * from libro where fecha = '"+dateTimePicker1.Text+"';";

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
                    dgvLista.RowCount = dgvLista.RowCount +1;
                    fila = dgvLista.RowCount - 1;
                    dgvLista.Rows[fila].Cells[0].Value = Rec["fecha"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["nfact"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["impuestos"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["costos"].ToString();  
                    dgvLista.Rows[fila].Cells[4].Value = Rec["totalventa"].ToString();
                    sumaiva();

                  
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

        private void frmLibroVentas_Load(object sender, EventArgs e)
        {
            llenarDGV();

            
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
         
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            this.Hide();
            m.Show();
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            llenarDGV();

        }
    }
}
