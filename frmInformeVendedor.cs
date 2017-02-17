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
    public partial class frmInformeVendedor : Form
    {
        public frmInformeVendedor()
        {
            InitializeComponent();
        }

        private void sumaiva2()
        {

            double totaliva = 0, totalneto=0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totaliva += Convert.ToDouble(row.Cells["total"].Value);
            }
            lbltotal.Text = Convert.ToString("$"+totaliva);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totalneto += Convert.ToDouble(row.Cells["neto"].Value);
            }
            lblneto.Text = Convert.ToString("$"+totalneto);


           






        }
        private void sumaiva()
        {
            try
            {

                double netos = 0, net = 0;
                double tota = 0, tot = 0;



                int fila = 0;


                do
                {


                    string vend;
                    vend = this.dataGridView1.Rows[fila].Cells["Vendedor"].Value.ToString();


                    if (vend == cboVendedor.SelectedValue.ToString())
                    {

                        tota = Convert.ToDouble(dataGridView1.Rows[fila].Cells["total"].Value.ToString());

                        tot = tot + tota;

                        lbltotal.Text = Convert.ToString("$" + tot);

                        //MessageBox.Show("efect = " + tot.ToString());


                        netos = Convert.ToDouble(dataGridView1.Rows[fila].Cells["neto"].Value.ToString());

                        net = net + netos;

                        lblneto.Text = Convert.ToString("$" + net);

                        //MessageBox.Show("cheque = " + net.ToString());
                        fila = fila + 1;
                    }
                    else
                    { 

                    }



                }
                while (dataGridView1.RowCount > fila);
            }
            catch
            {
                MessageBox.Show("EL VENDEDOR :" + cboVendedor.Text + " ,NO POSEE VENTAS DURANTE EL MES SELECCIONADO ");
            }
           

        }
        private void cmdcerrar_Click(object sender, EventArgs e)
        {

            Informes n = new Informes();
            n.Show();

            this.Close();


        }
        private void llenard()
        {
            try
            {
                string CadSql;
                CadSql = "select nfact,vendedor,neto,total,cliente,fecha from informevent where vendedor = '" + cboVendedor.SelectedValue.ToString() + "' and fecha = '"+dateTimePicker1.Text+"';";

                claseBD CBd = new claseBD();
                int fila;
                MySqlDataReader Rec = null;
                try
                {

                    CBd.AbrirConexion();
                    Rec = CBd.EjecutarConsulta(CadSql);
                    dataGridView1.RowCount = 0;
                    while (Rec.Read())
                    {
                        dataGridView1.RowCount = dataGridView1.RowCount + 1;
                        fila = dataGridView1.RowCount - 1;
                        dataGridView1.Rows[fila].Cells[0].Value = Rec["nfact"].ToString();
                        dataGridView1.Rows[fila].Cells[1].Value = Rec["vendedor"].ToString();
                        dataGridView1.Rows[fila].Cells[2].Value = Rec["neto"].ToString();
                        dataGridView1.Rows[fila].Cells[3].Value = Rec["total"].ToString();
                        dataGridView1.Rows[fila].Cells[4].Value = Rec["cliente"].ToString();
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
            catch
            {
                MessageBox.Show("Seleccione Un Vendedor");
            }
        }

        ClaseFunciones a = new ClaseFunciones();
        private void frmInformeVendedor_Load(object sender, EventArgs e)
        {
            String CadSqlX;
            CadSqlX = "select nom_ven, des_ven from vendedores";
            a.llenarCombo(CadSqlX, cboVendedor, "des_ven", "des_ven");
            cboVendedor.SelectedIndex = 0;
            lblneto.Text = "";
            lbltotal.Text = "";
        }



        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            lblneto.Text = "";
            lbltotal.Text = "";
            llenard();
            sumaiva2();
            //sumaiva();
        }
    }
}
