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
            cedula,
            DNI
        }

        public string nro_documento { get; set; }
        public TipoDocumento tipo_documento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha_Nacimiento  { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

    }
}
