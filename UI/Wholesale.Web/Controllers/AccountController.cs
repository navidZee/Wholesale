using Microsoft.AspNetCore.Mvc;

namespace Wholesale.Web.Controllers
{
    public class AccountController : Controller
    {
        public AccountController() { }

        public IActionResult Login() => View();

    }
}