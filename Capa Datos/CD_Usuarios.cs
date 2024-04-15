using Capa_Dominio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public  class CD_Usuarios
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7F8OG1J\\MSSQLEXPRESS;Initial Catalog=DBPrueba;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;Persist Security Info=False;");

        public void GuardarUsuario(Usuario usuario)
        {
            try
            {
                conn.Open();
                string query = @"
                    INSERT INTO Usuarios (Username,Telefono,Password,ConfirmarPassword,Tipo)
                    VALUES (@Username, @Telefono, @Password, @ConfirmarPassword, @Tipo)";

                SqlParameter Username = new SqlParameter();
                Username.ParameterName = "@Username";
                Username.Value = usuario.username;
                Username.DbType = System.Data.DbType.String;

                SqlParameter Telefono = new SqlParameter();
                Telefono.ParameterName = "@Telefono";
                Telefono.Value = usuario.telefono;
                Telefono.DbType = System.Data.DbType.String;

                SqlParameter Password = new SqlParameter();
                Password.ParameterName = "@Password";
                Password.Value = usuario.password;
                Password.DbType = System.Data.DbType.String;

                SqlParameter ConfirmarPassword = new SqlParameter();
                ConfirmarPassword.ParameterName = "@ConfirmarPassword";
                ConfirmarPassword.Value = usuario.confirmarpass;
                ConfirmarPassword.DbType = System.Data.DbType.String;

                SqlParameter Tipo = new SqlParameter();
                Tipo.ParameterName = "@Tipo";
                Tipo.Value = usuario.tipo;
                Tipo.DbType = System.Data.DbType.String;

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(Username);
                command.Parameters.Add(Telefono);
                command.Parameters.Add(Password);
                command.Parameters.Add(ConfirmarPassword);
                command.Parameters.Add(Tipo);

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

        public void ModificarUsuario(Usuario usuario)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE Usuarios 
SET Username = @Username, Telefono = @Telefono, Password = @Password, ConfirmarPassword = @ConfirmarPassword, Tipo = @Tipo 
WHERE idUsuario = @idUsuario";
                SqlParameter idUsuario = new SqlParameter();
                idUsuario.ParameterName = "@idUsuario";
                idUsuario.Value = usuario.idUsuario;
                idUsuario.DbType = System.Data.DbType.String;

                SqlParameter Username = new SqlParameter();
                Username.ParameterName = "@Username";
                Username.Value = usuario.username;
                Username.DbType = System.Data.DbType.String;

                SqlParameter Telefono = new SqlParameter();
                Telefono.ParameterName = "@Telefono";
                Telefono.Value = usuario.telefono;
                Telefono.DbType = System.Data.DbType.String;

                SqlParameter Password = new SqlParameter();
                Password.ParameterName = "@Password";
                Password.Value = usuario.password;
                Password.DbType = System.Data.DbType.String;

                SqlParameter ConfirmarPassword = new SqlParameter();
                ConfirmarPassword.ParameterName = "@ConfirmarPassword";
                ConfirmarPassword.Value = usuario.confirmarpass;
                ConfirmarPassword.DbType = System.Data.DbType.String;

                SqlParameter Tipo = new SqlParameter();
                Tipo.ParameterName = "@Tipo";
                Tipo.Value = usuario.tipo;
                Tipo.DbType = System.Data.DbType.String;

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(idUsuario); 
                command.Parameters.Add(Username);
                command.Parameters.Add(Telefono);
                command.Parameters.Add(Password);
                command.Parameters.Add(ConfirmarPassword);
                command.Parameters.Add(Tipo);

                command.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { conn.Close(); }
        }

        public List<Usuario> ListaUsuarios(string search = null)
        {
            List<Usuario> usuario = new List<Usuario>();

            try
            {
                conn.Open();
                string query = @"SELECT idUsuario, Username, Telefono, Password, ConfirmarPassword, Tipo
                         FROM Usuarios";
                SqlCommand command = new SqlCommand();
                if (!string.IsNullOrEmpty(search))
                {
                    query += " WHERE Username LIKE @Search OR Tipo LIKE @Search";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }
                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    usuario.Add(new Usuario
                    {
                        idUsuario = int.Parse(reader["idUsuario"].ToString()),
                        username = reader["Username"].ToString(),
                        telefono = reader["Telefono"].ToString(),
                        password = reader["Password"].ToString(),
                        confirmarpass = reader["ConfirmarPassword"].ToString(),
                        tipo = reader["Tipo"].ToString()
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
            return usuario;
        }


        public void EliminarUsuario(int idUsuario)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM Usuarios WHERE idUsuario = @idUsuario";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                command.ExecuteNonQuery();

            }
            catch (Exception) { }
            finally { conn.Close(); }
        }

    }
}
