using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public static class CLSConvertidor
    {
        public static double ConvertirAUnidadBase(double cantidad, string unidad)
        {
            switch (unidad.ToLower())
            {
                case "mililitros":
                return cantidad / 1000.0; // pasa a litros

                case "miligramos":
                    return cantidad / 1000.0; // pasa a gramos (si tu unidad base es kg, debería ser /1_000_000)

                case "gramos":
                    return cantidad / 1000.0; // a kilogramos

                case "litros":

                case "kilogramos":
                    return cantidad; // ya está en unidad base

                default:
                    return cantidad; // por si acaso
            }
        }
    }
}
