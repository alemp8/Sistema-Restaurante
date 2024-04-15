using Capa_Datos;
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
    public partial class RegistroClientes : Form
    {

        private Capa_Negocio.CN_Clientes logica;
        private Clientes _clientes;
        public RegistroClientes()
        {
            InitializeComponent();
            _clientes = new Clientes();
            logica = new Capa_Negocio.CN_Clientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Limpiar()
        {
            tbCodCliente.Text = string.Empty;
            tbNombre.Text = string.Empty;
            tbApellido.Text = string.Empty;
            tbDireccion.Text = string.Empty;
            tbTelefono.Text = string.Empty;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            this.Close ();
            //((FrmCliente)this.Owner).CargarClientes();
        }
        private void Guardar()
        {

            Validar();

            Clientes cliente = new Clientes();
            cliente.codigoCliente = tbCodCliente.Text;
            cliente.nombre = tbNombre.Text;
            cliente.apellido = tbApellido.Text;
            cliente.direccion = tbDireccion.Text;
            cliente.telefono = tbTelefono.Text;
            cliente.idCliente = _clientes != null ? _clientes.idCliente : 0;
            logica.GuardarCliente(cliente);
        }

        public void CargarClientes(Clientes cliente)
        {
            _clientes = cliente;
            if (cliente != null)
            {
                Limpiar();

                cliente.codigoCliente = tbCodCliente.Text;
                cliente.nombre = tbNombre.Text;
                cliente.apellido = tbApellido.Text;
                cliente.direccion = tbDireccion.Text;
                cliente.telefono = tbTelefono.Text;
            }
        }

        private void Validar()
        {
            if (_clientes.nombre == string.Empty)
            {
                error.SetError(tbNombre, "Escriba el Nombre");
                error.GetError(tbNombre);

            } else if(_clientes.apellido == string.Empty)
            {
                error.SetError(tbApellido, "Escriba el Apellido");
                error.GetError(tbApellido);
            }else if(_clientes.direccion == string.Empty)
            {
                error.SetError(tbDireccion, "Escriba la Direccion");
                error.GetError(tbDireccion);
            }else if(_clientes.telefono == null)
            {
                error.SetError(tbTelefono, "Escriba el Telefono");
                error.GetError(tbTelefono);
            }
        }

        private void tbCodCliente_TextChanged(object sender, EventArgs e)
        {
            _clientes.codigoCliente = tbCodCliente.Text;
            error.Clear();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            _clientes.nombre = tbNombre.Text;
            error.Clear();
        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {
            _clientes.apellido = tbApellido.Text;
            error.Clear();
        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {
            _clientes.direccion = tbNombre.Text;
            error.Clear();
        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {
            _clientes.telefono = tbTelefono.Text;
            error.Clear();
        }
    }
}
