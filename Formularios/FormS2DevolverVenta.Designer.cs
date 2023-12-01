namespace Formularios
{
    partial class FormS2DevolverVenta
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
            lblNombreClienteDevolverVenta = new Label();
            lblApellidoClienteDevolverVenta = new Label();
            label3 = new Label();
            txtBoxNombreClienteDevolverVenta = new TextBox();
            txtBoxApellidoClienteDevolverVenta = new TextBox();
            txtBoxCantVendidaDevolverVenta = new TextBox();
            btnDevolverVenta = new Button();
            btnVolverAtras = new Button();
            SuspendLayout();
            // 
            // lblNombreClienteDevolverVenta
            // 
            lblNombreClienteDevolverVenta.AutoSize = true;
            lblNombreClienteDevolverVenta.Location = new Point(69, 77);
            lblNombreClienteDevolverVenta.Margin = new Padding(6, 0, 6, 0);
            lblNombreClienteDevolverVenta.Name = "lblNombreClienteDevolverVenta";
            lblNombreClienteDevolverVenta.Size = new Size(331, 32);
            lblNombreClienteDevolverVenta.TabIndex = 0;
            lblNombreClienteDevolverVenta.Text = "Ingrese el nombre del Cliente";
            // 
            // lblApellidoClienteDevolverVenta
            // 
            lblApellidoClienteDevolverVenta.AutoSize = true;
            lblApellidoClienteDevolverVenta.Location = new Point(69, 149);
            lblApellidoClienteDevolverVenta.Margin = new Padding(6, 0, 6, 0);
            lblApellidoClienteDevolverVenta.Name = "lblApellidoClienteDevolverVenta";
            lblApellidoClienteDevolverVenta.Size = new Size(328, 32);
            lblApellidoClienteDevolverVenta.TabIndex = 1;
            lblApellidoClienteDevolverVenta.Text = "Ingrese el apellido del cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 222);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(307, 32);
            label3.TabIndex = 2;
            label3.Text = "Ingrese la cantidad vendida";
            // 
            // txtBoxNombreClienteDevolverVenta
            // 
            txtBoxNombreClienteDevolverVenta.Location = new Point(518, 70);
            txtBoxNombreClienteDevolverVenta.Margin = new Padding(6);
            txtBoxNombreClienteDevolverVenta.Name = "txtBoxNombreClienteDevolverVenta";
            txtBoxNombreClienteDevolverVenta.Size = new Size(175, 39);
            txtBoxNombreClienteDevolverVenta.TabIndex = 3;
            // 
            // txtBoxApellidoClienteDevolverVenta
            // 
            txtBoxApellidoClienteDevolverVenta.Location = new Point(518, 143);
            txtBoxApellidoClienteDevolverVenta.Margin = new Padding(6);
            txtBoxApellidoClienteDevolverVenta.Name = "txtBoxApellidoClienteDevolverVenta";
            txtBoxApellidoClienteDevolverVenta.Size = new Size(175, 39);
            txtBoxApellidoClienteDevolverVenta.TabIndex = 4;
            // 
            // txtBoxCantVendidaDevolverVenta
            // 
            txtBoxCantVendidaDevolverVenta.Location = new Point(518, 215);
            txtBoxCantVendidaDevolverVenta.Margin = new Padding(6);
            txtBoxCantVendidaDevolverVenta.Name = "txtBoxCantVendidaDevolverVenta";
            txtBoxCantVendidaDevolverVenta.Size = new Size(175, 39);
            txtBoxCantVendidaDevolverVenta.TabIndex = 5;
            // 
            // btnDevolverVenta
            // 
            btnDevolverVenta.Location = new Point(573, 309);
            btnDevolverVenta.Margin = new Padding(6);
            btnDevolverVenta.Name = "btnDevolverVenta";
            btnDevolverVenta.Size = new Size(201, 66);
            btnDevolverVenta.TabIndex = 6;
            btnDevolverVenta.Text = "Devolver Venta";
            btnDevolverVenta.UseVisualStyleBackColor = true;
            btnDevolverVenta.Click += btnDevolverVenta_Click;
            // 
            // btnVolverAtras
            // 
            btnVolverAtras.Location = new Point(59, 309);
            btnVolverAtras.Margin = new Padding(6);
            btnVolverAtras.Name = "btnVolverAtras";
            btnVolverAtras.Size = new Size(201, 66);
            btnVolverAtras.TabIndex = 7;
            btnVolverAtras.Text = "Volver atras";
            btnVolverAtras.UseVisualStyleBackColor = true;
            btnVolverAtras.Click += btnVolverAtras_Click;
            // 
            // FormS2DevolverVenta
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 410);
            Controls.Add(btnVolverAtras);
            Controls.Add(btnDevolverVenta);
            Controls.Add(txtBoxCantVendidaDevolverVenta);
            Controls.Add(txtBoxApellidoClienteDevolverVenta);
            Controls.Add(txtBoxNombreClienteDevolverVenta);
            Controls.Add(label3);
            Controls.Add(lblApellidoClienteDevolverVenta);
            Controls.Add(lblNombreClienteDevolverVenta);
            Margin = new Padding(6);
            Name = "FormS2DevolverVenta";
            Text = "FormS2DevolverVenta";
            Load += FormS2DevolverVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreClienteDevolverVenta;
        private Label lblApellidoClienteDevolverVenta;
        private Label label3;
        private TextBox txtBoxNombreClienteDevolverVenta;
        private TextBox txtBoxApellidoClienteDevolverVenta;
        private TextBox txtBoxCantVendidaDevolverVenta;
        private Button btnDevolverVenta;
        private Button btnVolverAtras;
    }
}