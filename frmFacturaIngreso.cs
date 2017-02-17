using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototipo1
{
    public partial class frmFacturaIngreso : Form
    {
        public frmFacturaIngreso()
        {
            InitializeComponent();
            
        }
        ClaseFunciones a = new ClaseFunciones();
        private void truncartabla()
        {

            string cadsql = "truncate table grillafacturaprov ; ";
            string TRUNCAJA = "truncate table cajaingreso";
            claseBD CBd = new claseBD();
            int fila;
            CBd.EjecutarIUD(TRUNCAJA);
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(cadsql);

                dgvLista.RowCount = 0;
                while (Rec.Read())
                {
                    dgvLista.RowCount = dgvLista.RowCount + 1;
                    fila = dgvLista.RowCount - 1;
                    dgvLista.Rows[fila].Cells[0].Value = Rec["nombre_prod"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["cod_interno"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["cod_barra"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["precio_venta"].ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["precio_costo"].ToString();


                }
            }
            
            finally
            {
                if (Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                }
            }
        }
   





        private void cmdSalir_Click(object sender, EventArgs e)
        {
            string cadsql = "truncate table grillafacturaprov ; ";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(cadsql);

                dgvLista.RowCount = 0;
                while (Rec.Read())
                {
                    dgvLista.RowCount = dgvLista.RowCount + 1;
                    fila = dgvLista.RowCount - 1;
                    dgvLista.Rows[fila].Cells[0].Value = Rec["nombre_prod"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["cod_interno"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["cod_barra"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["precio_venta"].ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["precio_costo"].ToString();


                }
            }
            
            finally
            {
                if (Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                }
            }

            this.Hide();
       
            //m.Show();
        }

        private void mskRUT_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Letra = e.KeyChar;
            if (!char.IsDigit(Letra) && Letra != 'k' && Letra != 'K')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void convierte()
        {
            double NUMSubtotales = Convert.ToDouble(txtsubtotales.Text);
      
      
            txtTotalesSinIva.Text = NUMSubtotales.ToString();
       
        }

        private void llenarDgvClientes2()
        {
            string CadSql;
            CadSql = "select rut,giro,razon from proveedores a;";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvClientes.RowCount = 0;
                while (Rec.Read())
                {
                    dgvClientes.RowCount = dgvClientes.RowCount + 1;
                    fila = dgvClientes.RowCount - 1;
                    dgvClientes.Rows[fila].Cells[0].Value = Rec["rut"].ToString();
                    dgvClientes.Rows[fila].Cells[1].Value = Rec["giro"].ToString();
                    dgvClientes.Rows[fila].Cells[2].Value = Rec["razon"].ToString();
                }

            }
            catch
            { }
            try
            {

                convierte();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
   
        
        private void frmFactura_Load(object sender, EventArgs e)
        {


            Ndoc.Visible = false;

            lblglosa.Visible = false;

            cboBuscar.SelectedIndex = 0;

            llenarDGV();
         
            llenarDgvClientes2();
            
            claseBD.conex.Close();
            
        }
        
        private void llenarDGV()
        {
            
            string CadSql;
            CadSql = "select * from grillafacturaprov ;";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvLista.RowCount = 0;
                while (Rec.Read())
                {
                    dgvLista.RowCount = dgvLista.RowCount + 1;
                    fila = dgvLista.RowCount - 1;
                    dgvLista.Rows[fila].Cells[0].Value = Rec["cod_interno"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["nombre_prod"].ToString();  
                    dgvLista.Rows[fila].Cells[2].Value = Rec["precio_venta"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["precio_costo"].ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["cantidad"].ToString();
                    dgvLista.Rows[fila].Cells[5].Value = Rec["total"].ToString();          
                    txtsubtotales.Text = Rec["subtotal"].ToString();
                    txtiva.Text = Rec["iva"].ToString();
                    txttotales.Text = Rec["totales"].ToString();
                    lblcostofact.Text = Rec["precio_costo"].ToString();      
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                }
            
            }
        }

        private bool verifica()
        {
            bool verifica = true;
            if (txtRazon.Text == "")
            {
                verifica = false;
            }
            else if (txtGiro.Text == "")
            {
                verifica = false;
            }
            else if (mskRUT.Text == "")
            {
                verifica = false;
            }
            else if (txtVencimiento.Text == "")
            {
                verifica = false;
            }
            else if(txtTelefono.Text == "")
            {
                verifica = false;
            }
            return verifica;
        }
        private void insertCompleto()
        {
            claseBD CBd = new claseBD();
            string CadSql;
            CadSql = "insert into compra_" + mskRUT.Text + "_" + txtnfact.Text + " (rut,numero_factura,razon_social,giro,fecha,subtotales,iva,totales) values ('" + mskRUT.Text.ToUpper() + "','" +txtnfact.Text + "','" + txtRazon.Text.ToUpper() + "','" + txtGiro.Text.ToUpper() + "','" + dateTimePicker1.Text.ToUpper() + "','" + txtsubtotales.Text + "','" + txtiva.Text + "','" + txttotales.Text + "');";
            //CadSql = "insert into " + mskRUT.Text + "_" + lblNumFact.Text + " values ('"++"')";
            //hacer otro insert para los datos juridicos
            try
            {
                if (CBd.EjecutarIUD(CadSql) > 0)
                {
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insertAvanzado()
        {
            claseBD CBd = new claseBD();
            string CadSql;
            CadSql = "insert into compra_" + mskRUT.Text + "_" + txtnfact.Text + "(codigo,nombre_producto, precio_venta, cantidad,total) select cod_interno,nombre_prod,precio_venta,cantidad,total from grillafacturaprov";
            //CadSql = "insert into " + mskRUT.Text + "_" + lblNumFact.Text + " values ('"++"')";
            //hacer otro insert para los datos juridicos
            try
            {
                if (CBd.EjecutarIUD(CadSql) > 0)
                {

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void creartablaautomatica()
        {

            claseBD CBd = new claseBD();
            string CadSql;

            CadSql = "create table compra_" + mskRUT.Text + "_" + txtnfact.Text + "(rut varchar (255),numero_factura varchar (255),razon_social varchar (255),giro varchar (255),fecha varchar (255),subtotales int,iva int,totales int,codigo varchar(255), nombre_producto varchar (255), precio_venta int, cantidad varchar(255), total int);";
            try
            {
                if (CBd.EjecutarIUD(CadSql) > 0)
                {


                }
                else
                {
                    MessageBox.Show("Factura Ingresada Correctamente");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (verifica())
            {
                string insertrecepcion = "insert into recepcion values ('" + txtnfact.Text + "','" + dateTimePicker1.Text + "','" + txttotales.Text + "','" + mskRUT.Text + "')";
                claseBD cbd = new claseBD();
                string insertlibrocompra = "insert into informecompra values ('" + dtpkMesAño.Text + "','" + dateTimePicker1.Text + "','" + txtiva.Text + "','" + txttotales.Text + "','"+txtnfact.Text+"','"+txtRazon.Text+"','"+mskRUT.Text+"')";

                cbd.EjecutarIUD(insertlibrocompra);

                cbd.EjecutarIUD(insertrecepcion);

                creartablaautomatica();

                insertAvanzado();

                insertCompleto();

                if (mskRUT.Text == "" || txtnfact.Text == "")
                {
                    MessageBox.Show("DEBE SELECCIONAR UN PROVEEDOR, PARA INGRESAR LA COMPRA");

                }
                else
                {
                    string truncaja = "truncate table caja";

                    cbd.EjecutarIUD2(truncaja);

                    truncartabla();

                    MessageBox.Show("COMPRA INGRESADA CORRECTAMENTE");
                    frmMenu m = new frmMenu();
                    m.Show();
                    this.Hide();
                    
              
                }

            }
            else
            {
                MessageBox.Show("Debe completar los datos");
            }
            
            
        }
      
        private void button1_Click(object sender, EventArgs e)
        {            
            String dato = this.dgvClientes.CurrentRow.Cells["grdRUT"].Value.ToString();
            string CadSql;
            CadSql = "select * from proveedores where '"+dato+"' = rut ;";
            claseBD CBd = new claseBD();
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
              
                while (Rec.Read())
                {                   
                    mskRUT.Text = Rec["rut"].ToString();
                    txtRazon.Text = Rec["razon"].ToString();
                    txtGiro.Text = Rec["giro"].ToString();            
                    txtTelefono.Text = Rec["telefono"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                }
            }          
        }
        private void txtAnn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtKilometraje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!txtBuscar.Text.Equals("") || !txtBuscar.Text.Equals(null))
            {
                if (cboBuscar.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un filtro de busqueda");
                    llenarDgv();
                }
                else if (cboBuscar.SelectedIndex == 0)
                {
                    BuscarDGV("rut");

                }
                else if (cboBuscar.SelectedIndex == 1)
                {
                    BuscarDGV("razon_social");

                }
                else if (cboBuscar.SelectedIndex == 2)
                {
                    BuscarDGV("nombres");

                }

            }
            else
            {
                MessageBox.Show("Ingrese un valor para buscar");
                llenarDgv();
            }
        }

        private void llenarDgv()
        {
            string CadSql;
            CadSql = "select a.rut,a.razon_social,a.nombres from proveedores a";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvClientes.RowCount = 0;
                while (Rec.Read())
                {
                    dgvClientes.RowCount = dgvClientes.RowCount + 1;
                    fila = dgvClientes.RowCount - 1;
                    dgvClientes.Rows[fila].Cells[0].Value = Rec["rut"].ToString();
                    dgvClientes.Rows[fila].Cells[2].Value = Rec["razon_social"].ToString();
                    dgvClientes.Rows[fila].Cells[1].Value = Rec["nombres"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                }
            }
        }

        private void BuscarDGV(string dato)
        {
            string CadSql;
            CadSql = "select rut ,nombres,razon_social from clientes where  " + dato + " like '%" + txtBuscar.Text + "%';";

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                dgvClientes.RowCount = 0;
                while (Rec.Read())
                {
                    dgvClientes.RowCount = dgvClientes.RowCount + 1;
                    fila = dgvClientes.RowCount - 1;
                    dgvClientes.Rows[fila].Cells[0].Value = Rec["rut"].ToString();
                    dgvClientes.Rows[fila].Cells[2].Value = Rec["razon_social"].ToString();
                    dgvClientes.Rows[fila].Cells[1].Value = Rec["nombres"].ToString();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                }
            }
        }
        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!txtBuscar.Text.Equals("") || !txtBuscar.Text.Equals(null))
            {
                if (cboBuscar.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un filtro de busqueda");
                    llenarDgv();
                }
                else if (cboBuscar.SelectedIndex == 0)
                {
                    BuscarDGV("rut");

                }
                else if (cboBuscar.SelectedIndex == 1)
                {
                    BuscarDGV("razon_social");

                }
                else if (cboBuscar.SelectedIndex == 2)
                {
                    BuscarDGV("nombres");
                }

            }
            else
            {
                MessageBox.Show("Ingrese un valor para buscar");
                llenarDgv();
            }
        }

        private void lblLetras_Click(object sender, EventArgs e)
        {

        }

        private void cmdverstock_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAvisoStock av = new frmAvisoStock();
            av.Show();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "CHEQUE")
            { 
                lblglosa.Visible = true;
                Ndoc.Visible = true;
            }
            else
            {

            }
        }

      
    }
}
