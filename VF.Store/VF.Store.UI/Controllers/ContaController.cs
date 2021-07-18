using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using VF.Store.Data.EF;
using VF.Store.UI.Infraestrutura;
using VF.Store.UI.Models;

namespace VF.Store.UI.Controllers
{
    public class ContaController : Controller
    {
        private readonly VFStoreDataContext _ctx = new VFStoreDataContext();

        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            var model = new LoginVM(){ReturnUrl = returnUrl};
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            var usuario = _ctx.Usuarios.FirstOrDefault(u => u.Email.ToLower() == model.Email.ToLower());

            if (usuario == null)
                ModelState.AddModelError("Email", "Este email não foi localizado");
            else
            {
                if (usuario.Senha != model.Senha.Encrypt())
                    ModelState.AddModelError("Senha", "Senha cadastrada é inválida");
            }

            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.Email, model.PermanecerLogado);

                if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);
                }

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}
