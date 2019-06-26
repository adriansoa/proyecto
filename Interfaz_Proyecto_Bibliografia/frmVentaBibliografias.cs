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
            cmbLibro.DataSource = Libro.ObtenerLibros();
            cmbLibro.SelectedItem = null;

            facturaventa = new FacturaVenta();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DetalleFacturaVenta dv = new DetalleFacturaVenta();
            dv.Libro = (Libro)cmbLibro.SelectedItem;
            dv.Cantidad = Convert.ToInt32(txtCantidad.Text);
            facturaventa.Nro_Factura = txtNroFactura.Text;
            facturaventa.Nro_Timbrado = Convert.ToInt32(txtNroTimbrado.Text);
            facturaventa.Ruc = txtCI.Text;
            facturaventa.Razon_Social = txtNombre.Text;
            facturaventa.Direccion = txtDireccion.Text;
            facturaventa.Telefono = txtTelefono.Text;
            if (rdbContado.Checked)
            {
                facturaventa.Cond_Venta = "Contado";
            }
            else
            {
                facturaventa.Cond_Venta = "Credito";
            }
            facturaventa.Fecha_Emision = dtpFechaEmision.Value;
            facturaventa.detalle_venta.Add(dv);
            FacturaVenta.Agregar(facturaventa);
            MessageBox.Show("La Venta ha sido guardada con éxito");
            Limpiar();
            
            dtpFechaEmision.Value = System.DateTime.Now;
            cmbLibro.SelectedItem = null;
            
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
