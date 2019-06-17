using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaClases
{

    public enum TipoMateria { Obligatoria, Electiva }

    public class Materia
    {
        public int Id_Materia { get; set; }
        public int codigo { get; set; }
        public string Nombre { get; set; }
        public int cant_creditos { get; set; }
        public TipoMateria tipo_cant_creditosmateria { get; set; }

        public static List<Materia> listaMateria = new List<Materia>();

        public static void AgregarMateria(Materia m)
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();

                string sentenciasql = @"INSERT INTO materia (codigo,Nombre,cant_creditos,cant_creditos,tipo_cant_creditosmateria)
                                        VALUES (@codigo, @Nombre, @cant_creditos, @tipo_cant_creditosmateria)";
                SqlCommand cmd = new SqlCommand(sentenciasql, con);
                SqlParameter p1 = new SqlParameter("@codigo", m.codigo);
                SqlParameter p2 = new SqlParameter("@Nombre", m.Nombre);
                SqlParameter p3 = new SqlParameter("@cant_creditos", m.cant_creditos);
                SqlParameter p4 = new SqlParameter("@Apellido", m.tipo_cant_creditosmateria);
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                int n = cmd.ExecuteNonQuery();
            }

            //listadoAlumnos.Add(a);
        }


        public static bool EliminarMateria(Materia m)
        {
            {
                //listaProveedores.Remove(p);

                try
                {
                    //string datosConexion = "Data Source = localhost; Initial Catalog = SegundoParcialCSharp; User ID=sa; Password = 12345";

                    using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
                    {
                        //Paso 2 - Abrir la conexión
                        con.Open();

                        string textoCmd = @"Delete from Materia 
                                        where ID_Materia = @Id_Materia";

                        SqlCommand cmd = new SqlCommand(textoCmd, con);

                        SqlParameter p5 = new SqlParameter("@Id_Materia", m.Id_Materia);
                        p5.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(p5);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            return true;
                        }
                        catch (SqlException sqle)
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex2)
                {
                    //Error
                    return false;
                }
            }
        }

        public static void ModificarrMateria(Materia m)
        {
            //listaProveedores[index] = p;
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string sentenciasql = @"UPDATE Materia SET codigo = @codigo, @Nombre=Nombre, @cant_creditos=cant_creditos ,@tipo_cant_creditosmateria = @tipo_cant_creditosmateria where Id = @Id";
                SqlCommand cmd = new SqlCommand(sentenciasql, con);
                SqlParameter p1 = new SqlParameter("@codigo", m.codigo);
                SqlParameter p2 = new SqlParameter("@Nombre", m.Nombre);
                SqlParameter p3 = new SqlParameter("@cant_creditos", m.cant_creditos);
                SqlParameter p4 = new SqlParameter("@Apellido", m.tipo_cant_creditosmateria);
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                int n = cmd.ExecuteNonQuery();
            }
        }

        public static List<Materia> ObtenerMateria()
        {
            //return listaProveedores;
            Materia m;
            listaMateria.Clear();

            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Proveedor";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    m = new Materia();
                    m.Id_Materia = elLectorDeDatos.GetInt32(0);
                    m.codigo = elLectorDeDatos.GetInt32(1);
                    m.Nombre = elLectorDeDatos.GetString(2);
                    m.cant_creditos = elLectorDeDatos.GetInt32(3);
                    m.tipo_cant_creditosmateria = (TipoMateria)elLectorDeDatos.GetInt32(3);

                    listaMateria.Add(m);
                }
            }
            return listaMateria;
        }



        public override string ToString()
        {
            return this.Nombre;
        }

    }
}
