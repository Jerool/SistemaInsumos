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
    public partial class FRMUsuario : Form
    {
        public FRMUsuario(string nombre, string apellido, string DNI, int legajo, int telefono, string direccion)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblapellido.Text = apellido;
            lblDNI.Text = DNI;
            lblLegajo.Text =Convert.ToString(legajo);
            lbltelefono.Text = Convert.ToString(telefono);
            lbldireccion.Text= direccion;
        }

    }
}
