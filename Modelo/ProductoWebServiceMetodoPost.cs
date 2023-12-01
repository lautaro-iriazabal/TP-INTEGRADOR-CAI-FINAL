using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProductoWebServiceMetodoPost
    {
        private string _nombre, _idUsuario, _idProveedor;
        private int _idCategoria, _stock;
        private double _precio;

        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }

        public ProductoWebServiceMetodoPost(int idCategoria, string nombre, double precio, int stock, string idUsuario, string idProveedor)
        {
            IdCategoria = idCategoria;
            IdUsuario = idUsuario;
            IdProveedor = idProveedor;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }
        public ProductoWebServiceMetodoPost()
        {

        }
    }
}
