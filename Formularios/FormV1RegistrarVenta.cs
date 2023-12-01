using Negocio;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Formularios
{
    public partial class FormV1RegistrarVenta : Form
    {
        public FormV1RegistrarVenta()
        {
            InitializeComponent();
        }
        static int productosConStrockCritico = 0;
        static List<JToken> listaProductosConStrockCritico = new List<JToken>();
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {

                string nombreCliente = ConsolaUtils.ValidateNombre(txtBoxNombreClienteVentaRegistrada.Text);
                string apellidoCliente = ConsolaUtils.ValidateNombre(txtBoxApellidoClienteVentaRegistrada.Text);
                string nombreUsuario = ConsolaUtils.ValidateVacio(txtBoxUsuarioVentaRegistrada.Text, "Nombre Usuario");
                string nombreProducto = ConsolaUtils.ValidateVacio(txtBoxNombreProductoVentaRegistrada.Text, "Nombre Producto");

                JToken cliente = Cliente.ObtenerClientePorNombre(nombreCliente, apellidoCliente);
                JToken usuario = UsuarioNegocio.ObtenerUsuarioPorNombre(nombreUsuario);
                JToken producto = Producto.ObtenerProductoPorNombre(nombreProducto);

                if (cliente != null && usuario != null && producto != null)
                {

                    string idCliente = cliente["id"].Value<string>();
                    string idUsuario = usuario["id"].Value<string>();
                    string idProducto = producto["id"].Value<string>();

                    int stock = Producto.ObtenerStock(nombreProducto);

                    //int cantidad = ConsolaUtils.PedirIntRango($"Ingrese la cantidad. El stock disponible es {stock}", 1, stock);
                    int cantidad = ConsolaUtils.ValidateInt(txtBoxCantidadVenta.Text, "Cantidad");
                    bool ventaExitosa = Venta.RegistrarVenta(idCliente, idUsuario, idProducto, cantidad);
                    //Venta.MostrarResumenVenta(cliente, producto, cantidad);

                    if (ventaExitosa)
                    {
                        MessageBox.Show("Venta exitosa!");
                        if (stock - cantidad < cantidad * 0.25)
                        {
                            productosConStrockCritico += 1;
                            listaProductosConStrockCritico.Add(producto);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar la venta");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Ocurrio un error inesperado");
            }

        }
    }
}

