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

        private void tsmLibro_Click(object sender, EventArgs e)
        {
            frmLibro libro = new frmLibro();
            libro.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void gestionDeBibliografiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionBibliografia gt = new frmGestionBibliografia();
            gt.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateria mat = new frmMateria();
            mat.Show();
        }

        private void facultadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacultad facu = new frmFacultad();
            facu.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe ad = new frmAcercaDe();
            ad.Show();
        }

        private void tsmInforme_Click(object sender, EventArgs e)
        {
            frmInformeVenta fiv = new frmInformeVenta();
            fiv.Show();
        }
    }
}
