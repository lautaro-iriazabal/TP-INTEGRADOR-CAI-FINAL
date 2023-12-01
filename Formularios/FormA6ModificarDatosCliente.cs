using Modelo;
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
    public partial class FormA6ModificarDatosCliente : Form
    {
        public string fa6a_nombre;
        public string fa6a_apellido;
        public static FormA6ModificarDatosCliente  instancia;
        public FormA6ModificarDatosCliente()
        {
            InitializeComponent();
            instancia = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdministrador formAdministrador = new FormAdministrador();
            formAdministrador.Show();
        }

        private void btnConfirmarModificacion_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormA6ModificarDatosCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCambiarDatosCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormA6BModificarCliente formModificarCliente = new FormA6BModificarCliente(txtBoxNombreClienteAModificar.Text, txtBoxApellidoClienteAModificar.Text);
            formModificarCliente.Show();

        }

        private void txtBoxNombreClienteAModificar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
