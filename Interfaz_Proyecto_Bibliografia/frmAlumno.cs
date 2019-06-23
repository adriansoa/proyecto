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
        
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            
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
            ActualizarDataGrid();
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
            cmbTipoDocumento.Text = "";
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
                string query = "DELETE FROM Alumno WHERE Codigo=@Id";
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
                    txtId.Text = "";
                }


            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgAlumno.Rows.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila de la grilla!!");
            }
            else
            {
                int codigo = Convert.ToInt32(dtgAlumno.CurrentRow.Cells[0].Value);
                using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Alumno SET Nro_Documento ='" + this.txtNroDocumento.Text +
                     "',Tipo_Documento='" + this.cmbTipoDocumento.Text +
                    "',Nombre='" + this.txtNombre.Text + "',Apellido='" + this.txtApellido.Text +
                    "',Fecha_Nacimiento='" + this.dtpFechaNacimiento.Text + "',Direccion='" + this.txtDireccion.Text +
                    "',Telefono='" + this.txtTelefono.Text + "',Email='" + this.txtEmail.Text + "',Promocion='" + this.txtPromocion.Text
                    + "' WHERE Codigo= " + codigo +"", con);
                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado != -1)
                    {
                        MessageBox.Show("Registro actualizado exitosamente!!" + resultado);
                        ActualizarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro!!");
                    }
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dtgAlumno.Rows.Count == 0)
            {
                MessageBox.Show("Favor consulte primero antes de seleccionar!!");
            }
            else
            {
                int codigo = Convert.ToInt32(dtgAlumno.CurrentRow.Cells[0].Value);
                using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Alumno WHERE Codigo ="+ codigo +"", con);
                    SqlDataReader registro = cmd.ExecuteReader();
                    if (registro.Read())
                    {
                        txtId.Text = registro["Codigo"].ToString();
                        txtNroDocumento.Text = registro["Nro_Documento"].ToString();
                        cmbTipoDocumento.SelectedText = registro["Tipo_Documento"].ToString();
                        txtNombre.Text = registro["Nombre"].ToString();
                        txtApellido.Text = registro["Apellido"].ToString();
                        dtpFechaNacimiento.Value = (DateTime)registro["Fecha_Nacimiento"];
                        txtDireccion.Text = registro["Direccion"].ToString();
                        txtTelefono.Text = registro["Telefono"].ToString();
                        txtEmail.Text = registro["Email"].ToString();
                        txtPromocion.Text = registro["Promocion"].ToString();
                    }
                }

            }
        }
    }
}