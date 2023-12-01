namespace Formularios
{
    partial class FormA8V2S4VentasPorClientes
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
            lblVentasRealizadasPorCliente = new Label();
            lblClienteConMasVentas = new Label();
            lstBoxVentasPorClientes = new ListBox();
            btnVolverAtras = new Button();
            SuspendLayout();
            // 
            // lblVentasRealizadasPorCliente
            // 
            lblVentasRealizadasPorCliente.AutoSize = true;
            lblVentasRealizadasPorCliente.Location = new Point(375, 47);
            lblVentasRealizadasPorCliente.Margin = new Padding(6, 0, 6, 0);
            lblVentasRealizadasPorCliente.Name = "lblVentasRealizadasPorCliente";
            lblVentasRealizadasPorCliente.Size = new Size(751, 32);
            lblVentasRealizadasPorCliente.TabIndex = 0;
            lblVentasRealizadasPorCliente.Text = "Ventas Realizadas por Cliente, con su ID de venta y Cantidad Vendida";
            // 
            // lblClienteConMasVentas
            // 
            lblClienteConMasVentas.AutoSize = true;
            lblClienteConMasVentas.Location = new Point(375, 79);
            lblClienteConMasVentas.Margin = new Padding(6, 0, 6, 0);
            lblClienteConMasVentas.Name = "lblClienteConMasVentas";
            lblClienteConMasVentas.Size = new Size(324, 32);
            lblClienteConMasVentas.TabIndex = 1;
            lblClienteConMasVentas.Text = "El cliente con mas ventas es: ";
            // 
            // lstBoxVentasPorClientes
            // 
            lstBoxVentasPorClientes.FormattingEnabled = true;
            lstBoxVentasPorClientes.ItemHeight = 32;
            lstBoxVentasPorClientes.Location = new Point(72, 150);
            lstBoxVentasPorClientes.Name = "lstBoxVentasPorClientes";
            lstBoxVentasPorClientes.Size = new Size(814, 740);
            lstBoxVentasPorClientes.TabIndex = 2;
            lstBoxVentasPorClientes.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnVolverAtras
            // 
            btnVolverAtras.Location = new Point(1089, 844);
            btnVolverAtras.Name = "btnVolverAtras";
            btnVolverAtras.Size = new Size(150, 46);
            btnVolverAtras.TabIndex = 3;
            btnVolverAtras.Text = "Volver atras";
            btnVolverAtras.UseVisualStyleBackColor = true;
            btnVolverAtras.Click += btnVolverAtras_Click;
            // 
            // FormA8V2S4VentasPorClientes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(btnVolverAtras);
            Controls.Add(lstBoxVentasPorClientes);
            Controls.Add(lblClienteConMasVentas);
            Controls.Add(lblVentasRealizadasPorCliente);
            Margin = new Padding(6);
            Name = "FormA8V2S4VentasPorClientes";
            Text = "FormA8VentasPorClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVentasRealizadasPorCliente;
        private Label lblClienteConMasVentas;
        private ListBox lstBoxVentasPorClientes;
        private Button btnVolverAtras;
    }
}