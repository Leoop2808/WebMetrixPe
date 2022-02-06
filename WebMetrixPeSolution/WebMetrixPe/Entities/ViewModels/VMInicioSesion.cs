using System.ComponentModel.DataAnnotations;
using System.Net;

namespace WebMetrixPe.Entities.ViewModels
{
    public class VMInicioSesion
    {
        [Required(ErrorMessage = "Campo usuario es obligatorio.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Campo clave es obligatoria.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public HttpStatusCode codigoHttp { get; set; }
        public string Error { get; set; }
        public bool RememberMe { get; set; }
        public string UrlReturn { get; set; }
    }
}