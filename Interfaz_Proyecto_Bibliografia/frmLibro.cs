using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Libro.AgregarLibro(libro);


            MessageBox.Show("El libro ha sido registrado con éxito");
            ActualizarDataGrib();
            Limpiar();
        }

        private void ActualizarDataGrib()
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM Libro", con);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dtgDetalleLibro.DataSource = tabla;

            }
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ActualizarDataGrib();
        }

        private void frmLibro_Load(object sender, EventArgs e)
        {
            cmbMateria.DataSource = null;
            cmbMateria.DataSource = Materia.ObtenerMateria();
            cmbMateria.SelectedItem = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = dtgDetalleLibro.CurrentRow.Index;

            if (index >= 0)
            {
                Libro.listaLibro[index] = ObtenerLibroFormulario();
                ActualizarDataGrib();
            }
        }

        private Libro ObtenerLibroFormulario()
        {
            Libro lib = new Libro();
            libro.codigo = txtCodigo.Text;
            libro.titulo = txtTitulo.Text;
            libro.autor = txtAutor.Text;
            libro.editorial = txtEditorial.Text;
            libro.anho_publicacion = txtAnoPublicacion.Text;
            libro.edicion = txtEdicion.Text;
            libro.materia = (Materia)cmbMateria.SelectedItem;
            libro.Precio = txtPrecio.Text;
            Libro.listaLibro.Add(libro);

            return lib;
        }

        private void dtgDetalleLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Libro lib = (Libro)dtgDetalleLibro.CurrentRow.DataBoundItem;

            if (lib != null)
            {
                txtCodigo.Text = Convert.ToString(lib.codigo);
                txtTitulo.Text = lib.titulo;
                txtAnoPublicacion.Text = lib.anho_publicacion;
                txtAutor.Text = lib.autor;
                txtEdicion.Text = lib.edicion;
                txtEditorial.Text = lib.editorial;
                txtPrecio.Text = lib.Precio;
                cmbMateria.SelectedItem = lib.materia;
                
                
            }
        }
    }
}
