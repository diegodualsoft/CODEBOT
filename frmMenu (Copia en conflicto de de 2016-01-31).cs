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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        

        private void frmMenu_Load(object sender, EventArgs e)
        {

           
            lblSalir.Visible = false;
            lblGestionCli.Visible = false;
            lblAbirCaja.Visible = false;
     
            


        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void cmdIngreso_Click(object sender, EventArgs e)
        {
            frmIngresoCLI F = new frmIngresoCLI();
            F.Show();
            this.Hide();
        }

        private void cmdGestionClientes_Click(object sender, EventArgs e)
        {
            frmListadoClientes F = new frmListadoClientes();
            F.Show();
            this.Hide();
        }

        private void cmdIngresoVehiculos_Click(object sender, EventArgs e)
        {
       

            this.Hide();
        }

        
        

        private void cmdFactura_Click(object sender, EventArgs e)
        {
            frmFactura fact = new frmFactura();
            fact.Show();
            this.Hide();

        }

        private void cmdAbrirCaja_MouseHover(object sender, EventArgs e)
        {
            lblAbirCaja.Visible = true;
        }

        private void cmdAbrirCaja_Click(object sender, EventArgs e)
        {
            frmGuiaDespacho f = new frmGuiaDespacho();
            f.Show();
            this.Hide();

        }

        private void cmdLibroDeVentas_Click(object sender, EventArgs e)
        {
            frmLibroVentas flv = new frmLibroVentas();
            flv.Show();
            this.Hide();
        }

        
        private void cmdProductos_Click(object sender, EventArgs e)
        {
            frmGestionProductos GP = new frmGestionProductos();
            GP.Show();
            this.Close();

        }

       

        private void cmdAdmin_Click(object sender, EventArgs e)
        {
            frmAdministracion admin = new frmAdministracion();
            admin.Show();
            this.Hide();
        }

        private void cmdGesvehiculos_Click(object sender, EventArgs e)
        {
         
        }

        private void cmdGesClientes_Click(object sender, EventArgs e)
        {
            frmGestionClientes gc = new frmGestionClientes();
            gc.Show();
            this.Hide();
        }

        private void lblGestionCli_MouseHover(object sender, EventArgs e)
        {
            lblGestionCli.Visible = true;
        }

        private void lblGestionCli_MouseLeave(object sender, EventArgs e)
        {
            lblGestionCli.Visible = false;
        }

        private void cmdGesvehiculos_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void cmdGesvehiculos_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cmdAbrirCaja_MouseHover_1(object sender, EventArgs e)
        {
            lblAbirCaja.Visible = true;
        }

        private void cmdAbrirCaja_MouseLeave(object sender, EventArgs e)
        {
            lblAbirCaja.Visible = false;
        }

        private void cmdAdmin_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void cmdAdmin_MouseLeave(object sender, EventArgs e)
        {
     
        }

        private void cmdSalir_MouseHover(object sender, EventArgs e)
        {
            lblSalir.Visible = true;
        }

        private void cmdSalir_MouseLeave(object sender, EventArgs e)
        {
            lblSalir.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFactEmitidas f = new frmFactEmitidas();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGestionComercial fc = new frmGestionComercial();
            fc.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmInformeDeCarga ic = new frmInformeDeCarga();
            ic.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmImprirfacturasFecha f2 = new frmImprirfacturasFecha();
            f2.Show();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {

        }

        

        
        
    }
}
