using Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public partial class FRMMostrarPedidos : Form
    {
        List<CLSPedidos> listapedidos = new List<CLSPedidos>();
        public FRMMostrarPedidos()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (string linea in File.ReadAllLines("Pedidos.txt").Skip(1)) // salta encabezado
            {
                string[] partes = linea.Split(';');
                if (partes.Length < 3) continue;

                string direccion = partes[0];

                // Producto y cantidad
                List<ProductosPedidos> listaProductos = partes[1].Split(',').Select(p =>
                {
                  var datos = p.Split('|');
                  string nombre = datos[0].Trim();
                  double cantidad = double.Parse(datos[1].Trim());

                  CLSProducto producto = new CLSProducto
                  {
                   Nombre = nombre
                  };

                  return new ProductosPedidos(producto, cantidad);}).ToList();

                // ID
                int id = int.Parse(partes[2]);

                CLSPedidos pedido = new CLSPedidos(direccion, listaProductos, id);
                listapedidos.Add(pedido);
            }

            dataGridView1.DataSource = listapedidos;
        }
    }
}
