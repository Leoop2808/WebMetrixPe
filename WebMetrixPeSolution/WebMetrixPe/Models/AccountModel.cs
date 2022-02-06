using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using WebMetrixPe.Entities.Models;

namespace WebMetrixPe.Models
{
    public class AccountModel
    {
        private int _timeOut = 5;
        private string _urlApiMetrixPe = ConfigurationManager.AppSettings["API_METRIX_PE_URL"];
        private string _credWebToApiMetrixPe = ConfigurationManager.AppSettings["API_METRIX_PE_WEB_CRED"];
        public InicioSesionResponse Login(string username, string password)
        {
            InicioSesionResponse responseMethod = new InicioSesionResponse();

            try
            {
                string urlService = "Token";
                var dataLogin = new Dictionary<string, string>
                  {
                     { "grant_type", "password" },
                     { "username", username },
                     { "password", password}
                  };

                var content = new FormUrlEncodedContent(dataLogin);
                HttpClient httpClient = new HttpClient();

                httpClient.Timeout = new TimeSpan(0, _timeOut, 0);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _credWebToApiMetrixPe);
                var responseService = httpClient.PostAsync(_urlApiMetrixPe + urlService, content).Result;

                Login_GetDataService(responseService, responseMethod);

            }
            catch (Exception)
            {
                responseMethod.codigo = HttpStatusCode.InternalServerError;
                responseMethod.mensaje = "Error en la petición de inicio de sesión.";
            }
            return responseMethod;
        }

        private void Login_GetDataService(HttpResponseMessage responseService, InicioSesionResponse responseMethod)
        {
            if (responseService.StatusCode == HttpStatusCode.OK)
            {
                using (Stream stream = responseService.Content.ReadAsStreamAsync().Result)
                {
                    using (StreamReader re = new StreamReader(stream))
                    {
                        String json = re.ReadToEnd();
                        responseMethod.data = (InicioSesionOkResponse)JsonConvert.DeserializeObject(json, typeof(InicioSesionOkResponse));
                    }
                }
            }
            else if (responseService.StatusCode == HttpStatusCode.BadRequest)
            {
                using (Stream stream = responseService.Content.ReadAsStreamAsync().Result)
                {
                    using (StreamReader re = new StreamReader(stream))
                    {
                        String json = re.ReadToEnd();
                        var dataBadRequest = (InicioSesionBadRequestResponse)JsonConvert.DeserializeObject(json, typeof(InicioSesionBadRequestResponse));
                        if (dataBadRequest.error == "invalid_grant")
                        {
                            responseMethod.mensaje = "Usuario o clave incorrectos.";
                        }
                        else
                        {
                            responseMethod.mensaje = "Error en el intento de inicio de sesión.";
                        }
                    }
                }
            }
            else
            {
                responseMethod.mensaje = "Error al iniciar sesión.";
            }
            responseMethod.codigo = responseService.StatusCode;
        }
    }
}