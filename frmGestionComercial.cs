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
    public partial class frmGestionComercial : Form
    {
        public frmGestionComercial()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmFactEmitidas fe =new frmFactEmitidas();
            fe.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmCajaIngreso ing = new frmCajaIngreso();
            ing.Show();
            this.Close();
        }
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            frmMenu a = new frmMenu();
            a.Show();
            this.Close();
        }
        private void cmdgestprov_Click(object sender, EventArgs e)
        {
            frmIngresoPROV ing = new frmIngresoPROV();
            ing.Show();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmNotaCredito ntc = new frmNotaCredito();
            ntc.Show();
            this.Hide();
        }
        private void btnRanking_Click(object sender, EventArgs e)
        {
            frmRanking a = new frmRanking();
            a.Show();
            this.Close();
        }
    }
}
