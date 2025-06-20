using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public class CLSGestionararchivos
    {
        string path = "Insumos.txt";
        internal List<CLSInsumos> cargarinsumos()
        {
            List<CLSInsumos> listainsumo = new List<CLSInsumos>();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = "";
                string[] vl = new string[0];

                sr.ReadLine();
                linea = sr.ReadLine();

                while (linea != null)
                {
                    vl = linea.Split(';');
                    CLSInsumos insumo = new CLSInsumos(vl[0], Convert.ToDouble(vl[2]), vl[1], vl[3], vl[4], vl[5], vl[6]);
                    listainsumo.Add(insumo);
                    linea = sr.ReadLine();
                }
                return listainsumo;
            }
        }
        public List<CLSProveedor> cargarproveedores()
        {
            List<CLSProveedor> listaproveedores = new List<CLSProveedor>();
            using (FileStream fs = new FileStream("Proveedores.txt", FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = "";
                string[] vl = new string[0];

                sr.ReadLine();
                linea = sr.ReadLine();
                while (linea != null)
                {
                    vl = linea.Split(';');
                    CLSProveedor proveedor = new CLSProveedor(vl[0], Convert.ToDouble(vl[1]), vl[2], vl[3], vl[4]);
                    listaproveedores.Add(proveedor);
                    linea = sr.ReadLine();
                }
                return listaproveedores;
            }
        }
        internal List<CLSProducto> productoscarga(List<CLSInsumos> listaInsumos)
        {
            List<CLSProducto> listaproductos = new List<CLSProducto>();

            using (FileStream fs = new FileStream("Productos.txt", FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = "";
                sr.ReadLine();
                linea = sr.ReadLine() ;
                while (linea != null)
                {
                    string[] vl = linea.Split(';');
                    string nombre = vl[0];
                    string rubro = vl[1];
                    int precio = Convert.ToInt32(vl[2]);

                    List<CLSInsumoproducto> listainsumos = new List<CLSInsumoproducto>();

                    if (vl.Length > 3)
                    {
                        string[] partesInsumos = vl[3].Split(':');
                        foreach (var parte in partesInsumos)
                        {
                            string[] datos = parte.Split('|');
                            
                                string nombreInsumo = datos[0];
                            double cantidadUsada = double.Parse(datos[1].Replace(',', '.'), CultureInfo.InvariantCulture);
                            CLSInsumos insumo = listaInsumos.FirstOrDefault(i => i.Nombre.Trim().Equals(nombreInsumo.Trim(), StringComparison.OrdinalIgnoreCase));
                                if (insumo == null)
                                {
                                    // Crear un insumo "ficticio" si no se encuentra en la lista
                                    insumo = new CLSInsumos(nombreInsumo, 0, "unidad", "calidad", "proporcion", "proveedor", "responsable"); // Podés usar "" o "?" también
                                }

                                CLSInsumoproducto ip = new CLSInsumoproducto(insumo, cantidadUsada);
                                listainsumos.Add(ip);
                            
                        }
                    }
                    CLSProducto producto = new CLSProducto(nombre, rubro, precio, listainsumos);
                    listaproductos.Add(producto);
                    linea = sr.ReadLine();
                }
                    
            } 
            return listaproductos;
        }
           
    }
}


