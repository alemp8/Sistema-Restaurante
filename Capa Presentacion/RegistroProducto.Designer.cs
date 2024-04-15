namespace Capa_Presentacion
{
    partial class RegistroProducto
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
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            tbISV = new TextBox();
            label7 = new Label();
            tbStock = new TextBox();
            label6 = new Label();
            tbPrecioCompra = new TextBox();
            label5 = new Label();
            tbPrecioVenta = new TextBox();
            tbNombre = new TextBox();
            tbCodigo = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 448);
            panel1.TabIndex = 1;
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
            groupBox1.Controls.Add(tbISV);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbStock);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbPrecioCompra);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbPrecioVenta);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbCodigo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(622, 261);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos ";
            // 
            // tbISV
            // 
            tbISV.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbISV.Location = new Point(317, 164);
            tbISV.Name = "tbISV";
            tbISV.Size = new Size(276, 25);
            tbISV.TabIndex = 12;
            tbISV.TextChanged += tbISV_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(317, 140);
            label7.Name = "label7";
            label7.Size = new Size(33, 21);
            label7.TabIndex = 11;
            label7.Text = "ISV";
            // 
            // tbStock
            // 
            tbStock.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStock.Location = new Point(317, 216);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(276, 25);
            tbStock.TabIndex = 10;
            tbStock.TextChanged += tbStock_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(317, 192);
            label6.Name = "label6";
            label6.Size = new Size(47, 21);
            label6.TabIndex = 9;
            label6.Text = "Stock";
            // 
            // tbPrecioCompra
            // 
            tbPrecioCompra.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrecioCompra.Location = new Point(22, 164);
            tbPrecioCompra.Name = "tbPrecioCompra";
            tbPrecioCompra.Size = new Size(276, 25);
            tbPrecioCompra.TabIndex = 8;
            tbPrecioCompra.TextChanged += tbPrecioCompra_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 140);
            label5.Name = "label5";
            label5.Size = new Size(113, 21);
            label5.TabIndex = 7;
            label5.Text = "Precio Compra";
            // 
            // tbPrecioVenta
            // 
            tbPrecioVenta.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrecioVenta.Location = new Point(22, 216);
            tbPrecioVenta.Name = "tbPrecioVenta";
            tbPrecioVenta.Size = new Size(276, 25);
            tbPrecioVenta.TabIndex = 6;
            tbPrecioVenta.TextChanged += tbPrecioVenta_TextChanged;
            // 
            // tbNombre
            // 
            tbNombre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNombre.Location = new Point(22, 112);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(571, 25);
            tbNombre.TabIndex = 5;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // tbCodigo
            // 
            tbCodigo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCodigo.Location = new Point(22, 60);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(276, 25);
            tbCodigo.TabIndex = 4;
            tbCodigo.TextChanged += tbCodigo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 35);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 192);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 3;
            label4.Text = "Precio Venta";
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
            panel2.Size = new Size(654, 38);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(228, 6);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 1;
            label1.Text = "Registro de Productos";
            // 
            // RegistroProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 444);
            Controls.Add(panel1);
            Name = "RegistroProducto";
            Text = "RegistroProducto";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private GroupBox groupBox1;
        private TextBox tbStock;
        private Label label6;
        private TextBox tbPrecioCompra;
        private Label label5;
        private TextBox tbPrecioVenta;
        private TextBox tbNombre;
        private TextBox tbCodigo;
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Label label1;
        private TextBox tbISV;
        private Label label7;
    }
}