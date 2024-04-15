using Capa_Datos;
using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    
    public class CN_Pedidos
    {
        private CD_Pedidos AccesoDatos;

        public CN_Pedidos()
        {
            AccesoDatos = new CD_Pedidos();
        }

        public Ventas InsertarVenta(Ventas venta)
        {
            if (venta.IdVenta == 0)
            {
                AccesoDatos.GuardarVenta(venta);
            }
            else
            {
               // AccesoDatos.ModificarCliente(cliente);
            }
            return venta;
        }

        public void ActualizarStock(int idProducto,int cantidad)
        {
            AccesoDatos.ActualizarStock(idProducto, cantidad);
        }

        public void EliminarPedido(int idVenta)
        {
            AccesoDatos.EliminarPedido(idVenta);
        }
    }
}
