using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public class CLSInsumoproducto
    {
		private CLSInsumos _Insumo;

		public CLSInsumos Insumo
		{
			get { return _Insumo; }
			set { _Insumo = value; }
		}

		private double _Cantidadusada;

		public double CantidadUsada
		{
			get { return _Cantidadusada; }
			set { _Cantidadusada = value; }
		}

		public CLSInsumoproducto(CLSInsumos insumo, double cantidadusada)
        {
			Insumo = insumo;
			CantidadUsada = cantidadusada;
        }

		public override string ToString()
		{
            return $"{Insumo.Nombre} - {CantidadUsada} {Insumo.Unidad}";
        }

    }
}
