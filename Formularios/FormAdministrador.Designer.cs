namespace Formularios
{
    partial class FormAdministrador
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
            btnAgregarUsuario = new Button();
            bntRegistrarProveedor = new Button();
            btnDarDeBajaProveedor = new Button();
            btnAgregarProducto = new Button();
            btnRegistrarCliente = new Button();
            btnModificarCliente = new Button();
            btnVerStockCritico = new Button();
            btnVentasPorClientes = new Button();
            btnProdMasVendidosPorCategoria = new Button();
            lblAdministrador = new Label();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(72, 111);
            btnAgregarUsuario.Margin = new Padding(6, 7, 6, 7);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(264, 94);
            btnAgregarUsuario.TabIndex = 0;
            btnAgregarUsuario.Text = "1. Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // bntRegistrarProveedor
            // 
            bntRegistrarProveedor.Location = new Point(72, 254);
            bntRegistrarProveedor.Margin = new Padding(6, 7, 6, 7);
            bntRegistrarProveedor.Name = "bntRegistrarProveedor";
            bntRegistrarProveedor.Size = new Size(264, 106);
            bntRegistrarProveedor.TabIndex = 1;
            bntRegistrarProveedor.Text = "2. Registrar Proveedor";
            bntRegistrarProveedor.UseVisualStyleBackColor = true;
            bntRegistrarProveedor.Click += bntRegistrarProveedor_Click;
            // 
            // btnDarDeBajaProveedor
            // 
            btnDarDeBajaProveedor.Location = new Point(72, 416);
            btnDarDeBajaProveedor.Margin = new Padding(6, 7, 6, 7);
            btnDarDeBajaProveedor.Name = "btnDarDeBajaProveedor";
            btnDarDeBajaProveedor.Size = new Size(264, 98);
            btnDarDeBajaProveedor.TabIndex = 2;
            btnDarDeBajaProveedor.Text = "3. Dar de Baja Proveedor";
            btnDarDeBajaProveedor.UseVisualStyleBackColor = true;
            btnDarDeBajaProveedor.Click += btnDarDeBajaProveedor_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(449, 111);
            btnAgregarProducto.Margin = new Padding(6, 7, 6, 7);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(264, 94);
            btnAgregarProducto.TabIndex = 3;
            btnAgregarProducto.Text = "4. Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(449, 254);
            btnRegistrarCliente.Margin = new Padding(6, 7, 6, 7);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(264, 106);
            btnRegistrarCliente.TabIndex = 4;
            btnRegistrarCliente.Text = "5. Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(449, 416);
            btnModificarCliente.Margin = new Padding(6, 7, 6, 7);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(264, 98);
            btnModificarCliente.TabIndex = 5;
            btnModificarCliente.Text = "6. Modificar Cliente";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnVerStockCritico
            // 
            btnVerStockCritico.Location = new Point(821, 111);
            btnVerStockCritico.Margin = new Padding(6, 7, 6, 7);
            btnVerStockCritico.Name = "btnVerStockCritico";
            btnVerStockCritico.Size = new Size(264, 94);
            btnVerStockCritico.TabIndex = 6;
            btnVerStockCritico.Text = "7. Ver Stock Critico";
            btnVerStockCritico.UseVisualStyleBackColor = true;
            btnVerStockCritico.Click += btnVerStockCritico_Click;
            // 
            // btnVentasPorClientes
            // 
            btnVentasPorClientes.Location = new Point(821, 254);
            btnVentasPorClientes.Margin = new Padding(6, 7, 6, 7);
            btnVentasPorClientes.Name = "btnVentasPorClientes";
            btnVentasPorClientes.Size = new Size(264, 106);
            btnVentasPorClientes.TabIndex = 7;
            btnVentasPorClientes.Text = "8. Ventas Por Clientes";
            btnVentasPorClientes.UseVisualStyleBackColor = true;
            btnVentasPorClientes.Click += btnVentasPorClientes_Click;
            // 
            // btnProdMasVendidosPorCategoria
            // 
            btnProdMasVendidosPorCategoria.Location = new Point(821, 416);
            btnProdMasVendidosPorCategoria.Margin = new Padding(6, 7, 6, 7);
            btnProdMasVendidosPorCategoria.Name = "btnProdMasVendidosPorCategoria";
            btnProdMasVendidosPorCategoria.Size = new Size(264, 98);
            btnProdMasVendidosPorCategoria.TabIndex = 8;
            btnProdMasVendidosPorCategoria.Text = "9. Prod. mas Vendidos por Cat.";
            btnProdMasVendidosPorCategoria.UseVisualStyleBackColor = true;
            btnProdMasVendidosPorCategoria.Click += btnProdMasVendidosPorCategoria_Click;
            // 
            // lblAdministrador
            // 
            lblAdministrador.AutoSize = true;
            lblAdministrador.Location = new Point(26, 22);
            lblAdministrador.Margin = new Padding(6, 0, 6, 0);
            lblAdministrador.Name = "lblAdministrador";
            lblAdministrador.Size = new Size(344, 32);
            lblAdministrador.TabIndex = 9;
            lblAdministrador.Text = "Logueado como Administrador";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(973, 598);
            btnCerrarSesion.Margin = new Padding(6, 7, 6, 7);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(193, 49);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 677);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblAdministrador);
            Controls.Add(btnProdMasVendidosPorCategoria);
            Controls.Add(btnVentasPorClientes);
            Controls.Add(btnVerStockCritico);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnDarDeBajaProveedor);
            Controls.Add(bntRegistrarProveedor);
            Controls.Add(btnAgregarUsuario);
            Margin = new Padding(6, 7, 6, 7);
            Name = "FormAdministrador";
            Text = "FormAdministrador";
            Load += FormAdministrador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarUsuario;
        private Button bntRegistrarProveedor;
        private Button btnDarDeBajaProveedor;
        private Button btnAgregarProducto;
        private Button btnRegistrarCliente;
        private Button btnModificarCliente;
        private Button btnVerStockCritico;
        private Button btnVentasPorClientes;
        private Button btnProdMasVendidosPorCategoria;
        private Label lblAdministrador;
        private Button btnCerrarSesion;
    }
}