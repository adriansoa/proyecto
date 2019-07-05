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
            txtSubTotal.ReadOnly = true;
            facturaventa = new FacturaVenta();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //DetalleFacturaVenta dv = new DetalleFacturaVenta();
            //dv.Libro = (Libro)cmbLibro.SelectedItem;
            //dv.Cantidad = Convert.ToInt32(txtCantidad.Text);
            //facturaventa.Nro_Factura = txtNroFactura.Text;
            //facturaventa.Nro_Timbrado = Convert.ToInt32(txtNroTimbrado.Text);
            //facturaventa.Ruc = txtCI.Text;
            //facturaventa.Razon_Social = txtNombre.Text;
            //facturaventa.Direccion = txtDireccion.Text;
            //facturaventa.Telefono = txtTelefono.Text;
            //if (rdbContado.Checked)
            //{
            //    facturaventa.Cond_Venta = "Contado";
            //}
            //else
            //{
            //    facturaventa.Cond_Venta = "Credito";
            //}
            //facturaventa.Fecha_Emision = dtpFechaEmision.Value;
            //facturaventa.detalle_venta.Add(dv);
            //FacturaVenta.Agregar(facturaventa);
            //MessageBox.Show("La Venta ha sido guardada con éxito");
            //Limpiar();

            //dtpFechaEmision.Value = System.DateTime.Now;
            //cmbLibro.SelectedItem = null;

            DetalleFacturaVenta dfv = new DetalleFacturaVenta();
            dfv.Cantidad = Convert.ToInt32(txtCantidad.Text);
            dfv.Precio = Convert.ToInt32(txtPrecio.Text);
            dfv.SubTotal = Convert.ToInt32(txtSubTotal.Text);
            dfv.Libro = (Libro)cmbLibro.SelectedItem;
            facturaventa.detalle_venta.Add(dfv);
           
            ActualizarDataGrid();

            LimpiarDetalle();

        }

        private void LimpiarDetalle()
        {
            txtCantidad.Text = "";
            cmbLibro.SelectedItem = null;
            txtPrecio.Text = "";
            txtSubTotal.Text = "";
        }


        private void ActualizarDataGrid()
        {

            dtgVentaDetalle.DataSource = null;
            dtgVentaDetalle.DataSource = facturaventa.detalle_venta;
        }

        private void Limpiar()
        {
            txtNroFactura.Text = "";
            txtNroTimbrado.Text = "";
            txtCI.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCantidad.Text = "";
            cmbLibro.SelectedItem = null;
            txtPrecio.Text = "";
            txtSubTotal.Text = "";
            dtgVentaDetalle.DataSource = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string V_VALOR = "";
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Favor Ingrese el Nombre del Cliente", "Advertencia");
                txtNombre.SelectAll();
                txtNombre.Focus();
                V_VALOR = "-1";
                return;
            }

            if (dtpFechaEmision.Value < System.DateTime.Today)
            {
                MessageBox.Show("La fecha de emision no puede ser menor a la fecha actual!", "Advertencia");
                dtpFechaEmision.Focus();
                V_VALOR = "-1";
                return;
            }

            /*try
            {
                int resultado = int.Parse(txtCantidad.Text);
                //dfv.Cantidad = Convert.ToInt32(txtCantidad.Text);
            }
            catch
            {
                MessageBox.Show("Favor ingrese un valor numerico");
                txtCantidad.Text = "";
                txtCantidad.SelectAll();
                txtCantidad.Focus();

            }

            try
            {
                int resultado = int.Parse(txtPrecio.Text);
                //dfv.Precio = Convert.ToInt32(txtPrecio.Text);
            }
            catch
            {
                MessageBox.Show("Favor ingrese un valor numerico");
                txtPrecio.Text = "";
                txtPrecio.SelectAll();
                txtPrecio.Focus();

            }*/

            facturaventa.Fecha_Emision = dtpFechaEmision.Value.Date;
            facturaventa.Nro_Factura = txtNroFactura.Text;
            facturaventa.Nro_Timbrado = txtNroTimbrado.Text;
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
            FacturaVenta.Agregar(facturaventa);
            MessageBox.Show("La venta ha sido guardado con éxito");
            Limpiar();
            dtgVentaDetalle.DataSource = null;
            dtpFechaEmision.Value = System.DateTime.Now;
            cmbLibro.SelectedItem = null;
            facturaventa = new FacturaVenta();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DetalleFacturaVenta dfv = (DetalleFacturaVenta)dtgVentaDetalle.CurrentRow.DataBoundItem;
            facturaventa.detalle_venta.Remove(dfv);
            ActualizarDataGrid();

        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txtCantidad.Text);
            n2 = Convert.ToInt32(txtPrecio.Text);
            r = n1 * n2;
            txtSubTotal.Text = r.ToString();
        }

        /*private void txtCI_Leave(object sender, EventArgs e)
        {
            string V_VALOR = "";
            if (txtCI.Text.Trim() == "")
            {
                MessageBox.Show("Favor Ingrese el numero de identidad del cliente", "Advertencia");
                txtCI.SelectAll();
                txtCI.Focus();
                V_VALOR = "-1";
                return;
            }
        }*/

        private void txtNroFactura_Leave(object sender, EventArgs e)
        {
            string V_VALOR = "";
            if (txtNroFactura.Text.Trim() == "")
            {
                MessageBox.Show("Favor Ingrese el numero de la factura", "Advertencia");
                txtNroFactura.SelectAll();
                txtNroFactura.Focus();
                V_VALOR = "-1";
                return;
            }
        }

        private void txtNroTimbrado_Leave(object sender, EventArgs e)
        {
            string V_VALOR = "";
            if (txtNroTimbrado.Text.Trim() == "")
            {
                MessageBox.Show("Favor Ingrese el numero de timbrado", "Advertencia");
                txtNroTimbrado.SelectAll();
                txtNroTimbrado.Focus();
                V_VALOR = "-1";
                return;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (txtNroFactura.Text.Trim()!="" || txtNroTimbrado.Text.Trim() != "")
            {
               DialogResult resultado = MessageBox.Show("Desea cargar una nueva factura sin antes confirmar la actual?","ATENCION",MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Limpiar();
                }
            } 
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            string V_VALOR = "";
            if (txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Favor Ingrese la direccion del cliente", "Advertencia");
                txtDireccion.SelectAll();
                txtDireccion.Focus();
                V_VALOR = "-1";
                return;
            }
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            frmAlumno al = new frmAlumno();
            al.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente cli = new frmConsultaCliente();
            AddOwnedForm(cli);
            cli.Show();
        }
    }
}
