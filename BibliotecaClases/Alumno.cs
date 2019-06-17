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
            return string.Format("Nombre: {0} Nro Doc: {1} Telefono: {2}", this.nombre, this.nro_documento, this.telefono);
        }

        public static List<Alumno> listadoAlumnos = new List<Alumno>();

        public static void AgregarAlumno(Alumno a)
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();

                string sentenciasql = @"INSERT INTO Alumno (Nro_Documento,Tipo_Documento,Nombre,Apellido,Fecha_Nacimiento, Direccion, Telefono, Email, Promocion)
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

        public static void ModificarAlumno(int index, Alumno alumno)
        {
            //listaAlumnos.Remove(alumno);
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "UPDATE Alumno SET Nro_Documento =@Nro_Documento, Tipo_Documento = @Tipo_Documento, Nombre = @Nombre, Apellido = @Apellido, Fecha_Nacimiento = @Fecha_Nacimiento, Direccion = @Direccion, Telefono= @Telefono, Email = @Email,  Promocion = @Promocion WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = alumno.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();

            }
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean Id = false)
        {
            SqlParameter p1 = new SqlParameter("@Nro_Documento", this.nro_documento);
            SqlParameter p2 = new SqlParameter("@Tipo_Documento", this.tipo_documento);
            SqlParameter p3 = new SqlParameter("@Nombre", this.nombre);
            SqlParameter p4 = new SqlParameter("@Apellido", this.apellido);
            SqlParameter p5 = new SqlParameter("@Fecha_Nacimiento", this.fecha_Nacimiento);
            SqlParameter p6 = new SqlParameter("@Direccion", this.direccion);
            SqlParameter p7 = new SqlParameter("@Telefono", this.telefono);
            SqlParameter p8 = new SqlParameter("@Email", this.email);
            SqlParameter p9 = new SqlParameter("@Promocion", this.Promocion);

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

            if (Id == true) cmd = ObtenerParametroId(cmd);
            return cmd;
        }

        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            Alumno a = new Alumno();

            SqlParameter p10 = new SqlParameter("@Id", a.Id);
            p10.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p10);
            return cmd;
        }


        
        public static List<Alumno> ObtenerAlumnos()
        {

            Alumno alumno;
            listadoAlumnos.Clear();

            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Alumno";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    alumno = new Alumno();
                    alumno.Id = elLectorDeDatos.GetInt32(0);
                    alumno.nro_documento = elLectorDeDatos.GetString(1);
                    alumno.tipo_documento = (TipoDocumento)elLectorDeDatos.GetInt32(2);
                    alumno.nombre = elLectorDeDatos.GetString(3);
                    alumno.apellido = elLectorDeDatos.GetString(4);
                    alumno.fecha_Nacimiento = elLectorDeDatos.GetDateTime(5);
                    alumno.direccion = elLectorDeDatos.GetString(6);
                    alumno.telefono = elLectorDeDatos.GetString(7);
                    alumno.email = elLectorDeDatos.GetString(8);
                    alumno.Promocion = elLectorDeDatos.GetInt32(9);

                    listadoAlumnos.Add(alumno);
                }
            }

            return listadoAlumnos;
        }
    }
}