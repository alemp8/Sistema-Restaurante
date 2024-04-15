using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7F8OG1J\\MSSQLEXPRESS;Initial Catalog=DBPrueba;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;Persist Security Info=False;");

        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (VerificarCredenciales(username, password))
            {
                MessageBox.Show("Inicio de Sesión exitoso");
                Menu menu = new Menu(username);
                menu.Show();
                MessageBox.Show("¡Bienvenido!");

                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }
        }

        private bool VerificarCredenciales(string username, string password)
        {
            try
            {
                {
                    conn.Open();

                    string consulta = "SELECT COUNT(*) FROM Usuarios WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand comando = new SqlCommand(consulta, conn))
                    {
                        comando.Parameters.AddWithValue("@Username", username);
                        comando.Parameters.AddWithValue("@Password", password);

                        int count = (int)comando.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
