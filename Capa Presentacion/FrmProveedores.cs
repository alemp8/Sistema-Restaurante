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
    public partial class FrmProveedores : Form
    {
        private CN_Proveedor logica;
        public FrmProveedores()
        {
            InitializeComponent();
            logica = new CN_Proveedor();
        }
        public void CargarProveedores(string search = null)
        {
            List<Proveedores> proveedor = logica.ListaProveedores(search);
            dgvProveedores.DataSource = proveedor;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarProveedores(tbBuscar.Text);
            tbBuscar.Text = string.Empty;
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void EliminarProveedor(int idProveedor)
        {
            logica.EliminarProveedor(idProveedor);
        }

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistroProveedor registroProveedor = new RegistroProveedor();
            registroProveedor.Show();
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dgvProveedores.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Modificar")
            {
                RegistroProveedor registro = new RegistroProveedor();
                registro.CargarProveedores(new Proveedores
                {
                    idProveedor = int.Parse((dgvProveedores.Rows[e.RowIndex].Cells[0].Value.ToString())),
                    RTN = dgvProveedores.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    NombreEmpresa = dgvProveedores.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Direccion = dgvProveedores.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Telefono = dgvProveedores.Rows[e.RowIndex].Cells[4].Value.ToString()
                });
                registro.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                EliminarProveedor(int.Parse((dgvProveedores.Rows[e.RowIndex].Cells[0].Value.ToString())));
                CargarProveedores();
            }
        }
    }
}
