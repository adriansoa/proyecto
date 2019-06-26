using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
   public class Libro
    {
        public int codigo { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string editorial { get; set; }
        public int anho_publicacion { get; set; }
        public string edicion { get; set; }
        public int materiaId { get; set; }
        public string Precio { get; set; }

        public static List<Libro> listaLibro = new List<Libro>();

        public static void AgregarLibro(Libro l)
        {
            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();

                string sentenciasql = @"INSERT INTO Libro (Titulo, Autor, Editorial,Anho_Publicacion,Edicion,MateriaId,Precio)
                                        VALUES (@Titulo, @Autor, @Editorial,@Anho_Publicacion,@Edicion,@MateriaId,@Precio)";
                SqlCommand cmd = new SqlCommand(sentenciasql, con);
                SqlParameter p1 = new SqlParameter("@Titulo", l.titulo);
                SqlParameter p2 = new SqlParameter("@Autor", l.autor);
                SqlParameter p3 = new SqlParameter("@Editorial", l.editorial);
                SqlParameter p4 = new SqlParameter("@Anho_Publicacion", l.anho_publicacion);
                SqlParameter p5 = new SqlParameter("@Edicion", l.edicion);
                SqlParameter p6 = new SqlParameter("@MateriaId", l.materiaId);
                SqlParameter p7 = new SqlParameter("@Precio", l.Precio);
             
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.VarChar;
                p5.SqlDbType = SqlDbType.VarChar;
                p6.SqlDbType = SqlDbType.Int;
                p7.SqlDbType = SqlDbType.VarChar;
       
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
              
                int n = cmd.ExecuteNonQuery();
            }


        }

        public static List<Libro> ObtenerLibros()
        {
            Libro libro;
            listaLibro.Clear();

            using (SqlConnection con = new SqlConnection(ConexionSqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select Titulo from Libro";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    libro = new Libro();
                    libro.titulo = elLectorDeDatos.GetString(0);
                    
                    //Revisar la clase Materia,  funcion ObtenerMateria el codigo se repite 2 veces by Adrian

                    listaLibro.Add(libro);
                }
            }
            return listaLibro;
        }

        public override string ToString()
        {
            return this.titulo;
        }
    }
}
