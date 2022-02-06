using System.Web;
using System.Web.Mvc;

namespace WebMetrixPe.FiltersAttributes
{
    public class FilterSession : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Controller controller = filterContext.Controller as Controller;
            if (controller != null)
            {
                HttpSessionStateBase session = filterContext.HttpContext.Session;
                if (session["sesion"] == null)
                {
                    filterContext.Result = new RedirectToRouteResult(
                            new System.Web.Routing.RouteValueDictionary {{ "Controller", "Account" },
                                { "Action", "Logout" } });
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
}