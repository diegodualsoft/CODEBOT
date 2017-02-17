using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototipo1
{
    public partial class frmAdministracion : Form
    {
        public frmAdministracion()
        {
            InitializeComponent();
        }
        
        private void cmdLibroDeVentas_Click(object sender, EventArgs e)
        {
            frmLibroVentas lv = new frmLibroVentas();
            lv.Show();
            this.Hide();
        }

        private void cmdFactura_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdProductos_Click(object sender, EventArgs e)
        {
            frmGestionProductos prod = new frmGestionProductos();
            prod.Show();
            this.Hide();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Informes inf = new Informes();
            inf.Show();
            this.Close();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Close();
        }

        private void cmdIngresoVen_Click(object sender, EventArgs e)
        {
            frmAgregarVendedor a = new frmAgregarVendedor();
            a.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLibroVentasBoleta lvb = new frmLibroVentasBoleta();
            lvb.Show();
            this.Hide();
        }

    }
}
