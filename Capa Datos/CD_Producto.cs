using Capa_Dominio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Producto
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7F8OG1J\\MSSQLEXPRESS;Initial Catalog=DBPrueba;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;Persist Security Info=False;");

        public void GuardarProducto(Productos producto)
        {
            try
            {
                conn.Open();
                string query = @"
                    INSERT INTO Productos (CodigoProducto,NombreProducto,Stock,PrecioCompra,ISV,PrecioVenta)
                    VALUES (@CodigoProducto, @NombreProducto, @Stock, @PrecioCompra, @ISV, @PrecioVenta)";

                SqlParameter CodigoProducto = new SqlParameter();
                CodigoProducto.ParameterName = "@CodigoProducto";
                CodigoProducto.Value = producto.Codigo;
                CodigoProducto.DbType = System.Data.DbType.String;

                SqlParameter NombreProducto = new SqlParameter();
                NombreProducto.ParameterName = "@NombreProducto";
                NombreProducto.Value = producto.Nombre;
                NombreProducto.DbType = System.Data.DbType.String;

                SqlParameter Stock = new SqlParameter();
                Stock.ParameterName = "@Stock";
                Stock.Value = producto.Stock;
                Stock.DbType = System.Data.DbType.String;

                SqlParameter PrecioCompra = new SqlParameter();
                PrecioCompra.ParameterName = "@PrecioCompra";
                PrecioCompra.Value = producto.PrecioCompra;
                PrecioCompra.DbType = System.Data.DbType.String;

                SqlParameter ISV = new SqlParameter();
                ISV.ParameterName = "@ISV";
                ISV.Value = producto.ISV;
                ISV.DbType = System.Data.DbType.String;

                SqlParameter PrecioVenta = new SqlParameter();
                PrecioVenta.ParameterName = "@PrecioVenta";
                PrecioVenta.Value = producto.PrecioVenta;
                PrecioVenta.DbType = System.Data.DbType.String;

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(CodigoProducto);
                command.Parameters.Add(NombreProducto);
                command.Parameters.Add(Stock);
                command.Parameters.Add(PrecioCompra);
                command.Parameters.Add(ISV);
                command.Parameters.Add(PrecioVenta);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Productos> ListaProductos(string search = null)
        {
            List<Productos> producto =  new List<Productos>();

            try
            {
                conn.Open();
                string query = @"SELECT idProducto, CodigoProducto, NombreProducto, Stock, PrecioCompra, ISV, PrecioVenta
                                FROM Productos";
                SqlCommand command = new SqlCommand();
                if (!string.IsNullOrEmpty(search))
                {
                    query += " WHERE NombreProducto LIKE @Search OR CodigoProducto LIKE @Search ";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }
                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    producto.Add(new Productos
                    {
                        IdProducto= int.Parse(reader["idProducto"].ToString()),
                        Codigo = reader["CodigoProducto"].ToString(),
                        Nombre= reader["NombreProducto"].ToString(),
                        Stock = reader["Stock"].ToString(),
                        PrecioVenta = reader["PrecioVenta"].ToString(),
                        ISV = reader["ISV"].ToString(),
                        PrecioCompra =reader["PrecioCompra"].ToString()
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return producto;
        }
        public void ModificarProducto(Productos producto)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE Productos 
SET NombreProducto = @NombreProducto, CodigoProducto = @CodigoProducto, Stock = @Stock, PrecioCompra = @PrecioCompra,  ISV= @ISV, PrecioVenta = @PrecioVenta
WHERE idProducto = @idProducto";
                SqlParameter idProducto = new SqlParameter();
                idProducto.ParameterName = "@idProducto";
                idProducto.Value = producto.IdProducto;
                idProducto.DbType = System.Data.DbType.String;

                SqlParameter CodigoProducto = new SqlParameter();
                CodigoProducto.ParameterName = "@CodigoProducto";
                CodigoProducto.Value = producto.Codigo;
                CodigoProducto.DbType = System.Data.DbType.String;

                SqlParameter NombreProducto = new SqlParameter();
                NombreProducto.ParameterName = "@NombreProducto";
                NombreProducto.Value = producto.Nombre;
                NombreProducto.DbType = System.Data.DbType.String;

                SqlParameter Stock = new SqlParameter();
                Stock.ParameterName = "@Stock";
                Stock.Value = producto.Stock;
                Stock.DbType = System.Data.DbType.String;

                SqlParameter PrecioCompra = new SqlParameter();
                PrecioCompra.ParameterName = "@PrecioCompra";
                PrecioCompra.Value = producto.PrecioCompra;
                PrecioCompra.DbType = System.Data.DbType.String;

                SqlParameter ISV = new SqlParameter();
                ISV.ParameterName = "@ISV";
                ISV.Value = producto.ISV;
                ISV.DbType = System.Data.DbType.String;

                SqlParameter PrecioVenta = new SqlParameter();
                PrecioVenta.ParameterName = "@PrecioVenta";
                PrecioVenta.Value = producto.PrecioVenta;
                PrecioVenta.DbType = System.Data.DbType.String;

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(idProducto);
                command.Parameters.Add(CodigoProducto);
                command.Parameters.Add(NombreProducto);
                command.Parameters.Add(Stock);
                command.Parameters.Add(PrecioCompra);
                command.Parameters.Add(ISV);
                command.Parameters.Add(PrecioVenta);

                command.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { conn.Close(); }
        }

        public void EliminarProducto(int idProducto)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM Productos WHERE idProducto = @idProducto";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@idProducto", idProducto));
                command.ExecuteNonQuery();

            }
            catch (Exception) { }
            finally { conn.Close(); }
        }
    }
}
