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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ventaDeBibliografiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentaBibliografias Venta = new frmVentaBibliografias();
            Venta.Show();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno al = new frmAlumno();
            al.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateria mat = new frmMateria();
            mat.Show();
        }
    }
}
