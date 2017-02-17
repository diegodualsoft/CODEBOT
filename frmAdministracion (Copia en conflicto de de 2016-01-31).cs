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
            frmFactura fact = new frmFactura();
            fact.Show();
            this.Hide();

        }

        private void cmdProductos_Click(object sender, EventArgs e)
        {
            frmGestionProductos prod = new frmGestionProductos();
            prod.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
