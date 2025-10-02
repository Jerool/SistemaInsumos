using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN.Clases
{
	public class ProductosPedidos
	{
		private CLSProducto _Producto;

		public CLSProducto Producto
		{
			get { return _Producto; }
			set { _Producto = value; }
		}

		private double _CantidadUsadaProductos;

		public double CantidadUsadaProductos
        {
			get { return _CantidadUsadaProductos; }
			set { _CantidadUsadaProductos = value; }
		}

        public ProductosPedidos(CLSProducto producto, double cantidadproductos)
        {
            Producto = producto;
			CantidadUsadaProductos=cantidadproductos;
        }
    }
}
