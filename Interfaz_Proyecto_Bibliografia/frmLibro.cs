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
        int index;
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
            libro.editorial = txtEditoria.Text;
            libro.anho_publicacion = txtAnoPublicacion.Text;
            libro.edicion = txtEdicion.Text;
            libro.materia = (Materia)cmbMateria.SelectedItem;

            Libro.listaLibro.Add(libro);

            ActualizarDataGrib();
            Limpiar();
        }

        private void ActualizarDataGrib()
        {
            dtgLibroDetalle.DataSource = null;
            dtgLibroDetalle.DataSource = Libro.listaLibro;
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEditoria.Text = "";
            txtAnoPublicacion.Text = "";
            txtEdicion.Text = "";
            cmbMateria.SelectedItem = null;
            txtPrecio.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Libro libro = (Libro)dtgLibroDetalle.CurrentRow.DataBoundItem;
            if(libro != null)
            {
                Libro.listaLibro.Remove(libro);
            }
            ActualizarDataGrib();
        }

        private void frmLibro_Load(object sender, EventArgs e)
        {
            cmbMateria.DataSource = Materia.ObtenerMateria();
            libro = new Libro();
            dtgLibroDetalle.AutoGenerateColumns = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            dtgLibroDetalle[1, index].Value = txtCodigo.Text;
            dtgLibroDetalle[2, index].Value = txtTitulo.Text;
            dtgLibroDetalle[3, index].Value = txtAutor.Text;
            dtgLibroDetalle[4, index].Value = txtEditoria.Text;
            dtgLibroDetalle[5, index].Value = txtAnoPublicacion.Text;
            dtgLibroDetalle[6, index].Value = txtEdicion.Text;
            dtgLibroDetalle[7, index].Value = cmbMateria.SelectedItem;
            dtgLibroDetalle[8, index].Value = txtPrecio.Text;

            Limpiar();
        }

        private void dtgLibroDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgLibroDetalle.CurrentRow.Index;
            txtCodigo.Text = dtgLibroDetalle[1, index].Value.ToString();
            txtTitulo.Text = dtgLibroDetalle[2, index].Value.ToString();
            txtAutor.Text = dtgLibroDetalle[3, index].Value.ToString();
            txtEditoria.Text = dtgLibroDetalle[4, index].Value.ToString();
            txtAnoPublicacion.Text = dtgLibroDetalle[5, index].Value.ToString();
            txtEdicion.Text = dtgLibroDetalle[6, index].Value.ToString();
            cmbMateria.SelectedItem = dtgLibroDetalle[7, index].Value.ToString();
            txtPrecio.Text = dtgLibroDetalle[8, index].Value.ToString();

            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}
