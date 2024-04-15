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
    public partial class Menu : Form
    {
        private string username;

        public Menu(string username)
        {
            InitializeComponent();

            this.username = username;

            if (username != "Administrador")
            {
                btnUsuarios.Enabled = false;
                btnProveedores.Enabled = false;
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.ShowDialog();
        }

        private void btnProveedores_Click_1(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            RegistroPedidos registroPedidos = new RegistroPedidos();
            registroPedidos.ShowDialog();
        }
    }
}
