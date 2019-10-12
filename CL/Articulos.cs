using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL
{
    public class Articulos
    {
        public int IdArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public int Bonificacion { get; set; }
        public decimal Precio { get; set; }
        public int IdProveedor {get; set;}
    }


}
