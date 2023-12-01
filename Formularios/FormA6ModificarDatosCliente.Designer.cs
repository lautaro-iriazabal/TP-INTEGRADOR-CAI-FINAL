namespace Formularios
{
    partial class FormA6ModificarDatosCliente
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
            lblModificacionClientes = new Label();
            txtBoxNombreClienteAModificar = new TextBox();
            txtBoxApellidoClienteAModificar = new TextBox();
            lblNombreClienteAModificar = new Label();
            lblApellidoClienteAModificar = new Label();
            btnModificarEstadoCliente = new Button();
            btnCancelarModificacion = new Button();
            btnCambiarDatosCliente = new Button();
            lblIngreseNombreApellidoCliente = new Label();
            SuspendLayout();
            // 
            // lblModificacionClientes
            // 
            lblModificacionClientes.AutoSize = true;
            lblModificacionClientes.Location = new Point(12, 9);
            lblModificacionClientes.Name = "lblModificacionClientes";
            lblModificacionClientes.Size = new Size(770, 32);
            lblModificacionClientes.TabIndex = 0;
            lblModificacionClientes.Text = "Desde este formulario puede modificar los datos del cliente que desee";
            // 
            // txtBoxNombreClienteAModificar
            // 
            txtBoxNombreClienteAModificar.Location = new Point(603, 171);
            txtBoxNombreClienteAModificar.Name = "txtBoxNombreClienteAModificar";
            txtBoxNombreClienteAModificar.Size = new Size(200, 39);
            txtBoxNombreClienteAModificar.TabIndex = 1;
            txtBoxNombreClienteAModificar.TextChanged += txtBoxNombreClienteAModificar_TextChanged;
            // 
            // txtBoxApellidoClienteAModificar
            // 
            txtBoxApellidoClienteAModificar.Location = new Point(603, 298);
            txtBoxApellidoClienteAModificar.Name = "txtBoxApellidoClienteAModificar";
            txtBoxApellidoClienteAModificar.Size = new Size(200, 39);
            txtBoxApellidoClienteAModificar.TabIndex = 3;
            // 
            // lblNombreClienteAModificar
            // 
            lblNombreClienteAModificar.AutoSize = true;
            lblNombreClienteAModificar.Location = new Point(251, 171);
            lblNombreClienteAModificar.Name = "lblNombreClienteAModificar";
            lblNombreClienteAModificar.Size = new Size(184, 32);
            lblNombreClienteAModificar.TabIndex = 10;
            lblNombreClienteAModificar.Text = "Nombre Cliente";
            // 
            // lblApellidoClienteAModificar
            // 
            lblApellidoClienteAModificar.AutoSize = true;
            lblApellidoClienteAModificar.Location = new Point(251, 301);
            lblApellidoClienteAModificar.Name = "lblApellidoClienteAModificar";
            lblApellidoClienteAModificar.Size = new Size(184, 32);
            lblApellidoClienteAModificar.TabIndex = 11;
            lblApellidoClienteAModificar.Text = "Apellido Cliente";
            lblApellidoClienteAModificar.Click += label2_Click;
            // 
            // btnModificarEstadoCliente
            // 
            btnModificarEstadoCliente.Location = new Point(780, 452);
            btnModificarEstadoCliente.Name = "btnModificarEstadoCliente";
            btnModificarEstadoCliente.Size = new Size(289, 55);
            btnModificarEstadoCliente.TabIndex = 19;
            btnModificarEstadoCliente.Text = "Modificar Estado";
            btnModificarEstadoCliente.UseVisualStyleBackColor = true;
            btnModificarEstadoCliente.Click += btnConfirmarModificacion_Click;
            // 
            // btnCancelarModificacion
            // 
            btnCancelarModificacion.Location = new Point(12, 452);
            btnCancelarModificacion.Name = "btnCancelarModificacion";
            btnCancelarModificacion.Size = new Size(285, 55);
            btnCancelarModificacion.TabIndex = 20;
            btnCancelarModificacion.Text = "Cancelar Modificacion";
            btnCancelarModificacion.UseVisualStyleBackColor = true;
            btnCancelarModificacion.Click += btnCancelarModificacion_Click;
            // 
            // btnCambiarDatosCliente
            // 
            btnCambiarDatosCliente.Location = new Point(485, 456);
            btnCambiarDatosCliente.Name = "btnCambiarDatosCliente";
            btnCambiarDatosCliente.Size = new Size(289, 55);
            btnCambiarDatosCliente.TabIndex = 21;
            btnCambiarDatosCliente.Text = "Cambiar Datos";
            btnCambiarDatosCliente.UseVisualStyleBackColor = true;
            btnCambiarDatosCliente.Click += btnCambiarDatosCliente_Click;
            // 
            // lblIngreseNombreApellidoCliente
            // 
            lblIngreseNombreApellidoCliente.AutoSize = true;
            lblIngreseNombreApellidoCliente.Location = new Point(12, 41);
            lblIngreseNombreApellidoCliente.Name = "lblIngreseNombreApellidoCliente";
            lblIngreseNombreApellidoCliente.Size = new Size(702, 32);
            lblIngreseNombreApellidoCliente.TabIndex = 22;
            lblIngreseNombreApellidoCliente.Text = "Ingrese el nombre y apellido del cliente y luego elija una opcion";
            // 
            // FormA6ModificarDatosCliente
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 523);
            Controls.Add(lblIngreseNombreApellidoCliente);
            Controls.Add(btnCambiarDatosCliente);
            Controls.Add(btnCancelarModificacion);
            Controls.Add(btnModificarEstadoCliente);
            Controls.Add(lblApellidoClienteAModificar);
            Controls.Add(lblNombreClienteAModificar);
            Controls.Add(txtBoxApellidoClienteAModificar);
            Controls.Add(txtBoxNombreClienteAModificar);
            Controls.Add(lblModificacionClientes);
            Margin = new Padding(6);
            Name = "FormA6ModificarDatosCliente";
            Text = "FormA6ModificarDatosClientecs";
            Load += FormA6ModificarDatosCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModificacionClientes;
        private TextBox txtBoxNombreClienteAModificar;
        private TextBox txtBoxHostClienteAModificar;
        private TextBox txtBoxApellidoClienteAModificar;
        private TextBox txtBoxTelefonoClienteAModificar;
        private TextBox txtBoxDireccionClienteAModificar;
        private TextBox txtBoxEmailClienteAModificar;
        private TextBox txtBoxFecNacClienteAModificar;
        private TextBox txtBoxDNIClienteAModificar;
        private TextBox txtBoxIDClienteAModificar;
        private Label lblNombreClienteAModificar;
        private Label lblApellidoClienteAModificar;
        private Label lblHostClienteAModificar;
        private Label lblEmailClienteAModificar;
        private Label lblFecNacClienteAModificar;
        private Label lblDireccionClienteAModificar;
        private Label lblDNIClienteAModificar;
        private Label lblTelefonoClienteAModificar;
        private Label lblIDClienteAModificar;
        private Button btnConfirmarModificacion;
        private Button btnCancelarModificacion;
        private Button btnCambiarDatosCliente;
        private Button btnModificarEstadoCliente;
        private Label lblIngreseNombreApellidoCliente;
    }
}