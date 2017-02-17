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


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
