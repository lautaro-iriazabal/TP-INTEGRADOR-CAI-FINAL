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
    public partial class FormA8V2S4VentasPorClientes : Form
    {
        public FormA8V2S4VentasPorClientes()
        {
            InitializeComponent();
            MostrarVentaPorClientes();
        }
        private void MostrarVentaPorClientes()
        {
            string clientes = Cliente.ObtenerListaClientes();
            JArray arrayClientes = JArray.Parse(clientes);

            string nombreClienteMasVentas = "";
            string apellidoClienteMasVentas = "";
            int maxVentas = 0;

            foreach (JObject clienteJson in arrayClientes)
            {
                string idCliente = clienteJson["id"].Value<string>();
                string nombre = clienteJson["nombre"].Value<string>();
                string apellido = clienteJson["apellido"].Value<string>();
                string ventasPorCliente = Venta.ObtenerVentasPorCliente(idCliente);
                JArray arrayVentas = JArray.Parse(ventasPorCliente);

                if (arrayVentas.Count > 0)
                {
                    lstBoxVentasPorClientes.Items.Add($"Cliente {nombre} {apellido}");
                    lstBoxVentasPorClientes.Items.Add("Ventas realizadas:");
                    foreach (JObject venta in arrayVentas)
                    {
                        string idVenta = venta["id"].Value<string>();
                        int cantidad = venta["cantidad"].Value<int>();
                        lstBoxVentasPorClientes.Items.Add($"Id Venta: {idVenta} \nCantidad vendida: {cantidad}");
                    }
                    lstBoxVentasPorClientes.Items.Add("");
                    if (arrayVentas.Count > maxVentas)
                    {
                        maxVentas = arrayVentas.Count;
                        nombreClienteMasVentas = nombre;
                        apellidoClienteMasVentas = apellido;
                    }
                }
            }
            MessageBox.Show($"El cliente que más ventas realizó es {nombreClienteMasVentas} {apellidoClienteMasVentas} con {maxVentas} ventas");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }




}
