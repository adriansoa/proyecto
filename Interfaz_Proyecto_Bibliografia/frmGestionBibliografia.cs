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

        private void ActualizarDataGrid()
        {
           // if (cmbMateria.s)
          //  {
                dtgBibliografiaDetalle.DataSource = null;
                dtgBibliografiaDetalle.DataSource = Libro.ObtenerLibro();
          //  }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbMateria.SelectedItem != null){

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
    }
}
