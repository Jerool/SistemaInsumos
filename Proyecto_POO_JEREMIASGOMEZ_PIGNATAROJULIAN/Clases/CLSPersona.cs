using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public class CLSPersona
    {
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Apellido;

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        private string _DNI;

        public string DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }

        public CLSPersona(string nombre, string apellido, string dni) 
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }
    }
}
