﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class DetalleFacturaVenta
    {
        public Libro Libro { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int SubTotal { get; set; }
    }
}
