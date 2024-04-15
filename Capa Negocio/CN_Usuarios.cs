using Capa_Datos;
using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios AccesoDatos;
        public CN_Usuarios()
        {
            AccesoDatos = new CD_Usuarios();
        }

        public Usuario GuardarUsuario(Usuario usuario)
        {
            if (usuario.idUsuario == 0)
            {
                AccesoDatos.GuardarUsuario(usuario);
            }
            else
            {
                AccesoDatos.ModificarUsuario(usuario);
            }
            return usuario;
        }

        public List<Usuario> ListaUsuarios(string search = null)
        {
            return AccesoDatos.ListaUsuarios(search);
        }
     

        public void EliminarUsuario(int codigoUsuario)
        {
          AccesoDatos.EliminarUsuario(codigoUsuario);
        }

    }
}
