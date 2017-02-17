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
    public partial class frmNotaCredito : Form
    {
        public frmNotaCredito()
        {
            InitializeComponent();
        }
        public int fila2 = 0;
        public double res = 0;
        public string codprod = null;
        public double cant = 0;
        public double stock = 0;
        private void operatoria()
        {
            try
            {
                string identificador;
                int fila = 0;
                double costo = 0, subtotal = 0, subtotcalc = 0, resultado = 0, ivam = 0, ivas = 0, mobra = 0, iva = 0, sub = 0;
                do
                {
                    identificador = dgvLista.Rows[fila].Cells["total"].Value.ToString();
                    if (identificador == null || identificador == "")
                    {
                        dgvLista.Rows.RemoveAt(fila);
                        

                    }
                    else
                    {
                        subtotal = Convert.ToDouble(dgvLista.Rows[fila].Cells["total"].Value.ToString());


                    }
                    fila = fila + 1;
                }
                while (dgvLista.RowCount > fila);
                //foreach (DataGridViewRow row in dgvLista.Rows)
                //{
                //    subtotal += Convert.ToDouble(row.Cells["total"].Value);
                //    if (subtotal.ToString() == null)
                //    {

                //    }
                //    else
                //    {
                //    }
                //}

                txtneto.Text = Convert.ToString(subtotal);

                subtotcalc = int.Parse(txtneto.Text);

                ivas = subtotcalc * 0.19;
                ivam = mobra * 0.19;
                iva = ivam + ivas;
                sub = subtotal + mobra;
                txtiva.Text = "" + iva;
                txtneto.Text = "" + sub;
                resultado = iva + sub;
                txttotal.Text = "" + resultado;
            }
            catch
            {
 
            }

        }
        private void llenarnumfact()
        {

            string CadSql;
            CadSql = "select numnc from ncemitidas ;";

            claseBD CBd = new claseBD();
       

            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);
    
                while (Rec.Read())
                {
                    int nf;
                
                    nf = int.Parse(Rec["numnc"].ToString());
                    Convert.ToInt32(nf);
                    nf = nf + 1;
                    int.Parse(lblnumnc.Text = "" + nf);

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
        private void llenarcli()
        {
            string consulta = "select razon_social from " + txtrut.Text + "_" + txtnfact.Text + "";
            claseBD CBd = new claseBD();

            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(consulta);

                while (Rec.Read())
                {

              
                   lblcliente.Text = Rec["razon_social"].ToString();
               

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
        private void insertcompleto()
        {
          
            string insertnc = "insert into nc_"+lblnumnc.Text+" (comentario,motivo,nnc,nfact,rut,razon,neto,iva,totales) values ('"+txtdescripcion.Text+"','"+comboBox1.Text+"','"+lblnumnc.Text+"','"+txtnfact.Text+"','"+txtrut.Text+"','"+lblcliente.Text+"','"+txtneto.Text+"','"+txtiva.Text+"','"+txttotal.Text+"')";
            claseBD cbd = new claseBD();
            cbd.EjecutarIUD(insertnc);
           

        }
        private void creatabla()
        {
            string cadsql = "create table nc_" + lblnumnc.Text + " (comentario varchar(255) not null,motivo varchar(255) not null,nnc varchar(255) not null,nfact varchar(255)not null,rut varchar(255) not null, razon varchar(255) not null,neto varchar(255) not null, iva varchar(255) not null, totales varchar(255) not null,codigo varchar(255) not null, nombre varchar(255) not null,precio varchar(255) not null,cantidad varchar(255) not null,total varchar(255) not null)";
            claseBD cbd = new claseBD();
            cbd.EjecutarIUD2(cadsql);
        }
        private void llenartablanc()
        {
            try
            {
                if (dgvLista.RowCount == 0)
                {
                    claseBD cbd = new claseBD();

                    string cadsql = "insert into nc_" + lblnumnc.Text + " (codigo,nombre,precio,cantidad,total) select codigo,nombre_producto, precio_venta, cantidad,total from " + txtrut.Text + "_" + txtnfact.Text + "";
                    cbd.EjecutarIUD(cadsql);
                }
                else
                {
                    
                }
            }
            catch
            { }
            finally
            {
                claseBD.conex.Close();
            }
        }

        private void bucle()
        {
            claseBD cbd = new claseBD();
            try
            {
                do
                {
                        //llenarDgvCajaParaDevolver();

                        MessageBox.Show("metodo bucle, actualizar codigo de producto" +codprod.ToString() + "resultados" + "=" + res);

                        string updatestock = "update productos set Stock = '" + res.ToString() + "' where cod_interno =" + codprod + "";

                  

       
                }
                while (dgvLista.RowCount > fila2);
            }
            catch
            { 
            }

        }
        private void llenarDgvCajaParaDevolver()
        {

            string consulta = "select a.codigo,a.cantidad,b.Stock,b.cod_interno from nc_" + lblnumnc.Text + " a, productos b";
       

            claseBD CBd = new claseBD();
            int fila = 0;
            MySqlDataReader Rec = null;
            try
            {

          
                
               
                do 
                {
                    //1.- obtiene el total de la fila del indice como un identificador de datos nulos
                   string identificador = dgvLista.Rows[fila].Cells["total"].Value.ToString();
                   if (identificador == null || identificador == "")
                   {
                       //2.-si la fila no presenta datos aumenta en 1 , ya que no puede operar con datos vacios y tampoco reconoce datos vacios
                       // y si la fila no tiene datos pero se muestra como indice , el bucle no termina.
                       fila = fila + 1;
                   }
                   else
                   {
                       //3.- obtiene los datos necesarios de la fila del dataGridView Para hacer la consulta correspondiente
                       codprod = dgvLista.Rows[fila].Cells["codigo"].Value.ToString();

                       cant = double.Parse(dgvLista.Rows[fila].Cells["Cantidad"].Value.ToString());
                       //4.- obtiene el stock actual de productos de la base de datos
                       Rec = CBd.EjecutarConsulta2("select Stock from productos where cod_interno = '"+codprod+"'");
                       Rec.Read(); // 5.-ejecuta la consulta y abre coneccion
                       stock = double.Parse(Rec["Stock"].ToString());
                       Rec.Close(); //6.-cierra la coneccion para evitar choque de coneccion con la consulta "updatestock"
      
                       res = stock + cant; //<--Sobre las variables son Datos Globales declarados arriva **//7.- suma el stock de la base de datos con los de la fila del datagrid
                       //8.-  update
                       string updatestock = "update productos set Stock = '" + res.ToString() + "' where cod_interno =" + codprod + "";
                       //9.- ejecuta consulta
                       CBd.EjecutarIUD(updatestock);
                       //10.- aumenta en uno la fila, para leer la siguiente o terminar el Do While
                       fila= fila + 1;
              


                   }

                }
                while (dgvLista.RowCount > fila); //condicion de Termino (hacer hasta que fila sea mayor al total de filas del dataGridView)
           

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

        private void llenarDgvCaja()
        {
           
            string consulta = "select * from nc_"+lblnumnc.Text+"";
          

            claseBD CBd = new claseBD();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(consulta);
                dgvLista.RowCount = 0;
                while (Rec.Read())
                {
                    dgvLista.RowCount = dgvLista.RowCount + 1;
                    fila = dgvLista.RowCount - 1;
                    dgvLista.Rows[fila].Cells[0].Value = Rec["nombre"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["codigo"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["precio"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["cantidad"].ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["total"].ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                llenarcli();
                llenartablanc();
                llenarDgvCaja();
                
            }
            catch
            {
 
            }
            operatoria();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            claseBD cbd = new claseBD();
            string trunca = "truncate table nc_"+lblnumnc.Text+"";
            cbd.EjecutarIUD(trunca);
            this.Hide();
            frmGestionComercial gc = new frmGestionComercial();
            gc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String precio = this.dgvLista.CurrentRow.Cells["precio"].Value.ToString();
            String cantidad = this.dgvLista.CurrentRow.Cells["Cantidad"].Value.ToString();
            String total = this.dgvLista.CurrentRow.Cells["total"].Value.ToString();
            txtprecio.Text = precio;
            txtcant.Text = cantidad;
            lbltotporprod.Text = total;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                claseBD cbd = new claseBD();
                String codigo = this.dgvLista.CurrentRow.Cells["codigo"].Value.ToString();
                string updatecaja = "Update nc_" + lblnumnc.Text + " Set precio = " + txtprecio.Text + ",cantidad =" + txtcant.Text + ",total = " + lbltotporprod.Text + " where codigo = " + codigo + "";
                cbd.EjecutarIUD(updatecaja);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());

            }
            finally
            {
                llenarDgvCaja();
                operatoria();
            }
        }
        private void textchangedoperatoria()
        {
            try
            {
                
                
                double res = 0, precio = 0, cantt = 0;
                precio = double.Parse(txtprecio.Text);
                cantt = double.Parse(txtcant.Text);
                res = precio * cantt;
                lbltotporprod.Text = res.ToString();
            }
            catch
            {
 
            }

        }
   
        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            if (txtprecio.Text == "")
            {
                txtprecio.Text = "0";
            }
            else
            {
            }
            textchangedoperatoria();
        }

        private void txtcant_TextChanged(object sender, EventArgs e)
        {
            if (txtcant.Text == "")
            {
                txtcant.Text = "0";
            }
            else
            {
            }
            textchangedoperatoria();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                claseBD cbd = new claseBD();
                string updlibro = "update libro set estado = 'NULA' where nfact = '"+txtnfact.Text+"' ";
                string consulta = "update libro set impuestos = '" + txtiva.Text + "',totalventa = '" + txttotal.Text + "' where nfact = '" + txtnfact.Text + "'";
                string updateventa = "update informevent set neto = '" + txtneto.Text + "',total = '" + txttotal.Text + "' where nfact = '" + txtnfact.Text + "'";
                string insetnumnc = "insert into ncemitidas values ('" + lblnumnc.Text + "','" + txtrut.Text + "','" + txtnfact.Text + "')";
                if (MessageBox.Show("¿Esta seguro de que desea emitir la nota de credito?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (checkBox1.Checked)
                    {

                        if (comboBox1.Text == "FACTURA NULA" || comboBox1.Text == "DEVOLUCION")
                        {
                            cbd.EjecutarIUD(updlibro);
                            llenarDgvCajaParaDevolver();
                            cbd.EjecutarIUD(consulta);
                            cbd.EjecutarIUD(updateventa);
                            cbd.EjecutarConsulta(insetnumnc);
                            frmGestionComercial ggc = new frmGestionComercial();
                            ggc.Show();
                            this.Hide();
                        }
                        else
                        {
                            llenarDgvCajaParaDevolver();
                            cbd.EjecutarIUD(consulta);
                            cbd.EjecutarIUD(updateventa);
                            cbd.EjecutarConsulta(insetnumnc);

                            frmGestionComercial ggc = new frmGestionComercial();
                            ggc.Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {

                    }
                }
                else
                { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                claseBD.conex.Close();

            }
            insertcompleto();


        }

        private void frmNotaCredito_Load(object sender, EventArgs e)
        {
            llenarnumfact();
            creatabla();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Usted a seleccionado devolver productos a stock, verifique que el campo ''cantidad'' se encuentre con el stock que desea devolver.");
            }
            else
            { }
        }
    }
}
