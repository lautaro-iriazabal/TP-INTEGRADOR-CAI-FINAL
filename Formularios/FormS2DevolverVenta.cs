using Negocio;
using Newtonsoft.Json.Linq;
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

namespace Formularios
{
    public partial class FormS2DevolverVenta : Form
    {
        public string idUsuario;
        public FormS2DevolverVenta(string idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void btnDevolverVenta_Click(object sender, EventArgs e)
        {
            //pasar atributo de un formulario a otro (idUsuario)

            try
            {
                string nombreCliente = ConsolaUtils.ValidateNombre(txtBoxNombreClienteDevolverVenta.Text);
                string apellidoCliente = ConsolaUtils.ValidateNombre(txtBoxApellidoClienteDevolverVenta.Text);

                JToken cliente = Cliente.ObtenerClientePorNombre(nombreCliente, apellidoCliente);

                if (cliente == null)
                {
                    MessageBox.Show("Alguno de los datos ingresados no existe en la base de datos");
                    return;
                }

                string idCliente = cliente["id"].Value<string>();

                int cantidad;
                if (!int.TryParse(txtBoxCantVendidaDevolverVenta.Text, out cantidad) || cantidad < 1 || cantidad > 10000000)
                {
                    MessageBox.Show("Error: La cantidad vendida debe ser un número entre 1 y 10000000.");
                    return;
                }

                bool valoresCorrectos = Venta.DevolverVenta(cantidad, idCliente, idUsuario);
                if (!valoresCorrectos)
                {
                    MessageBox.Show("Error: No se pudo procesar la devolución de la venta.");
                }
                else
                {
                    MessageBox.Show("Venta devuelta correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void FormS2DevolverVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {


            this.Hide();
            FormSupervisor formSupervisor = new FormSupervisor(idUsuario);
            formSupervisor.Show();


        }
    }
}
