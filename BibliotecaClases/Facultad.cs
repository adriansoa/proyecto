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
            //listaFacultad.Add(f);
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

        public static void ModificarFacultad(int index,Facultad facultad)
        {
            using(SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "UPDATE facultad SET Nombre=@Nombre,Anho_Fundacion=@Anho_Fundacion where Id = @Id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = facultad.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean Id = false)
        {
            SqlParameter p1 = new SqlParameter("@Nombre", this.nombre);
            SqlParameter p2 = new SqlParameter("@Anho_Fundacion", this.anho_fundacion);

            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            if (Id == true) cmd = ObtenerParametrosId(cmd);
            return cmd;
        }

        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {
            Facultad fac = new Facultad();
            SqlParameter p3 = new SqlParameter("@Id", fac.codigo);
            p3.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p3);
            return cmd;
        }


        public static void EliminarFacultad(Facultad facultad)
        {
            //listaFacultad.Remove(f);

            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"DELETE FROM Facultad WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = facultad.ObtenerParametrosId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Facultad> ObtenerFacultad()
        {
            Facultad facultad;
            listaFacultad.Clear();

            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Facultad";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    facultad = new Facultad();
                    facultad.codigo = elLectorDeDatos.GetInt32(0);
                    facultad.nombre = elLectorDeDatos.GetString(1);
                    facultad.anho_fundacion = elLectorDeDatos.GetString(2);

                    listaFacultad.Add(facultad);
                }
            }

            return listaFacultad;
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0} Anho Fundacion: {1}", this.nombre,this.anho_fundacion);
        }

    }




}
