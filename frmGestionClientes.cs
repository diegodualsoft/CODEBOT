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
    public partial class frmGestionClientes : Form
    {
        public frmGestionClientes()
        {
            InitializeComponent();
        }

        private void frmGestionClientes_Load(object sender, EventArgs e)
        {

        }

        private void cmdIngreso_Click(object sender, EventArgs e)
        {
            frmIngresoCLI f = new frmIngresoCLI();
            f.Show();
            this.Hide();

        }

        private void cmdGestionClientes_Click(object sender, EventArgs e)
        {
            frmListadoClientes f = new frmListadoClientes();
            f.Show();
            this.Hide();
        }

        private void frmVolver_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            this.Hide();
            m.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
