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
    public partial class frmFacultad : Form
    {
        public frmFacultad()
        {
            InitializeComponent();
        }

        private void frmFacultad_Load(object sender, EventArgs e)
        {
           
        }

        private void ActualizarDataGrib()
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                SqlCommand comando = new SqlCommand("Select * from Facultad", con);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dtgFacultad.DataSource = tabla;

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Facultad fac = new Facultad();
            fac.nombre = txtNombre.Text;
            fac.anho_fundacion = txtAñoInicio.Text;

            Facultad.AgregarFacultad(fac);

            MessageBox.Show("La Facultad ha sido agregada con exito");
            LimpiarFormulario();
            ActualizarDataGrib();
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtAñoInicio.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string query = "DELETE FROM Facultad WHERE Id=@Id";
                SqlCommand comando = new SqlCommand(query, con);
                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("Favor complete el campo CODIGO con el codigo del registro que desea eliminar!");
                }else
                {
                    comando.Parameters.AddWithValue("@Id", txtCodigo.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El registro fue eliminado");
                    ActualizarDataGrib();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Facultad SET Nombre='" + this.txtNombre.Text + "',Anho_Fundacion='" + this.txtAñoInicio.Text + "' WHERE Id=" + Convert.ToInt32(this.txtCodigo.Text + ""), con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizado el registro");
                ActualizarDataGrib();

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ActualizarDataGrib();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                SqlCommand comando = new SqlCommand("Select * from Facultad WHERE Id=@Id", con);

                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("Favor complete el campo CODIGO con el codigo del registro que desea buscar!");
                }
                else
                {
                    comando.Parameters.AddWithValue("@Id", txtCodigo.Text);
                    SqlDataReader registro = comando.ExecuteReader();
                    if (registro.Read())
                    {
                        txtNombre.Text = registro["Nombre"].ToString();
                        txtAñoInicio.Text = registro["Anho_Fundacion"].ToString();
                    }

                }
            }
        }
    }
}
