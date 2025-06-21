using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public static class CLSConvertidor
    {
        public static double ConvertirAUnidadBase(double cantidadInsumo, string unidad, double cantidadProducto)
        {
            switch (unidad.ToLower())
            {
                case "mililitros":
                return (cantidadInsumo * cantidadProducto) / 1000.0; // pasa a litros

                case "miligramos":
                    return (cantidadInsumo * cantidadProducto) / 1000.0; // pasa a gramos (si tu unidad base es kg, debería ser /1_000_000)

                case "gramos":
                    return (cantidadInsumo * cantidadProducto) / 1000.0; // a kilogramos

                case "litros":

                case "kilogramos":
                    return (cantidadInsumo * cantidadProducto); // ya está en unidad base

                default:
                    return cantidadInsumo; // por si acaso
            }
        }

        public static double ConvertirInsumo(int cantidadIngresada, string unidadIngresada)
        {
            switch (unidadIngresada.ToLower())
            {
                case "mililitros":
                    return cantidadIngresada / 1000.0; // pasa a litros

                case "miligramos":
                    return cantidadIngresada / 1000.0; // pasa a gramos (si tu unidad base es kg, debería ser /1_000_000)

                case "gramos":
                    return cantidadIngresada / 1000.0; // a kilogramos

                case "litros":

                case "kilogramos":
                    return cantidadIngresada; // ya está en unidad base

                default:
                    return cantidadIngresada; // por si acaso
            }
        }
    }
}
