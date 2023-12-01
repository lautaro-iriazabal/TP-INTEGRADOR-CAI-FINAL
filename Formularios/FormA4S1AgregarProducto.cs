using Formularios;
using Modelo;
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

namespace Form1
{
    public partial class FormA4S1AgregarProducto : Form
    {
        public FormA4S1AgregarProducto()
        {
            InitializeComponent();
        }

        private void btnConfirmarAgregarProductoNuevo_Click(object sender, EventArgs e)
        {
            int stock = Convert.ToInt32(txtBoxStockNuevoProducto.Text);
            int idCategoria = Convert.ToInt32(txtBoxCategoriaNuevoProducto.Text);
            string cuitProveedor = txtBoxCUITProveedorProductoAAgregar.Text;
            string proveedorFinded = Proveedor.BuscarProveedorPorCuitDevuelveString(cuitProveedor);
            string Usuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            string nombre = txtBoxNombreProovedorNuevoProducto.Text;
            string precio = txtBoxPrecioNuevoProducto.Text;
            string listaErrores = "";
            double precioSalida = 0;

            listaErrores += ConsolaUtils.ValidateVacio(precio, "Precio");
            listaErrores += ConsolaUtils.ValidateVacio(nombre, "Nombre");



            if (listaErrores.Contains("error") || listaErrores.Contains("-1"))
                MessageBox.Show(listaErrores, "Error");
            else
            {
                ProductoWebServiceMetodoPost ProductoAgregar = new ProductoWebServiceMetodoPost();
                ProductoAgregar.IdCategoria = idCategoria;
                ProductoAgregar.IdUsuario = Usuario;
                ProductoAgregar.IdProveedor = proveedorFinded;
                ProductoAgregar.Nombre = nombre;
                ProductoAgregar.Precio = precioSalida;
                ProductoAgregar.Stock = stock;

                Producto.CrearProducto(ProductoAgregar);

                MessageBox.Show("Se agrego el producto con exito!");


            }
        }

        private void FormA4S1AgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();

            formLogin.Show();
        }
    }
}
