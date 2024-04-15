namespace Capa_Presentacion
{
    partial class RegistroProveedor
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
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            tbTelefono = new TextBox();
            label5 = new Label();
            tbDireccion = new TextBox();
            tbNombre = new TextBox();
            tbRTN = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            btnCancelar.Location = new Point(199, 362);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 36);
            btnCancelar.TabIndex = 12;
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
            btnLimpiar.Location = new Point(291, 362);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 36);
            btnLimpiar.TabIndex = 11;
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
            btnGuardar.Location = new Point(383, 362);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 36);
            btnGuardar.TabIndex = 10;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbTelefono);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbDireccion);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbRTN);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(37, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(622, 261);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Empresa";
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
            tbNombre.Size = new Size(576, 25);
            tbNombre.TabIndex = 5;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // tbRTN
            // 
            tbRTN.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbRTN.Location = new Point(22, 60);
            tbRTN.Name = "tbRTN";
            tbRTN.Size = new Size(276, 25);
            tbRTN.TabIndex = 4;
            tbRTN.TextChanged += tbRTN_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 35);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 1;
            label2.Text = "RTN";
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
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(709, 38);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(229, 8);
            label1.Name = "label1";
            label1.Size = new Size(219, 25);
            label1.TabIndex = 1;
            label1.Text = "Registro de Proveedores";
            // 
            // RegistroProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 425);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "RegistroProveedor";
            Text = "RegistroProveedor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private GroupBox groupBox1;
        private TextBox tbTelefono;
        private Label label5;
        private TextBox tbDireccion;
        private TextBox tbNombre;
        private TextBox tbRTN;
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Label label1;
    }
}