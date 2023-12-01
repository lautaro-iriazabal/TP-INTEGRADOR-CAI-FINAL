using Formularios;
using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Form1
{
    public partial class FormA2RegistrarProveedor : Form
    {
        public FormA2RegistrarProveedor()
        {
            InitializeComponent();
        }

        private void btnConfirmarUsuarioNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmarProveedorNuevo_Click(object sender, EventArgs e)
        {
            ProveedorWebServiceMetodoPost proveedor = new ProveedorWebServiceMetodoPost();
            // Realiza la validación de los campos.

            {
                string nombreProveedor = ConsolaUtils.ValidateNombre(txtBoxNombreProovedorNuevo.Text);
                string apellidoProveedor = ConsolaUtils.ValidateNombre(txtBoxApellidoProovedorNuevo.Text);
                string emailProveedor = ConsolaUtils.ValidateEmail(txtBoxEmailProovedorNuevo.Text);
                string cuitProveedor = ConsolaUtils.ValidateVacio(txtBoxCUITProovedorNuevo.Text, "CUIT Proveedor");
                string listaErrores = "";
                txtBoxNombreProovedorNuevo.Clear();
                txtBoxApellidoProovedorNuevo.Clear();
                txtBoxCUITProovedorNuevo.Clear();
                txtBoxEmailProovedorNuevo.Clear();

                //listaErrores += ConsolaUtils.ValidateVacio(host);
                listaErrores += ConsolaUtils.ValidateNombre(nombreProveedor);
                listaErrores += ConsolaUtils.ValidateNombre(apellidoProveedor);
                listaErrores += ConsolaUtils.ValidateEmail(emailProveedor);
                listaErrores += ConsolaUtils.ValidateCUIT(cuitProveedor);

                if (listaErrores.Contains("error") || listaErrores.Contains("-1"))
                {
                    MessageBox.Show(listaErrores, "Error");
                }



                else
                {
                    Guid idUsuario = Guid.Parse("D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
                    string Usuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
                    proveedor.IdUsuario = Usuario;
                    proveedor.Nombre = nombreProveedor;
                    proveedor.Apellido = apellidoProveedor;
                    proveedor.Email = emailProveedor;
                    proveedor.Cuit = cuitProveedor;
                    proveedor.FechaAlta = DateTime.Now;
                }

                try
                {
                    // Intenta ejecutar el método para crear el proveedor
                    ProveedoresDatos.CrearProveedor(proveedor);

                    // Si no hay excepciones, muestra un mensaje de éxito
                    MessageBox.Show(proveedor.ToString(), "Proveedor registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Si ocurre una excepción, muestra un mensaje de advertencia con detalles del error
                    MessageBox.Show($"Ocurrieron inconvenientes al intentar agregar a su proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void FormA2RegistrarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarRegistrarProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdministrador formAdministrador = new FormAdministrador();
            formAdministrador.Show();
        }
    }

}