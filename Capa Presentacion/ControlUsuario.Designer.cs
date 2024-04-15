namespace Capa_Presentacion
{
    partial class ControlUsuario
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
            panel2 = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            label1 = new Label();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbTipo = new ComboBox();
            tbConfPassword = new TextBox();
            tbPassword = new TextBox();
            tbTelefono = new TextBox();
            tbUsername = new TextBox();
            usuarioBindingSource = new BindingSource(components);
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 408);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cbTipo);
            panel2.Controls.Add(tbConfPassword);
            panel2.Controls.Add(tbPassword);
            panel2.Controls.Add(tbTelefono);
            panel2.Controls.Add(tbUsername);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 12F);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 408);
            panel2.TabIndex = 1;
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
            btnCancelar.Location = new Point(147, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 36);
            btnCancelar.TabIndex = 9;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(588, 43);
            panel3.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(227, 6);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 5;
            label1.Text = "USUARIOS";
           
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
            btnLimpiar.Location = new Point(240, 318);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 36);
            btnLimpiar.TabIndex = 8;
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
            btnGuardar.Location = new Point(331, 318);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 36);
            btnGuardar.TabIndex = 6;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(39, 172);
            label6.Name = "label6";
            label6.Size = new Size(98, 21);
            label6.TabIndex = 10;
            label6.Text = "Tipo Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(316, 117);
            label5.Name = "label5";
            label5.Size = new Size(164, 21);
            label5.TabIndex = 9;
            label5.Text = "Confirmar Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(316, 60);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 8;
            label4.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(39, 117);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 7;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(39, 61);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(39, 196);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(232, 29);
            cbTipo.TabIndex = 4;
            // 
            // tbConfPassword
            // 
            tbConfPassword.Location = new Point(316, 140);
            tbConfPassword.Name = "tbConfPassword";
            tbConfPassword.Size = new Size(232, 29);
            tbConfPassword.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(316, 84);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(232, 29);
            tbPassword.TabIndex = 2;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(39, 140);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(232, 29);
            tbTelefono.TabIndex = 1;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(39, 84);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(232, 29);
            tbUsername.TabIndex = 0;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Capa_Dominio.Usuario);
            // 
            // ControlUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 408);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ControlUsuario";
            Text = "Control de Usuario";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox tbConfPassword;
        private TextBox tbPassword;
        private TextBox tbTelefono;
        private TextBox tbUsername;
        private ComboBox cbTipo;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private BindingSource usuarioBindingSource;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
    }
}