using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
	public class CLSPedidos
	{
		private string _Nombre;

		public string Nombre
		{
			get { return _Nombre; }
			set { _Nombre = value; }
		}

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

		private CLSProducto _Productos;

		public CLSProducto Productos
        {
			get { return _Productos; }
			set { _Productos = value; }
		}


		public CLSPedidos(string nombre, int cantidad, string direccion, CLSProducto producto)
        {
            Nombre = nombre;
			Cantidad = cantidad;
			Direccion = direccion;
			Productos = producto;
        }


    }
}
