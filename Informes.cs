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
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }

        private void Informes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmInformeVendedor iv = new frmInformeVendedor();
            iv.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAdministracion n = new frmAdministracion();
            n.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInformeDeCompra com = new frmInformeDeCompra();
            com.Show();
            this.Close();
        }
    }
}
