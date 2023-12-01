namespace Formularios
{
    partial class FormA6BModificarCliente
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
            button1 = new Button();
            btnModificarDatosCliente = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(28, 377);
            button1.Name = "button1";
            button1.Size = new Size(157, 51);
            button1.TabIndex = 0;
            button1.Text = "Volver atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnModificarDatosCliente
            // 
            btnModificarDatosCliente.Location = new Point(570, 377);
            btnModificarDatosCliente.Name = "btnModificarDatosCliente";
            btnModificarDatosCliente.Size = new Size(218, 51);
            btnModificarDatosCliente.TabIndex = 1;
            btnModificarDatosCliente.Text = "Modificar Datos";
            btnModificarDatosCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(600, 95);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(600, 157);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 95);
            label3.Name = "label3";
            label3.Size = new Size(184, 32);
            label3.TabIndex = 4;
            label3.Text = "Nombre Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 157);
            label4.Name = "label4";
            label4.Size = new Size(184, 32);
            label4.TabIndex = 5;
            label4.Text = "Apellido Cliente";
            // 
            // FormA6BModificarCliente
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnModificarDatosCliente);
            Controls.Add(button1);
            Name = "FormA6BModificarCliente";
            Text = "FormA6BModificarCliente";
            Load += FormA6BModificarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnModificarDatosCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}