using Capa_Datos;
using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Producto
    {
        private CD_Producto AccesoDatos;

        public CN_Producto()
        {
            AccesoDatos = new CD_Producto();
        }
        public Productos GuardarProducto(Productos producto)
        {
            if (producto.IdProducto == 0)
            {
                AccesoDatos.GuardarProducto(producto);
            }
            else
            {
                AccesoDatos.ModificarProducto(producto);
            }
            return producto;
        }

        public List<Productos> ListaProductos(string search = null)
        {
            return AccesoDatos.ListaProductos(search);
        }

        public void EliminarProductos(int idProducto)
        {
            AccesoDatos.EliminarProducto(idProducto);
        }
    }
}
