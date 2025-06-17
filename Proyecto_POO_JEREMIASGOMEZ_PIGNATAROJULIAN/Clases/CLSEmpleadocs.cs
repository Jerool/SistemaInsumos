using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public class CLSEmpleadocs : CLSPersona
    {
		
		private string _Direccion;

		public string Direccion
		{
			get { return _Direccion; }
			set { _Direccion = value; }
		}

		private string _Telefono;

		public string Telefono
		{
			get { return _Telefono; }
			set { _Telefono = value; }
		}

		private string _Contraseña;

		public string Contraseña
		{
			get { return _Contraseña; }
			set { _Contraseña = value; }
		}




		public CLSEmpleadocs(string nombre, string apellido, string dni,  string direccion, string telefono, string contraseña) : base(nombre,apellido,dni)
        {
			Direccion = direccion; 
			Telefono = telefono;
			Contraseña = contraseña;
        }

      
        internal void registrarempleado(string text1, string text2, string text3, string text4, string text5, string contra)
        {
            string path = "Empleados.txt";
            int legajo = 1;

            if (File.Exists(path))
            {
                legajo = File.ReadAllLines(path).Length + 1;
            }
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(DNI + ";" + Nombre + ";" + Apellido + ";" + Direccion + ";" + Telefono +";" + legajo + ";" + Contraseña);
            }
        }
    }
}
