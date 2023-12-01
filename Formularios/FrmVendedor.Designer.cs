namespace Formularios
{
    partial class FrmVendedor
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
            btnRegistrarVenta = new Button();
            btnVentasPorClientes = new Button();
            btnCerrarSesion = new Button();
            lblLogueadoComoVendedor = new Label();
            SuspendLayout();
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(338, 133);
            btnRegistrarVenta.Margin = new Padding(5);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(229, 46);
            btnRegistrarVenta.TabIndex = 0;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // btnVentasPorClientes
            // 
            btnVentasPorClientes.Location = new Point(338, 206);
            btnVentasPorClientes.Name = "btnVentasPorClientes";
            btnVentasPorClientes.Size = new Size(229, 46);
            btnVentasPorClientes.TabIndex = 1;
            btnVentasPorClientes.Text = "Ventas por Clientes";
            btnVentasPorClientes.UseVisualStyleBackColor = true;
            btnVentasPorClientes.Click += btnVentasPorClientes_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(728, 365);
            btnCerrarSesion.Margin = new Padding(5);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(195, 46);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblLogueadoComoVendedor
            // 
            lblLogueadoComoVendedor.AutoSize = true;
            lblLogueadoComoVendedor.Location = new Point(70, 45);
            lblLogueadoComoVendedor.Name = "lblLogueadoComoVendedor";
            lblLogueadoComoVendedor.Size = new Size(297, 32);
            lblLogueadoComoVendedor.TabIndex = 3;
            lblLogueadoComoVendedor.Text = "Logueado como Vendedor";
            // 
            // FrmVendedor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 435);
            Controls.Add(lblLogueadoComoVendedor);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnVentasPorClientes);
            Controls.Add(btnRegistrarVenta);
            Margin = new Padding(5);
            Name = "FrmVendedor";
            Text = "FrmVendedor";
            Load += FrmVendedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarVenta;
        private Button btnVentasPorClientes;
        private Button btnCerrarSesion;
        private Label lblLogueadoComoVendedor;
    }
}