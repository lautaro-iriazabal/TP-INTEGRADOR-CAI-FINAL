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

namespace Formularios
{
    public partial class FormA5RegistrarCliente : Form
    {
        public FormA5RegistrarCliente()
        {
            InitializeComponent();
        }

        private void btnConfirmarClienteNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
                string nombre = ConsolaUtils.ValidateNombre(txtBoxNombreClienteNuevo.Text);
                string apellido = ConsolaUtils.ValidateNombre(txtBoxApellidoUsuarioNuevo.Text);
                string direccion = ConsolaUtils.ValidateVacio(txtBoxDireccionClienteNuevo.Text, "Direccion");
                string telefono = ConsolaUtils.ValidateTelefono(txtBoxTelefonoClienteNuevo.Text);
                string email = ConsolaUtils.ValidateEmail(txtBoxEmailUsuarioNuevo.Text);
                DateTime fechaNacimiento;
                
                bool esFechaValida = DateTime.TryParseExact(txtBoxFechaNacimientoClienteNuevo.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaNacimiento);

                if (!esFechaValida)
                {
                    MessageBox.Show("Fecha no válida.");
                }

                string host = ConsolaUtils.ValidateVacio(txtBoxHostClienteNuevo.Text, "Host");
                int dni = ConsolaUtils.ValidateDNI(txtBoxDNIUsuarioNuevo.Text);

                string listaErrores = "";
                listaErrores += ConsolaUtils.ValidateNombre(nombre);
                listaErrores += ConsolaUtils.ValidateNombre(apellido);
                listaErrores += ConsolaUtils.ValidateTelefono(telefono);
                listaErrores += ConsolaUtils.ValidateEmail(email);
                              

                if (listaErrores.Contains("error") || listaErrores.Contains("-1"))
                {
                    MessageBox.Show(listaErrores, "Error");
                }
                else
                {
                    ClienteWebServiceMetodoPost ClienteAgregar = new ClienteWebServiceMetodoPost();
                    ClienteAgregar.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
                    ClienteAgregar.Nombre = nombre;
                    ClienteAgregar.Apellido = apellido;
                    ClienteAgregar.Dni = Convert.ToInt32(dni);
                    ClienteAgregar.Direccion = direccion;
                    ClienteAgregar.Telefono = telefono;
                    ClienteAgregar.Email = email;
                    ClienteAgregar.FechaNacimiento = fechaNacimiento;
                    ClienteAgregar.Host = host;
                    ClientesDatos.CrearCliente(ClienteAgregar);
                    MessageBox.Show("El cliente fue registrado de forma exitosa");
                }
                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un eror durante la creacion del cliente... " + ex.Message);
            }
        }


   

        private void FormA5RegistrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarAgregarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdministrador formAdministrador = new FormAdministrador();
            formAdministrador.Show();
        }
    }
}
