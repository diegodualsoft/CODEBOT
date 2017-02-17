using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Prototipo1
{
    public partial class frmIngresoMercaderia : Form
    {
        public frmIngresoMercaderia()
        {
            InitializeComponent();
        }
        string frmvalor = null, frmabierto = null;
        private void obtienefrmvar()
        {
            string CadSql;
            CadSql = "select * from frmcajaingreso";

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
                    frmvalor = Rec["frm_variable_valor"].ToString();
                    frmabierto = Rec["frm_abierto"].ToString();
                }

            }
            catch
            { }
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        string desde = null;
        private void obtienedatostraspaso()
        {
            string CadSql;
            CadSql = "select * from traspasos where tra_numero = "+frmvalor+" ";

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
                    desde = Rec["tra_desde"].ToString();
                }
            }
            catch
            { }
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void llenarDgvClientes()
        {
            string CadSql;
            CadSql = "select rut ,giro,razon from proveedores a;";

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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void frmIngresoMercaderia_Load(object sender, EventArgs e)
        {
            //obtienefrmvar(); //HABILITAR CON CAJA INGRESO CHECKBOX CODIGO TRASPASO
            //obtienedatostraspaso(); //HABILITAR CON CAJA INGRESO CHECKBOX CODIGO TRASPASO
            if (frmabierto == "si")
            {
                rbtGuiatraspaso.Checked = true;
                gruptraspasos.Visible = true;
                txtNtraspaso.Text = frmvalor;
                txtDesde.Text = desde;
            }
            else
            {
 
            }
            llenarDgvCaja();
            cboBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBuscar.SelectedIndex = 0;
            cboBuscar.SelectedIndex = 0;
            llenarDgvClientes();
            calculos();
            claseBD.conex.Close();
        }
        //private void insertaenbucle()
        //{
        //    try
        //    {
        //        claseBD cbBd = new claseBD();
        //        foreach (DataGridViewRow row2 in dgvLista.Rows)
        //        {
        //            string insertadetalle = "insert into traspasos_detalle(trd_numero,trd_cant,trd_precio_producto,trd_nombre_producto,trd_codigo,trd_valor_total,trd_precio_costo) values (" + bolid + ",'" + row2.Cells["Cantidad"].Value.ToString() + "','" + double.Parse(row2.Cells["precio"].Value.ToString()) + "','" + row2.Cells["nombre"].Value.ToString() + "','" + row2.Cells["codigo"].Value.ToString() + "','" + row2.Cells["total"].Value.ToString() + "','" + row2.Cells["PrecioCosto"].Value.ToString() + "')";
        //            cbBd.EjecutarIUD(insertadetalle);
        //        }
        //        cbBd.CerrarConexion();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());

        //    }
        //}
        private void llenarDgvCaja()
        {
            string CadSql;
            CadSql = "select * from caja_ingreso";

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

                    dgvLista.Rows[fila].Cells[0].Value = Rec["nombre"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["cod_barra"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["precio"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["cant"].ToString();
                    dgvLista.Rows[fila].Cells[4].Value = Rec["total"].ToString();
                    dgvLista.Rows[fila].Cells[5].Value = Rec["costo"].ToString();
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void updatestockk()
        {
            claseBD cbd = new claseBD();
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                string stockadble = row.Cells["Cantidad"].Value.ToString().Replace(',', '.');

                string updatestock = "update productos set Stock = Stock + " + stockadble + " where cod_barra = '" + row.Cells["codigo"].Value.ToString() + "' ";
                cbd.EjecutarIUD(updatestock);
            }
        }
        private void insertaingreso()
        {
            claseBD cbdd = new claseBD();
            string csql = "insert into ingreso_mercaderia (ing_fecha,ing_hora,ing_total_ingreso,ing_rut_prov,ing_nombre_prov,ing_numero_documento) values ('" + dtpfecha.Text + "','" + DateTime.Now.ToShortTimeString() + "','" + txttotales.Text + "','" + txtRut.Text + "','" + txtProveedor.Text + "','"+txtNDoc.Text+"')";
            cbdd.EjecutarIUD(csql);
            cbdd.CerrarConexion();
        }
        private void truncajaingreso()
        {
            claseBD cbdd2 = new claseBD();
            string csql2 = "truncate table caja_ingreso";
            cbdd2.EjecutarIUD(csql2);
            cbdd2.CerrarConexion();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //updatestockk(); // se rebaja desde frmCajaIngreso
            if (txtNDoc.Text == "")
            {
                MessageBox.Show("Falta numero documento");
            }
            else
            {
                if (MessageBox.Show("Desea ingresar mercaderia de factura N°" + txtNDoc.Text + "", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    insertaingreso();
                    truncajaingreso();
                    MessageBox.Show("Ingreso de mercaderia exitoso");
                    frmCajaIngreso cjin = new frmCajaIngreso();
                    cjin.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operacion cancelada por el Usuario.");
                }
            }
           
            //cierra ventana
        }
        private void llenarDgv()
        {
            string CadSql;
            CadSql = "select * from proveedores";

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
                    dgvClientes.Rows[fila].Cells[2].Value = Rec["giro"].ToString();
                    dgvClientes.Rows[fila].Cells[1].Value = Rec["razon"].ToString();

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
            CadSql = "select rut ,giro,razon from proveedores where  " + dato + " like '%" + txtBuscar.Text + "%';";

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
        private void calculos()
        {
            double subtotal = 0, subtotcalc = 0, resultado = 0, ivam = 0, ivas = 0, mobra = 0, iva = 0, sub = 0,impcarn = 0;
            if (dgvLista.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvLista.Rows)
                {
                    subtotal += Convert.ToDouble(row.Cells["total"].Value);
                }
            }
            txtsubtotales.Text = subtotal.ToString();
            iva = subtotal * 0.19;
            impcarn = subtotal * 0.05;
            txtiva.Text = Convert.ToInt32(iva).ToString();
            txtImpCarn.Text = Convert.ToInt32(impcarn).ToString();
            resultado = iva + impcarn + subtotal;
            txttotales.Text = Convert.ToInt32(resultado).ToString();

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
                    BuscarDGV("razon");

                }
                else if (cboBuscar.SelectedIndex == 2)
                {
                    BuscarDGV("razon");

                }

            }
            else
            {
                MessageBox.Show("Ingrese un valor para buscar");
                llenarDgv();
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String dato = this.dgvClientes.CurrentRow.Cells["grdRUT"].Value.ToString();
            string CadSql;
            CadSql = "select * from proveedores where '" + dato + "' = rut ;";

            claseBD CBd = new claseBD();

            MySqlDataReader Rec = null;
            try
            {
                CBd.AbrirConexion();
                Rec = CBd.EjecutarConsulta(CadSql);

                while (Rec.Read())
                {

                    txtRut.Text = Rec["rut"].ToString();
                    txtProveedor.Text = Rec["razon"].ToString();
                    txtGiro.Text = Rec["giro"].ToString();

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

        private void rbtGuiatraspaso_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtGuiatraspaso.Checked)
            {
                gruptraspasos.Visible = true;
                grupDocumentos.Visible = false;
            }
        }

        private void rbtGuia_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtGuia.Checked)
            {
                grupDocumentos.Visible = true;
                gruptraspasos.Visible = false;
            }
            
        }

        private void rbtFactura_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtFactura.Checked)
            {
                grupDocumentos.Visible = true;
                gruptraspasos.Visible = false;
            }
        }

       


       


        

    }
}
