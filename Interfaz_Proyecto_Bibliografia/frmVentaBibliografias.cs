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
        public frmVentaBibliografias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*DetalleFacturaVenta df = new DetalleFacturaVenta();
            df.CodigoLibro = 
            */
        }

        

        private void frmVentaBibliografias_Load(object sender, EventArgs e)
        {
            rdbContado.Checked = true;
            cmbLibro.DataSource = Libro.ObtenerLibro();
            cmbLibro.SelectedItem = null;
        }
    }
}
