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

        public delegate void EmpleadoRegistrado(string b);
        public static EmpleadoRegistrado empleadoregistrado;

        public delegate void ProveedorRegistrado(string v);
        public static ProveedorRegistrado proveedorRegistrado;

        public delegate void PedidoRegistrado(string a);
        public static PedidoRegistrado pedidoRegistrado;
    }
}
