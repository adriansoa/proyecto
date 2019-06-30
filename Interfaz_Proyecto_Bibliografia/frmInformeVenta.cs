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
                //con.Open();
                //SqlCommand comando = new SqlCommand("select v.fecha_emision,v.cond_venta,v.razon_social,vd.cantidad,vd.bibliografia,vd.subtotal from venta as v inner join venta_detalle as vd on v.Id = vd.venta_id", con);
                //SqlDataAdapter adaptador = new SqlDataAdapter();
                //adaptador.SelectCommand = comando;
                //DataTable tabla = new DataTable();
                //adaptador.Fill(tabla);
                //dtgVentaPendiente.DataSource = tabla;

                con.Open();
                SqlCommand comando = new SqlCommand("select v.fecha_emision,v.razon_social,v.cond_venta,vd.cantidad,vd.bibliografia,vd.subtotal from venta as v inner join venta_detalle as vd on v.Id = vd.venta_id", con);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                //dtgVentaPendiente.Rows.Clear();
                foreach (DataRow item in tabla.Rows)
                {
                    int n = dtgVentaPendiente.Rows.Add();
                    dtgVentaPendiente.Rows[n].Cells[0].Value =false;
                    dtgVentaPendiente.Rows[n].Cells[1].Value = item["fecha_emision"].ToString();
                    dtgVentaPendiente.Rows[n].Cells[2].Value = item["cond_venta"].ToString();
                    dtgVentaPendiente.Rows[n].Cells[3].Value = item["razon_social"].ToString();
                    dtgVentaPendiente.Rows[n].Cells[4].Value = item["cantidad"].ToString();
                    dtgVentaPendiente.Rows[n].Cells[5].Value = item["bibliografia"].ToString();
                    dtgVentaPendiente.Rows[n].Cells[6].Value = item["subtotal"].ToString();
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in dtgVentaPendiente.Rows)
            {
                //dtgVentaConfirmada.Rows.Clear();

                if((bool)item.Cells[0].Value==true)
                {
                    int n = dtgVentaConfirmada.Rows.Add();
                    dtgVentaConfirmada.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    dtgVentaConfirmada.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dtgVentaConfirmada.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    dtgVentaConfirmada.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
                    dtgVentaConfirmada.Rows[n].Cells[4].Value = item.Cells[5].Value.ToString();
                    dtgVentaConfirmada.Rows[n].Cells[5].Value = item.Cells[6].Value.ToString();
                }
            }

        }

        private void dtgVentaPendiente_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)dtgVentaPendiente.SelectedRows[0].Cells[0].Value == false)
            {
                dtgVentaPendiente.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dtgVentaPendiente.SelectedRows[0].Cells[0].Value = false;
            }
        }
    }
}
