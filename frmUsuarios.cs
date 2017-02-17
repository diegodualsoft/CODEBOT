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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegistroUs_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario fru = new frmRegistroUsuario();
            fru.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
 
        }

        private void btnEliminarUs_Click(object sender, EventArgs e)
        {
            frmEliminarUsuario frmEU = new frmEliminarUsuario();
            frmEU.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frmAcuUsuario().ShowDialog();
        }
    }
}
