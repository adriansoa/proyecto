using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Facultad
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int anho_fundacion { get; set; }

        public static List<Facultad> listaFacultad = new List<Facultad>();

        public static void AgregarFacultad(Facultad f)
        {
            listaFacultad.Add(f);
        }
        
        public static void EliminarFacultad(Facultad f)
        {
            listaFacultad.Remove(f);
        }

        public static List<Facultad> ObtenerFacultad()
        {
            return listaFacultad;
        }

        public override string ToString()
        {
            return this.nombre;
        }

    }




}
