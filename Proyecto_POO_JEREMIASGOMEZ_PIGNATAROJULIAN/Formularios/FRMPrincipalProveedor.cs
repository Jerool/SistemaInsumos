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
        public FRMPrincipalProveedor()
        {
            InitializeComponent();
            listainsumos = mostrarinsumos.cargarinsumos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listainsumos;
        }
    }
}
