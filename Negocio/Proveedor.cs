using Modelo;
using Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json.Linq;


namespace Negocio
{
    public class Proveedor
    {
        private Guid _id, _idProducto, _idUsuario;
        private string _nombre, _apellido, _email;
        private DateTime _fechaAlta;
        private int _cuit;

        public Guid Id { get => _id; set => _id = value; }
        public Guid IdProducto { get => _idProducto; set => _idProducto = value; }
        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get; set; }
        public int CUIT { get => _cuit; set => _cuit = value; }

        // Lista de proveedores registrados
        static List<Proveedor> proveedores = new List<Proveedor>();

        // Método para registrar un nuevo proveedor
        public static void RegistrarProveedor(string nombre, string apellido, string email, string cuit)
        {
            // Crear un nuevo proveedor con un ID único, el nombre, el apellido, el estado "Activo" y las categorías de productos
            ProveedorModel nuevoProveedor = new ProveedorModel(nombre, apellido, email, cuit);

            // Agregar el nuevo proveedor
            var jsonRequest = JsonConvert.SerializeObject(nuevoProveedor);
            HttpResponseMessage response = WebHelper.Post("Proveedor/AgregarProveedor", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
            else
            {
                Console.WriteLine($"El proveedor {nombre} {apellido} fue registrado con éxito");
            }
        }
       

        public static string ObtenerListaProveedores()
        {
            // Trae todos los proveedores activos
            string content = "";
            HttpResponseMessage response = WebHelper.Get($"Proveedor/TraerProveedores");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                content = response.Content.ReadAsStringAsync().Result;
            }
            return content;
        }

        public static JToken ObtenerProveedorPorNombre(string nombre, string apellido)
        {
            // Busca en los usuarios activos a un usuario por el nombre de usuario y devuelve su id
            string idProveedor = "";
            string content = ObtenerListaProveedores();
            // Analizar el contenido JSON
            JArray jsonArray = JArray.Parse(content);
            JToken proveedor = jsonArray.FirstOrDefault(item => (string)item["nombre"] == nombre && (string)item["apellido"] == apellido);

            return proveedor;
        }

        // Método para dar de baja un proveedor existente
        public static void DarDeBajaProveedor(string nombre, string apellido)
        {
            String IdUsuarioMaster = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";

            Dictionary<String, String> map = new Dictionary<String, String>(); 
            JToken proveedor = ObtenerProveedorPorNombre(nombre, apellido);
            if (proveedor == null)
            {
                Console.WriteLine("El proveedor ingresado no fue encontrado en la base de datos");
            }
            else
            {
                string idProveedor = proveedor["id"].ToString();
                map.Add("id", idProveedor);
                map.Add("idUsuario", IdUsuarioMaster);

                var jsonRequest = JsonConvert.SerializeObject(map);

                HttpResponseMessage response = WebHelper.DeleteConBody("Proveedor/BajaProveedor", jsonRequest);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Verifique los datos ingresados");
                }
                else
                {
                    Console.WriteLine("Proveedor eliminado");
                }
            }  
        }

        public static ProveedorWebService BuscarProveedorPorId(Guid idProveedor)
        {
            return ListarProveedores().Find(proveedor => proveedor.Id == idProveedor);
        }


      

        public static Guid BuscarProveedorPorCuitYDevolverId(string cuit)
        {

            ProveedorWebService proveedorFinded = ListarProveedores().Find(p => p.Cuit == cuit);
            return proveedorFinded.Id;

        }

        public static void EliminarProveedor(string idProveedor)
        {
            string usuarioAdministrador = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            ProveedoresDatos.BorrarProveedor(idProveedor, usuarioAdministrador);
        }
        public static void CrearProveedor(ProveedorWebServiceMetodoPost usuario)
        {
            ProveedoresDatos.CrearProveedor(usuario);
        }


        public static bool ModificarProveedor(int cuit, string nuevoNombre)
        {
          

            bool check = false;
            Proveedor proveedorFinded = BuscarProveedorporCUIT(cuit);
            if (proveedorFinded != null)
            {
                proveedorFinded.Nombre = nuevoNombre;
                check = true;
            }
            else
            {
                Console.WriteLine("No se pudo hallar un Proovedor con los datos ingresados");
            }
            return check;
        }

        public static void EditarProveedor(ProveedorWebserviceMetodoPatch proveedor)
        {
            ProveedoresDatos.EditarProveedor(proveedor);
        }

        public static Proveedor BuscarProveedorporCUIT(int cuit)
        {
            return proveedores.Find(proveedor => proveedor.CUIT == cuit);
        }

        //LISTAR PROVEEDORES WEB SERVICE
        public static List<ProveedorWebService> ListarProveedores()
        {
            return ProveedoresDatos.ListarProveedores();
        }
        //REGISTRAR PROVEDOR, PERO PARA LOS FORMS
        public static void RegistrarProveedor(ProveedorWebServiceMetodoPost usuario)
        {
            ProveedoresDatos.CrearProveedor(usuario);
        }

        public static string BuscarProveedorPorCuitDevuelveString(string cuit)
        {
            ProveedorWebService proveedorFinded = ListarProveedores().Find(p => p.Cuit == cuit);
            return Convert.ToString(proveedorFinded.Id);
        }
    }
}
