using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class FacturaVenta
    {

        public string Nro_Factura { get; set; }
        public string Nro_Timbrado { get; set; }
        public string Ruc { get; set; }
        public string Razon_Social { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public string Cond_Venta { get; set; }

        public List<DetalleFacturaVenta> detalle_venta = new List<DetalleFacturaVenta>();

        public static List<FacturaVenta> listaVentas = new List<FacturaVenta>();

        public static void Agregar(FacturaVenta fv)
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Venta (NroFactura,NroTimbrado,Fecha_Emision,Ruc,Razon_Social,Direccion,Telefono,Cond_Venta) output INSERTED.Id VALUES (@NroFactura, @NroTimbrado,@Fecha_Emision,@Ruc,@Razon_Social,@Direccion,@Telefono,@Cond_Venta)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter p1 = new SqlParameter("@NroFactura", fv.Nro_Factura);
                SqlParameter p2 = new SqlParameter("@NroTimbrado", fv.Nro_Timbrado);
                SqlParameter p3 = new SqlParameter("@Fecha_Emision", fv.Fecha_Emision);
                SqlParameter p4 = new SqlParameter("@Ruc", fv.Ruc);
                SqlParameter p5 = new SqlParameter("@Razon_Social", fv.Razon_Social);
                SqlParameter p6 = new SqlParameter("@Direccion", fv.Direccion);
                SqlParameter p7 = new SqlParameter("@Telefono", fv.Telefono);
                SqlParameter p8 = new SqlParameter("@Cond_Venta", fv.Cond_Venta);
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.DateTime;
                p4.SqlDbType = SqlDbType.VarChar;
                p5.SqlDbType = SqlDbType.VarChar;
                p6.SqlDbType = SqlDbType.VarChar;
                p7.SqlDbType = SqlDbType.VarChar;
                p8.SqlDbType = SqlDbType.VarChar;
                
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);

                int venta_id = (int)cmd.ExecuteScalar();

                foreach (DetalleFacturaVenta dfv in fv.detalle_venta)
                {
                    string textoCmd2 = @"insert into Venta_Detalle (Venta_id, Cantidad, Bibliografia,Precio,SubTotal) VALUES (@id, @cantidad, @Bibliografia,@Precio,@SubTotal)";
                    SqlCommand cmd2 = new SqlCommand(textoCmd2, con);

                    SqlParameter p9 = new SqlParameter("@Id", venta_id);
                    SqlParameter p10 = new SqlParameter("@Cantidad", dfv.Cantidad);
                    SqlParameter p11 = new SqlParameter("@Bibliografia", dfv.Libro.titulo);
                    SqlParameter p12 = new SqlParameter("@Precio", dfv.Precio);
                    SqlParameter p13 = new SqlParameter("@SubTotal", dfv.SubTotal);
                    p9.SqlDbType = SqlDbType.Int;
                    p10.SqlDbType = SqlDbType.Int;
                    p11.SqlDbType = SqlDbType.VarChar;
                    p12.SqlDbType = SqlDbType.Int;
                    p13.SqlDbType = SqlDbType.Int;
                    cmd2.Parameters.Add(p9);
                    cmd2.Parameters.Add(p10);
                    cmd2.Parameters.Add(p11);
                    cmd2.Parameters.Add(p12);
                    cmd2.Parameters.Add(p13);

                    cmd2.ExecuteNonQuery();
                    
                }
            }
        }

        public static void Eliminar(FacturaVenta fv)
        {
            listaVentas.Remove(fv);
        }

        public static List<FacturaVenta> Obtener()
        {
            return listaVentas;
        }

        public static DataTable ObtenerVentasPendientes()
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select vd.Id,vt.Fecha_Emision,vd.Bibliografia,lb.Titulo from Venta vt inner join Venta_Detalle vd on vd.Venta_Id = vt.Id inner join Libro lb on lb.Id = vd.Bibliografia wwhere vd.estado = 0; ";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());
                return tabla;

            }

        }

        public static void ConfirmarVentas(List<int> listaIds)
        {

            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                foreach (int id in listaIds)
                {
                    string textoCmd = @"UPDATE Venta_Detalle SET estado = 1 where Id = @Id";
                    SqlCommand cmd = new SqlCommand(textoCmd, con);
                    SqlParameter p1 = new SqlParameter("@Id", id);
                    p1.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(p1);
                    cmd.ExecuteNonQuery();
                }

            }
        }

    }
}
