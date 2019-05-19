using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
   public abstract class Persona
    {
        public enum TipoDocumento
        {
            pasaporte,
            cedula
        }

        public string nro_documento { get; set; }
        public TipoDocumento tipo_documento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string fecha_Nacimiento  { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public static List<Persona> listaPersona = new List<Persona>();

        public static void AgregarPersona(Persona p)
        {
            listaPersona.Add(p);
        }

        public static void EliminarPersona(Persona p)
        {
            listaPersona.Remove(p);
        }

        public static List<Persona> ObtenerPersona()
        {
            return listaPersona;
        }

        public override string ToString()
        {
            return this.nombre;
        }

    }
}
