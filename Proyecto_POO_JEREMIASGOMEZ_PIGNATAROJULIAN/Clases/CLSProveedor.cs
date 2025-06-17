using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public class CLSProveedor
    {
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private double _CUIT;

        public double CUIT
        {
            get { return _CUIT; }
            set { _CUIT = value; }
        }

        private string _direccion;

        public string  Direccion
        {
            get { return  _direccion; }
            set { _direccion = value; }
        }
        private string _Telefono;

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }


        public CLSProveedor(string nombre, double cuit, string direccion, string telefono) 
        {
            Nombre = nombre;
            CUIT = cuit;
            Direccion = direccion;
            Telefono = telefono;

        }

        internal void registrarproveedor(string text1, decimal value, string text2, string txtTelefono)
        {
            string path = "Proveedores.txt";
            
           
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(Nombre + ";" + CUIT + ";" + Direccion + ";" + Telefono);
            }
        }

        public override string ToString()
        {
            return $"{Nombre} - {CUIT}";
        }

    }
}
