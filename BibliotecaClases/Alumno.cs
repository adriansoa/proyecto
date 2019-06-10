using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Alumno : Persona
    {
       public int Promocion;
    
        public override string ToString()
        {
            return string.Format ("Nombre: {0} Nro Doc: {1} Telefono: {2}", this.nombre ,this.nro_documento , this.telefono);
        }

        public static List<Alumno> listadoAlumnos = new List<Alumno>();

        public static void AgregarAlumno(Alumno a)
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();

                string sentenciasql = @"INSERT INTO alumno (Nro_Documento,Tipo_Documento,Nombre,Apellido,Fecha_Nacimiento, Direccion, Telefono, Email, Promocion)
                                        VALUES (@Nro_Documento, @Tipo_Documento, @Nombre, @Apellido, @Fecha_Nacimiento, @Direccion, @Telefono, @Email, @Promocion)";
                SqlCommand cmd = new SqlCommand(sentenciasql, con);
                SqlParameter p1 = new SqlParameter("@Nro_Documento", a.nro_documento);
                SqlParameter p2 = new SqlParameter("@Tipo_Documento", a.tipo_documento);
                SqlParameter p3 = new SqlParameter("@Nombre", a.nombre);
                SqlParameter p4 = new SqlParameter("@Apellido", a.apellido);
                SqlParameter p5 = new SqlParameter("@Fecha_Nacimiento", a.fecha_Nacimiento);
                SqlParameter p6 = new SqlParameter("@Direccion", a.direccion);
                SqlParameter p7 = new SqlParameter("@Telefono", a.telefono);
                SqlParameter p8 = new SqlParameter("@Email", a.email);
                SqlParameter p9 = new SqlParameter("@Promocion", a.Promocion);

                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.VarChar;
                p5.SqlDbType = SqlDbType.DateTime;
                p6.SqlDbType = SqlDbType.VarChar;
                p7.SqlDbType = SqlDbType.VarChar;
                p8.SqlDbType = SqlDbType.VarChar;
                p9.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);
                cmd.Parameters.Add(p9);

                int n = cmd.ExecuteNonQuery();
            }

            //listadoAlumnos.Add(a);
        }
        public static void EliminarAlumno(Alumno a)
        {
            listadoAlumnos.Remove(a);
        }
        public static List<Alumno> ObtenerCarnes()
        {
            return listadoAlumnos;
        }


    }
}
