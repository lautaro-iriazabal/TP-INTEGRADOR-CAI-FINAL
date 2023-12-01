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
    public partial class FormS1AgregarProducto : Form
    {
        public FormS1AgregarProducto()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener datos desde los TextBox
                int categoria = int.Parse(txtBoxCategoriaProductoNuevo.Text);
                string nombreProducto = ConsolaUtils.ValidateNombre(txtBoxNombreProductoNuevo.Text);
                int precio = int.Parse(txtBoxPrecioProductoNuevo.Text);
                int stock = int.Parse(txtBoxStockProdAAgregar.Text);
                string nombreProveedor = ConsolaUtils.ValidateNombre(txtBoxNombreProveedorProdAAgregar.Text);
                string apellidoProveedor = ConsolaUtils.ValidateNombre(txtBoxApellidoProveedorProdAAgregar.Text);

                // Validar nombre de proveedor
                string nombre = ConsolaUtils.ValidateNombre(nombreProveedor);
                string apellido = ConsolaUtils.ValidateNombre(apellidoProveedor);

                // Obtener proveedor desde la base de datos
                JToken proveedor = Proveedor.ObtenerProveedorPorNombre(nombre, apellido);

                if (proveedor == null)
                {
                    // Mostrar mensaje en TextBox en caso de error
                    MessageBox.Show("El proveedor ingresado no fue encontrado en la base de datos");
                }
                else
                {
                    // Registrar producto
                    string idProveedor = proveedor["id"].ToString();
                    Producto.RegistrarProducto(categoria, idProveedor, nombreProducto, precio, stock);

                    // Mostrar mensaje en MessageBox en caso de éxito
                    MessageBox.Show("Producto agregado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch (FormatException ex)
            {
                // Mostrar mensaje en TextBox en caso de error de formato
                MessageBox.Show("Error de formato: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Mostrar mensaje en TextBox en caso de otro tipo de error
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void FormS1AgregarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
