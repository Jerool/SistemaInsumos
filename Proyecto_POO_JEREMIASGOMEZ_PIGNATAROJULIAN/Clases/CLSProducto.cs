using Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
	public class CLSProducto
	{
		private string _Nombre;

		public string Nombre
		{
			get { return _Nombre; }
			set { _Nombre = value; }
		}

		private string _Rubro;

		public string Rubro
		{
			get { return _Rubro; }
			set { _Rubro = value; }
		}

		private int _Precio;

		public int Precio
		{
			get { return _Precio; }
			set { _Precio = value; }
		}
		private List<CLSInsumoproducto> _Insumoproductos;
		public List<CLSInsumoproducto> Insumoproductos
		{
			get { return _Insumoproductos; }
			set { _Insumoproductos = value; }
		}

		public CLSProducto(string nombre, string rubro, int precio, List<CLSInsumoproducto> insumoproducto)
		{
			Nombre = nombre;
			Rubro = rubro;
			Precio = precio;
			Insumoproductos = insumoproducto;
		}
		public override string ToString()
		{
			string insumos = string.Join(":", Insumoproductos.Select(i => $"{i.Insumo.Nombre}|{i.CantidadUsada}|{i.Insumo.Unidad}"));
			return $"{Nombre};{Rubro};{Precio};{insumos}";
		}
		public string InsumosUsados
        {
            get
            {
                return string.Join(":", Insumoproductos.Select(i => $"{i.Insumo.Nombre} ({i.CantidadUsada}) {i.Insumo.Unidad}"));
            }
        }
    }
}
