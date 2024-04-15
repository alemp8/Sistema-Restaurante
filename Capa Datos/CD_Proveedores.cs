using Capa_Dominio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Proveedores
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7F8OG1J\\MSSQLEXPRESS;Initial Catalog=DBPrueba;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;Persist Security Info=False;");

        public void GuardarProvedor(Proveedores proveedor)
        {
            try
            {
                conn.Open();
                string query = @"
                    INSERT INTO Proveedores (RTN,NombreEmpresa,Telefono,Direccion)
                    VALUES (@RTN, @NombreEmpresa, @Telefono, @Direccion)";
                SqlParameter RTN = new SqlParameter();
                RTN.ParameterName = "@RTN";
                RTN.Value = proveedor.RTN;
                RTN.DbType = System.Data.DbType.String;

                SqlParameter NombrePersona = new SqlParameter();
                NombrePersona.ParameterName = "@NombreEmpresa";
                NombrePersona.Value = proveedor.NombreEmpresa;
                NombrePersona.DbType = System.Data.DbType.String;

                SqlParameter Telefono = new SqlParameter();
                Telefono.ParameterName = "@Telefono";
                Telefono.Value = proveedor.Telefono;
                Telefono.DbType = System.Data.DbType.String;

                SqlParameter Direccion = new SqlParameter();
                Direccion.ParameterName = "@Direccion";
                Direccion.Value = proveedor.Direccion;
                Direccion.DbType = System.Data.DbType.String;               

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(RTN);
                command.Parameters.Add(NombrePersona);
                command.Parameters.Add(Telefono);
                command.Parameters.Add(Direccion);
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

        public List<Proveedores> ListaProveedores(string search = null)
        {
            List<Proveedores> proveedor = new List<Proveedores>();

            try
            {
                conn.Open();
                string query = @"SELECT IdProveedor, RTN, NombreEmpresa, Telefono, Direccion
                                FROM Proveedores";
                SqlCommand command = new SqlCommand();
                if (!string.IsNullOrEmpty(search))
                {
                    query += " WHERE NombreEmpresa LIKE @Search OR RTN LIKE @Search OR Telefono LIKE @Search OR Direccion LIKE @Search ";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }
                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    proveedor.Add(new Proveedores
                    {
                        idProveedor = int.Parse(reader["IdProveedor"].ToString()),
                        RTN = reader["RTN"].ToString(),
                        NombreEmpresa = reader["NombreEmpresa"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Direccion = reader["Direccion"].ToString()
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
            return proveedor;
        }
        public void ModificarProveedor(Proveedores proveedor)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE Proveedores 
                                SET RTN = @RTN, NombreEmpresa = @NombreEmpresa, Telefono = @Telefono, Direccion = @Direccion 
            WHERE IdProveedor = @IdProveedor";
                SqlParameter IdProveedor = new SqlParameter();
                IdProveedor.ParameterName = "@IdProveedor";
                IdProveedor.Value = proveedor.idProveedor;
                IdProveedor.DbType = System.Data.DbType.String;

                SqlParameter RTN = new SqlParameter();
                RTN.ParameterName = "@RTN";
                RTN.Value = proveedor.RTN;
                RTN.DbType = System.Data.DbType.String;

                SqlParameter NombrePersona = new SqlParameter();
                NombrePersona.ParameterName = "@NombreEmpresa";
                NombrePersona.Value = proveedor.NombreEmpresa;
                NombrePersona.DbType = System.Data.DbType.String;

                SqlParameter Telefono = new SqlParameter();
                Telefono.ParameterName = "@Telefono";
                Telefono.Value = proveedor.Telefono;
                Telefono.DbType = System.Data.DbType.String;

                SqlParameter Direccion = new SqlParameter();
                Direccion.ParameterName = "@Direccion";
                Direccion.Value = proveedor.Direccion;
                Direccion.DbType = System.Data.DbType.String;

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(IdProveedor);
                command.Parameters.Add(RTN);
                command.Parameters.Add(NombrePersona);
                command.Parameters.Add(Telefono);
                command.Parameters.Add(Direccion);

                command.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { conn.Close(); }
        }

        public void BorrarProveedor(int idProveedor)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM Proveedores WHERE IdProveedor = @IdProveedor";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@IdProveedor", idProveedor));
                command.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally { conn.Close(); }
        }
    }
}
