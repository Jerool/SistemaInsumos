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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public partial class FRMInicioSesion : Form
    {
        string linea = "";
        string[] vl = new string[0];
        string[] vl1 = new string[0];
        public FRMInicioSesion()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = false;
            lblerror.Visible = false;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnIniciarsesion_Click(object sender, EventArgs e)
        {

            string path = "Empleados.txt";
            string path1 = "Proveedores.txt";
            bool ValidarUsuario = false;
            bool empleado = false;
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    sr.ReadLine();
                    linea = sr.ReadLine();
                    while (linea != null)
                    {
                        vl = linea.Split(';');
                        if (vl[0] == txtDNI.Text && vl[6] == txtContraseña.Text)
                        {
                            ValidarUsuario = true;
                            empleado = true;
                            this.Hide();
                            FRMPrincipal aux = new FRMPrincipal(vl[1], vl[2], vl[0], Convert.ToInt32(vl[5]), Convert.ToInt32(vl[4]), vl[3]);
                            aux.Show();
                            aux.Enabled = true;
                            CLSDelegadosGlobales.bienvenida = nombre1 =>
                            {
                                MessageBox.Show($"Bienvenido, {nombre1}");
                            };
                            CLSDelegadosGlobales.bienvenida?.Invoke(vl[1]);
                            return;
                        }
                        linea = sr.ReadLine();
                    }
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (!empleado && File.Exists(path1))
            {
                using (FileStream fs1 = new FileStream(path1, FileMode.Open, FileAccess.Read))
                using (StreamReader sr1 = new StreamReader(fs1))
                {
                    sr1.ReadLine();
                    linea = sr1.ReadLine();
                    while (linea != null)
                    {
                        vl1 = linea.Split(';');
                        if (vl1[1] == txtDNI.Text && vl1[4] == txtContraseña.Text)
                        {
                            ValidarUsuario = true;
                            this.Hide();
                            FRMPrincipalProveedor aux1 = new FRMPrincipalProveedor(vl1[0],Convert.ToDouble(vl1[1]), vl1[2], vl1[3], vl1[4]);
                            aux1.Show();
                            aux1.Enabled = true;
                            return;
                        }
                        linea = sr1.ReadLine();
                    }
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ValidarUsuario == false)
            {
                if (txtDNI.Text != "DNI")
                {
                    if (txtContraseña.Text != "Contraseña")
                    {
                        if (vl[0] != txtDNI.Text && vl[6] != txtContraseña.Text || vl1[1] != txtDNI.Text && vl1[4] != txtContraseña.Text)
                        {
                            MessageBox.Show("Usuario no registrado");
                            txtContraseña.Text = string.Empty;
                            txtDNI.Text = string.Empty;
                        }
                    }
                    else msgerror("Por favor, ingrese la contraseña");
                }
                else
                {
                    msgerror("Por favor, ingrese el DNI");
                }
            }
        }

    

        private void msgerror(string v)
        {
            lblerror.Text = "       " + v;
            lblerror.Visible = true;
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDNI_Enter(object sender, EventArgs e)
        {
            if (txtDNI.Text == "DNI")
            {
                txtDNI.Text = string.Empty;
                txtDNI.ForeColor = Color.LightGray;
            }
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            if (txtDNI.Text == string.Empty)
            {
                txtDNI.Text = "DNI";
                txtDNI.ForeColor= Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = string.Empty;
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar= false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FRMInicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FRMRegistrarse aux = new FRMRegistrarse();
            aux.Show();
            aux.Enabled = true;
            this.Hide();
        }
    }
}
