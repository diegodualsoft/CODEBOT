using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Prototipo1
{
    public partial class frmkit : Form
    {
        public frmkit()
        {
            InitializeComponent();
        }

        private void frmkit_Load(object sender, EventArgs e)
        {
            getProductos();
           // getComponentes();
        }
        internal void getProductos()
        {
            string sql = "select k.nom_kit as Nombre from productos pro, kit k, kit_producto kp where k.cod_kit = kp.cod_kit and pro.cod_interno = kp.cod_interno group by Nombre ;";
            DataTable produtos = new claseBD().Select_datatable(sql);
            dgvProductos.DataSource = produtos;
        }
        internal void getComponentes(string nombre)
        {
            lstComponentes.Items.Clear();
            try
            {
                string sql = "select cod_interno as code from kit_producto where cod_kit =(select cod_kit from kit where nom_kit = '" + nombre + "');";
                DataTable tmp = new claseBD().Select_datatable(sql);
                DataTable componentes = new DataTable();
                DataColumn dc = new DataColumn("Nombre");
                componentes.Columns.Add(dc);
                foreach (DataRow r in tmp.Rows)
                {
                    string sql_2 = "select nombre_prod as Nombre from productos  where cod_interno=" + r["code"].ToString() + " group by Nombre;";
                    DataTable dt = new claseBD().Select_datatable(sql_2);
                    foreach (DataRow rv in dt.Rows)
                    {
                        componentes.ImportRow(rv);
                    }
                }

                foreach (DataRow row in componentes.Rows)
                {
                    lstComponentes.Items.Add(row["Nombre"].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chlcomponentes_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                getComponentes(dgvProductos.SelectedCells[0].Value.ToString());
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (pnlPrinicpal.Visible)
            {
                pnlAgregarKit.Visible = false;
                pnlCantidades.Visible = false;
            }
            if(pnlCantidades.Visible)
            {
                pnlAgregarKit.Visible = false;
                pnlPrinicpal.Visible = false;
            }
            if(pnlAgregarKit.Visible)
            {
                pnlCantidades.Visible = false;
                pnlPrinicpal.Visible = false;
            }

            lbl_producto.Text = dgvProductos.SelectedCells[0].Value.ToString();
            this.pnlCantidades.Visible = true;

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getComponentes(dgvProductos.SelectedCells[0].Value.ToString());
        }

        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
        }
    }
}
