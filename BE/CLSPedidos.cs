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

		public CLSPedidos(string direccion, List<ProductosPedidos> listaproducto, int id)
        {
			Direccion = direccion;
			ListaProductos = listaproducto;
			ID = id;
        }


		public override string ToString()
        {
            string ProductosUsados = string.Join(",", ListaProductos.Select(p =>$"{p.Producto.Nombre} | {p.CantidadUsadaProductos}"));
            return $"{Direccion};{ProductosUsados};{ID}";
		}

        public string ProductosResumen
        {
            get
            {
                return string.Join(", ", ListaProductos.Select(p => $"{p.Producto.Nombre} x {p.CantidadUsadaProductos}"));
            }
        }

    }
}
