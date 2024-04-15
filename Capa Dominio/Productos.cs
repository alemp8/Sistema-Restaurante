using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Stock { get; set; }
        public string PrecioCompra { get; set; }
        public string ISV { get; set; }
        public string PrecioVenta { get; set; }
    }
}
