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
        Alumno alumno;
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            
            cmbTipoDocumento.DataSource = Enum.GetValues(typeof(Persona.TipoDocumento));
            cmbTipoDocumento.SelectedItem = null;
            //ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dtgAlumno.DataSource = null;
            dtgAlumno.DataSource = Alumno.ObtenerAlumnos();
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
            al.Promocion = Convert.ToInt32(txtPromocion.Text);

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Alumno a = (Alumno)dtgAlumno.CurrentRow.DataBoundItem;
            if (a != null)
            {
                Alumno.listadoAlumnos.Remove(a);
            }
            ActualizarDataGrid();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = dtgAlumno.CurrentRow.Index;

            if (index >= 0)
            {
                Alumno.listadoAlumnos[index] = ObtenerAlumnoFormulario();
                ActualizarDataGrid();
            }
        }

        private Alumno ObtenerAlumnoFormulario()
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
            al.Promocion = Convert.ToInt32(txtPromocion.Text);

            return al;
        }

        private void dtgAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Alumno al = (Alumno)dtgAlumno.CurrentRow.DataBoundItem;

            if (al != null)
            {
                al.tipo_documento = (Persona.TipoDocumento)cmbTipoDocumento.SelectedItem;
                al.nro_documento = txtNroDocumento.Text;
                al.nombre = txtNombre.Text;
                al.apellido = txtApellido.Text;
                al.direccion = txtDireccion.Text;
                al.fecha_Nacimiento = dtpFechaNacimiento.Value.Date;
                al.telefono = txtTelefono.Text;
                al.email = txtEmail.Text;
                al.Promocion = Convert.ToInt32(txtPromocion.Text);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
