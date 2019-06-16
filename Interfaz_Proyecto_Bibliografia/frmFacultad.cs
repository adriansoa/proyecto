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
            //ActualizarDataGrib();
        }

        private void ActualizarDataGrib()
        {
            dtgFacultad.DataSource = null;
            dtgFacultad.DataSource = Facultad.listaFacultad;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Facultad facultad = (Facultad)dtgFacultad.CurrentRow.DataBoundItem;
            //if(facultad != null)
            //{
            //    Facultad.listaFacultad.Remove(facultad);
            //}
            //ActualizarDataGrib();

            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string query = "DELETE FROM Facultad WHERE Id=@Id";
                SqlCommand comando = new SqlCommand(query, con);
                comando.Parameters.AddWithValue("@Id", txtCodigo.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("El registro fue eliminado");

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = dtgFacultad.CurrentRow.Index;

            if(index >= 0)
            {
                Facultad.listaFacultad[index] = ObtenerFacultadFormulario();
                ActualizarDataGrib();
            }

        }

        private Facultad ObtenerFacultadFormulario()
        {
            Facultad facultad = new Facultad();
            facultad.nombre = txtNombre.Text;
            facultad.anho_fundacion = Convert.ToInt32(txtAñoInicio.Text);

            return facultad;
        }

        private void dtgFacultad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Facultad facultad = (Facultad)dtgFacultad.CurrentRow.DataBoundItem;

            if(facultad != null)
            {
                facultad.nombre = txtNombre.Text;
                facultad.anho_fundacion = Convert.ToInt32(txtAñoInicio.Text);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //ActualizarDataGrib();
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
    }
}
