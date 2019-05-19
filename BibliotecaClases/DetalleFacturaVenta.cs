using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class DetalleFacturaVenta
    {
        public int CodigoLibro { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int PrecioUnitario { get; set; }
    }
}
