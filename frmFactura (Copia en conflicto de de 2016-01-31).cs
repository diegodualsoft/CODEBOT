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
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
            
        }
        private void creartablamobra()
        {
            claseBD cbd = new claseBD();
            string create = "create table mobra_"+lblNumFact.Text+" (mdo varchar(255),descripcion varchar(700),precio int)";
            cbd.EjecutarIUD(create);

        }
        private void insertarenmobra_numfact()
        {

        }
        private void truncartabla()
        {
            
            string cadsql = "truncate table grillafactura ; ";
            string TRUNCAJA = "truncate table caja";
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
            frmGuiaDespacho g = new frmGuiaDespacho();
            frmGuiaDespacho m = new frmGuiaDespacho();

            
            string cadsql = "truncate table grillafactura ; ";

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
            g.Show();
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

        private void llenarDgvClientes()
        {
            string CadSql;
            CadSql = "select rut ,nombres,razon_social from clientes a;";

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
                    dgvClientes.Rows[fila].Cells[1].Value = Rec["nombres"].ToString();
                    dgvClientes.Rows[fila].Cells[2].Value = Rec["razon_social"].ToString();
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
            cboBuscar.SelectedIndex = 0;

            llenarnumfact();

            llenarDGV();
         
            llenarDgvClientes();
            
            claseBD.conex.Close();
            
        }
       
        private void truncarmobra()
        {
            claseBD cbd = new claseBD();
            string cadsql = "truncate table mobra";
            string truncacaja = "truncate table caja";
            cbd.EjecutarIUD(cadsql);
            cbd.EjecutarIUD(truncacaja);
        }
        private void llenarnumfact()
        {

            string CadSql;
            CadSql = "select n_fact from nfact ;";

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
                    int nf;
                    dgvLista.RowCount = dgvLista.RowCount + 1;
                    fila = dgvLista.RowCount - 1;
                    nf = int.Parse(Rec["n_fact"].ToString());
                    Convert.ToInt32(nf);
                    nf = nf + 1;
                    int.Parse(lblNumFact.Text=""+nf);
             
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
        private void llenarDGV()
        {
            
            string CadSql;
            CadSql = "select * from grillafactura ;";

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
            else if (txtVendedor.Text == "")
            {
                verifica = false;
            }
            else if (txtnombrecontacto.Text == "")
            {
                verifica = false;
            }
            else if (txtcomuna.Text == "")
            {
                verifica = false;
            }
            else if (txtciudad.Text == "")
            {
                verifica = false;
            }
            else if (txtDireccion.Text == "")
            {
                verifica = false;
            }
            else if (txtNF.Text == "")
            {
                verifica = false;
            }
            else if (txtPalabras.Text == "")
            {
                verifica = false;
            }
            else if (txtPalabras2.Text == "")
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


        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (verifica())
            {
                string insertemision = "insert into emision values ('" + lblNumFact.Text + "','" + dateTimePicker1.Text + "','" + txttotales.Text + "','" + mskRUT.Text + "')";
                claseBD cbd = new claseBD();
                string insertlibro = "insert into libro values ('" + dateTimePicker1.Text + "','" + lblNumFact.Text + "','" + txtiva.Text + "','" + lblcostofact.Text + "','" + txttotales.Text + "')";
                cbd.EjecutarIUD(insertlibro);
                cbd.EjecutarIUD(insertemision);
                if (mskRUT.Text == "" || txtnombrecontacto.Text == "")
                {
                    MessageBox.Show("DEBE SELECCIONAR UN CLIENTE, PARA GENERAR LA FACTURA");

                }
                else
                {
                    string truncaja = "truncate table caja";

                    cbd.EjecutarIUD2(truncaja);

                    creartablaautomatica();

                    insertAvanzado();

                    insertCompleto();

                    insertnfactrut();

                    truncartabla();

                    frmGuiaDespacho gp = new frmGuiaDespacho();

                    gp.Show();

                    this.Hide();
                   

                }



            }
            else
            {
                MessageBox.Show("Debe complettar los datos");
            }
            
            
        }
        private void insertCompleto()
        {

            claseBD CBd = new claseBD();
            string CadSql;
            
            CadSql = "insert into " + mskRUT.Text + "_" + lblNumFact.Text + " (rut,nombre_contacto,numero_factura,razon_social,direccion,comuna,ciudad,vendedor,NF,giro,fecha,subtotales,iva,totales,palabras,palabras2,vcto,telefono) values ('" + mskRUT.Text.ToUpper() +"','" + txtnombrecontacto.Text.ToUpper() + "','" + lblNumFact.Text + "','" + txtRazon.Text.ToUpper() + "','" + txtDireccion.Text.ToUpper() + "','" + txtcomuna.Text.ToUpper() + "','" + txtciudad.Text.ToUpper() + "','" + txtVendedor.Text.ToUpper() + "','" + txtNF.Text.ToUpper() + "','" + txtGiro.Text.ToUpper() + "','" + dateTimePicker1.Text.ToUpper() + "','" + txtsubtotales.Text + "','" + txtiva.Text + "','" + txttotales.Text + "','" + txtPalabras.Text.ToUpper() + "','" + txtPalabras2.Text.ToUpper() + "','" + txtVencimiento.Text.ToUpper() + "','" + txtTelefono.Text.ToUpper() + "');";
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

            CadSql = "insert into " + mskRUT.Text + "_" + lblNumFact.Text + "(codigo,nombre_producto, precio_venta, cantidad,total) select cod_interno,nombre_prod,precio_venta,cantidad,total from grillafactura";
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
        private void insertnfactrut()
        {

            claseBD CBd = new claseBD();
            string CadSql,CadSql2;


            CadSql2 = "insert into nfactimpresion values ('" + mskRUT.Text + "','" + lblNumFact.Text + "','" + dateTimePicker1.Text + "','" + txtRazon.Text + "')";
            CadSql = "insert into nfact values ('"+mskRUT.Text+"','"+lblNumFact.Text+"','"+dateTimePicker1.Text+"','"+txtRazon.Text+"')";
            //CadSql = "insert into " + mskRUT.Text + "_" + lblNumFact.Text + " values ('"++"')";
            CBd.EjecutarIUD(CadSql2);
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

            CadSql = "create table " + mskRUT.Text + "_" + lblNumFact.Text + "(rut varchar (255), nombre_contacto varchar (255),numero_factura varchar (255),razon_social varchar (255),direccion varchar (255),comuna varchar (255),ciudad varchar(255),vendedor varchar(255),NF varchar (255),palabras varchar (255),palabras2 varchar(255),vcto varchar (255),telefono varchar (50),giro varchar (255),fecha varchar (255),mano_de_obra int,subtotales int,iva int,totales int,codigo varchar(255), nombre_producto varchar (255), precio_venta int, cantidad varchar(255), total int);";
            try
            {
                if (CBd.EjecutarIUD(CadSql) > 0)
                {


                }
                else
                {
                    MessageBox.Show("Factura Guardada Correctamente Para El Sr. " +txtRazon.Text+ " "+txtGiro.Text);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            String dato = this.dgvClientes.CurrentRow.Cells["grdRUT"].Value.ToString();
            string CadSql;
            CadSql = "select * from clientes where '"+dato+"' = rut ;";

            claseBD CBd = new claseBD();

            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
              
                while (Rec.Read())
                {
                    
                    mskRUT.Text = Rec["rut"].ToString();
                    txtRazon.Text = Rec["razon_social"].ToString();
                    txtGiro.Text = Rec["giro"].ToString();
                    txtnombrecontacto.Text = Rec["nombres"].ToString();
                    txtDireccion.Text = Rec["direccion"].ToString();
                    txtciudad.Text = Rec["ciudad"].ToString();
                    txtcomuna.Text = Rec["comuna"].ToString();
                    txtVendedor.Text = Rec["vendedor"].ToString();
                    txtTelefono.Text = Rec["telefono"].ToString();
                    txtNF.Text = Rec["NF"].ToString();
                    
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
            CadSql = "select a.rut,a.razon_social,a.nombres from clientes a";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
      
    }
}
