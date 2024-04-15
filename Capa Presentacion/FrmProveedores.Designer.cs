namespace Capa_Presentacion
{
    partial class FrmProveedores
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
            btnAgregar = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            dgvProveedores = new DataGridView();
            idProveedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rTNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreEmpresaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewLinkColumn();
            Eliminar = new DataGridViewLinkColumn();
            proveedoresBindingSource = new BindingSource(components);
            panel2 = new Panel();
            label1 = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            tbBuscar = new TextBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proveedoresBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            btnAgregar.Location = new Point(644, 43);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(52, 29);
            btnAgregar.TabIndex = 10;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvProveedores);
            panel3.Location = new Point(21, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(756, 339);
            panel3.TabIndex = 9;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AutoGenerateColumns = false;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { idProveedorDataGridViewTextBoxColumn, rTNDataGridViewTextBoxColumn, nombreEmpresaDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, Modificar, Eliminar });
            dgvProveedores.DataSource = proveedoresBindingSource;
            dgvProveedores.Location = new Point(0, 0);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new Size(756, 339);
            dgvProveedores.TabIndex = 0;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            idProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor";
            idProveedorDataGridViewTextBoxColumn.HeaderText = "idProveedor";
            idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            // 
            // rTNDataGridViewTextBoxColumn
            // 
            rTNDataGridViewTextBoxColumn.DataPropertyName = "RTN";
            rTNDataGridViewTextBoxColumn.HeaderText = "RTN";
            rTNDataGridViewTextBoxColumn.Name = "rTNDataGridViewTextBoxColumn";
            // 
            // nombreEmpresaDataGridViewTextBoxColumn
            // 
            nombreEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpresa";
            nombreEmpresaDataGridViewTextBoxColumn.HeaderText = "NombreEmpresa";
            nombreEmpresaDataGridViewTextBoxColumn.Name = "nombreEmpresaDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // Modificar
            // 
            Modificar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Modificar.HeaderText = "Modificar";
            Modificar.Name = "Modificar";
            Modificar.Text = "Modificar";
            Modificar.UseColumnTextForLinkValue = true;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForLinkValue = true;
            // 
            // proveedoresBindingSource
            // 
            proveedoresBindingSource.DataSource = typeof(Capa_Dominio.Proveedores);
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 39);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(298, 6);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 3;
            label1.Text = "Proveedores";
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
            btnBuscar.Location = new Point(586, 43);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(52, 29);
            btnBuscar.TabIndex = 7;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Font = new Font("Segoe UI", 12F);
            tbBuscar.Location = new Point(95, 43);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(485, 29);
            tbBuscar.TabIndex = 6;
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnBuscar);
            Controls.Add(tbBuscar);
            Name = "FrmProveedores";
            Text = "FrmProveedores";
            Load += FrmProveedores_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)proveedoresBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAgregar;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox tbBuscar;
        private DataGridView dgvProveedores;
        private DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rTNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreEmpresaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn Modificar;
        private DataGridViewLinkColumn Eliminar;
        private BindingSource proveedoresBindingSource;
    }
}