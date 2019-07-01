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
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rdbNroDocumento.Checked)
            {
                if (txtValor.Text.Trim() == "")
                {
                    MessageBox.Show("Favor ingrese el numero de documento!!", "ATENCION");
                }
                else
                {
                    int NroDocumento = Convert.ToInt32(txtValor.Text);
                    using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
                    {
                        con.Open();
                        SqlCommand comando = new SqlCommand("SELECT * from Alumno WHERE Nro_Documento=" + NroDocumento + "", con);
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dtgDetalleClientes.DataSource = tabla;

                    }
                }
                
            } else if (rdbNombre.Checked)
            {
                if (txtValor.Text.Trim() == "")
                {
                    MessageBox.Show("Favor ingrese el nombre del cliente!!", "ATENCION");
                }
                else
                {
                    string nombre = txtValor.Text;
                    using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
                    {
                        con.Open();
                        SqlCommand comando = new SqlCommand("SELECT * from Alumno WHERE Nombre LIKE '%" + nombre + "%'", con);
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dtgDetalleClientes.DataSource = tabla;

                    }
                }
            }
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            rdbNroDocumento.Checked= true;
        }

        private void dtgDetalleClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmVentaBibliografias venta  =(frmVentaBibliografias)Owner;
            venta.txtCI.Text = dtgDetalleClientes.CurrentRow.Cells[1].Value.ToString();
            venta.txtNombre.Text = dtgDetalleClientes.CurrentRow.Cells[3].Value.ToString() +" "+ dtgDetalleClientes.CurrentRow.Cells[4].Value.ToString(); ;
            venta.txtDireccion.Text = dtgDetalleClientes.CurrentRow.Cells[6].Value.ToString();
            venta.txtTelefono.Text = dtgDetalleClientes.CurrentRow.Cells[7].Value.ToString();
            this.Close();
        }
    }
}
