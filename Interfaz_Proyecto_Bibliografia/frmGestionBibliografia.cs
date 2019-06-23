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
    public partial class frmGestionBibliografia : Form
    {
        public frmGestionBibliografia()
        {
            InitializeComponent();
        }

        private void frmGestionBibliografia_Load(object sender, EventArgs e)
        {
            cmbMateria.DataSource = Materia.ObtenerMateria();
            cmbMateria.SelectedItem = null;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbMateria.SelectedItem != null){

                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Favor seleccione una materia!!");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmLibro lib = new frmLibro();
            lib.Show();
        }


        private void ActualizarGrilla()
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {

                string Materia = cmbMateria.SelectedItem.ToString();
                con.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM Libro JOIN Materia M ON Libro.MateriaId = M.Codigo WHERE M.Nombre LIKE '%" + Materia + "%'", con);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dtgBibliografiaDetalle.DataSource = tabla;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgBibliografiaDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Favor seleccione por completo una fila!!");
            }
            else
            {
                int codigo = Convert.ToInt32(dtgBibliografiaDetalle.CurrentRow.Cells[0].Value);
                using (SqlConnection con= new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
                {
                    con.Open();
                    string sentenciasql = "DELETE  FROM Libro WHERE Libro.Id=" + codigo +"";
                    SqlCommand cmd = new SqlCommand(sentenciasql, con);
                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado != -1)
                    {
                        MessageBox.Show("Registro eliminado exitosamente!!" + resultado);
                        ActualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro!!");
                    }
                }

            }

        }
    }
}
