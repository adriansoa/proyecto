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
using BibliotecaClases;
namespace Interfaz_Proyecto_Bibliografia
{
    public partial class frmMateria : Form
    {
        public frmMateria()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Materia mat = new Materia();
            mat.codigo = Convert.ToInt32(txtCodigo.Text);
            mat.Nombre = txtNombre.Text;
            mat.cant_creditos = Convert.ToInt32(txtCantidadCreditos.Text);
            if (rdbObligatoria.Checked)
            {
                mat.tipo_materia = TipoMateria.Obligatoria;

            } else if (rdbElectiva.Checked)
            {
                mat.tipo_materia = TipoMateria.Electiva;
            }

            Materia.AgregarMateria(mat);
            MessageBox.Show("La materia ha sido agregada con exito");
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCantidadCreditos.Text = "";
            rdbObligatoria.Checked = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ActualizarDataGridMateria();
        }

        private void ActualizarDataGridMateria()
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM Materia", con);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dtgMaterias.DataSource = tabla;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Materia mat = (Materia)dtgMaterias.CurrentRow.DataBoundItem;
            if (mat != null)
            {
                Materia.listaMateria.Remove(mat);
            }
            ActualizarDataGridMateria();
            LimpiarFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = dtgMaterias.CurrentRow.Index;

            if (index >= 0)
            {
                Materia.listaMateria[index] = ObtenerMateriaFormulario();
                ActualizarDataGridMateria();
            }
        }

        private Materia ObtenerMateriaFormulario()
        {
            Materia mat = new Materia();
            mat.codigo = Convert.ToInt32(txtCodigo.Text);
            mat.Nombre = txtNombre.Text;
            mat.cant_creditos = Convert.ToInt32(txtCantidadCreditos.Text);
            if (rdbObligatoria.Checked)
            {
                mat.tipo_materia = TipoMateria.Obligatoria;

            }
            else if (rdbElectiva.Checked)
            {
                mat.tipo_materia = TipoMateria.Electiva;
            }

            return mat;
        }

        private void dtgMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Materia mat = (Materia)dtgMaterias.CurrentRow.DataBoundItem;

            if (mat != null)
            {
                txtCodigo.Text = Convert.ToString(mat.codigo);
                txtNombre.Text = mat.Nombre;
                txtCantidadCreditos.Text = Convert.ToString(mat.cant_creditos);
                if (mat.tipo_materia == TipoMateria.Obligatoria)
                {
                    rdbObligatoria.Checked = true;
                }else if (mat.tipo_materia == TipoMateria.Electiva)
                {
                    rdbElectiva.Checked = true;
                }
            }
        }

        private void frmMateria_Load(object sender, EventArgs e)
        {
            rdbObligatoria.Checked = true;
        }
    }
}
