using System;

using System.Collections.Generic;

using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
//A:| Tipo Documento     : 33
//A:| Folio Documento    :  23021
//A:| Fecha Emision      : 2016/09/15
//A:| Forma Pago         : 2
//A:| Rut Emisor         : 76071238-8
//A:| Razon Social Emisor: Patagonia Beef SpA
//A:| Giro Emisor        : Carniceria, Ganaderia, Rotiseria
//A:| ACTECO Emisor      : 013000
//A:| Direccion Origen   : Avda. Recabarren 01374
//A:| Comuna Origen      : Temuco
//A:| Ciudad Origen      : Temuco
//A:| Codigo Vendedor    : 2
//A:| Rut Receptor       : 76.254.266-8
//A:| Razon Social Recep : EL FIORDO SPA                      
//A:| Giro Receprot      : EXPLOTACION HOTELES CAFE RESTAURANT
//A:| Direccion Receprot : BULNES 733                         
//A:| Comuna Receptor    : TEMUCO                   
//A:| Ciudad Receprot    : TEMUCO                   
//A:| Monto Neto         :      167955
//A:| Tasa Iva           : 19
//A:| Iva                :       31911
//A:| TipoImp            : 18
//A:| TasaImp            : 5
//A:| MontoImp           :        8398
//A:| Monto Total        :      208264
//B:|         1|ASIENTO CAT V                      |     24.65|    5000|     123250|18
//B:|         2|POSTA NEGRA CAT V                  |     10.16|    4400|      44704|18
namespace Prototipo1
{

    class ClaseFunciones
    {
        claseBD Conexion = new claseBD();

        public string enletras(string num)
        {

            string res, dec = "";

            Int64 entero;

            int decimales;

            double nro;

            try
            {

                nro = Convert.ToDouble(num);

            }

            catch
            {

                return "";

            }

            entero = Convert.ToInt64(Math.Truncate(nro));

            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));

            if (decimales > 0)
            {

                dec = " CON " + decimales.ToString() + "/100";

            }

            res = toText(Convert.ToDouble(entero)) + dec;

            return res;

        }

        public string toText(double value)
        {

            string Num2Text = "";

            value = Math.Truncate(value);

            if (value == 0) Num2Text = "CERO";

            else if (value == 1) Num2Text = "UNO";

            else if (value == 2) Num2Text = "DOS";

            else if (value == 3) Num2Text = "TRES";

            else if (value == 4) Num2Text = "CUATRO";

            else if (value == 5) Num2Text = "CINCO";

            else if (value == 6) Num2Text = "SEIS";

            else if (value == 7) Num2Text = "SIETE";

            else if (value == 8) Num2Text = "OCHO";

            else if (value == 9) Num2Text = "NUEVE";

            else if (value == 10) Num2Text = "DIEZ";

            else if (value == 11) Num2Text = "ONCE";

            else if (value == 12) Num2Text = "DOCE";

            else if (value == 13) Num2Text = "TRECE";

            else if (value == 14) Num2Text = "CATORCE";

            else if (value == 15) Num2Text = "QUINCE";

            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);

            else if (value == 20) Num2Text = "VEINTE";

            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);

            else if (value == 30) Num2Text = "TREINTA";

            else if (value == 40) Num2Text = "CUARENTA";

            else if (value == 50) Num2Text = "CINCUENTA";

            else if (value == 60) Num2Text = "SESENTA";

            else if (value == 70) Num2Text = "SETENTA";

            else if (value == 80) Num2Text = "OCHENTA";

            else if (value == 90) Num2Text = "NOVENTA";

            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);

            else if (value == 100) Num2Text = "CIEN";

            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);

            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";

            else if (value == 500) Num2Text = "QUINIENTOS";

            else if (value == 700) Num2Text = "SETECIENTOS";

            else if (value == 900) Num2Text = "NOVECIENTOS";

            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);

            else if (value == 1000) Num2Text = "MIL";

            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);

            else if (value < 1000000)
            {

                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";

                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);

            }

            else if (value == 1000000) Num2Text = "UN MILLON";

            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);

            else if (value < 1000000000000)
            {

                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";

                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);

            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";

            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {

                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";

                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            }

            return Num2Text;

        }


        public void llenarCombo(String CadSql, ComboBox Cbo, string CampoVer, String CampoValor)
        {
            MySqlDataAdapter DA = new MySqlDataAdapter(CadSql, claseBD.conex);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Cbo.DataSource = DS.Tables[0];
            Cbo.DisplayMember = CampoVer;
            Cbo.ValueMember = CampoValor;
            Cbo.SelectedIndex = -1;
        }


    }

}