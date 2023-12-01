namespace Formularios
{
    partial class FormSupervisor
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
            lblLogueadoComoSupervisor = new Label();
            btnAgregarProducto = new Button();
            btnDevolverVenta = new Button();
            btnVentasPorClientes = new Button();
            btnProductosMasVendidosPorCategoria = new Button();
            btnMostrarStockCritico = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lblLogueadoComoSupervisor
            // 
            lblLogueadoComoSupervisor.AutoSize = true;
            lblLogueadoComoSupervisor.Location = new Point(22, 19);
            lblLogueadoComoSupervisor.Margin = new Padding(6, 0, 6, 0);
            lblLogueadoComoSupervisor.Name = "lblLogueadoComoSupervisor";
            lblLogueadoComoSupervisor.Size = new Size(310, 32);
            lblLogueadoComoSupervisor.TabIndex = 0;
            lblLogueadoComoSupervisor.Text = "Logueado Como Supervisor";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(104, 90);
            btnAgregarProducto.Margin = new Padding(6, 6, 6, 6);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(280, 77);
            btnAgregarProducto.TabIndex = 1;
            btnAgregarProducto.Text = "1. Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnDevolverVenta
            // 
            btnDevolverVenta.Location = new Point(104, 179);
            btnDevolverVenta.Margin = new Padding(6, 6, 6, 6);
            btnDevolverVenta.Name = "btnDevolverVenta";
            btnDevolverVenta.Size = new Size(280, 77);
            btnDevolverVenta.TabIndex = 2;
            btnDevolverVenta.Text = "2. Devolver Venta";
            btnDevolverVenta.UseVisualStyleBackColor = true;
            btnDevolverVenta.Click += btnDevolverVenta_Click;
            // 
            // btnVentasPorClientes
            // 
            btnVentasPorClientes.Location = new Point(448, 90);
            btnVentasPorClientes.Margin = new Padding(6, 6, 6, 6);
            btnVentasPorClientes.Name = "btnVentasPorClientes";
            btnVentasPorClientes.Size = new Size(299, 107);
            btnVentasPorClientes.TabIndex = 3;
            btnVentasPorClientes.Text = "4. Mostrar Ventas por Clientes";
            btnVentasPorClientes.UseVisualStyleBackColor = true;
            btnVentasPorClientes.Click += btnVentasPorClientes_Click;
            // 
            // btnProductosMasVendidosPorCategoria
            // 
            btnProductosMasVendidosPorCategoria.Location = new Point(448, 239);
            btnProductosMasVendidosPorCategoria.Margin = new Padding(6, 6, 6, 6);
            btnProductosMasVendidosPorCategoria.Name = "btnProductosMasVendidosPorCategoria";
            btnProductosMasVendidosPorCategoria.Size = new Size(299, 107);
            btnProductosMasVendidosPorCategoria.TabIndex = 4;
            btnProductosMasVendidosPorCategoria.Text = "5. Productos Mas Vendidos Por Categoria";
            btnProductosMasVendidosPorCategoria.UseVisualStyleBackColor = true;
            btnProductosMasVendidosPorCategoria.Click += btnProductosMasVendidosPorCategoria_Click;
            // 
            // btnMostrarStockCritico
            // 
            btnMostrarStockCritico.Location = new Point(104, 269);
            btnMostrarStockCritico.Margin = new Padding(6, 6, 6, 6);
            btnMostrarStockCritico.Name = "btnMostrarStockCritico";
            btnMostrarStockCritico.Size = new Size(280, 77);
            btnMostrarStockCritico.TabIndex = 5;
            btnMostrarStockCritico.Text = "3. Mostrar Stock Critico";
            btnMostrarStockCritico.UseVisualStyleBackColor = true;
            btnMostrarStockCritico.Click += btnMostrarStockCritico_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(607, 418);
            btnCerrarSesion.Margin = new Padding(6, 6, 6, 6);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(247, 77);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // FormSupervisor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 521);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnMostrarStockCritico);
            Controls.Add(btnProductosMasVendidosPorCategoria);
            Controls.Add(btnVentasPorClientes);
            Controls.Add(btnDevolverVenta);
            Controls.Add(btnAgregarProducto);
            Controls.Add(lblLogueadoComoSupervisor);
            Margin = new Padding(6, 6, 6, 6);
            Name = "FormSupervisor";
            Text = "FormSupervisor";
            Load += FormSupervisor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogueadoComoSupervisor;
        private Button btnAgregarProducto;
        private Button btnDevolverVenta;
        private Button btnVentasPorClientes;
        private Button btnProductosMasVendidosPorCategoria;
        private Button btnMostrarStockCritico;
        private Button btnCerrarSesion;
    }
}