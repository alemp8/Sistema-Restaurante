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
    public partial class RegistroProveedor : Form
    {
        private CN_Proveedor logica;
        private Proveedores _proveedor;

        public RegistroProveedor()
        {
            InitializeComponent();
            _proveedor = new Proveedores();
            logica = new CN_Proveedor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Limpiar()
        {
            tbRTN.Text = string.Empty;
            tbNombre.Text = string.Empty;
            tbDireccion.Text = string.Empty;
            tbTelefono.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar()
        {
            Proveedores proveedor = new Proveedores();
            proveedor.RTN = tbRTN.Text;
            proveedor.NombreEmpresa = tbNombre.Text;
            proveedor.Direccion = tbDireccion.Text;
            proveedor.Telefono = tbTelefono.Text;
            proveedor.idProveedor = _proveedor != null ? _proveedor.idProveedor : 0;
            logica.GuardarProveedor(proveedor);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            this.Close();
        }

        private void tbRTN_TextChanged(object sender, EventArgs e)
        {
            _proveedor.RTN = tbRTN.Text;
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            _proveedor.NombreEmpresa = tbNombre.Text;
        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {
            _proveedor.Direccion = tbDireccion.Text;
        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {
            _proveedor.Telefono= tbTelefono.Text;
        }

        public void CargarProveedores(Proveedores proveedor)
        {
            _proveedor = proveedor;
            if (proveedor != null)
            {
                Limpiar();

                proveedor.RTN = tbRTN.Text;
                proveedor.NombreEmpresa = tbNombre.Text;
                proveedor.Direccion = tbDireccion.Text;
                proveedor.Telefono = tbTelefono.Text;
            }
        }
    }
}
