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
    public partial class FrmVendedor : Form
    {
        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            FormV1RegistrarVenta formRegistrarVenta = new FormV1RegistrarVenta();
            formRegistrarVenta.ShowDialog();
            this.Hide();
        }

        private void btnVentasPorClientes_Click(object sender, EventArgs e)
        {
            FormA8V2S4VentasPorClientes formMostrarVentasPorClientes = new FormA8V2S4VentasPorClientes();
            formMostrarVentasPorClientes.ShowDialog();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

        }
    }
}
