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

namespace Formularios
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }



        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            FormA1AgregarUsuario formAgregarUsuario = new FormA1AgregarUsuario();
            formAgregarUsuario.ShowDialog();
            this.Hide();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FormA4S1AgregarProducto formAgregarProducto = new FormA4S1AgregarProducto();
            formAgregarProducto.ShowDialog();   
            this.Hide();
        }

        private void btnVerStockCritico_Click(object sender, EventArgs e)
        {
            FormA7S3MostrarStockCritico formMostrarStockCritico = new FormA7S3MostrarStockCritico();
            formMostrarStockCritico.ShowDialog();
            this.Hide();
        }

        private void bntRegistrarProveedor_Click(object sender, EventArgs e)
        {
            FormA2RegistrarProveedor formRegistrarProveedor = new FormA2RegistrarProveedor();
            formRegistrarProveedor.ShowDialog();
            this.Hide();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            FormA5RegistrarCliente formRegistrarCliente = new FormA5RegistrarCliente();
            formRegistrarCliente.ShowDialog();
            this.Hide();
        }

        private void btnVentasPorClientes_Click(object sender, EventArgs e)
        {
            FormA8V2S4VentasPorClientes formVentasPorClientes = new FormA8V2S4VentasPorClientes();
            formVentasPorClientes.ShowDialog();
            this.Hide();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            FormA6ModificarDatosCliente formModificarCliente = new FormA6ModificarDatosCliente(); 
            formModificarCliente.ShowDialog();
            this.Hide();
        }

        private void btnProdMasVendidosPorCategoria_Click(object sender, EventArgs e)
        {
            FormA9S5ProductosMasVendidosPorCategoria formProductosMasVendidosPorCategoria = new FormA9S5ProductosMasVendidosPorCategoria();
            formProductosMasVendidosPorCategoria.ShowDialog();
            this.Hide();
                
        }

        private void btnDarDeBajaProveedor_Click(object sender, EventArgs e)
        {
            FormA3DarDeBajaProveedor formA3DarDeBajaProveedor = new FormA3DarDeBajaProveedor();
            formA3DarDeBajaProveedor.ShowDialog();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
