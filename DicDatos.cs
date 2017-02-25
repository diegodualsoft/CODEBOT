using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codebot
{
/*
 * clase de  diccionario de datos de mysql, en donde entrega el tipo de dato corresponde a c#
 * 
 * */
    public class DicDatos
    {
        public string tipoData(string data)
        {
            string[] tipo = data.Split('(');
            return DatoEs(tipo[0]);
        }
        private string DatoEs(string dato)
        {
            string tipo = "";
            switch (dato.ToLower())
            {
                case "varchar": tipo = "string"; break;
                case "Varchar": tipo = "string"; break;
                case "Longtext": tipo = "string"; break;
                case "longtext": tipo = "string"; break;
                case "Mediumtext": tipo = "string"; break;
                case "mediumtext": tipo = "string"; break;
                case "Text": tipo = "string"; break;
                case "text": tipo = "string"; break;
                case "Blob": tipo = "string"; break;
                case "blob": tipo = "string"; break;
                case "Enum": tipo = "string"; break;
                case "enum": tipo = "string"; break;
                case "Set": tipo = "string"; break;
                case "set": tipo = "string"; break;
                case "char": tipo = "char"; break;
                case "Char": tipo = "char"; break;
                case "Tinyint": tipo = "uint"; break;
                case "tinyint": tipo = "uint"; break;
                case "float": tipo = "float"; break;
                case "xreal": tipo = "double"; break;
                case "double": tipo = "double"; break;
                case "smallint": tipo = "int"; break;
                case "mediumint": tipo = "int"; break;
                case "integer": tipo = "int"; break;
                case "int": tipo = "int"; break;
                case "bigint": tipo = "int"; break;
                case "date": tipo = "DateTime"; break;
                case "datetime": tipo = "DateTime"; break;
                case "timestamp": tipo = "DateTime"; break;
                case "time": tipo = "DateTime"; break;
                case "year": tipo = "DateTime"; break;
                case "bool": tipo = "bool"; break;
                case "boolean": tipo = "Boolean"; break;
                case "bit": tipo = "bool"; break;
                case "decimal": tipo = "decimal"; break;
                case "longblob": tipo = "string"; break;
            }
            return tipo;
        }
        /*
         * equivalecia de datos
         * -------------------------------------
         * string = logtext, text, tinytext, MediumText, blob ,Enum y set
         * char = char
         * --------------------
         * numericos
         * uint = TinyInt
         * int = SmallInt, MediumInt, Integer, int. bigint
         * double = double, xReal
         * float = float
         * decimal = decimal
         * --------------------
         * fechas
         * datetime = date //yyyy-MM-dd
         * datetime = datetime //yyyy-MM-dd hh:mm:ss
         * datetime = timeStamp // yyyy-MM-dd hh:mm:ss
         * datetime = time //hh:mm:ss
         * datetime = year // yy or yyyy
         * --------------------------
         * datos booleano
         * bool or boolean = bit
         * 
         * */
    }
}
