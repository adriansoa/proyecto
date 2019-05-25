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
