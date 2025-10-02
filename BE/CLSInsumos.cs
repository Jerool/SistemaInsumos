using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public class CLSInsumos : Iinsumo
    {
		private string _Nombre;

		public string Nombre
		{
			get { return _Nombre; }
			set { _Nombre = value; }
		}

		private double _Cantidad;

		public double Cantidad
		{
			get { return _Cantidad; }
			set { _Cantidad = value; }
		}

		private string _Unidad;

		public string Unidad
		{
			get { return _Unidad; }
			set { _Unidad = value; }
		}

		private string _calidad;

		public string Calidad
		{
			get { return _calidad; }
			set { _calidad = value; }
		}

		private string _proporcion;

		public string Proporcion
		{
			get { return _proporcion; }
			set { _proporcion = value; }
		}

		private string _proveedor;

		public string Proveedor
		{
			get { return _proveedor; }
			set { _proveedor = value; }
		}
			
		private string _Responsable;

		public string Responsable	
		{
			get { return _Responsable; }	
			set { _Responsable = value; }
		}

        public CLSInsumos(string nombre, double cantidad, string unidad, string calidad, string proporcion, string proveedor, string responsable)
        {
            Nombre = nombre;
			Cantidad = cantidad;
			Unidad = unidad;
			Calidad = calidad;
			Proporcion = proporcion;
			Proveedor = proveedor;
			Responsable = responsable;
        }

       public void registrarinsumo(string text1, double value, string text2, string text3, string text4, string text5, string nombrempleado)
        {
            string path = "Insumos.txt";
			using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
			using (StreamWriter sw = new StreamWriter(fs))
			{
				sw.WriteLine(Nombre + ";" + Unidad + ";" + Cantidad + ";" + Calidad + ";" + Proporcion + ";" + Proveedor + ";" + Responsable);
            }
        }
		public override string ToString()
		{
			return $"{Nombre} - {Proveedor}";
		}

		public string ArchivoString()
		{
            return $"{Nombre};{Unidad};{Cantidad};{Calidad};{Proporcion};{Proveedor};{Responsable}";
        }

        internal List<CLSProveedor> FiltrarProveedor(List<CLSProveedor> listaproveedores, string v)
        {
			string ProveedorBuscar = v;
			var listaProveedoresFiltrada = listaproveedores.Where(i => $"{i.Nombre} - {i.CUIT}" == ProveedorBuscar).ToList();
            return listaProveedoresFiltrada;
        }
    }
}
