namespace Capa_Presentacion
{
    partial class RegistroPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            tbTotal = new TextBox();
            dgvPedidosProductos = new DataGridView();
            groupBox2 = new GroupBox();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            nudCantidad = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tbVenta = new TextBox();
            tbCosto = new TextBox();
            tbISV = new TextBox();
            label6 = new Label();
            tbProducto = new TextBox();
            tbCodProducto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            tbCliente = new TextBox();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            ISV = new DataGridViewTextBoxColumn();
            Venta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosProductos).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(tbTotal);
            panel1.Controls.Add(dgvPedidosProductos);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-6, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 558);
            panel1.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LimeGreen;
            btnGuardar.FlatAppearance.BorderColor = Color.SeaGreen;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 25;
            btnGuardar.Location = new Point(723, 509);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(70, 29);
            btnGuardar.TabIndex = 26;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(516, 514);
            label11.Name = "label11";
            label11.Size = new Size(42, 21);
            label11.TabIndex = 25;
            label11.Text = "Total";
            // 
            // tbTotal
            // 
            tbTotal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTotal.Location = new Point(564, 509);
            tbTotal.Multiline = true;
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(153, 29);
            tbTotal.TabIndex = 24;
            // 
            // dgvPedidosProductos
            // 
            dgvPedidosProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidosProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Producto, Costo, ISV, Venta, Cantidad, Subtotal });
            dgvPedidosProductos.Location = new Point(26, 213);
            dgvPedidosProductos.Name = "dgvPedidosProductos";
            dgvPedidosProductos.Size = new Size(847, 290);
            dgvPedidosProductos.TabIndex = 14;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscarProducto);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(nudCantidad);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbVenta);
            groupBox2.Controls.Add(tbCosto);
            groupBox2.Controls.Add(tbISV);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbProducto);
            groupBox2.Controls.Add(tbCodProducto);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(878, 91);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Productos";
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.Green;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarProducto.IconColor = Color.White;
            btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProducto.IconSize = 20;
            btnBuscarProducto.Location = new Point(109, 53);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(34, 29);
            btnBuscarProducto.TabIndex = 24;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Green;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAgregar.IconColor = Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 20;
            btnAgregar.Location = new Point(817, 53);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(44, 29);
            btnAgregar.TabIndex = 23;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(759, 29);
            label10.Name = "label10";
            label10.Size = new Size(42, 21);
            label10.TabIndex = 22;
            label10.Text = "Cant";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(750, 53);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(64, 29);
            nudCantidad.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(632, 29);
            label9.Name = "label9";
            label9.Size = new Size(96, 21);
            label9.TabIndex = 20;
            label9.Text = "Precio Venta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(530, 29);
            label8.Name = "label8";
            label8.Size = new Size(33, 21);
            label8.TabIndex = 19;
            label8.Text = "ISV";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(396, 29);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 18;
            label7.Text = "Precio Costo";
            // 
            // tbVenta
            // 
            tbVenta.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbVenta.Location = new Point(632, 53);
            tbVenta.Multiline = true;
            tbVenta.Name = "tbVenta";
            tbVenta.Size = new Size(115, 29);
            tbVenta.TabIndex = 16;
            // 
            // tbCosto
            // 
            tbCosto.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCosto.Location = new Point(395, 53);
            tbCosto.Multiline = true;
            tbCosto.Name = "tbCosto";
            tbCosto.Size = new Size(116, 29);
            tbCosto.TabIndex = 15;
            // 
            // tbISV
            // 
            tbISV.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbISV.Location = new Point(514, 53);
            tbISV.Multiline = true;
            tbISV.Name = "tbISV";
            tbISV.Size = new Size(115, 29);
            tbISV.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(144, 29);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 14;
            label6.Text = "Producto";
            // 
            // tbProducto
            // 
            tbProducto.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbProducto.Location = new Point(144, 53);
            tbProducto.Multiline = true;
            tbProducto.Name = "tbProducto";
            tbProducto.Size = new Size(247, 29);
            tbProducto.TabIndex = 13;
            // 
            // tbCodProducto
            // 
            tbCodProducto.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCodProducto.Location = new Point(4, 53);
            tbCodProducto.Multiline = true;
            tbCodProducto.Name = "tbCodProducto";
            tbCodProducto.Size = new Size(103, 29);
            tbCodProducto.TabIndex = 4;
            tbCodProducto.TextChanged += tbCodProducto_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 29);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 29);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 2;
            label5.Text = "Cod. Producto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbCliente);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(878, 69);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Pedido";
            // 
            // tbCliente
            // 
            tbCliente.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCliente.Location = new Point(479, 28);
            tbCliente.Multiline = true;
            tbCliente.Name = "tbCliente";
            tbCliente.Size = new Size(247, 29);
            tbCliente.TabIndex = 25;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(180, 28);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 29);
            dtpFecha.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(127, 32);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 1;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(415, 32);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 2;
            label3.Text = "Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(904, 38);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(348, 8);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 1;
            label1.Text = "Registro de Pedidos";
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Visible = false;
            // 
            // Producto
            // 
            Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Costo
            // 
            Costo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Costo.HeaderText = "Costo";
            Costo.Name = "Costo";
            // 
            // ISV
            // 
            ISV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ISV.HeaderText = "ISV";
            ISV.Name = "ISV";
            // 
            // Venta
            // 
            Venta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Venta.HeaderText = "Venta";
            Venta.Name = "Venta";
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            Subtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Goldenrod;
            btnLimpiar.FlatAppearance.BorderColor = Color.Olive;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.Olive;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = Color.White;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 25;
            btnLimpiar.Location = new Point(799, 509);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(70, 29);
            btnLimpiar.TabIndex = 27;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // RegistroPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 547);
            Controls.Add(panel1);
            Name = "RegistroPedidos";
            Text = "Registro Pedidos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosProductos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label1;
        private DateTimePicker dtpFecha;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox tbProducto;
        private TextBox tbCodProducto;
        private Label label4;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox tbVenta;
        private TextBox tbCosto;
        private TextBox tbISV;
        private DataGridView dgvPedidosProductos;
        private Label label10;
        private NumericUpDown nudCantidad;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Label label11;
        private TextBox tbTotal;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private TextBox tbCliente;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn ISV;
        private DataGridViewTextBoxColumn Venta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private FontAwesome.Sharp.IconButton btnLimpiar;
    }
}