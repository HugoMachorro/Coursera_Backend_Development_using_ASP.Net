using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index_session()
        {
            return View();
        }

        public IActionResult Login()
        {
            HttpContext.Session.SetString("username", "Hugo");
            return RedirectToAction("Success");
        }

        public IActionResult Success() {
        ViewBag.Username = HttpContext.Session.GetString("username");
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return View("Index_session");
        }

        public IActionResult QueryTest()
        {
            string name = "Hugo Andrés";
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"]))
            {
                name = HttpContext.Request.Query["name"];
            }
            ViewBag.Name = name;
            return View();
        }
    }
}
