﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototipo1
{
    public partial class frmingresoProductoEspecifico : Form
    {
        public frmingresoProductoEspecifico()
        {
            InitializeComponent();
        }

        private void frmingresoProductoEspecifico_FormClosed(object sender, FormClosedEventArgs e)
        {
            new frmVerPerfil().ShowDialog();
        }

        private void llenarGrillaProductos()
        {

        }
      
    }
}
