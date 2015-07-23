using System.Web.Mvc;
using SportsStore.WebUI.Models;
using SportsStore.WebUI.Infrastructure.Abstract;

namespace SportsStore.WebUI.Controllers
{
    public class AccountController : Controller
    {
        IAuthProvider authProvider;

        public AccountController(IAuthProvider auth)
        {
            authProvider = auth;
        }

        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (authProvider.Authenticate(model.UserName, model.Password))
                {
                    // ?? called the null-coalescing operator, returns the left operand
                    // if it is not null, otherwise returns the right operand
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect user name or password");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}
