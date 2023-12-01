using Modelo;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Formularios
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textUsuario = new TextBox();
            textPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnIniciarSesion = new Button();
            lblBienvenidoElectroHogar = new Label();
            SuspendLayout();
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(553, 145);
            textUsuario.Margin = new Padding(6, 4, 6, 4);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(201, 39);
            textUsuario.TabIndex = 0;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(553, 235);
            textPassword.Margin = new Padding(6, 4, 6, 4);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(201, 39);
            textPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 145);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 242);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(371, 345);
            btnIniciarSesion.Margin = new Padding(6, 4, 6, 4);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(202, 47);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lblBienvenidoElectroHogar
            // 
            lblBienvenidoElectroHogar.AutoSize = true;
            lblBienvenidoElectroHogar.Font = new Font("Bahnschrift SemiCondensed", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenidoElectroHogar.Location = new Point(179, 9);
            lblBienvenidoElectroHogar.Name = "lblBienvenidoElectroHogar";
            lblBienvenidoElectroHogar.Size = new Size(640, 64);
            lblBienvenidoElectroHogar.TabIndex = 5;
            lblBienvenidoElectroHogar.Text = "Bienvenido a ElectroHogar SA";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 494);
            Controls.Add(lblBienvenidoElectroHogar);
            Controls.Add(btnIniciarSesion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textPassword);
            Controls.Add(textUsuario);
            Margin = new Padding(6, 4, 6, 4);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsuario;
        private TextBox textPassword;
        private Label label1;
        private Label label2;
        private Button btnIniciarSesion;
        private Label lblBienvenidoElectroHogar;
    }
}