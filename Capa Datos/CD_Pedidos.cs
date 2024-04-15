using Capa_Dominio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Pedidos
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7F8OG1J\\MSSQLEXPRESS;Initial Catalog=DBPrueba;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;Persist Security Info=False;");
        SqlTransaction transaccion = null;

        public void GuardarVenta(Ventas venta)
        {
            try
            {
                conn.Open();
                transaccion = conn.BeginTransaction();

                // Insertar la venta
                int idVenta = InsertarVenta(venta, conn, transaccion);

                // Insertar los detalles de la venta
                InsertarDetallesVenta(venta.Detalles, idVenta, conn, transaccion);

                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion?.Rollback();
                throw new Exception("Error al guardar la venta: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private int InsertarVenta(Ventas venta, SqlConnection conexion, SqlTransaction transaccion)
        {
            string query = @"INSERT INTO Ventas (Fecha, Cliente, Total) 
                     VALUES (@Fecha, @Cliente, @Total);
                     SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conexion, transaccion);
            cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
            cmd.Parameters.AddWithValue("@Cliente", venta.Cliente);
            cmd.Parameters.AddWithValue("@Total", venta.Total);

            int idVenta = Convert.ToInt32(cmd.ExecuteScalar());

            return idVenta;
        }

        private void InsertarDetallesVenta(List<DetalleVenta> detalles, int idVenta, SqlConnection conexion, SqlTransaction transaccion)
        {
            foreach (var detalle in detalles)
            {
                string query = @"INSERT INTO DetalleVenta (IdVenta, IdProducto, Cantidad, Subtotal) 
                                 VALUES (@IdVenta, @IdProducto, @Cantidad, @Subtotal);";

                SqlCommand cmd = new SqlCommand(query, conexion, transaccion);
                cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                cmd.Parameters.AddWithValue("@IdProducto", detalle.IdProducto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@Subtotal", detalle.Subtotal);

                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarStock(int CodigoProducto, int Cantidad)
        {
            try
            {
                conn.Open();

                string query = @"UPDATE Productos SET Stock = Stock - @Cantidad WHERE CodigoProducto = @CodigoProducto";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CodigoProducto", CodigoProducto);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el stock del producto: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void EliminarPedido(int idVenta)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM Ventas WHERE IdVenta = @IdVenta";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@IdVenta", idVenta));
                command.ExecuteNonQuery();

            }
            catch (Exception) { }
            finally { conn.Close(); }
        }
    }
}
