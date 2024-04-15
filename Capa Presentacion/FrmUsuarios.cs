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
    public partial class FrmUsuarios : Form
    {
        private CN_Usuarios logica;
        public FrmUsuarios()
        {
            InitializeComponent();
            logica = new CN_Usuarios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarUsuarios(tbBuscar.Text);
            tbBuscar.Text = string.Empty;
        }
        public void CargarUsuarios(string search = null)
        {
            List<Usuario> usuarios = logica.ListaUsuarios(search);
            dgvUsuarios.DataSource = usuarios;
        }
        private void EliminarUsuario(int idusuario)
        {
            logica.EliminarUsuario(idusuario);
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ControlUsuario controlUsuario = new ControlUsuario();
            controlUsuario.ShowDialog();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Modificar")
            {
                ControlUsuario registro = new ControlUsuario();
                registro.CargarUsuarios(new Usuario
                {
                    idUsuario = int.Parse((dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString())),
                    username = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    telefono= dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    password = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    confirmarpass = dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    tipo = dgvUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString()
                });
                registro.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                EliminarUsuario(int.Parse((dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString())));
                CargarUsuarios();
            }
        }
    }
}
