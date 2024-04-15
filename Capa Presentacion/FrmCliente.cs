using Capa_Dominio;
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
    public partial class FrmCliente : Form
    {
        private Capa_Negocio.CN_Clientes logica;
        public FrmCliente()
        {
            InitializeComponent();
            logica = new Capa_Negocio.CN_Clientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistroClientes registroClientes = new RegistroClientes();
            registroClientes.ShowDialog();
        }

        public void CargarClientes(string search = null)
        {
            List<Clientes> clientes = logica.ListaClientes(search);
            dgvClientes.DataSource = clientes;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }
        private void EliminarCliente(int CodCliente)
        {
            logica.EliminarClientes(CodCliente);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarClientes(tbBuscar.Text);
            tbBuscar.Text = string.Empty;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dgvClientes.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Modificar")
            {
                RegistroClientes registro = new RegistroClientes();
                registro.CargarClientes(new Clientes
                {
                    idCliente = int.Parse((dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString())),
                    codigoCliente = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    nombre = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    apellido = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    direccion = dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    telefono = dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString()
                });
                registro.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                EliminarCliente(int.Parse((dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString())));
                CargarClientes();
            }
        }

        
    }
}
