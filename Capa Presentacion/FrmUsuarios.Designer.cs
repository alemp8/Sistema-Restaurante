namespace Capa_Presentacion
{
    partial class FrmUsuarios
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
            dgvUsuarios = new DataGridView();
            idUsuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            confirmarpassDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewLinkColumn();
            Eliminar = new DataGridViewLinkColumn();
            usuarioBindingSource = new BindingSource(components);
            panel2 = new Panel();
            btnInicio = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            tbBuscar = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
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
            panel1.Location = new Point(0, -2);
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
            panel3.Controls.Add(dgvUsuarios);
            panel3.Location = new Point(19, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(756, 339);
            panel3.TabIndex = 4;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.BackgroundColor = Color.WhiteSmoke;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { idUsuarioDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, confirmarpassDataGridViewTextBoxColumn, Modificar, Eliminar });
            dgvUsuarios.DataSource = usuarioBindingSource;
            dgvUsuarios.GridColor = SystemColors.MenuText;
            dgvUsuarios.Location = new Point(0, 0);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(756, 339);
            dgvUsuarios.TabIndex = 3;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            idUsuarioDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            idUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario";
            idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            usernameDataGridViewTextBoxColumn.HeaderText = "username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            passwordDataGridViewTextBoxColumn.HeaderText = "password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // confirmarpassDataGridViewTextBoxColumn
            // 
            confirmarpassDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            confirmarpassDataGridViewTextBoxColumn.DataPropertyName = "confirmarpass";
            confirmarpassDataGridViewTextBoxColumn.HeaderText = "confirmarpass";
            confirmarpassDataGridViewTextBoxColumn.Name = "confirmarpassDataGridViewTextBoxColumn";
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
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Capa_Dominio.Usuario);
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Controls.Add(btnInicio);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 39);
            panel2.TabIndex = 2;
            // 
            // btnInicio
            // 
            btnInicio.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            btnInicio.IconColor = Color.White;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.IconSize = 35;
            btnInicio.Location = new Point(3, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(62, 42);
            btnInicio.TabIndex = 5;
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(344, 7);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 3;
            label1.Text = "Usuarios";
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
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Panel panel3;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn confirmarpassDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn Modificar;
        private DataGridViewLinkColumn Eliminar;
        private BindingSource usuarioBindingSource;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnInicio;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox tbBuscar;
    }
}