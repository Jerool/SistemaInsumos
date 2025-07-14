using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    public partial class FRMProducto : Form
    {
        CLSGestionararchivos mostrarinsumos = new CLSGestionararchivos();
        public List<CLSInsumos> listainsumo = new List<CLSInsumos>();
        private List<CLSInsumoproducto> insumosParaProducto = new List<CLSInsumoproducto>();
        public List<CLSProducto> listaproducto = new List<CLSProducto>();
        public FRMProducto()
        {
            InitializeComponent();
            listainsumo = mostrarinsumos.cargarinsumos();
            cmbinsumo.DataSource = listainsumo;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CLSInsumos insumoSeleccionado = (CLSInsumos)cmbinsumo.SelectedItem;
                double CantidadInsumoIngresada = double.Parse(txtcantidadinsumo.Text); // si escribís mal, lanza excepción
                string unidadIngresada = cbmunidad.Text;
                double CantidadProductoIngresado = double.Parse(txtCantidadProducto.Text);

                double cantidadConvertida = CLSConvertidor.ConvertirAUnidadBase(CantidadInsumoIngresada, unidadIngresada, CantidadProductoIngresado);

                double CantidadUsada = (from i in insumosParaProducto
                                        where i.Insumo.Nombre == insumoSeleccionado.Nombre
                                        select i.CantidadUsada).Sum();

                if (CantidadUsada + cantidadConvertida > insumoSeleccionado.Cantidad)
                {
                    MessageBox.Show($"No hay suficiente cantidad disponible del insumo: {insumoSeleccionado.Nombre}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                listBox1.Items.Add($"{insumoSeleccionado.Nombre} - {cantidadConvertida} {insumoSeleccionado.Unidad}");
                CLSInsumoproducto ip = new CLSInsumoproducto(insumoSeleccionado, cantidadConvertida);
                insumosParaProducto.Add(ip);
                txtcantidadinsumo.Text = "";
                cbmunidad.SelectedIndex = -1;
                cmbinsumo.SelectedIndex = -1; 
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
           
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtnombre.Text) || string.IsNullOrWhiteSpace(txtRubro.Text) || string.IsNullOrWhiteSpace(numericUpDown1.Value.ToString()))
                {
                    MessageBox.Show("Debe ingresar un nombre,rubro y precio para el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (numericUpDown1.Value == 0)
                {
                    MessageBox.Show("Debe ingresar un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (insumosParaProducto.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un insumo para el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (var ip in insumosParaProducto)
                {
                    ip.Insumo.Cantidad -= ip.CantidadUsada;
                }
                using (FileStream fs = new FileStream("Insumos.txt", FileMode.Create, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("NOMBRE;UNIDAD;CANTIDAD;CALIDAD;PROPORCION;PROVEEDORES;RESPONSABLE");
                    foreach (var insumo in listainsumo)
                    {
                        sw.WriteLine(insumo.ArchivoString());
                    }
                }
                CLSProducto nuevoProducto = new CLSProducto(txtnombre.Text, txtRubro.Text, (int)numericUpDown1.Value, new List<CLSInsumoproducto>(insumosParaProducto), Convert.ToInt16(txtCantidadProducto.Text));
                listaproducto.Add(nuevoProducto);
                using (FileStream fs = new FileStream("Productos.txt", FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(nuevoProducto.ArchivoProductos());
                }
                MessageBox.Show("Producto registrado con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarcontroles();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void actualizarcontroles()
        {
            txtnombre.Text = string.Empty;
            txtcantidadinsumo.Text = string.Empty;
            txtRubro.Text = string.Empty;
            numericUpDown1.Value = 0;
            listBox1.Items.Clear();
            cmbinsumo.SelectedIndex = -1;
            cbmunidad.SelectedIndex = -1;
        }
        private void txtcantidadinsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }
        }
        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }
        }

        private void cmbinsumo_KeyPress(object sender, KeyPressEventArgs e)
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

