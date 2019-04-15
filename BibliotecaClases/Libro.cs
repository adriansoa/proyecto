using System;
using System.Collections.Generic;
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
        public string anho_publicacion { get; set; }
        public int edicion { get; set; }



        //Firma de Metodo
        public void RegistraLibro()
        {
        }

        public Libro()
        {

        }

    }
}
