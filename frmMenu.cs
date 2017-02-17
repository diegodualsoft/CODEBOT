using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        claseBD CBd = new claseBD();
        
     
        public string user{get; set;}
       
        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblSalir.Visible = false;
            lblGestionCli.Visible = false;
            lblAbirCaja.Visible = false;
            lblImpresion.Visible = false;
            lblInformeCarga.Visible = false;
            lblAdmin.Visible = false;
            lblGesComercial.Visible = false;
            lblGesUsuarios.Visible = false;

                cargaPermisos();
            
           
        }
        internal void cargaPermisos()
        {
            try
            {
                DataSet data = new DataSet();
                data.ReadXml("C:\\pos\\login.xml");
                DataRow[] row = data.Tables["login"].Select();
                txtUsuario.Text = row[0]["usu"].ToString();
                controlUsuario(row[0]["tip"].ToString());
            }
            catch { }
        }
        public void controlUsuario(string TipoUs)
        {
            TipoUs = TipoUs.ToUpper();
            txtTipoUs.Text = TipoUs;
            if (TipoUs == "CAJA")
            {
                MessageBox.Show("El Usuario no esta autorizado a usar este SISTEMA ");
                Application.Exit();
            }
            else
            {
                if (TipoUs == "ADMINISTRACION")
                {
                    cmdGesClientes.Enabled = true;
                    cmdAbrirCaja.Enabled = true;
                    button1.Enabled = true;
                    cmdAdmin.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
                else
                {
                    if (TipoUs == "JUNIOR")
                    {
                        cmdGesClientes.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                        btnUsuarios.Enabled = true;
                        cmdAdmin.Enabled = true;
                    }
                    else
                    {
                        if (TipoUs == "SUPREMO")
                        {
                            cmdGesClientes.Enabled = true;
                            cmdAbrirCaja.Enabled = true;
                            button1.Enabled = true;
                            cmdAdmin.Enabled = true;
                            button2.Enabled = true;
                            button3.Enabled = true;
                            btnUsuarios.Enabled = true;
                        }
                    }
                }
            }
        }
        public string obtenerTipoUsuario(string user)
        {
          
            string CadSql;
            CadSql = "Select * from usuarios where usu_nombre = '"+user+"';";
            string resultado = "";
            CBd.AbrirConexion();
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                while(Rec.Read())
                {
                    resultado = Rec["usu_tipo"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return resultado;

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
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
            

        }

        private void cmdAbrirCaja_MouseHover(object sender, EventArgs e)
        {
            lblAbirCaja.Visible = true;
        }

        private void cmdAbrirCaja_Click(object sender, EventArgs e)
        {
            //frmCajaFactura gp = new frmCajaFactura();
            //gp.Show();
            //this.Hide();
            MessageBox.Show("SISTEMA NO HABILITADO PARA FACTURAR, ESTADO: EN PROSCESO, ORDEN: GERENCIA PATAGONIA BEEF SPA");

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
           // frmGestionClientes gc = new frmGestionClientes();
           // gc.Show();
           //this.Hide();

            frmListadoClientes f = new frmListadoClientes();
            f.Show();
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
            lblAdmin.Visible = true;
        }

        private void cmdAdmin_MouseLeave(object sender, EventArgs e)
        {
            lblAdmin.Visible = false;
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
            this.WindowState = FormWindowState.Minimized;
          this.Close();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmInformeDeCarga ic = new frmInformeDeCarga();
            ic.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmImprimirFacturasFecha f2 = new frmImprimirFacturasFecha();
            f2.Show();
        }


        private void button1_MouseHover(object sender, EventArgs e)
        {
            lblGesComercial.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblGesComercial.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            lblInformeCarga.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            lblInformeCarga.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            lblImpresion.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            lblImpresion.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBanco mb  = new frmBanco();
            mb.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmlineaCredito fl = new frmlineaCredito();
            fl.Show();
            
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios fU = new frmUsuarios();
            fU.Show();
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            lblGesUsuarios.Visible = true;
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            lblGesUsuarios.Visible = false;
        }

        private void txtTipo_Click(object sender, EventArgs e)
        {

        }

        private void lblDesconexion_DoubleClick(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoUs_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDesconexion_Click(object sender, EventArgs e)
        {

        }
    }
}
