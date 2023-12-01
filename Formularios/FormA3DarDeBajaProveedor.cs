using Formularios;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Form1
{
    public partial class FormA3DarDeBajaProveedor : Form
    {
        public FormA3DarDeBajaProveedor()
        {
            InitializeComponent();
        }

        private void btnConfirmarBajaDeProveedor_Click(object sender, EventArgs e)
        {      
                string nombre = ConsolaUtils.ValidateNombre(txtBoxNombreProovedorADarDeBaja.Text);
                string apellido = ConsolaUtils.ValidateNombre(txtBoxApellidoProveedorABorrar.Text);
                string listaErrores = "";

                listaErrores += ConsolaUtils.ValidateNombre(nombre);
                listaErrores += ConsolaUtils.ValidateNombre(apellido);

                if (listaErrores.Contains("error") || listaErrores.Contains("-1"))
                {
                    MessageBox.Show(listaErrores, "Error");
                }
                else
                {
                    Proveedor.DarDeBajaProveedor(nombre, apellido);
                    MessageBox.Show("Proveedor dado de baja correctamente");
                }
        }

        private void FormA3DarDeBajaProveedor_Load(object sender, EventArgs e)
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
