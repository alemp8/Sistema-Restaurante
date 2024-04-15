namespace Capa_Presentacion
{
    partial class FrmProductos
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            dgvProductos = new DataGridView();
            idProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioCompraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iSVDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioVentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewLinkColumn();
            Eliminar = new DataGridViewLinkColumn();
            productosBindingSource = new BindingSource(components);
            panel2 = new Panel();
            label1 = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            tbBuscar = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productosBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Location = new Point(1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 455);
            panel1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightSeaGreen;
            btnAgregar.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.Cyan;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            btnAgregar.IconColor = Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 25;
            btnAgregar.Location = new Point(642, 48);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(52, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvProductos);
            panel3.Location = new Point(19, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(756, 339);
            panel3.TabIndex = 4;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.BackgroundColor = Color.WhiteSmoke;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { idProductoDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn, precioCompraDataGridViewTextBoxColumn, iSVDataGridViewTextBoxColumn, precioVentaDataGridViewTextBoxColumn, Modificar, Eliminar });
            dgvProductos.DataSource = productosBindingSource;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.GridColor = SystemColors.MenuText;
            dgvProductos.Location = new Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(756, 339);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            idProductoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            idProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto";
            idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // precioCompraDataGridViewTextBoxColumn
            // 
            precioCompraDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            precioCompraDataGridViewTextBoxColumn.DataPropertyName = "PrecioCompra";
            precioCompraDataGridViewTextBoxColumn.HeaderText = "PrecioCompra";
            precioCompraDataGridViewTextBoxColumn.Name = "precioCompraDataGridViewTextBoxColumn";
            // 
            // iSVDataGridViewTextBoxColumn
            // 
            iSVDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            iSVDataGridViewTextBoxColumn.DataPropertyName = "ISV";
            iSVDataGridViewTextBoxColumn.HeaderText = "ISV";
            iSVDataGridViewTextBoxColumn.Name = "iSVDataGridViewTextBoxColumn";
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            precioVentaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            precioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta";
            precioVentaDataGridViewTextBoxColumn.HeaderText = "PrecioVenta";
            precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            // 
            // Modificar
            // 
            Modificar.ActiveLinkColor = Color.FromArgb(0, 192, 0);
            Modificar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Modificar.HeaderText = "Modificar";
            Modificar.LinkColor = Color.FromArgb(0, 192, 0);
            Modificar.Name = "Modificar";
            Modificar.ReadOnly = true;
            Modificar.Resizable = DataGridViewTriState.True;
            Modificar.Text = "Modificar";
            Modificar.UseColumnTextForLinkValue = true;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.LinkColor = Color.Red;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForLinkValue = true;
            // 
            // productosBindingSource
            // 
            productosBindingSource.DataSource = typeof(Capa_Dominio.Productos);
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 39);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(344, 7);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 3;
            label1.Text = "Productos";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LimeGreen;
            btnBuscar.FlatAppearance.BorderColor = Color.SeaGreen;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 25;
            btnBuscar.Location = new Point(584, 48);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(52, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Font = new Font("Segoe UI", 12F);
            tbBuscar.Location = new Point(93, 48);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(485, 29);
            tbBuscar.TabIndex = 0;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productosBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Panel panel3;
        private DataGridView dgvProductos;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox tbBuscar;
        private DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioCompraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iSVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn Modificar;
        private DataGridViewLinkColumn Eliminar;
        private BindingSource productosBindingSource;
    }
}