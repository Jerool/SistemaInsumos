using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public FRMPedidos()
        {
            InitializeComponent();
            ListaProductos = MostrarProductos.ProductosCarga(MostrarProductos.cargarinsumos());
            foreach (var Producto in ListaProductos)
            {
                cmbProductos.Items.Add(Producto.MostrarProductos());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
