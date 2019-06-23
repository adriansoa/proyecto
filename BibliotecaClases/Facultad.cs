using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Facultad
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string anho_fundacion { get; set; }

        public static List<Facultad> listaFacultad = new List<Facultad>();

        public static void AgregarFacultad(Facultad f)
        {
           
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();

                string sentenciasql = @"INSERT INTO facultad (Nombre, Anho_Fundacion) VALUES (@Nombre,@Anho_Fundacion)";
                SqlCommand cmd = new SqlCommand(sentenciasql, con);
                SqlParameter p1 = new SqlParameter("@Nombre", f.nombre);
                SqlParameter p2 = new SqlParameter("@Anho_Fundacion", f.anho_fundacion);

                p1.SqlDbType = System.Data.SqlDbType.VarChar;
                p2.SqlDbType = System.Data.SqlDbType.Int;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                int m = cmd.ExecuteNonQuery();

            }
        }

       
        public override string ToString()
        {
            return string.Format("Nombre: {0} Anho Fundacion: {1}", this.nombre,this.anho_fundacion);
        }

    }




}
