using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UsuarioWebServiceMetodoPost
    {
        private string idUsuario, nombre, apellido, direccion, telefono, email, nombreUsuario, contrasenia;
        private int host, dni;
        private string fechaNac;

        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public int Host { get => host; set => host = value; }
        public int Dni { get => dni; set => dni = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
    }
}
