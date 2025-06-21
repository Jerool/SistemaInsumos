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
    public partial class FRMVerProductos : Form
    {
        public List<CLSProducto> listaproductos = new List<CLSProducto>();
        CLSGestionararchivos mostrarproductos = new CLSGestionararchivos();
        public FRMVerProductos()
        {
            InitializeComponent();
            listaproductos = mostrarproductos.ProductosCarga(mostrarproductos.cargarinsumos());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaproductos;
        }
    }
}
