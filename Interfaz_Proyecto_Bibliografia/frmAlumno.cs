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
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            cmbTipoDocumento.DataSource = Enum.GetValues(typeof(Persona.TipoDocumento));
            cmbTipoDocumento.SelectedItem = null;
        }



        private void ActualizarDataGrid()
        {
            dtgAlumno.DataSource = null;
            dtgAlumno.DataSource = Alumno.listadoAlumnos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno al = new Alumno();
            al.tipo_documento = (Persona.TipoDocumento)cmbTipoDocumento.SelectedItem;
            al.nro_documento = txtNroDocumento.Text;
            al.nombre = txtNombre.Text;
            al.apellido = txtApellido.Text;
            al.direccion = txtDireccion.Text;
            al.fecha_Nacimiento = dtpFechaNacimiento.Value.Date;
            al.telefono = txtTelefono.Text;
            al.email = txtEmail.Text;
            al.Promocion = txtPromocion.Text;

            Alumno.AgregarAlumno(al);
    
            MessageBox.Show("El alumno ha sido agregado con éxito");
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtNroDocumento.Text = "";
            txtPromocion.Text = "";
            txtTelefono.Text = "";
            cmbTipoDocumento.SelectedItem = null;
            dtpFechaNacimiento.Value = System.DateTime.Now;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }
    }
}
