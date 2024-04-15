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
    public partial class FrmProductos : Form
    {
        private CN_Producto logica;
        public FrmProductos()
        {
            InitializeComponent();
            logica = new CN_Producto();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarProductos(tbBuscar.Text);
            tbBuscar.Text = string.Empty;
        }

        public void CargarProductos(string search = null)
        {
            List<Productos> productos = logica.ListaProductos(search);
            dgvProductos.DataSource = productos;
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
        private void EliminarProducto(int idProducto)
        {
            logica.EliminarProductos(idProducto);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistroProducto registroProducto = new RegistroProducto();
            registroProducto.ShowDialog();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Modificar")
            {
                RegistroProducto registro = new RegistroProducto();
                registro.CargarProductos(new Productos
                {
                    IdProducto = int.Parse((dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString())),
                    Codigo = dgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Nombre = dgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Stock = dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    PrecioCompra = dgvProductos.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    ISV = dgvProductos.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    PrecioVenta = dgvProductos.Rows[e.RowIndex].Cells[6].Value.ToString()
                });
                registro.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                EliminarProducto(int.Parse((dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString())));
                CargarProductos();
            }
        }

       
    }
}
