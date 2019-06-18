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

            Materia.AgregarMateria(mat);
            MessageBox.Show("La materia ha sido agregada con exito");
            LimpiarFormulario();
            ActualizarDataGridMateria();
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
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string query = "DELETE FROM Materia WHERE Codigo=@Id";
                SqlCommand comando = new SqlCommand(query, con);
                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("Favor complete el campo CODIGO con el codigo del registro que desea eliminar!");
                }
                else
                {
                    comando.Parameters.AddWithValue("@Id", txtCodigo.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El registro fue eliminado");
                    ActualizarDataGridMateria();
                }


            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        

        private void dtgMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmMateria_Load(object sender, EventArgs e)
        {
            rdbObligatoria.Checked = true;
        }
    }
}
