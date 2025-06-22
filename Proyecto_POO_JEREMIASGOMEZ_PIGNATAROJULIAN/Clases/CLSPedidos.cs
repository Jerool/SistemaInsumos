using Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
	public class CLSPedidos
	{
		private int _Cantidad;
		public int Cantidad
		{
			get { return _Cantidad; }
			set { _Cantidad = value; }
		}

		private string _Direccion;

		public string Direccion
		{
			get { return _Direccion; }
			set { _Direccion = value; }
		}

		private List<ProductosPedidos> _ListaProductos;

		public List<ProductosPedidos> ListaProductos
		{
			get { return _ListaProductos; }
			set { _ListaProductos = value; }
		}

		private int _ID;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}

		public CLSPedidos(int cantidad, string direccion, List<ProductosPedidos> listaproducto)
        {
			Cantidad = cantidad;
			Direccion = direccion;
			ListaProductos = listaproducto;
        }


		public override string ToString()
        {
            string ProductosUsados = string.Join(",", ListaProductos.Select(p =>$"{p.Producto.Nombre} | {p.CantidadUsadaProductos}"));
            return $"{Cantidad};{Direccion};{ProductosUsados}";
		}

    }
}
