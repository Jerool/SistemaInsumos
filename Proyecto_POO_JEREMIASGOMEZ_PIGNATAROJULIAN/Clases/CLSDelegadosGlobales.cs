using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public static class CLSDelegadosGlobales
    {
        public delegate void Bienvenida(string nombre);
        public static Bienvenida bienvenida;

        public delegate void EmpleadoRegistrado(string asdsadas);
        public static EmpleadoRegistrado empleadoregistrado;

        public delegate void ProveedorRegistrado(string asdsad);
        public static ProveedorRegistrado proveedorRegistrado;


    }
}
