using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Newtonsoft.Json.Linq;

namespace Formularios
{
    public partial class FormA6BModificarCliente : Form
    {
        public string nombre1;
        public string apellido1;
        public static FormA6BModificarCliente instancia;
        public static JToken id_local;

        public FormA6BModificarCliente(string nombre, string apellido)
        {
            InitializeComponent();
            instancia = this;
            nombre1 = nombre;
            apellido1 = apellido;
            this.label1.Text = nombre1;
            this.label2.Text = apellido1;
            id_local = Cliente.ObtenerClientePorNombre(nombre1, apellido1);
            //Lo que falta aca es la conexion con el swagger para que despues, a partir de matchear nombre y apellido, se tome el ID del cliente, y una vez hecho eso, se pueden modificar sus datos, como el email o telefono.
        }

        private void FormA6BModificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormA6ModificarDatosCliente formModificarDatosCliente = new FormA6ModificarDatosCliente();

            formModificarDatosCliente.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
