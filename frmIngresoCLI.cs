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
    public partial class frmIngresoCLI : Form
    {
        claseBD CBd = new claseBD();
        public frmIngresoCLI()
        {
            InitializeComponent();
        }
        ClaseFunciones a = new ClaseFunciones();
        private void frmIngresoCLI_Load(object sender, EventArgs e)
        {
            cboVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            String CadSqlX;
            CadSqlX = "select nom_ven, des_ven from vendedores";
            a.llenarCombo(CadSqlX, cboVendedor, "des_ven", "des_ven");

            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            llenarDgv();
            cboBuscar.SelectedIndex = 0;

            
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmMenu M = new frmMenu();
            //M.Show();
            frmListadoClientes f = new frmListadoClientes();
            f.Show();
            this.Hide();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);

            }
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);

            }
        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);

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

      

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
            {
                e.KeyChar = Convert.ToChar(0);

            } 
        }

        

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (mskRUT.MaskCompleted)
            {
                string rut2 = mskRUT.Text;

                if (mskRUT.Text.Substring(0, 1) == "0")
                {
                    rut2 = rut2.Substring(1, 8);

                }
                string CadSql;
                CadSql = "update clientes set  nombres='" + txtNombre.Text.ToUpper() + "', razon_social='" + txtrazonsocial.Text.ToUpper() + "', giro='" + txtgiro.Text.ToUpper() + "', direccion='" + txtDireccion.Text.ToUpper() + "', telefono='" + txtTelefono.Text.ToUpper() + "',comuna = '" + txtcomuna.Text.ToUpper() + "',ciudad = '" + txtciudad.Text.ToUpper() + "',vendedor = '" + cboVendedor.SelectedValue.ToString() +"', NF= '"+txtNF.Text.ToUpper()+"', saldo='"+txtSaldo.Text+"' where rut='" + rut2 + "';";

                try
                {
                    if (CBd.EjecutarIUD(CadSql) > 0)
                    {
                        MessageBox.Show("Cliente Modificado", "Listo");
                        limpiar();
                        cmdGuardar.Enabled = true;
                        cmdEliminar.Enabled = false;
                        cmdModificar.Enabled = false;
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Cliente NO Modificado", "ERROR");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe Ingresar un rut completo");
            }
            llenarDgv();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (mskRUT.MaskCompleted)
            {
                string rut2 = mskRUT.Text;

                if (mskRUT.Text.Substring(0, 1) == "0")
                {
                    rut2 = rut2.Substring(1, 8);

                }
                string CadSql;

                CadSql = "delete from clientes where rut='" + rut2 + "';";



                try
                {
                    if (CBd.EjecutarIUD(CadSql) > 0)
                    {
                        MessageBox.Show("Cliente Eliminado");
                        limpiar();
                        cmdGuardar.Enabled = true;
                        cmdEliminar.Enabled = false;
                        cmdModificar.Enabled = false;
                        
                    }
                    else
                    {
                        MessageBox.Show("Cliente NO Eliminado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe Ingresar un rut completo");
            }
            llenarDgv();
        }

        private void cmdGuardar_Click_1(object sender, EventArgs e)
        {
            if (mskRUT.MaskCompleted)
            {
                string rut2 = mskRUT.Text;

                if (mskRUT.Text.Substring(0, 1) == "0")
                {
                    rut2 = rut2.Substring(1, 8);

                }
                string CadSql;
                CadSql = "insert into clientes values('" + rut2.ToUpper() + "','" + txtrazonsocial.Text.ToUpper() + "','" + txtgiro.Text.ToUpper() + "','" + txtNombre.Text.ToUpper() + "','" + txtDireccion.Text.ToUpper() + "','" + txtTelefono.Text.ToUpper() + "','"+txtcomuna.Text.ToUpper()+"','"+txtciudad.Text.ToUpper()+"','"+cboVendedor.SelectedValue.ToString()+"','"+txtNF.Text.ToUpper()+"','"+txtSaldo.Text.ToUpper()+"');";
                
                //validar existencia
                // CadSql = "select * from clientes where rut = '++'";
                //end validar existencia

                try
                {
                    if (CBd.EjecutarIUD(CadSql) > 0)
                    {
                        MessageBox.Show("Cliente Registrado", "Listo");
                        limpiar();

                    }
                    else
                    {
                        MessageBox.Show("Cliente NO Registrado", "ERROR");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe Ingresar un rut completo");
            }
            llenarDgv();
        }

        
        private void limpiar()
        {
            mskRUT.Text = "";
            
            txtgiro.Text = "";
            txtrazonsocial.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtciudad.Text = "";
            txtcomuna.Text = "";
            cboVendedor.SelectedIndex = -1;
            txtNF.Text = "";
            txtSaldo.Text = "";
            
        }

        public bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        public static Boolean vRut(string rut)
        {

            Boolean ok = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace("K","");
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int aux = int.Parse(rut.Substring(0, rut.Length - 1));

                char verificador = char.Parse(rut.Substring(rut.Length - 1, 1));

                int num1 = 0, num2 = 1;
                for (; aux != 0; aux /= 10)
                {
                    num2 = (num2 + aux % 10 * (9 - num1++ % 6)) % 11;
                }
                if (verificador == (char)(num2 != 0 ? num2 + 47 : 75))
                {
                    ok = true;
                }
            }
            catch (Exception)
            {
            }

            return ok;
        }

        private void llenarDgv()
        {
            string CadSql;
            CadSql = "select a.rut,a.razon_social,a.giro,a.nombres from clientes a";

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
                    dgvLista.Rows[fila].Cells[0].Value = Rec["rut"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["razon_social"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["giro"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["nombres"].ToString();

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

        private void mskRUT_Leave(object sender, EventArgs e)
        {
            
               
                string rut;
                rut = mskRUT.Text;
                string CadSql;
                if (mskRUT.MaskCompleted)
                {
                    string rut2 = mskRUT.Text;

                    if (mskRUT.Text.Substring(0, 1) == "0")
                    {
                        rut2 = rut2.Substring(1, 8);

                    }
                    CadSql = "select * from clientes where rut = '" + rut2 + "'";


                    claseBD CBd = new claseBD();

                    MySqlDataReader Rec = null;
                    try
                    {
                        CBd.AbrirConexion();
                        Rec = CBd.EjecutarConsulta(CadSql);

                        while (Rec.Read())
                        {

                            txtrazonsocial.Text = Rec["razon_social"].ToString();
                            txtgiro.Text = Rec["giro"].ToString();
                            txtNombre.Text = Rec["nombres"].ToString();
                            txtDireccion.Text = Rec["direccion"].ToString();
                            txtTelefono.Text = Rec["telefono"].ToString();
                            txtciudad.Text = Rec["ciudad"].ToString();
                            txtcomuna.Text = Rec["comuna"].ToString();
                            cboVendedor.Text = Rec["vendedor"].ToString();
                            txtNF.Text = Rec["NF"].ToString();
                            txtSaldo.Text = Rec["saldo"].ToString();


                        }
                        
                        
                            cmdGuardar.Enabled = true;
                            cmdEliminar.Enabled = true;
                            cmdModificar.Enabled = true;
                        
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
                else
                {
                    MessageBox.Show("Debe completar el texto RUT");
                    limpiar();
                }

            
        }

        private void cmdVerificar_Click(object sender, EventArgs e)
        {
            if (mskRUT.MaskCompleted)
            {
                string rut2 = mskRUT.Text;

                if (mskRUT.Text.Substring(0, 1) == "0")
                {
                    rut2 = rut2.Substring(1, 8);

                }
                if (validarRut(rut2))
                {
                    MessageBox.Show("RUT VÁLIDO","ÉXITO");
                }
                else
                {
                    MessageBox.Show("RUT ERRONEO","ERROR");
                }
            }
            else
            {
                MessageBox.Show("Para verificar un rut, debe ingresar un rut completo","ERROR");
            }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        private void BuscarDGV(string dato)
        {
            string CadSql;
            CadSql = "select rut ,nombres,razon_social,giro from clientes where  " + dato + " like '%" + txtBuscar.Text + "%';";

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
                    dgvLista.Rows[fila].Cells[0].Value = Rec["rut"].ToString();
                    dgvLista.Rows[fila].Cells[1].Value = Rec["razon_social"].ToString();
                    dgvLista.Rows[fila].Cells[2].Value = Rec["giro"].ToString();
                    dgvLista.Rows[fila].Cells[3].Value = Rec["nombres"].ToString();
                    


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
                    BuscarDGV("giro");

                }
                else if (cboBuscar.SelectedIndex == 3)
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
                    BuscarDGV("giro");

                }
                else if (cboBuscar.SelectedIndex == 3)
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

        private void mskRUT_TextChanged(object sender, EventArgs e)
        {
            if (mskRUT.Text == "")
            {
                limpiar();
            }
        }

        private void smdSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                String dato = this.dgvLista.CurrentRow.Cells["grdRUT"].Value.ToString();
                mskRUT.Text = dato;
                if (!mskRUT.MaskCompleted)
                {
                    mskRUT.Text = "0" + dato;
                }
                mskRUT_Leave(sender,e);
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un elemento");
            }
        }


        
    }
}
