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

namespace Formularios
{
    public partial class FormA7S3MostrarStockCritico : Form
    {
        public FormA7S3MostrarStockCritico()
        {
            InitializeComponent();
        }

        private void lstBoxStockCritico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void AñadirProductoAlaLista(string producto)
        {
            lstBoxStockCritico.Items.Add(producto);
        }

        private void FormA7S3MostrarStockCritico_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnMostrarStockCritico_Click(object sender, EventArgs e)
        {
            Dictionary<int, List<(string Nombre, int Stock)>> productosAgrupados = new Dictionary<int, List<(string, int)>>();
            int productosConStrockCritico = 0;
            List<JToken> listaProductosConStrockCritico = new List<JToken>();
            if (productosConStrockCritico > 0)
            {
                foreach (JToken producto in listaProductosConStrockCritico)
                {
                    string nombreProducto = producto["nombre"].Value<string>();
                    int idCategoria = producto["idCategoria"].Value<int>();
                    int stock = Producto.ObtenerStock(nombreProducto);

                    if (!productosAgrupados.ContainsKey(idCategoria))
                    {
                        productosAgrupados[idCategoria] = new List<(string, int)>();
                    }

                    productosAgrupados[idCategoria].Add((nombreProducto, stock));
                }

                foreach (var categoriaProductos in productosAgrupados)
                {
                    int idCategoria = categoriaProductos.Key;
                    string mensaje = $"Productos en stock crítico de categoría {idCategoria}:\n";

                    foreach (var producto in categoriaProductos.Value)
                    {
                        mensaje += $"  Nombre: {producto.Nombre}, Stock: {producto.Stock}\n";

                        // Agregar a ListBox
                        lstBoxStockCritico.Items.Add($"Categoría {idCategoria}: {producto.Nombre}, Stock: {producto.Stock}");
                    }

                    mensaje += "\n";
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                MessageBox.Show("No hay productos con stock crítico");
            }
        }
    }


}
