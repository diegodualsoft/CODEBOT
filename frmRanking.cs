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
    public partial class frmRanking : Form
    {
        public frmRanking()
        {
            InitializeComponent();
        }

        claseBD CBd = new claseBD();
        private void llenarDgv()
        {
            string fechaIni = null;
            fechaIni = (FechaYMD(dtpinicio.Text));
            string CadSql;
            CadSql = "select * from ranking where fecha ='" + fechaIni + "';";


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
                    dgvLista.Rows[fila].Cells[0].Value = Rec["nombre"].ToString();


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
                CBd.CerrarConexion();
            }
        }

        private String[] meses = { "01", "03", "05", "07", "08", "10", "12" };
        private String[] bisiestos = { "2000", "2004", "2008", "2012", "2016", "2020", "2024", "2028", "2032", "2036", "2040", "2044", "2048", "2052", "2056", "2060", "2064" };
        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String dato = this.dgvLista.CurrentRow.Cells["grdProducto"].Value.ToString();
            txtproducto.Text = dato;
            claseBD a = new claseBD();

        }

        private void frmRanking_Load(object sender, EventArgs e)
        {
            llenarDgv();
        }

        private void dtpinicio_ValueChanged(object sender, EventArgs e)
        {
            llenarDgv();
        }
        public static string FechaYMD(string Fecha)
        {
            string dia, mes, year, strFecha;
            dia = Fecha.Substring(0, 2);
            mes = Fecha.Substring(3, 2);
            year = Fecha.Substring(6, 4);
            strFecha = year + "-" + mes + "-" + dia;
            return (strFecha);

        }

        public static string FechaDMY(string Fecha)
        {
            string dia, mes, year, strFecha;
            dia = Fecha.Substring(9, 2);
            mes = Fecha.Substring(6, 2);
            year = Fecha.Substring(0, 4);
            strFecha = dia + "-" + mes + "-" + year;
            return (strFecha);

        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaIni = null;
                string fechaFin = null;
                fechaIni = (FechaYMD(dtpinicio.Text));
                fechaFin = (FechaYMD(dtpfinal.Text));
                txtproducto.Text = dgvLista.CurrentRow.Cells["grdProducto"].Value.ToString();

                string cadsql = "select *,sum(cantidad) from ranking where fecha between '" + fechaIni + "' and '" + fechaFin + "' and nombre = '" + txtproducto.Text + "';";

                MySqlDataReader Rec = null;
                try
                {
                    CBd.AbrirConexion();
                    Rec = CBd.EjecutarConsulta(cadsql);
                    while (Rec.Read())
                    {
                        lblnombreproducto.Text = Rec["nombre"].ToString();
                        lblcantidadproducto.Text = Rec["sum(cantidad)"].ToString();


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
                    CBd.CerrarConexion();
                }
            }
            catch
            { }
        }
       
     
        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Close();
        }

        //----------------------------------------------------------------------------------------
    }
}
