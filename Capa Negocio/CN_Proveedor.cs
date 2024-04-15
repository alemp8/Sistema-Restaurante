using Capa_Datos;
using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Proveedor
    {
        private CD_Proveedores AccesoDatos;

        public CN_Proveedor()
        {
            AccesoDatos = new CD_Proveedores();
        }
        public Proveedores GuardarProveedor(Proveedores proveedor)
        {
            if (proveedor.idProveedor == 0)
            {
                AccesoDatos.GuardarProvedor(proveedor);
            }
            else
            {
                AccesoDatos.ModificarProveedor(proveedor);
            }
            return proveedor;
        }

        public List<Proveedores> ListaProveedores(string search = null)
        {
            return AccesoDatos.ListaProveedores(search);
        }

        public void EliminarProveedor(int idProveedor)
        {
            AccesoDatos.BorrarProveedor(idProveedor);
        }
    }
}
