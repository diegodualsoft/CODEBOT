using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
namespace Prototipo1
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
            
        }
        ClaseFunciones a = new ClaseFunciones();
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
            frmFactura gp = new frmFactura();
            gp.Show();
            //m.Show();
        }
        private void modificaproductos_especifico()
        {
            claseBD cbd = new claseBD();
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                string stockadble = row.Cells["Cantidad"].Value.ToString().Replace(',', '.');
                string updatestock = "update productos set Stock = Stock + " + stockadble + " where cod_barra = '" + row.Cells["codigo"].Value.ToString() + "' ";
                cbd.EjecutarIUD(updatestock);
            }
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
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
           
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            string CadSql;
            CadSql = "select * from productos where Stock < 0";


            claseBD CBd = new claseBD();
            //int fila;
            MySqlDataReader Rec = null;
            string stockcapt;
            int stockint = 0;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
                while (Rec.Read())
                {

                    stockcapt = Rec["Stock"].ToString();
  
                    if(stockint <= 0 )
                    {
                        cmdverstock.Enabled = true;
                        cmdverstock.Visible = true;
                    }
                    else
                    {

                    }

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
        private void calculos()
        {
            double subtotal = 0, subtotcalc = 0, resultado = 0, ivam = 0, ivas = 0, mobra = 0, iva = 0, sub = 0;
            if (dgvLista.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvLista.Rows)
                {
                    subtotal += Convert.ToDouble(row.Cells["total"].Value);
                }
            }
        }
        private void llenarDGV()
        {
            
            string CadSql;
            CadSql = "select * from caja_factura_1 ;";

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
                    dgvLista.Rows[fila].Cells[1].Value = Rec["nombre"].ToString();  
                    dgvLista.Rows[fila].Cells[2].Value = Rec["precio"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["costo"].ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["cant"].ToString();
                    dgvLista.Rows[fila].Cells[5].Value = Rec["total"].ToString();
         
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
                string cadena;
                int cadenaint;
                cadena = lblLetras.Text;
                cadena = a.toText(Double.Parse(txttotales.Text));

                cadenaint = int.Parse(cadena.Length.ToString());
                if (cadena.Length < 35 )
                {
                    cadena = a.toText(Double.Parse(txttotales.Text));
                    lblLetras.Text = (cadena.Substring(0, cadenaint) + " -");
                    lblletras3.Text = (cadena.Substring(cadenaint) + " PESOS");
                    txtPalabras.Text = lblLetras.Text;
                    txtPalabras2.Text = lblletras3.Text;
                }
                else 
                {
                    cadena = a.toText(Double.Parse(txttotales.Text));
                    lblLetras.Text = (cadena.Substring(0, 35) + " -");
                    lblletras3.Text = (cadena.Substring(35) + " PESOS");
                    txtPalabras.Text = lblLetras.Text;
                    txtPalabras2.Text = lblletras3.Text;
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
            else if (comboBox1.Text == "")
            {
                verifica = false;
            }
            else if (comboBox2.Text == "")
            {
                verifica = false;
            }
            return verifica;

        }

        private void rango()
        {

        }
        private void registrar()
        {
            try
            {
                claseBD cbd = new claseBD();
                string insertar = "insert into estadofact values ('" + mskRUT.Text + "','" + lblNumFact.Text + "','"+comboBox2.Text+"','$0','" + dateTimePicker1.Text+ "','" + txtVencimiento.Text + "')";
                cbd.EjecutarIUD2(insertar);
            }
            catch
            { }



        }
        private void registrarrango()
        {
            claseBD cbd = new claseBD();
            if (lblinicial.Text == "")
            {
                try
                {
                  

                    string insertar = "insert into rango values ('" + lblNumFact.Text + "','" + lblNumFact.Text + "')";
                    cbd.EjecutarIUD2(insertar);
                }
                catch
                { }
            }
            else
            {
                try
                {
                    string cadsql = "update rango set final = '" + lblNumFact.Text + "' where inicial = '" + lblinicial.Text + "'";
                    cbd.EjecutarIUD(cadsql);
                }
                catch
                { }
            }



        }
        private void consultarango()
        {
            string consulta = "select * from rango";
            claseBD CBd = new claseBD();

            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(consulta);

                while (Rec.Read())
                {


                    lblinicial.Text = Rec["inicial"].ToString();
                    lblfinal.Text = Rec["final"].ToString();


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
        private void generaarchplano()
        {
            FileStream fstream = new FileStream("D:\\33_FOLIO.xml", FileMode.OpenOrCreate, FileAccess.Write); // GUARDAR EL ARCHIVO A XML CON DATOS CONCADENADOS
            StreamWriter swrit = new StreamWriter(fstream);
            //ENCABEZADO
            swrit.WriteLine("A:| Tipo Documento     : 33"); //CADA UNA DE ESTAS CADENAS .WRITELINE SON UNICAS POR LINEA, SI QUEREMOS ESCRIBIR OTRA SOLO TENEMOS QUE ABRIR OTRA SENTECIA .WRITELINE
            swrit.WriteLine("A:| Folio Documento    :  23021");
            swrit.WriteLine("A:| Fecha Emision      : 2016/09/15");
            //CARATULA
            swrit.WriteLine("A:| Forma Pago         : 2");
            swrit.WriteLine("A:| Rut Emisor         : 76071238-8");
            swrit.WriteLine("A:| Razon Social Emisor: Patagonia Beef SpA");
            swrit.WriteLine("A:| Giro Emisor        : Carniceria, Ganaderia, Rotiseria");
            swrit.WriteLine("A:| ACTECO Emisor      : 013000");
            swrit.WriteLine("A:| Direccion Origen   : Avda. Recabarren 01374");
            swrit.WriteLine("A:| Comuna Origen      : Temuco");
            swrit.WriteLine("A:| Ciudad Origen      : Temuco");
            swrit.WriteLine("A:| Codigo Vendedor    : 2");
            swrit.WriteLine("A:| Rut Receptor       : 76.254.266-8");
            swrit.WriteLine("A:| Razon Social Recep : EL FIORDO SPA");
            swrit.WriteLine("A:| Giro Receprot      : EXPLOTACION HOTELES CAFE RESTAURANT");
            swrit.WriteLine("A:| Direccion Receprot : BULNES 733");
            swrit.WriteLine("A:| Comuna Receptor    : TEMUCO");
            swrit.WriteLine("A:| Ciudad Receprot    : TEMUCO");
            swrit.WriteLine("A:| Monto Neto         :      167955");
            swrit.WriteLine("A:| Tasa Iva           : 19");
            swrit.WriteLine("A:| Iva                :       31911");
            swrit.WriteLine("A:| TipoImp            : 18");
            swrit.WriteLine("A:| TasaImp            : 5");
            swrit.WriteLine("A:| MontoImp           :        8398");
            swrit.WriteLine("A:| Monto Total        :      208264");
            string consulta = "select * from caja_ingreso";
            claseBD CBd = new claseBD();

            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(consulta);

                while (Rec.Read())
                {


                    lblinicial.Text = Rec["inicial"].ToString();
                    lblfinal.Text = Rec["final"].ToString();


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
            swrit.WriteLine("B:|         1|ASIENTO CAT V                      |     24.65|    5000|     123250|18");


        }
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (verifica())
            {
                claseBD cbd = new claseBD();
                if (comboBox1.Text == "CREDITO")
                {
                    int monto = Int32.Parse(txttotales.Text);
                    string insertaCredito = "insert into movimientos values('" + lblNumFact.Text + "'," + monto + ",'" + dateTimePicker1.Text + "','" + txtVencimiento.Text + "','" + dtpkMesAño.Text+ "')";
                    cbd.EjecutarIUD(insertaCredito);
                }
                string insertemision = "insert into emision values ('" + lblNumFact.Text + "','" + dateTimePicker1.Text + "','" + txttotales.Text + "','" + mskRUT.Text + "')";

                string insertlibro = "insert into libro values ('" + dateTimePicker1.Text + "','" + lblNumFact.Text + "','" + txtiva.Text + "','" + lblcostofact.Text + "','" + txttotales.Text + "','"+comboBox2.Text+"','"+txtVencimiento.Text+"')";
                string insertinformevent = "insert into informevent values ('" + lblNumFact.Text + "','" + txtVendedor.Text + "','" + txtTotalesSinIva.Text + "','" + txttotales.Text + "','" + txtRazon.Text + "','" + dtpkMesAño.Text + "')";
                cbd.EjecutarIUD(insertinformevent);
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

                    registrar();


                    ingresoRank();


                    insertnfactrut();

                    truncartabla();

                    consultarango();

                    registrarrango();
                   
                    
                   
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

        #region ranking
        //=================================================================================================

        claseBD conex = new claseBD();
        string verificador = "";

        double cantidad = 0;
        private void consultaExistencia(string nombreProducto)
        {
            
                
           
            

            string fechaIni = null;
            fechaIni = (FechaYMD(dateTimePicker1.Text));
            string CadSql;
            CadSql = "select nombre,cantidad,fecha from ranking where nombre ='" + nombreProducto + "' and fecha ='" + fechaIni + "' ;";

            claseBD CBd = new claseBD();

            MySqlDataReader Rec = null;
            try
            {

                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);

                while (Rec.Read())
                {

                    verificador = Rec["nombre"].ToString();
                    
                    cantidad = Double.Parse(Rec["cantidad"].ToString());

                }
            }
            catch (Exception ex)
            {
                
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

        public static string FechaYMD(string Fecha)
        {
            string dia, mes, year, strFecha;
            dia = Fecha.Substring(0, 2);
            mes = Fecha.Substring(3, 2);
            year = Fecha.Substring(6, 4);
            strFecha = year + "-" + mes + "-" + dia;
            return (strFecha);

        }

        private void ingresoRank()
        {

            foreach (DataGridViewRow row in dgvLista.Rows)
            {

                string nombre_producto = row.Cells[1].Value.ToString();
                string cantidadDGV = row.Cells[4].Value.ToString();
                string celdaVacia = row.Cells[1].Value.ToString();

                if (celdaVacia == "")
                {
                }
                else
                {
                    claseBD conex = new claseBD();
                    string fechaIni = null;
                    fechaIni = (FechaYMD(dateTimePicker1.Text));
                    consultaExistencia( nombre_producto);
                   

                    if (verificador == nombre_producto.ToUpper())
                    {
                        try
                        {
                            double cantidad2 = double.Parse(cantidadDGV);
                            double cantidadF = cantidad + cantidad2;
                           
                            string CadSql = "update ranking set cantidad ='" + cantidadF + "' where fecha='" + fechaIni + "' and nombre ='" + nombre_producto.ToUpper() + "';";
                            conex.EjecutarIUD(CadSql);


                        }
                        catch (Exception ex)
                        {
                            
                        }


                    }
                    else
                    {
                        try
                        {
                            string CadSql = "insert into ranking (nombre,cantidad,fecha) values ('" + nombre_producto.ToUpper() + "','" + cantidadDGV.ToUpper() + "','" + fechaIni.ToUpper() + "');";
                            conex.EjecutarIUD(CadSql);


                        }
                        catch (Exception ex)
                        {
                           
                        }
                    }

                    //verificador = "";
                    cantidad = 0;
                }
            }
        }



        ////=================================================================================================
        #endregion



        private void insertCompleto()
        {

            claseBD CBd = new claseBD();
            string CadSql;
            
            CadSql = "insert into " + mskRUT.Text + "_" + lblNumFact.Text + " (tipopago,rut,nombre_contacto,numero_factura,razon_social,direccion,comuna,ciudad,vendedor,NF,giro,fecha,subtotales,iva,totales,palabras,palabras2,vcto,telefono) values ('"+comboBox1.Text+"','" + mskRUT.Text.ToUpper() +"','" + txtnombrecontacto.Text.ToUpper() + "','" + lblNumFact.Text + "','" + txtRazon.Text.ToUpper() + "','" + txtDireccion.Text.ToUpper() + "','" + txtcomuna.Text.ToUpper() + "','" + txtciudad.Text.ToUpper() + "','" + txtVendedor.Text.ToUpper() + "','" + txtNF.Text.ToUpper() + "','" + txtGiro.Text.ToUpper() + "','" + dateTimePicker1.Text.ToUpper() + "','" + txtsubtotales.Text + "','" + txtiva.Text + "','" + txttotales.Text + "','" + txtPalabras.Text.ToUpper() + "','" + txtPalabras2.Text.ToUpper() + "','" + txtVencimiento.Text.ToUpper() + "','" + txtTelefono.Text.ToUpper() + "');";
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

            CadSql = "insert into " + mskRUT.Text + "_" + lblNumFact.Text + "(codigo,nombre_producto, precio_venta, cantidad,total,margen) select cod_interno,nombre_prod,precio_venta,cantidad,total,margen from grillafactura";
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

            CadSql = "create table " + mskRUT.Text + "_" + lblNumFact.Text + "(tipopago varchar(255),rut varchar (255), nombre_contacto varchar (255),numero_factura varchar (255),razon_social varchar (255),direccion varchar (255),comuna varchar (255),ciudad varchar(255),vendedor varchar(255),NF varchar (255),palabras varchar (255),palabras2 varchar(255),vcto varchar (255),telefono varchar (50),giro varchar (255),fecha varchar (255),mano_de_obra int,subtotales int,iva int,totales int,codigo varchar(255), nombre_producto varchar (255), precio_venta int, cantidad varchar(255), total int,margen varchar(50));";
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
        private void preciospespeciales()
        {
            string cadql = "";
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


        private void cmdverstock_Click(object sender, EventArgs e)
        {
            
            frmAvisoStock av = new frmAvisoStock();
            av.Show();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String dato = this.dgvClientes.CurrentRow.Cells["grdRUT"].Value.ToString();
            string CadSql;
            CadSql = "select * from clientes where '" + dato + "' = rut ;";

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

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //private void llenarTxt()
        //{
        //    ssrut = rut; // ACA DEMOSTRAMOS COMO SE PUEDE PASAR CUALQUIER TIPO DE DATO AL XML
        //    ssfolio = nfactura;
        //    ruta = "D:\\33-" + ssfolio + ".txt";
        //    FileStream fstream = new FileStream("D:\\ 33-" + ssfolio + ".txt", FileMode.OpenOrCreate, FileAccess.Write); // GUARDAR EL ARCHIVO A XML CON DATOS CONCADENADOS
        //    StreamWriter swrit = new StreamWriter(fstream);
        //    swrit.WriteLine("A:|Tipo Documento :");
        //    swrit.WriteLine("A:|Folio Documento:");
        //    swrit.WriteLine("A:|Forma Pago:");
        //    swrit.WriteLine("A:|Rut Emisor:");
        //    swrit.WriteLine("A:|Razon Social Emisor:");
        //    swrit.WriteLine("A:|Giro Emisor:");
        //    swrit.WriteLine("A:|ACTECO Emisor:");
        //    swrit.WriteLine("A:|Direccion Origen;");
        //    swrit.WriteLine("A:|Comuna Origen:");
        //    swrit.WriteLine("A:|Ciudad Origen:");
        //    swrit.WriteLine("A:|Codigo Vendedor:");
        //    swrit.WriteLine("A:|RUT Receptor:");
        //    swrit.WriteLine("A:|Razón Social Receptor;");
        //    swrit.WriteLine("A:|Giro Receptor:");
        //    swrit.WriteLine("A:|Dirección Receptor:");
        //    swrit.WriteLine("A:|Comuna Receptor:");
        //    swrit.WriteLine("A:|Ciudad Receptor:");
        //    swrit.WriteLine("A:|Monto Neto:");
        //    swrit.WriteLine("A:|Tasa IVA:");
        //    swrit.WriteLine("A:|Monto IVA:");
        //    swrit.WriteLine("A:|Tipo Impuesto:");
        //    swrit.WriteLine("A:|Tasa Impuesto:");
        //    swrit.WriteLine("A:|Monto Impuesto:");
        //    swrit.WriteLine("A:|Monto Total:");
           

        //}
        //private void ObtenerDetallesProductos()
        //{
        //    string sql="Select "

        //     foreach (DataGridViewRow row in dgvLista.Rows)
        //    {

        //        string nombre_producto = row.Cells[1].Value.ToString();
        //        string cantidadDGV = row.Cells[4].Value.ToString();
        //        string celdaVacia = row.Cells[1].Value.ToString();
        //     }
        //}
      
    }
}
