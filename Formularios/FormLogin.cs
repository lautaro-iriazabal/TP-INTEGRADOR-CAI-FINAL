using Form1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Formularios
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*';
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Realizar validaciones de datos del usuario y contraseña
            String usuario = textUsuario.Text;
            String password = textPassword.Text;

            if (!(usuario.Length > 0 && password.Length > 0))
            {
                MessageBox.Show("Debe de ingresar un usuario y contraseña correcto");
            }

            // Hacer el login
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            String idUsuario = usuarioNegocio.LogIn(usuario, password).Replace("\"", "");
            
            if (idUsuario == "null")
            {
                MessageBox.Show("El usuario o contraseña ingresados no son correctos") ;
            }
            else
            {
                // Obtener el perfil
                int perfil = usuarioNegocio.ObtenerPerfil(idUsuario);

                // Ir al formulario que corresponde
                this.Hide();
                if (perfil == 1)
                {
                    FormAdministrador formAdministrador = new FormAdministrador();
                    formAdministrador.ShowDialog();
                }
                else if (perfil == 3)
                {
                    FrmVendedor formVendedor = new FrmVendedor();
                    formVendedor.ShowDialog();
                }
                else
                {
                    FormSupervisor formSupervisor = new FormSupervisor(idUsuario);
                    formSupervisor.ShowDialog();
                }
            }
           
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
