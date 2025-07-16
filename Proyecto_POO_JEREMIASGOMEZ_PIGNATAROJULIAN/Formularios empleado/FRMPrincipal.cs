using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public partial class FRMPrincipal : Form
    {
        string NombreEmpleado = "";
        string ApellidoEmpleado = "";
        string DNIEmpleado = "";
        int LegajoEmpleado = 0;
        string DireccionEmpleado = "";
        int TelefonoEmpleado = 0;
        delegate void objetodelegado(string msj);
        public FRMPrincipal(string nombre, string apellido, string DNI, int legajo, int telefono, string direccion)
        {
            InitializeComponent();
            NombreEmpleado = nombre;
            ApellidoEmpleado = apellido;
            DNIEmpleado = DNI;
            LegajoEmpleado = legajo;
            DireccionEmpleado = direccion;
            TelefonoEmpleado = telefono;
            AbrirForm(new FRMUsuario(NombreEmpleado, ApellidoEmpleado, DNIEmpleado, LegajoEmpleado, TelefonoEmpleado, DireccionEmpleado));
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FRMInicioSesion aux = new FRMInicioSesion();
            aux.Show();
            aux.Enabled = true;
            this.Hide();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlistas_Click(object sender, EventArgs e)
        {
            submenu.Visible = true;
        }

        private void btninsumos_Click(object sender, EventArgs e)
        {
            submenu.Visible = false;
            AbrirForm(new FRMVerinsumos());
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            submenu.Visible = false;
            AbrirForm(new FRMVerProductos());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRMInicioSesion aux = new FRMInicioSesion();
            aux.Show();
            aux.Enabled = true;
            this.Hide();
        }

        private void AbrirForm(object formulario)
        {
            if (this.panelContenedor.Controls.Count > 0) this.panelContenedor.Controls.RemoveAt(0);
            Form f = formulario as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(f);
            this.panelContenedor.Tag = f;
            f.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new FRMProducto());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new FRMProveedor());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new FRMRegistrarinsumo(NombreEmpleado));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirForm(new FRMUsuario(NombreEmpleado,ApellidoEmpleado,DNIEmpleado,LegajoEmpleado,TelefonoEmpleado,DireccionEmpleado));
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            AbrirForm(new FRMPedidos());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirForm(new FRMMostrarPedidos());
        }
    }
}
