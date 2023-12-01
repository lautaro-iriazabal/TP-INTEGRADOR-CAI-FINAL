using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProductoWebServiceMetodoPatch
    {

        private string _id, idUsuario, _nombre, _apellido, _email, _cuit;


        public string Id { get => _id; set => _id = value; }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public string Cuit { get => _cuit; set => _cuit = value; }
    }
}
