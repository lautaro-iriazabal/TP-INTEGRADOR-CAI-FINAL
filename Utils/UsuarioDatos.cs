using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using Modelo;
using System.Reflection.PortableExecutable;

namespace Utils
{
    public class UsuarioDatos
    {
        public string LogIn(string nombreUsuario, string password)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();

            map.Add("nombreUsuario", nombreUsuario);
            map.Add("contraseña", password);
            string respuesta;

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Post("Usuario/Login", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                 respuesta= "null";
            }
            else
            {
                var reader = new StreamReader(response.Content.ReadAsStream());

                 respuesta = reader.ReadToEnd();
            }
            

            return respuesta;
        }

        public List<UsuarioWS> ObtenerListaUsuarios()
        {
            // Trae todos los usuarios activos
            String IdUsuarioMaster = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            string content = "";
            HttpResponseMessage response = WebHelper.Get($"Usuario/TraerUsuariosActivos?id={IdUsuarioMaster}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                content = response.Content.ReadAsStringAsync().Result;
            }

            var reader = new StreamReader(response.Content.ReadAsStream());
            List<UsuarioWS> respuesta = JsonConvert.DeserializeObject<List<UsuarioWS>>(reader.ReadToEnd());

            return respuesta;
        }


        public static string ActualizarContrasenia(string nombreUsuario, string contraseña, string contraseñaNueva)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("nombreUsuario", nombreUsuario);
            map.Add("contraseña", contraseña);
            map.Add("contraseñaNueva", contraseñaNueva);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch("Usuario/CambiarContraseña", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

            var reader = new StreamReader(response.Content.ReadAsStream());

            String respuesta = reader.ReadToEnd();

            return respuesta;
        }

        public void BorrarUsuario(string idUsuario)
        {
            String IdUsuarioMaster = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";

            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idUsuario);
            map.Add("idUsuario", IdUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Usuario/BajaUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Revise los datos ingresados");
            }
        }

        public static void CrearUsuario(UsuarioWebServiceMetodoPost usuario)
        {
            var jsonRequest = JsonConvert.SerializeObject(usuario);

            HttpResponseMessage response = WebHelper.Post("Usuario/AgregarUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                
                Console.WriteLine(response.StatusCode.ToString());
            }
            else
            {
                Console.WriteLine("Usuario agregado exitosamente.");
            }

        }

        public static void InactivarUsuario(string idUsuario, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idUsuario);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Usuario/BajaUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
        }
        public static void ReactivarUsuario(string idUsuario, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idUsuario);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch("Usuario/ReactivarUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
        }
    }
}


