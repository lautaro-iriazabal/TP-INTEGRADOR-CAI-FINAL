namespace Formularios
{
    partial class FormA7S3MostrarStockCritico
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
            lblProductosStockCritico = new Label();
            lstBoxStockCritico = new ListBox();
            btnVolverAtras = new Button();
            btnMostrarStockCritico = new Button();
            SuspendLayout();
            // 
            // lblProductosStockCritico
            // 
            lblProductosStockCritico.AutoSize = true;
            lblProductosStockCritico.FlatStyle = FlatStyle.Popup;
            lblProductosStockCritico.Location = new Point(141, 33);
            lblProductosStockCritico.Margin = new Padding(6, 0, 6, 0);
            lblProductosStockCritico.Name = "lblProductosStockCritico";
            lblProductosStockCritico.Size = new Size(1055, 32);
            lblProductosStockCritico.TabIndex = 0;
            lblProductosStockCritico.Text = "Productos Con Stock en Nivel Critico. Estos productos se encuentran por debajo del 25% de stock";
            // 
            // lstBoxStockCritico
            // 
            lstBoxStockCritico.FormattingEnabled = true;
            lstBoxStockCritico.ItemHeight = 32;
            lstBoxStockCritico.Location = new Point(141, 132);
            lstBoxStockCritico.Name = "lstBoxStockCritico";
            lstBoxStockCritico.Size = new Size(1043, 420);
            lstBoxStockCritico.TabIndex = 1;
            lstBoxStockCritico.SelectedIndexChanged += lstBoxStockCritico_SelectedIndexChanged;
            // 
            // btnVolverAtras
            // 
            btnVolverAtras.Location = new Point(141, 574);
            btnVolverAtras.Name = "btnVolverAtras";
            btnVolverAtras.Size = new Size(221, 63);
            btnVolverAtras.TabIndex = 2;
            btnVolverAtras.Text = "Volver atrás";
            btnVolverAtras.UseVisualStyleBackColor = true;
            btnVolverAtras.Click += btnVolverAtras_Click;
            // 
            // btnMostrarStockCritico
            // 
            btnMostrarStockCritico.Location = new Point(925, 574);
            btnMostrarStockCritico.Name = "btnMostrarStockCritico";
            btnMostrarStockCritico.Size = new Size(259, 63);
            btnMostrarStockCritico.TabIndex = 3;
            btnMostrarStockCritico.Text = "Mostrar Stock critico";
            btnMostrarStockCritico.UseVisualStyleBackColor = true;
            btnMostrarStockCritico.Click += btnMostrarStockCritico_Click;
            // 
            // FormA7S3MostrarStockCritico
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 649);
            Controls.Add(btnMostrarStockCritico);
            Controls.Add(btnVolverAtras);
            Controls.Add(lstBoxStockCritico);
            Controls.Add(lblProductosStockCritico);
            Margin = new Padding(6);
            Name = "FormA7S3MostrarStockCritico";
            Text = "FormA7MostrarStockCritico";
            Load += FormA7S3MostrarStockCritico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductosStockCritico;
        private ListBox lstBoxStockCritico;
        private Button btnVolverAtras;
        private Button btnMostrarStockCritico;
    }
}