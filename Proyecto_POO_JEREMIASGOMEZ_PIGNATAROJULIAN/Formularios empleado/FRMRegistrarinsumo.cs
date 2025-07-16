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
    public partial class FRMRegistrarinsumo : Form
    {
        CLSGestionararchivos mostrarproveedores = new CLSGestionararchivos();
        List<CLSProveedor> listaproveedores = new List<CLSProveedor>();
        List<CLSInsumos> listainsumos = new List<CLSInsumos>();
        private List<CLSInsumoproducto> insumosParaProducto = new List<CLSInsumoproducto>();
        string nombreempleado = "";
        delegate void RegistrarInsumo();

        public FRMRegistrarinsumo(string nombre)
        {
            InitializeComponent();
            nombreempleado = nombre;
            listaproveedores = mostrarproveedores.cargarproveedores();
            cbmproveedor.DataSource = listaproveedores;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtproporcion.Text) || cbmcalidad.SelectedIndex == -1 || cbmproveedor.SelectedIndex == -1 || cbmunidad.SelectedIndex == -1 || numericUpDown1.Value == -1)
            {
                MessageBox.Show("Complete todos los campos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            listainsumos.Clear();
            using (FileStream fs = new FileStream("Insumos.txt",FileMode.Open,FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string linea = "";
                string[] vl = new string[0];
                sr.ReadLine();
                linea = sr.ReadLine();
                while (linea !=null)
                {
                    vl = linea.Split(';');
                    double cantidad = double.Parse(vl[2], System.Globalization.CultureInfo.InvariantCulture);
                    CLSInsumos insumo = new CLSInsumos(vl[0],cantidad, vl[1], vl[3], vl[4], vl[5], vl[6]);
                    listainsumos.Add(insumo);
                    linea = sr.ReadLine();
                }
            }
            bool coincide = false;

            
                int CantidadIngresada = ((int)numericUpDown1.Value); // si escribís mal, lanza excepción
                string unidadIngresada = cbmunidad.Text;
                double cantidadConvertida = CLSConvertidor.ConvertirInsumo(CantidadIngresada, unidadIngresada);

                foreach (var insumo in listainsumos)
                {
                if (insumo.Nombre.Trim().ToLower() == txtnombre.Text.Trim().ToLower() && insumo.Proveedor.Trim().ToLower() == cbmproveedor.Text.Trim().ToLower() && insumo.Calidad.Trim().ToLower() == cbmcalidad.Text.Trim().ToLower())
                {
                    coincide = true;
                    insumo.Cantidad += cantidadConvertida;
                    break;
                }
                }

            if (coincide == false)
            {
                CLSInsumos aux = new CLSInsumos(txtnombre.Text, ((int)numericUpDown1.Value), cbmunidad.Text, cbmcalidad.Text, txtproporcion.Text, cbmproveedor.Text, nombreempleado);
                listainsumos.Add(aux);
                aux.registrarinsumo(txtnombre.Text, ((int)numericUpDown1.Value), cbmunidad.Text, cbmcalidad.Text, txtproporcion.Text, cbmproveedor.Text, nombreempleado);
            }

            using (FileStream fs1 = new FileStream("Insumos.txt", FileMode.Create, FileAccess.Write))
            using (StreamWriter sw1 = new StreamWriter(fs1))
            {
                sw1.WriteLine("NOMBRE;UNIDAD;CANTIDAD;CALIDAD;PROPORCION;PROVEEDORES;RESPONSABLE");
                foreach (var insumo in listainsumos)
                {
                    sw1.WriteLine(insumo.ArchivoString());
                }
            }
            MessageBox.Show("Se ha registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            actualizarcampos();

        }
        private void actualizarcampos()
        {
            txtnombre.Text = string.Empty;
            txtproporcion.Text = string.Empty;
            cbmcalidad.SelectedIndex = -1;
            cbmproveedor.SelectedIndex = -1;
            cbmunidad.SelectedIndex = -1;
            numericUpDown1.Value = 0;

        }

        private void cbmcalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }
        }

        private void cbmproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }
        }

        private void cbmunidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }
        }
    }
}

