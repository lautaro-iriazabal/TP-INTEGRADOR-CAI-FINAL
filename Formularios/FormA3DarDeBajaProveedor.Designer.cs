namespace Form1
{
    partial class FormA3DarDeBajaProveedor
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
            lblDProveedorABorrar = new Label();
            txtBoxNombreProovedorADarDeBaja = new TextBox();
            btnConfirmarBajaDeProveedor = new Button();
            lblDarDeBajaUnProveedor = new Label();
            btnVolverAtras = new Button();
            lbl = new Label();
            txtBoxApellidoProveedorABorrar = new TextBox();
            SuspendLayout();
            // 
            // lblDProveedorABorrar
            // 
            lblDProveedorABorrar.AutoSize = true;
            lblDProveedorABorrar.Location = new Point(75, 317);
            lblDProveedorABorrar.Margin = new Padding(6, 0, 6, 0);
            lblDProveedorABorrar.Name = "lblDProveedorABorrar";
            lblDProveedorABorrar.Size = new Size(566, 32);
            lblDProveedorABorrar.TabIndex = 26;
            lblDProveedorABorrar.Text = "Ingresar el nombre del proveedor que quiera borrar";
            // 
            // txtBoxNombreProovedorADarDeBaja
            // 
            txtBoxNombreProovedorADarDeBaja.Location = new Point(682, 310);
            txtBoxNombreProovedorADarDeBaja.Margin = new Padding(6, 7, 6, 7);
            txtBoxNombreProovedorADarDeBaja.Name = "txtBoxNombreProovedorADarDeBaja";
            txtBoxNombreProovedorADarDeBaja.Size = new Size(249, 39);
            txtBoxNombreProovedorADarDeBaja.TabIndex = 24;
            // 
            // btnConfirmarBajaDeProveedor
            // 
            btnConfirmarBajaDeProveedor.Location = new Point(741, 677);
            btnConfirmarBajaDeProveedor.Margin = new Padding(6, 7, 6, 7);
            btnConfirmarBajaDeProveedor.Name = "btnConfirmarBajaDeProveedor";
            btnConfirmarBajaDeProveedor.Size = new Size(353, 69);
            btnConfirmarBajaDeProveedor.TabIndex = 32;
            btnConfirmarBajaDeProveedor.Text = "Confirmar Baja de Proveedor";
            btnConfirmarBajaDeProveedor.UseVisualStyleBackColor = true;
            btnConfirmarBajaDeProveedor.Click += btnConfirmarBajaDeProveedor_Click;
            // 
            // lblDarDeBajaUnProveedor
            // 
            lblDarDeBajaUnProveedor.AutoSize = true;
            lblDarDeBajaUnProveedor.Location = new Point(429, 94);
            lblDarDeBajaUnProveedor.Margin = new Padding(6, 0, 6, 0);
            lblDarDeBajaUnProveedor.Name = "lblDarDeBajaUnProveedor";
            lblDarDeBajaUnProveedor.Size = new Size(287, 32);
            lblDarDeBajaUnProveedor.TabIndex = 33;
            lblDarDeBajaUnProveedor.Text = "Dar de baja un Proveedor";
            // 
            // btnVolverAtras
            // 
            btnVolverAtras.Location = new Point(55, 677);
            btnVolverAtras.Margin = new Padding(6, 7, 6, 7);
            btnVolverAtras.Name = "btnVolverAtras";
            btnVolverAtras.Size = new Size(353, 69);
            btnVolverAtras.TabIndex = 34;
            btnVolverAtras.Text = "Volver atras";
            btnVolverAtras.UseVisualStyleBackColor = true;
            btnVolverAtras.Click += btnVolverAtras_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(75, 401);
            lbl.Margin = new Padding(6, 0, 6, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(563, 32);
            lbl.TabIndex = 35;
            lbl.Text = "Ingrese el Apellido del proveedor que quiera borrar";
            // 
            // txtBoxApellidoProveedorABorrar
            // 
            txtBoxApellidoProveedorABorrar.Location = new Point(682, 401);
            txtBoxApellidoProveedorABorrar.Margin = new Padding(6, 7, 6, 7);
            txtBoxApellidoProveedorABorrar.Name = "txtBoxApellidoProveedorABorrar";
            txtBoxApellidoProveedorABorrar.Size = new Size(249, 39);
            txtBoxApellidoProveedorABorrar.TabIndex = 36;
            // 
            // FormA3DarDeBajaProveedor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 775);
            Controls.Add(txtBoxApellidoProveedorABorrar);
            Controls.Add(lbl);
            Controls.Add(btnVolverAtras);
            Controls.Add(lblDarDeBajaUnProveedor);
            Controls.Add(btnConfirmarBajaDeProveedor);
            Controls.Add(lblDProveedorABorrar);
            Controls.Add(txtBoxNombreProovedorADarDeBaja);
            Margin = new Padding(6, 7, 6, 7);
            Name = "FormA3DarDeBajaProveedor";
            Text = "FormA3DarDeBajaProveedor";
            Load += FormA3DarDeBajaProveedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApellidoProveedorABorrar;
        private Label lblNombreProveedorABorrar;
        private TextBox txtBoxApellidoProovedorADarDeBaja;
        private TextBox txtBoxNombreProovedorADarDeBaja;
        private Button btnConfirmarBajaDeProveedor;
        private Label lblDarDeBajaUnProveedor;
        private Label lblDProveedorABorrar;
        private TextBox txtBoxIDProovedorADarDeBaja;
        private Button btnVolverAtras;
        private Label label1;
        private TextBox textBox1;
        private Label lbl;
        private TextBox txtBoxApellidoProveedorABorrar;
    }
}