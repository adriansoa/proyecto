using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases;

namespace Interfaz_Proyecto_Bibliografia
{
    public partial class frmVentaBibliografias : Form
    {
        FacturaVenta facturaventa;

        public frmVentaBibliografias()
        {
            InitializeComponent();
        }

        private void frmVentaBibliografias_Load(object sender, EventArgs e)
        {
            rdbContado.Checked = true;
            cmbLibro.DataSource = Libro.ObtenerLibro();
            //cmbLibro.SelectedItem = null;

            facturaventa = new FacturaVenta();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DetalleFacturaVenta dfv = new DetalleFacturaVenta();
            dfv.Cantidad = Convert.ToInt32(txtCantidad.Text);
            dfv.Libro = (Libro)cmbLibro.SelectedItem;
            facturaventa.detalle_venta.Add(dfv);

            MessageBox.Show("La venta se agrego con exito");
            Limpiar();
        }

        private void Limpiar()
        {
            txtNroFactura.Text = "";
            txtNroTimbrado.Text = "";
            txtCI.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCantidad.Text = "0";
            cmbLibro.SelectedItem = null;
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
