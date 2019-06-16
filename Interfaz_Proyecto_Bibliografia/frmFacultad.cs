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
    public partial class frmFacultad : Form
    {
        public frmFacultad()
        {
            InitializeComponent();
        }

        private void frmFacultad_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Facultad fac = new Facultad();
            fac.nombre = txtNombre.Text;
            fac.anho_fundacion = Convert.ToInt32(txtAñoInicio.Text);

            Facultad.AgregarFacultad(fac);

            MessageBox.Show("La Facultad ha sido agregado con exito");
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtAñoInicio.Text = "";
        }

       
    }
}
