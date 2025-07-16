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
    public partial class FRMVerinsumos : Form
    {
        CLSGestionararchivos mostrarinsumos = new CLSGestionararchivos();
        List<CLSInsumos> listainsumos = new List<CLSInsumos>();
        CLSGestionararchivos mostrarproveedores = new CLSGestionararchivos();
        List<CLSProveedor> listaproveedores = new List<CLSProveedor>();

        public FRMVerinsumos()
        {
            InitializeComponent();
            listainsumos = mostrarinsumos.cargarinsumos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listainsumos;
            dataGridView1.ReadOnly = true;
            listaproveedores = mostrarproveedores.cargarproveedores();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listaproveedores;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<CLSInsumos> listainsumos = new List<CLSInsumos>();
            CLSGestionararchivos Insumos = new CLSGestionararchivos();
            listainsumos = Insumos.cargarinsumos();
            string nombre = (string)dataGridView2.SelectedRows[0].Cells[0].Value;
            double cuil = (double)dataGridView2.SelectedRows[0].Cells[1].Value;
            string direccion = (string)dataGridView2.SelectedRows[0].Cells[2].Value;
            string Telefono = (string)dataGridView2.SelectedRows[0].Cells[3].Value;
            string Contrasena = (string)dataGridView2.SelectedRows[0].Cells[4].Value;
            CLSProveedor proveedor = new CLSProveedor(nombre,cuil,direccion,Telefono,Contrasena);
            var InsumosFiltrados = proveedor.MostrarInsumo(listainsumos,cuil,nombre);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = InsumosFiltrados;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<CLSProveedor> listaproveedores = new List<CLSProveedor>();
            CLSGestionararchivos Proveedores = new CLSGestionararchivos();
            listaproveedores = Proveedores.cargarproveedores();
            var fila = dataGridView1.SelectedRows[0];
            string nombre = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
            double cantidad = (double)dataGridView1.SelectedRows[0].Cells[1].Value;
            string unidad = (string)dataGridView1.SelectedRows[0].Cells[2].Value;
            string calidad = (string)dataGridView1.SelectedRows[0].Cells[3].Value;
            string proporcion = (string)dataGridView1.SelectedRows[0].Cells[4].Value;
            string proveedor = (string)dataGridView1.SelectedRows[0].Cells[5].Value;
            string responsable = (string)dataGridView1.SelectedRows[0].Cells[6].Value;
            CLSInsumos insumo = new CLSInsumos(nombre,cantidad,unidad,calidad,proporcion,proveedor,responsable);
            var ProveedoresFiltrados = insumo.FiltrarProveedor(listaproveedores,proveedor);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = ProveedoresFiltrados;
        }
    }
}
