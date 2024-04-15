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
    public partial class RegistroProducto : Form
    {
        private Productos _producto;
        private CN_Producto logica;
        public RegistroProducto()
        {
            InitializeComponent();
            _producto = new Productos();
            logica = new CN_Producto();
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            _producto.Codigo = tbCodigo.Text;
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            _producto.Nombre = tbNombre.Text;
        }

        private void tbPrecioVenta_TextChanged(object sender, EventArgs e)
        {
           // _producto.PrecioVenta = decimal.Parse(tbPrecioVenta.Text);
        }

        private void tbISV_TextChanged(object sender, EventArgs e)
        {
           // _producto.ISV = decimal.Parse(tbISV.Text);
        }

        private void tbPrecioCompra_TextChanged(object sender, EventArgs e)
        {
           // _producto.PrecioCompra = decimal.Parse(tbPrecioCompra.Text);
        }

        private void tbStock_TextChanged(object sender, EventArgs e)
        {
          //  _producto.Stock = int.Parse(tbStock.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            tbCodigo.Text = string.Empty;
            tbStock.Text = string.Empty;
            tbPrecioCompra.Text = string.Empty;
            tbISV.Text = string.Empty;
            tbPrecioVenta.Text = string.Empty;
            tbNombre.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            this.Close();
        }

        private void Guardar()
        {
            Productos producto = new Productos();
            producto.Codigo = tbCodigo.Text;
            producto.Nombre = tbNombre.Text;
            producto.Stock= tbStock.Text;
            producto.PrecioCompra = tbPrecioCompra.Text; 
            producto.ISV = tbISV.Text;
            producto.PrecioVenta = tbPrecioVenta.Text;
            producto.IdProducto = _producto != null ? _producto.IdProducto: 0;
            logica.GuardarProducto(producto);
        }

        public void CargarProductos(Productos producto)
        {
            _producto = producto;
            if (producto != null)
            {
                Limpiar();

                producto.Codigo = tbCodigo.Text;
                producto.Nombre = tbNombre.Text;
                producto.Stock = tbStock.Text;
                producto.PrecioCompra = tbPrecioCompra.Text;
                producto.ISV = tbISV.Text;
                producto.PrecioVenta = tbPrecioVenta.Text;
            }
        }
    }
}
