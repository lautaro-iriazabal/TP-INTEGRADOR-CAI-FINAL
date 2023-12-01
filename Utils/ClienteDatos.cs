using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
namespace Utils
{
    public class ClientesDatos
    {
        public static List<ClienteWebServices> ListarClientes()
        {
            HttpResponseMessage response = WebHelper.Get("Cliente/GetClientes");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("verifique los datos ingresados");
            }
            else
            {
                var contentstream = response.Content.ReadAsStringAsync().Result;
                List<ClienteWebServices> listadousuarios = JsonConvert.DeserializeObject<List<ClienteWebServices>>(contentstream);
                return listadousuarios;

            }
        }
        //CREACION CLIENTE PARA FORMS / WEB SERVICE
        public static void CrearCliente(ClienteWebServiceMetodoPost cliente)
        {
            var jsonRequest = JsonConvert.SerializeObject(cliente);

            HttpResponseMessage response = WebHelper.Post("Cliente/AgregarCliente", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
           
        }
        //BORRADO CLIENTE PARA FORMS / WEB SERVICE
        public static void BorrarCliente(string idUsuario, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idUsuario);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Cliente/BajaCliente", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados.");
            }

        }
        //EDIT CLIENTE PARA FORMS / WEB SERVICE

        public static void EditarCliente(ClienteWebServiceMetodoPatch cliente)
        {
            var jsonRequest = JsonConvert.SerializeObject(cliente);

            HttpResponseMessage response = WebHelper.Patch("Cliente/PatchCliente", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode.ToString());
            }

        }
    }


}
