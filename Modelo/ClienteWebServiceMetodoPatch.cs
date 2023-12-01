using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClienteWebServiceMetodoPatch
    {
        private Guid _id;
        private string _direccion;
        private string _telefono;
        private string _email;



        public Guid Id { get => _id; set => _id = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }


        public string ComboDisplay { get => $"{Id} - {Direccion} - {Telefono} - {Email} "; }
    }
}
