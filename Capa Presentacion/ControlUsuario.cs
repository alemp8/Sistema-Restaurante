using Capa_Datos;
using Capa_Dominio;
using Capa_Negocio;
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
    public partial class ControlUsuario : Form
    {
        private Usuario _usuario;
        private CN_Usuarios logica;

        public ControlUsuario()
        {
            InitializeComponent();
            _usuario = new Usuario();
            logica = new CN_Usuarios();
            cbTipo.Items.Add("-Seleccione-");
            cbTipo.Items.Add("Administrador");
            cbTipo.Items.Add("Cajero");
        }

        public void CargarUsuarios(Usuario usuario)
        {
            _usuario = usuario;
            if (usuario != null)
            {
                Limpiar();

                usuario.username = tbUsername.Text;
                usuario.telefono = tbTelefono.Text;
                usuario.password = tbPassword.Text;
                usuario.confirmarpass = tbConfPassword.Text;
                //usuario.tipo = cbTipo.SelectedValue.ToString();
            }
        }

        private void Guardar()
        {
            //Validar();

            Usuario usuario = new Usuario();
            usuario.username = tbUsername.Text;
            usuario.telefono = tbTelefono.Text;
            usuario.password = tbPassword.Text;
            usuario.confirmarpass = tbConfPassword.Text;
            usuario.tipo = cbTipo.SelectedItem.ToString();
            usuario.idUsuario = _usuario != null ? _usuario.idUsuario : 0;
            logica.GuardarUsuario(usuario);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbConfPassword.Text = string.Empty;
            tbTelefono.Text = string.Empty;
        }
    }
}
