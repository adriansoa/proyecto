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
    public partial class frmAlumno : Form
    {
        //Alumno alumno;
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            //ActualizarDataGrid();
            cmbTipoDocumento.DataSource = Enum.GetValues(typeof(Persona.TipoDocumento));
            cmbTipoDocumento.SelectedItem = null;
        }

        private void ActualizarDataGrid()
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                SqlCommand comando = new SqlCommand("Select * from Alumno", con);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dtgAlumno.DataSource = tabla;

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno al = new Alumno();
            al.nro_documento = txtNroDocumento.Text;
            al.tipo_documento = (Persona.TipoDocumento)cmbTipoDocumento.SelectedItem;
            al.nombre = txtNombre.Text;
            al.apellido = txtApellido.Text;
            al.fecha_Nacimiento = dtpFechaNacimiento.Value.Date;
            al.direccion = txtDireccion.Text;
            al.telefono = txtTelefono.Text;
            al.email = txtEmail.Text;
            al.Promocion = Convert.ToInt32(txtPromocion.Text);

            Alumno.AgregarAlumno(al);

            MessageBox.Show("El alumno ha sido agregado con éxito");
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtId.Text = "";
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
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string query = "DELETE FROM Alumno WHERE Id=@Id";
                SqlCommand comando = new SqlCommand(query, con);
                if (txtId.Text == "")
                {
                    MessageBox.Show("Favor complete el campo Id con el codigo del registro que desea eliminar!");
                }
                else
                {
                    comando.Parameters.AddWithValue("@Id", txtId.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El registro fue eliminado");
                    ActualizarDataGrid();
                }


            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            /* int index = dtgAlumno.CurrentRow.Index;

           if (index >= 0)
           {
               Alumno.listadoAlumnos[index] = ObtenerAlumnoFormulario();
               ActualizarDataGrid();
           }*/

            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Alumno SET Nro_Documento ='" + this.txtNroDocumento.Text +
                 "',Tipo_Documento='" + this.cmbTipoDocumento.Text +
                "',Nombre='" + this.txtNombre.Text + "',Apellido='" + this.txtApellido.Text +
                "',Fecha_Nacimiento='" + this.dtpFechaNacimiento.Text + "',Direccion='" + this.txtDireccion.Text +
                "',Telefono='" + this.txtTelefono.Text + "',Email='" + this.txtEmail.Text + "',Promocion='" + this.txtPromocion.Text
                + "' WHERE Id= " + Convert.ToInt32(this.txtId.Text + ""), con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizado el registro");
                ActualizarDataGrid();

            }
        }


        private Alumno ObtenerAlumnoFormulario()
        {
            Alumno al = new Alumno();
            al.nro_documento = txtNroDocumento.Text;
            al.tipo_documento = (Persona.TipoDocumento)cmbTipoDocumento.SelectedItem;
            al.nombre = txtNombre.Text;
            al.apellido = txtApellido.Text;
            al.fecha_Nacimiento = dtpFechaNacimiento.Value.Date;
            al.direccion = txtDireccion.Text;
            al.telefono = txtTelefono.Text;
            al.email = txtEmail.Text;
            al.Promocion = Convert.ToInt32(txtPromocion.Text);

            return al;
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}