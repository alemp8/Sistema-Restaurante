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
    public partial class RegistroPedidos : Form
    {
        private CN_Producto logica;
        private CN_Pedidos logicapedidos;
        private Ventas _ventas;
        public RegistroPedidos()
        {
            InitializeComponent();
            logica = new CN_Producto();
            logicapedidos = new CN_Pedidos();
        }

        public void CargarProductos(string search = null)
        {
            List<Productos> producto = logica.ListaProductos();

            Productos productoEncontrado = producto.Find(p => p.Codigo == search);

            if (productoEncontrado != null)
            {

                tbProducto.Text = productoEncontrado.Nombre;
                tbCosto.Text = productoEncontrado.PrecioCompra.ToString();
                tbISV.Text = productoEncontrado.ISV.ToString();
                tbVenta.Text = productoEncontrado.PrecioVenta.ToString();
            }
            else
            {
                tbCodProducto.Text = string.Empty;
            }
        }

        private void tbCodProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            CargarProductos(tbCodProducto.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string nombre = tbProducto.Text;
            int codigo = Convert.ToInt32(tbCodProducto.Text);
            decimal costo = Convert.ToDecimal(tbCosto.Text);
            decimal isv = Convert.ToDecimal(tbISV.Text);
            decimal venta = Convert.ToDecimal(tbVenta.Text);
            int cantidad = Convert.ToInt32(nudCantidad.Value);

            decimal acumulado = venta * cantidad;
            decimal subtotal = Convert.ToInt32(acumulado.ToString());


            dgvPedidosProductos.Rows.Add(codigo, nombre, costo, isv, venta, cantidad, subtotal);

            LimpiarTextBox();
            CalcularTotal();
        }

        public void LimpiarTextBox()
        {
            tbCodProducto.Text = string.Empty;
            tbProducto.Text = string.Empty;
            tbCosto.Text = string.Empty;
            tbISV.Text = string.Empty;
            tbVenta.Text = string.Empty;
            nudCantidad.Value = 1;
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvPedidosProductos.Rows)
            {

                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }
            tbTotal.Text = total.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();


            this.Close();
        }


        public void Guardar()
        {
            try
            {
                DateTime fecha = dtpFecha.Value;
                string Cliente = tbCliente.Text;
                decimal total = Convert.ToDecimal(tbTotal.Text);

                List<DetalleVenta> detallesVenta = new List<DetalleVenta>();
                foreach (DataGridViewRow fila in dgvPedidosProductos.Rows)
                {
                    int idProducto = Convert.ToInt32(fila.Cells["Codigo"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    decimal subtotal = Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                    detallesVenta.Add(new DetalleVenta { IdProducto = idProducto, Cantidad = cantidad, Subtotal = subtotal });
                }

                foreach (var detalle in detallesVenta)
                {
                    logicapedidos.ActualizarStock(detalle.IdProducto, detalle.Cantidad);
                }

                Ventas nuevaVenta = new Ventas();
                {
                    nuevaVenta.Fecha = fecha;
                    nuevaVenta.Cliente = Cliente;
                    nuevaVenta.Total = total;
                    nuevaVenta.Detalles = detallesVenta;
                };

                logicapedidos.InsertarVenta(nuevaVenta);

               


                MessageBox.Show("Venta guardada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la venta: " + ex.Message);
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
            dgvPedidosProductos.Rows.Clear();
        }
    }
}

