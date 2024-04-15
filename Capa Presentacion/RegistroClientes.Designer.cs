namespace Capa_Presentacion
{
    partial class RegistroClientes
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
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            tbApellido = new TextBox();
            label6 = new Label();
            tbTelefono = new TextBox();
            label5 = new Label();
            tbDireccion = new TextBox();
            tbNombre = new TextBox();
            tbCodCliente = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            error = new ErrorProvider(components);
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 448);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 25;
            btnCancelar.Location = new Point(174, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 36);
            btnCancelar.TabIndex = 7;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
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
            btnLimpiar.Location = new Point(266, 340);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 36);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
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
            btnGuardar.Location = new Point(358, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 36);
            btnGuardar.TabIndex = 5;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbApellido);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbTelefono);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbDireccion);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbCodCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(622, 261);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // tbApellido
            // 
            tbApellido.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbApellido.Location = new Point(322, 112);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(276, 25);
            tbApellido.TabIndex = 10;
            tbApellido.TextChanged += tbApellido_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(322, 88);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 9;
            label6.Text = "Apellido";
            // 
            // tbTelefono
            // 
            tbTelefono.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTelefono.Location = new Point(22, 216);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(276, 25);
            tbTelefono.TabIndex = 8;
            tbTelefono.TextChanged += tbTelefono_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 192);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 7;
            label5.Text = "Telefono";
            // 
            // tbDireccion
            // 
            tbDireccion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDireccion.Location = new Point(22, 164);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(576, 25);
            tbDireccion.TabIndex = 6;
            tbDireccion.TextChanged += tbDireccion_TextChanged;
            // 
            // tbNombre
            // 
            tbNombre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNombre.Location = new Point(22, 112);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(255, 25);
            tbNombre.TabIndex = 5;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // tbCodCliente
            // 
            tbCodCliente.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCodCliente.Location = new Point(22, 60);
            tbCodCliente.Name = "tbCodCliente";
            tbCodCliente.Size = new Size(255, 25);
            tbCodCliente.TabIndex = 4;
            tbCodCliente.TextChanged += tbCodCliente_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 35);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 140);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 88);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 38);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(228, 6);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 1;
            label1.Text = "Registro de Cliente";
            // 
            // error
            // 
            error.ContainerControl = this;
            // 
            // RegistroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 441);
            Controls.Add(panel1);
            Name = "RegistroClientes";
            Text = "RegistroClientes";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox tbCodCliente;
        private TextBox tbDireccion;
        private TextBox tbNombre;
        private TextBox tbApellido;
        private Label label6;
        private TextBox tbTelefono;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private ErrorProvider error;
    }
}