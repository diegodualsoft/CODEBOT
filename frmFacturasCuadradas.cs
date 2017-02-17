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
    public partial class frmFacturasCuadradas : Form
    {
        public frmFacturasCuadradas()
        {
            InitializeComponent();
        }

        private void frmFacturasCuadradas_Load(object sender, EventArgs e)
        {

            llenarDGV();
            sumaiva();

        }
        private void sumaiva()
        {
            try
            {
                double cheque = 0, ch = 0;
                double efectivo = 0, ef = 0;


                int filaa = 0;

                do
                {


                    string nd;
                    nd = this.dgvLista.Rows[filaa].Cells["grdtipopago"].Value.ToString();


                    if (nd == "EFECTIVO")
                    {


                        efectivo = Convert.ToDouble(dgvLista.Rows[filaa].Cells["encaja"].Value);

                        ef = ef + efectivo;

                        txttotefectivo.Text = Convert.ToString(ef);




                    }
                    else
                    {


                        cheque = Convert.ToDouble(dgvLista.Rows[filaa].Cells["encaja"].Value);

                        ch = ch + cheque;
                 
                        txttotcheques.Text = Convert.ToString(ch);


                    }
                    filaa = filaa + 1;

                }
                while (dgvLista.RowCount > filaa);
            }
            catch
            { 
            }

            try
            {
                int resss = 0;
                resss = int.Parse(txttotcheques.Text) + int.Parse(txttotefectivo.Text);
                txttotaltotal.Text = "" + resss;
            }
            catch
            { }

        }
        private void llenarDGV()
        {

            string CadSql;
            CadSql = "select * from factcuad where fecha = '"+dateTimePicker1.Text+"'";

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
                    dgvLista.Rows[fila].Cells[0].Value = Rec["nfact"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["fecha"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["totalfact"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["tipopago"].ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["caja"].ToString();
                    dgvLista.Rows[fila].Cells[5].Value = Rec["restante"].ToString();

                    

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

        private void button1_Click(object sender, EventArgs e)
        {
            llenarDGV();
            sumaiva();
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            llenarDGV();
            sumaiva();
        }

        
    }
}
