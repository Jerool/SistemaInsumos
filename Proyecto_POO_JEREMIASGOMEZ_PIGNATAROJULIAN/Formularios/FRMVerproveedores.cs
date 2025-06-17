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
    public partial class FRMVerproveedores : Form
    {
        public List<CLSProveedor> listaproveedores = new List<CLSProveedor>();
        CLSGestionararchivos mostrarproveedores = new CLSGestionararchivos();
        public FRMVerproveedores()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            listaproveedores = mostrarproveedores.cargarproveedores();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaproveedores;
        }
    }
}
