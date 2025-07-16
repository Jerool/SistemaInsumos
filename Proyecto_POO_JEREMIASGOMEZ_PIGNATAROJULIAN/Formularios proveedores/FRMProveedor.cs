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
    public partial class FRMProveedor : Form
    {
        public List<CLSProveedor> listaproveedores = new List<CLSProveedor>();
        public FRMProveedor()
        {
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtTelefono.Text) || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Complete todos los campos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            bool existe = false;
            string path = "Proveedores.txt";

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = sr.ReadLine(); // encabezado
                linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] vl = linea.Split(';');
                    if (vl[1] == numericUpDown1.Value.ToString())
                    {
                        existe = true;
                        break;
                    }
                    linea = sr.ReadLine();
                }
            }
            if (existe)
            {
                MessageBox.Show("El proveedor ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                actualizarcampos();
            }
            else
            {
                CLSProveedor aux = new CLSProveedor(txtnombre.Text, ((double)numericUpDown1.Value), txtDireccion.Text, txtTelefono.Text,txtContraseña.Text);
                listaproveedores.Add(aux);
                aux.RegistrarProveedor(txtnombre.Text,numericUpDown1.Value,txtDireccion.Text, txtTelefono.Text, txtContraseña.Text);
                CLSDelegadosGlobales.proveedorRegistrado = nombre =>
                {
                    MessageBox.Show($"Se ha registrado el proveedor correctamente,{nombre}");
                };
                CLSDelegadosGlobales.proveedorRegistrado?.Invoke(".");
                actualizarcampos();
            }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void actualizarcampos()
        {
           txtnombre.Text = string.Empty;
           txtDireccion.Text = string.Empty;
           txtTelefono.Text = string.Empty;
           numericUpDown1.Value = 0;
        }
    }
}
