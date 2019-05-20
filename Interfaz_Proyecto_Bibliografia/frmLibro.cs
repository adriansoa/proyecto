using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Proyecto_Bibliografia
{
    public partial class frmLibro : Form
    {
        Libro libro;
        public frmLibro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            libro.codigo = txtCodigo.Text;
            libro.titulo = txtTitulo.Text;
            libro.autor = txtAutor.Text;
            libro.editorial = txtEditorial.Text;
            libro.anho_publicacion = txtAnoPublicacion.Text;
            libro.edicion = txtEdicion.Text;
            libro.materia = (Materia)cmbMateria.SelectedItem;
            libro.Precio = txtPrecio.Text;
            Libro.listaLibro.Add(libro);

            ActualizarDataGrib();
            Limpiar();
        }

        private void ActualizarDataGrib()
        {
            dtgDetalleLibro.DataSource = null;
            dtgDetalleLibro.DataSource = Libro.listaLibro;
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEditorial.Text = "";
            txtAnoPublicacion.Text = "";
            txtEdicion.Text = "";
            cmbMateria.SelectedItem = null;
            txtPrecio.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Libro libro = (Libro)dtgDetalleLibro.CurrentRow.DataBoundItem;
            if(libro != null)
            {
                Libro.listaLibro.Remove(libro);
            }
            ActualizarDataGrib();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
