using Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Utils
{
    public class ProductosDatos
    {
        public static List<ProductoWebService> ListarProductos()
        {
            HttpResponseMessage response = WebHelper.Get("Producto/TraerProductos");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("verifique los datos ingresados");
            }
            else
            {
                var contentstream = response.Content.ReadAsStringAsync().Result;
                List<ProductoWebService> Listado = JsonConvert.DeserializeObject<List<ProductoWebService>>(contentstream);
                return Listado;
            }
        }

        public static List<ProductoWebService> ListarProductosPorCategoria(int idCategoria)
        {
            HttpResponseMessage response = WebHelper.Get("Producto/TraerProductosPorCategoria?catnum=" + idCategoria);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("verifique los datos ingresados");
            }
            else
            {
                var contentstream = response.Content.ReadAsStringAsync().Result;
                List<ProductoWebService> listadousuarios = JsonConvert.DeserializeObject<List<ProductoWebService>>(contentstream);
                return listadousuarios;
            }
        }

        public static void CrearProducto(ProductoWebServiceMetodoPost producto)
        {
            try
            {
                var jsonRequest = JsonConvert.SerializeObject(producto);

                HttpResponseMessage response = WebHelper.Post("Producto/AgregarProducto", jsonRequest);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
            catch (Exception ex)
            {
                // Aquí puedes manejar la excepción, por ejemplo, mostrando un mensaje al usuario.
               Console.Write("Ocurrió un error al crear el producto: " + ex.Message);
            }
        }


        public static void BorrarProducto(string idProducto, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idProducto);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Producto/BajaProducto", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados.");
            }

        }


        public static void EditarProducto(ProductoWebServiceMetodoPatch producto)
        {
            var jsonRequest = JsonConvert.SerializeObject(producto);

            HttpResponseMessage response = WebHelper.Patch("Producto/ModificarProducto", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode.ToString());
            }

        }



    }
}
