using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string username { get; set;}
        public string telefono { get; set; }
        public string tipo{ get; set; }
        public string password { get; set;}
        public string confirmarpass { get; set;}

    }
}
