using Capa_Dominio;
using Microsoft.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Clientes
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7F8OG1J\\MSSQLEXPRESS;Initial Catalog=DBPrueba;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;Persist Security Info=False;");

        public void GuardarCliente(Clientes cliente)
        {
            try
            {
                conn.Open();
                string query = @"
                    INSERT INTO Clientes (CodigoCliente,NombreCliente,ApellidoCliente,TelefonoCliente,DireccionClientes)
                    VALUES (@CodigoCliente, @NombreCliente, @ApellidoCliente, @TelefonoCliente, @DireccionClientes)";

                SqlParameter CodigoCliente = new SqlParameter();
                CodigoCliente.ParameterName = "@CodigoCliente";
                CodigoCliente.Value = cliente.codigoCliente;
                CodigoCliente.DbType = System.Data.DbType.String;

                SqlParameter NombreCliente = new SqlParameter();
                NombreCliente.ParameterName = "@NombreCliente";
                NombreCliente.Value = cliente.nombre;
                NombreCliente.DbType = System.Data.DbType.String;

                SqlParameter ApellidoCliente = new SqlParameter();
                ApellidoCliente.ParameterName = "@ApellidoCliente";
                ApellidoCliente.Value = cliente.apellido;
                ApellidoCliente.DbType = System.Data.DbType.String;

                SqlParameter DireccionClientes = new SqlParameter();
                DireccionClientes.ParameterName = "@DireccionClientes";
                DireccionClientes.Value = cliente.direccion;
                DireccionClientes.DbType = System.Data.DbType.String;
                                
                SqlParameter TelefonoCliente = new SqlParameter();
                TelefonoCliente.ParameterName = "@TelefonoCliente";
                TelefonoCliente.Value = cliente.telefono;
                TelefonoCliente.DbType = System.Data.DbType.String;

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(CodigoCliente);
                command.Parameters.Add(NombreCliente);
                command.Parameters.Add(ApellidoCliente);
                command.Parameters.Add(DireccionClientes);
                command.Parameters.Add(TelefonoCliente);

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

        public List<Clientes> ListaClientes(string search = null)
        {
            List<Clientes> cliente = new List<Clientes>();

            try
            {
                conn.Open();
                string query = @"SELECT idCliente, CodigoCliente, NombreCliente, ApellidoCliente, TelefonoCliente, DireccionClientes
                                FROM Clientes";
                SqlCommand command = new SqlCommand();
                if (!string.IsNullOrEmpty(search))
                {
                    query += " WHERE NombreCliente LIKE @Search OR ApellidoCliente LIKE @Search OR CodigoCliente LIKE @Search OR TelefonoCliente LIKE @Search OR DireccionClientes LIKE @Search ";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }
                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cliente.Add(new Clientes
                    {
                        idCliente = int.Parse(reader["idCliente"].ToString()),
                        codigoCliente = reader["CodigoCliente"].ToString(),
                        nombre = reader["NombreCliente"].ToString(),
                        apellido = reader["ApellidoCliente"].ToString(),
                        telefono = reader["TelefonoCliente"].ToString(),
                        direccion = reader["DireccionClientes"].ToString()
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
            return cliente;
        }
        public void ModificarCliente(Clientes cliente)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE Clientes 
SET NombreCliente = @NombreCliente, ApellidoCliente = @ApellidoCliente, DireccionClientes = @DireccionClientes, TelefonoCliente = @TelefonoCliente 
WHERE idCliente = @idCliente";
                SqlParameter CodigoCliente = new SqlParameter();
                CodigoCliente.ParameterName = "@CodigoCliente";
                CodigoCliente.Value = cliente.codigoCliente;
                CodigoCliente.DbType = System.Data.DbType.String;

                SqlParameter idCliente = new SqlParameter();
                idCliente.ParameterName = "@idCliente";
                idCliente.Value = cliente.idCliente;
                idCliente.DbType = System.Data.DbType.String;

                SqlParameter NombreCliente = new SqlParameter();
                NombreCliente.ParameterName = "@NombreCliente";
                NombreCliente.Value = cliente.nombre;
                NombreCliente.DbType = System.Data.DbType.String;

                SqlParameter ApellidoCliente = new SqlParameter();
                ApellidoCliente.ParameterName = "@ApellidoCliente";
                ApellidoCliente.Value = cliente.apellido;
                ApellidoCliente.DbType = System.Data.DbType.String;

                SqlParameter DireccionClientes = new SqlParameter();
                DireccionClientes.ParameterName = "@DireccionClientes";
                DireccionClientes.Value = cliente.direccion;
                DireccionClientes.DbType = System.Data.DbType.String;

                SqlParameter TelefonoCliente = new SqlParameter();
                TelefonoCliente.ParameterName = "@TelefonoCliente";
                TelefonoCliente.Value = cliente.telefono;
                TelefonoCliente.DbType = System.Data.DbType.String;

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(idCliente);
                command.Parameters.Add(CodigoCliente);
                command.Parameters.Add(NombreCliente);
                command.Parameters.Add(ApellidoCliente);
                command.Parameters.Add(DireccionClientes);
                command.Parameters.Add(TelefonoCliente);

                command.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { conn.Close(); }
        }

        public void EliminarClientes(int idCliente)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM Clientes WHERE idCliente = @idCliente";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@idCliente", idCliente));
                command.ExecuteNonQuery();

            }
            catch (Exception) { }
            finally { conn.Close(); }
        }
    }
}
