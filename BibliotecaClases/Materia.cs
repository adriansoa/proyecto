using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaClases
{

    public enum TipoMateria { Obligatoria, Electiva}

    public class Materia
    {
        public int codigo { get; set; }
        public string Nombre { get; set; }
        public int cant_creditos { get; set; }
        public TipoMateria tipo_materia { get; set; }
        public int Precio { get; set; }

        public static List<Materia> listaMateria = new List<Materia>();
        public static List<int> listaMateriaID = new List<int>();

        public static void AgregarMateria(Materia m)
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();

                string sentenciasql = @"INSERT INTO Materia (Nombre,Cantidad_Creditos, Tipo_Materia, Precio)
                                        VALUES (@Nombre,@Cantidad_Creditos, @Tipo_Materia, @Precio)";
                SqlCommand cmd = new SqlCommand(sentenciasql, con);
                SqlParameter p1 = new SqlParameter("@Nombre", m.Nombre);
                SqlParameter p2 = new SqlParameter("@Cantidad_Creditos", m.cant_creditos);
                SqlParameter p3 = new SqlParameter("@Tipo_Materia", m.tipo_materia);
                SqlParameter p4 = new SqlParameter("@Precio", m.Precio);

                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.Int;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.Int;
                    ;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);

                int n = cmd.ExecuteNonQuery();
            }

            
        }

        public static List<int> ObtenerMateriaId()
        {
            Materia m;
            listaMateriaID.Clear();

            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string sentenciaSQL = "SELECT Codigo FROM Materia";
                SqlCommand cmd = new SqlCommand(sentenciaSQL, con);
                SqlDataReader elLectordeDatos = cmd.ExecuteReader();

                while (elLectordeDatos.Read())
                {
                    Materia materia = new Materia();
                   int codigo = materia.codigo = elLectordeDatos.GetInt32(0);
                    listaMateriaID.Add(codigo);
                }
            }

           return listaMateriaID;
        }

        public static List<Materia> ObtenerMateria()
        {
            //return listaProveedores;
            Materia materia;
            listaMateria.Clear();

            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "SELECT Nombre FROM Materia";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    materia = new Materia();
                    materia.Nombre = elLectorDeDatos.GetString(0);
                    listaMateria.Add(materia);
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
