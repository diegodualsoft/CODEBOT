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
    public partial class frmBanco : Form
    {
        public frmBanco()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEmisionesChequera rep = new frmEmisionesChequera();
            this.Hide();
            rep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
