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
    public partial class FormA9S5ProductosMasVendidosPorCategoria : Form
    {
        public FormA9S5ProductosMasVendidosPorCategoria()
        {
            InitializeComponent();
            MostrarProductosMasVendidos();
        }

        private void MostrarProductosMasVendidos()
        {
            listBox1.Items.Clear();


            listBox1.Items.Add("Categoría 1:");
            listBox1.Items.Add("Nombre: Parlante JBL");
            listBox1.Items.Add("Cantidad vendida: 55 unidades");
            listBox1.Items.Add("");

            listBox1.Items.Add("Categoría 2:");
            listBox1.Items.Add("Nombre: Iphone 14");
            listBox1.Items.Add("Cantidad vendida: 102 unidades");
            listBox1.Items.Add("");

            listBox1.Items.Add("Categoría 3:");
            listBox1.Items.Add("Nombre: Lavarropas Drean");
            listBox1.Items.Add("Cantidad vendida: 40 unidades");
            listBox1.Items.Add("");

            listBox1.Items.Add("Categoría 4:");
            listBox1.Items.Add("Nombre: Notebook Lenovo");
            listBox1.Items.Add("Cantidad vendida: 87 unidades");
            listBox1.Items.Add("");

            listBox1.Items.Add("Categoría 5:");
            listBox1.Items.Add("Nombre: Samsung 42 pulgadas 4K");
            listBox1.Items.Add("Cantidad vendida: 43 unidades");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblCantVendidaProdMasVendidoCat4_Click(object sender, EventArgs e)
        {

        }

        private void FormA9S5ProductosMasVendidosPorCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
