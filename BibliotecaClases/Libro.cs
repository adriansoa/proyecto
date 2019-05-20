using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
   public class Libro
    {
        public string codigo { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string editorial { get; set; }
        public string anho_publicacion { get; set; }
        public string edicion { get; set; }
        public Materia materia { get; set; }

        public static List<Libro> listaLibro = new List<Libro>();

        public static void AgregarLibro(Libro l)
        {
            listaLibro.Add(l);
        }

        public static void EliminarLibro(Libro l)
        {
            listaLibro.Remove(l);
        }

        public static List<Libro> ObtenerLibro()
        {
            return listaLibro;
        }

        public override string ToString()
        {
            return this.autor;
        }
    }
}
