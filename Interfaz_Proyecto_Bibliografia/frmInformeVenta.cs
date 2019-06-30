using BibliotecaClases;
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

namespace Interfaz_Proyecto_Bibliografia
{
    public partial class frmInformeVenta : Form
    {
        public frmInformeVenta()
        {
            InitializeComponent();
        }

        private void frmInformeVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ActualizarDataGrib();
        }

        private void ActualizarDataGrib()
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                SqlCommand comando = new SqlCommand("select v.fecha_emision,v.cond_venta,v.razon_social,vd.cantidad,vd.bibliografia,vd.subtotal from venta as v inner join venta_detalle as vd on v.Id = vd.venta_id", con);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dtgVentaPendiente.DataSource = tabla;

            }
        }
    }
}
