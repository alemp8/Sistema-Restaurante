using Capa_Datos;
using Capa_Dominio;

namespace Capa_Negocio
{
    public class CN_Clientes
    {
        private CD_Clientes AccesoDatos;

        public CN_Clientes()
        {
            AccesoDatos = new CD_Clientes();
        }
        public Clientes GuardarCliente(Clientes cliente)
        {
            if (cliente.idCliente == 0)
            {
                AccesoDatos.GuardarCliente(cliente);
            }
            else
            {
                AccesoDatos.ModificarCliente(cliente);
            }
            return cliente;
        }

        public List<Clientes> ListaClientes(string search = null)
        {
            return AccesoDatos.ListaClientes(search);
        }

        public void EliminarClientes(int codigoCliente)
        {
            AccesoDatos.EliminarClientes(codigoCliente);
        }
    }
}
