using System.Net;

namespace WebMetrixPe.Entities.Models
{
    public class InicioSesionResponse
    {
        public HttpStatusCode codigo { get; set; }
        public string mensaje { get; set; }
        public InicioSesionOkResponse data { get; set; }
    }
    public class InicioSesionOkResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string UserName { get; set; }
    }
    public class InicioSesionBadRequestResponse
    {
        public string error { get; set; }
        public string error_description { get; set; }
    }
}