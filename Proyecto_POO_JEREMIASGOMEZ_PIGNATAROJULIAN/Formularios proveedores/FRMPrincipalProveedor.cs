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
    public partial class FRMPrincipalProveedor : Form
    {

        CLSGestionararchivos mostrarinsumos = new CLSGestionararchivos();
        List<CLSInsumos> listainsumos = new List<CLSInsumos>();
        public FRMPrincipalProveedor(string nombre, double cuil, string direccion, string telefono, string contrasena)
        {
            InitializeComponent();
            listainsumos = mostrarinsumos.cargarinsumos();
            CLSProveedor Proveedor = new CLSProveedor(nombre,cuil,direccion,telefono,contrasena);
            var insumosProveedor = Proveedor.MostrarInsumo(listainsumos,cuil,nombre);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = insumosProveedor;
        }

    }
}
