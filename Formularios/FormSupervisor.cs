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
    public partial class FormSupervisor : Form
    {
        string idUsuario;
        public FormSupervisor(string idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FormA4S1AgregarProducto formAgregarProducto = new FormA4S1AgregarProducto();
            formAgregarProducto.ShowDialog();
            this.Hide();
        }

        private void btnDevolverVenta_Click(object sender, EventArgs e)
        {
            FormS2DevolverVenta formDevolverVenta = new FormS2DevolverVenta(idUsuario);
            formDevolverVenta.ShowDialog();
            this.Hide();
        }

        private void btnMostrarStockCritico_Click(object sender, EventArgs e)
        {
            FormA7S3MostrarStockCritico formMostrarStockCritico = new FormA7S3MostrarStockCritico();
            formMostrarStockCritico.ShowDialog();
            this.Hide();

        }

        private void btnVentasPorClientes_Click(object sender, EventArgs e)
        {
            FormA8V2S4VentasPorClientes formVentasPorClientes = new FormA8V2S4VentasPorClientes();
            formVentasPorClientes.ShowDialog();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnProductosMasVendidosPorCategoria_Click(object sender, EventArgs e)
        {
            FormA9S5ProductosMasVendidosPorCategoria formProductosMasVendidosPorCategoria = new FormA9S5ProductosMasVendidosPorCategoria();
            formProductosMasVendidosPorCategoria.ShowDialog();
            this.Hide();
        }

        private void FormSupervisor_Load(object sender, EventArgs e)
        {

        }
    }
}
