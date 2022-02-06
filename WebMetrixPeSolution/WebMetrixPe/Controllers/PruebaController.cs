using System.Web.Mvc;
using WebMetrixPe.FiltersAttributes;

namespace WebMetrixPe.Controllers
{
    [Authorize]
    public class PruebaController : Controller
    {
        [FilterSession]
        public ActionResult Index()
        {
            return View("PruebaIndex");
        }
    }
}