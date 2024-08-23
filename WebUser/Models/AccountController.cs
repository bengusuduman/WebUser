using Microsoft.AspNetCore.Mvc;
using WebUser.DataModel;
using WebUser.Models;

namespace WebUser.Controllers
{
    public class AccountController : Controller
    {
        // Bu örnekte kullanıcı adı "admin" ve şifre "password" olarak sabitlenmiştir.
        private const string ValidUsername = "admin";
        private const string ValidPassword = "password";

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == ValidUsername && model.Password == ValidPassword)
                {
                    // Giriş başarılı, kullanıcıyı yönlendir
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    // Hatalı giriş
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }

            return View(model);
        }
    }
}
