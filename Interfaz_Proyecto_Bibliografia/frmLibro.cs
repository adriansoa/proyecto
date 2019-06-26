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
            
            libro.titulo = txtTitulo.Text;
            libro.autor = txtAutor.Text;
            libro.editorial = txtEditorial.Text;
            libro.anho_publicacion = Convert.ToInt32(txtAnoPublicacion.Text);
            libro.edicion = txtEdicion.Text;
            libro.materiaId =Convert.ToInt32(cmbMateriaID.SelectedItem);
            libro.Precio = txtPrecio.Text;
            Libro.AgregarLibro(libro);


            MessageBox.Show("El libro ha sido registrado con éxito");
            ActualizarDataGrib();
            LimpiarFormulario();
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

        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEditorial.Text = "";
            txtAnoPublicacion.Text = "";
            txtEdicion.Text = "";
            cmbMateriaID.SelectedItem = null;
            txtPrecio.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgDetalleLibro.Rows.Count == 0)
            {
                MessageBox.Show("Favor seleccione por completo una fila!!");
            }
            else
            {
                int codigo = Convert.ToInt32(dtgDetalleLibro.CurrentRow.Cells[0].Value);
                using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
                {
                    con.Open();
                    string sentenciasql = "DELETE  FROM Libro WHERE Libro.Id=" + codigo + "";
                    SqlCommand cmd = new SqlCommand(sentenciasql, con);
                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado != -1)
                    {
                        MessageBox.Show("Registro eliminado exitosamente!!" + resultado);
                        ActualizarDataGrib();
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro!!");
                    }
                }

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ActualizarDataGrib();
        }

        private void frmLibro_Load(object sender, EventArgs e)
        {
            cmbMateriaID.DataSource = null;
            cmbMateriaID.DataSource = Materia.ObtenerMateriaId();
            cmbMateriaID.SelectedItem = null;
            txtCodigo.Enabled = false;
        }

        private void ObtenerNombreMateria()
        {
            int materiaID = Convert.ToInt32(cmbMateriaID.SelectedItem);
            if (materiaID >= 0)
            {
                using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
                {
                    con.Open();
                    string sentenciaSQL = "SELECT * FROM Materia WHERE Codigo =" +materiaID + "";
                    SqlCommand cmd = new SqlCommand(sentenciaSQL, con);
                    SqlDataReader elLectordeDatos = cmd.ExecuteReader();    
                    while (elLectordeDatos.Read())
                    {
                        Materia materia = new Materia();
                        string nombre = materia.Nombre = elLectordeDatos.GetString(1);
                        txtMateria.Text = nombre;                        
                    }
                }
            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgDetalleLibro.Rows.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila de la grilla!!");
            }
            else
            {
                int codigo = Convert.ToInt32(dtgDetalleLibro.CurrentRow.Cells[0].Value);
                using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Libro SET Titulo ='" + this.txtTitulo.Text +
                     "',Autor='" + this.txtAutor.Text +
                    "',Editorial='" + this.txtEditorial.Text + "',Anho_Publicacion='" + this.txtAnoPublicacion.Text
                    +"',Edicion='" + this.txtEdicion.Text + "',MateriaId='" + this.cmbMateriaID.SelectedItem +
                    "',Precio='" + this.txtPrecio.Text + "' WHERE Id= " + codigo + "", con);
                    int resultado = cmd.ExecuteNonQuery();
               
                    if (resultado != -1)
                    {
                        MessageBox.Show("Registro actualizado exitosamente!!" + resultado);
                        ActualizarDataGrib();
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro!!");
                    }
                }

            }

        }

        private Libro ObtenerLibroFormulario()
        {
            Libro lib = new Libro();
            libro.codigo = Convert.ToInt32(txtCodigo.Text);
            libro.titulo = txtTitulo.Text;
            libro.autor = txtAutor.Text;
            libro.editorial = txtEditorial.Text;
            libro.anho_publicacion = Convert.ToInt32(txtAnoPublicacion.Text);
            libro.edicion = txtEdicion.Text;
            libro.materiaId = Convert.ToInt32(cmbMateriaID.SelectedItem);
            libro.Precio = txtPrecio.Text;
            Libro.listaLibro.Add(libro);

            return lib;
        }

        private void dtgDetalleLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = Convert.ToInt32(dtgDetalleLibro.CurrentRow.Cells[0].Value);

        if (codigo > 0)
            {
                using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Libro WHERE Id =" + codigo + "", con);
                    SqlDataReader registro = cmd.ExecuteReader();
                    if (registro.Read())
                    {
                        txtCodigo.Text = registro["Id"].ToString();
                        txtTitulo.Text = registro["Titulo"].ToString();
                        txtAutor.Text = registro["Autor"].ToString();
                        txtEditorial.Text = registro["Editorial"].ToString();
                        txtAnoPublicacion.Text = registro["Anho_Publicacion"].ToString();
                        txtEdicion.Text = registro["Edicion"].ToString();
                        cmbMateriaID.SelectedText = registro["MateriaId"].ToString();
                        ObtenerNombreMateria();
                        txtPrecio.Text = registro["Precio"].ToString();
                    }
                }
            }
            
        }

        private void cmbMateriaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMateria.Text = "";
            ObtenerNombreMateria();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dtgDetalleLibro.Rows.Count == 0)
            {
                MessageBox.Show("Favor consulte primero antes de seleccionar!!");
            }
            else
            {
                int codigo = Convert.ToInt32(dtgDetalleLibro.CurrentRow.Cells[0].Value);
                using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Libro WHERE Id =" + codigo + "", con);
                    SqlDataReader registro = cmd.ExecuteReader();
                    if (registro.Read())
                    {
                        txtCodigo.Text = registro["Id"].ToString();
                        txtTitulo.Text = registro["Titulo"].ToString();
                        txtAutor.Text = registro["Autor"].ToString();
                        txtEditorial.Text = registro["Editorial"].ToString();
                        txtAnoPublicacion.Text = registro["Anho_Publicacion"].ToString();
                        txtEdicion.Text = registro["Edicion"].ToString();
                        cmbMateriaID.SelectedText = registro["MateriaId"].ToString();
                        ObtenerNombreMateria();
                        txtPrecio.Text = registro["Precio"].ToString();
                        
                    }
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
