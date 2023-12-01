using Formularios;
using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;


namespace Form1
{
    public partial class FormA1AgregarUsuario : Form
    {
        public FormA1AgregarUsuario()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnConfirmarUsuarioNuevo_Click(object sender, EventArgs e)
        {
            
            string idUsuario = Guid.NewGuid().ToString();
            int host = ConsolaUtils.ValidateHost(txtBoxHostUsuarioNuevo.Text);
            string telefono = txtBoxTelefonoUsuarioNuevo.Text;
            string email = txtBoxEmailUsuarioNuevo.Text;
            string fechaNacimiento = txtBoxFechaNacUsuarioAAgregar.Text;
            string nombreUsuario = txtBoxUsuarioNuevo.Text;
            string contrasenia = txtBoxContraseñaUsuarioAAgregar.Text;
            DateTime fechaSalida = DateTime.Now;
            string nombre = ConsolaUtils.ValidateNombre(txtBoxNombreUsuarioNuevo.Text);
            string apellido = ConsolaUtils.ValidateNombre(txtBoxApellidoUsuarioNuevo.Text);           
            string dni = txtBoxHostUsuarioNuevo.Text;
            string direccion = txtBoxDireccionUsuarioNuevo.Text;

            string listaErrores = "";
            //listaErrores += ConsolaUtils.ValidateVacio(host);
            listaErrores += ConsolaUtils.ValidateNombre(nombre);
            listaErrores += ConsolaUtils.ValidateNombre(apellido);
            listaErrores += ConsolaUtils.ValidateDNI(dni);
            listaErrores += ConsolaUtils.ValidateTelefono(telefono);
            listaErrores += ConsolaUtils.ValidateEmail(email);
            listaErrores += ConsolaUtils.ValidateFechaNacimiento(fechaNacimiento);
            listaErrores += ConsolaUtils.ValidateVacio(nombreUsuario, "Nombre De Usuario");
            listaErrores += ConsolaUtils.ValidateVacio(contrasenia, "Contraseña");


            if (listaErrores.Contains("error")||listaErrores.Contains("-1"))
            {
                MessageBox.Show(listaErrores, "Error");
            }
            //Si no hay errores, creo el usuario en swagger y llamo al método con la ruta POST

            else
            {
                UsuarioWebServiceMetodoPost usuSwagger = new UsuarioWebServiceMetodoPost();
                usuSwagger.IdUsuario = idUsuario;
                usuSwagger.Host = host;
                usuSwagger.Nombre = nombre;
                usuSwagger.Apellido = apellido;
                usuSwagger.Dni = Convert.ToInt32(dni);
                usuSwagger.Direccion = direccion;
                usuSwagger.Telefono = telefono;
                usuSwagger.Email = email;
                usuSwagger.FechaNac = fechaNacimiento;
                usuSwagger.NombreUsuario = nombreUsuario;
                usuSwagger.Contrasenia = contrasenia;


                UsuarioNegocio.CrearUsuario(usuSwagger);
                MessageBox.Show("Se creó el usuario exitosamente.");


            }

        }

        private void FormA1AgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdministrador formAdministrador = new FormAdministrador();
            formAdministrador.Show();
        }
    }




}
