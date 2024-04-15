namespace Capa_Presentacion
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            btnUsuarios = new Button();
            btnProveedores = new Button();
            btnClientes = new Button();
            btnProducto = new Button();
            btnCombo = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnProducto);
            panel1.Controls.Add(btnCombo);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 454);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.Red;
            btnUsuarios.FlatAppearance.BorderColor = Color.Yellow;
            btnUsuarios.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = SystemColors.ButtonFace;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.Location = new Point(629, 55);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(142, 130);
            btnUsuarios.TabIndex = 14;
            btnUsuarios.Text = "\r\nUsuarios";
            btnUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnPedido_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.Red;
            btnProveedores.FlatAppearance.BorderColor = Color.Yellow;
            btnProveedores.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = SystemColors.ButtonFace;
            btnProveedores.Image = (Image)resources.GetObject("btnProveedores.Image");
            btnProveedores.Location = new Point(181, 55);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(142, 130);
            btnProveedores.TabIndex = 13;
            btnProveedores.Text = "\r\nProveedor";
            btnProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click_1;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Red;
            btnClientes.FlatAppearance.BorderColor = Color.Yellow;
            btnClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = SystemColors.ButtonFace;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.Location = new Point(31, 55);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(142, 130);
            btnClientes.TabIndex = 12;
            btnClientes.Text = "\r\nClientes";
            btnClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click_1;
            // 
            // btnProducto
            // 
            btnProducto.BackColor = Color.Red;
            btnProducto.FlatAppearance.BorderColor = Color.Yellow;
            btnProducto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducto.ForeColor = SystemColors.ButtonFace;
            btnProducto.Image = (Image)resources.GetObject("btnProducto.Image");
            btnProducto.Location = new Point(331, 55);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(142, 130);
            btnProducto.TabIndex = 10;
            btnProducto.Text = "\r\nProductos";
            btnProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProducto.UseVisualStyleBackColor = false;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnCombo
            // 
            btnCombo.BackColor = Color.Red;
            btnCombo.FlatAppearance.BorderColor = Color.Yellow;
            btnCombo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCombo.ForeColor = SystemColors.ButtonFace;
            btnCombo.Image = (Image)resources.GetObject("btnCombo.Image");
            btnCombo.Location = new Point(480, 55);
            btnCombo.Name = "btnCombo";
            btnCombo.Size = new Size(142, 130);
            btnCombo.TabIndex = 9;
            btnCombo.Text = "\r\nPedidos";
            btnCombo.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCombo.UseVisualStyleBackColor = false;
            btnCombo.Click += btnCombo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 39);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(325, 6);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 3;
            label1.Text = "Menu Principal";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(804, 454);
            panel3.TabIndex = 15;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 451);
            Controls.Add(panel1);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnCombo;
        private Button btnProducto;
        private Button btnProveedores;
        private Button btnClientes;
        private Button btnUsuarios;
        private Panel panel3;
    }
}