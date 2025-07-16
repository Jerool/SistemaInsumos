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
    public partial class FRMPedidos : Form
    {
        public List<CLSProducto> ListaProductos = new List<CLSProducto>();
        CLSGestionararchivos MostrarProductos = new CLSGestionararchivos();
        public List<ProductosPedidos> ListaProductosPedidos = new List<ProductosPedidos>();
        public List<CLSPedidos> ListaPedidos = new List<CLSPedidos>();
        public FRMPedidos()
        {
            InitializeComponent();
            ListaProductos = MostrarProductos.ProductosCarga(MostrarProductos.cargarinsumos());
            foreach (var Producto in ListaProductos)
            {
                cmbProductos.Items.Add(Producto);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var p in ListaProductosPedidos)
            {
                p.Producto.CantidadProductos -= p.CantidadUsadaProductos ;
            }
            using (FileStream fs = new FileStream("Productos.txt", FileMode.Create, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("Nombre;Rubro;Precio;Insumousados;CantidadProductos");

                foreach (var producto in ListaProductos)
                {
                    sw.WriteLine(producto.ArchivoProductos());
                }
            }
            int id = 0;
            if (File.Exists("Pedidos.txt"))
            {
                id = File.ReadAllLines("Pedidos.txt").Length + 1;
                CLSPedidos nuevoPedido = new CLSPedidos((int)numericUpDown1.Value, txtDireccion.Text, new List<ProductosPedidos>(ListaProductosPedidos));
                ListaPedidos.Add(nuevoPedido);
                using (FileStream fs = new FileStream("Pedidos.txt", FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(nuevoPedido + ";" + id);
                    MessageBox.Show("Se registro el pedido correctamente", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe");
            }
            
        }
     
        private void btnAgregarproducto_Click(object sender, EventArgs e)
        {
            try
            {
                CLSProducto ProductoSeleccionado = (CLSProducto)cmbProductos.SelectedItem;
                if ((double)numericUpDown1.Value > ProductoSeleccionado.CantidadProductos)
                {
                    MessageBox.Show("No hay suficiente productos", "Error", MessageBoxButtons.OK);
                    return;
                }
                string Direccion = txtDireccion.Text;
                double CantidadUsadaProductos = (double)numericUpDown1.Value;
                ProductosPedidos ProductoPedido = new ProductosPedidos(ProductoSeleccionado, CantidadUsadaProductos);
                listBox1.Items.Add($"{ProductoSeleccionado.Nombre} - {CantidadUsadaProductos}");
                ListaProductosPedidos.Add(ProductoPedido);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cmbProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }
        }
    }
}
