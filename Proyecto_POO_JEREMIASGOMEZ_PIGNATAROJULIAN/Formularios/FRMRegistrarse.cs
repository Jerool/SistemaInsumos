using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public partial class FRMRegistrarse : Form
    {
        List<CLSEmpleadocs> listaempleados = new List<CLSEmpleadocs>();
        public FRMRegistrarse()
        {
            InitializeComponent();
            txtrepetircontra.UseSystemPasswordChar = false;
            txtcontraseña.UseSystemPasswordChar = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtcontraseña.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtrepetircontra.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Complete todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtcontraseña.Text != txtrepetircontra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                txtcontraseña.Text = string.Empty;
                txtrepetircontra.Text = string.Empty;
            }
            bool existe = false;
            string path = "Empleados.txt";

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = sr.ReadLine(); // encabezado
                linea = sr.ReadLine();
                while (linea != null)
                {
                    string[] vl = linea.Split(';');
                    if (vl[0] == txtDNI.Text)
                    {
                        existe = true;
                        break;
                    }
                    linea = sr.ReadLine();
                }
            }
            if (existe)
            {
                MessageBox.Show("El Empleado ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CLSEmpleadocs aux = new CLSEmpleadocs(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtDireccion.Text, txtTelefono.Text, txtcontraseña.Text);
                listaempleados.Add(aux);
                aux.registrarempleado(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtDireccion.Text, txtTelefono.Text,txtcontraseña.Text);
                MessageBox.Show("Se ha registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRMInicioSesion aux1 = new FRMInicioSesion();
                aux1.Show();    
                aux1.Enabled = true;
                this.Hide();
            }
        }
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }
        }
        private void txtDNI_Enter(object sender, EventArgs e)
        {
            if (txtDNI.Text == "DNI")
            {
                txtDNI.Text = string.Empty;
                txtDNI.ForeColor = Color.LightGray;
            }
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = string.Empty;
                txtNombre.ForeColor = Color.LightGray;
            }
        }
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "APELLIDO")
            {
                txtApellido.Text = string.Empty;
                txtApellido.ForeColor = Color.LightGray;
            }
        }
        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "DIRECCION")
            {
                txtDireccion.Text = string.Empty;
                txtDireccion.ForeColor = Color.LightGray;
            }
        }
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "TELEFONO")
            {
                txtTelefono.Text = string.Empty;
                txtTelefono.ForeColor = Color.LightGray;
            }
        }
        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA")
            {
                txtcontraseña.Text = string.Empty;
                txtcontraseña.ForeColor = Color.LightGray;
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }
        private void txtrepetircontra_Enter(object sender, EventArgs e)
        {
            if (txtrepetircontra.Text == "REPETIR CONTRASEÑA")
            {
                txtrepetircontra.Text = string.Empty;
                txtrepetircontra.ForeColor = Color.LightGray;
                txtrepetircontra.UseSystemPasswordChar = true;
            }
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            if (txtDNI.Text == string.Empty)
            {
                txtDNI.Text = "DNI";
                txtDNI.ForeColor = Color.DimGray;
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.DimGray;
            }
        }
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == string.Empty)
            {
                txtApellido.Text = "APELLIDO";
                txtApellido.ForeColor = Color.DimGray;
            }
        }
        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == string.Empty)
            {
                txtDireccion.Text = "DIRECCION";
                txtDireccion.ForeColor = Color.DimGray;
            }
        }
        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == string.Empty)
            {
                txtTelefono.Text = "TELEFONO";
                txtTelefono.ForeColor = Color.DimGray;
            }
        }
        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == string.Empty)
            {
                txtcontraseña.Text = "CONTRASEÑA";
                txtcontraseña.ForeColor = Color.DimGray;
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }
        private void txtrepetircontra_Leave(object sender, EventArgs e)
        {
            if (txtrepetircontra.Text == string.Empty)
            {
                txtrepetircontra.Text = "REPETIR CONTRASEÑA";
                txtrepetircontra.ForeColor = Color.DimGray;
                txtrepetircontra.UseSystemPasswordChar = false;
            }
        }

        private void FRMRegistrarse_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
