using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{

    public enum TipoMateria { Obligatoria, Electiva}

    public class Materia
    {
        public int codigo { get; set; }
        public string Nombre { get; set; }
        public int cant_creditos { get; set; }
        public TipoMateria tipo_materia { get; set; }

        public static List<Materia> listaMateria = new List<Materia>();

        public static void AgregarMateria(Materia m)
        {
            listaMateria.Add(m);
        }

        public static void EliminarMateria(Materia m)
        {
            listaMateria.Remove(m);
        }

        public static List<Materia> ObtenerMateria()
        {
            return listaMateria;
        }

        public override string ToString()
        {
            return this.Nombre;
        }

    }
}
