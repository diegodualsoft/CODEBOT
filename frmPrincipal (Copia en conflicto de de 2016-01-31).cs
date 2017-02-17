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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        frmMenu M = new frmMenu();

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void cmdInicio_Click(object sender, EventArgs e)
        {
            M.Show();
            this.Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.progressBar1.Increment(4);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                frmMenu fm = new frmMenu();
                this.Hide();
                fm.Show();

                progressBar1.Value = 0;
                progressBar1.Enabled = false;
            }
        }


        
    }
}
