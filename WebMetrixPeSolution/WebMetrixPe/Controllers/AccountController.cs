using System;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMetrixPe.Entities.ViewModels;
using WebMetrixPe.Models;

namespace WebMetrixPe.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "None")]
    public class AccountController : Controller
    {
        public ActionResult Index(string urlReturn)
        {
            if (Session["sesion"] != null)
            {
                return Redirect(FormsAuthentication.DefaultUrl);
            }
            clearSession();
            Session.Abandon();
            FormsAuthentication.SignOut();
            var modelo = new VMInicioSesion() { UrlReturn = urlReturn };
            return View("Login", modelo);
        }
        public ActionResult Logout()
        {
            clearSession();
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
        private void clearSession()
        {
            Session["sesion"] = null;

            Session.RemoveAll();
            Session.Remove(FormsAuthentication.FormsCookieName);
            if (Response.Cookies[FormsAuthentication.FormsCookieName] != null)
            {
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName);
                cookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(cookie);
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(VMInicioSesion model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            AccountModel accountModel = new AccountModel();
            var responseModel = accountModel.Login(model.Username, model.Password);
            if (responseModel.codigo == HttpStatusCode.OK)
            {
                DateTime expires = DateTime.Now.AddDays(30);
                var authTicket = new FormsAuthenticationTicket(1, model.Username, DateTime.Now, expires, false, "", "/");
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(authTicket));
                Response.Cookies.Add(cookie);
                Session["sesion"] = responseModel.data;

                if (String.IsNullOrEmpty(model.UrlReturn))
                {
                    return Redirect(FormsAuthentication.DefaultUrl);
                }
                else
                {
                    return Redirect($"~/{model.UrlReturn}");
                }
            }
            else
            {
                model.codigoHttp = responseModel.codigo;
                model.Error = responseModel.mensaje;

                return View("Login", model);
            }
        }
    }
}