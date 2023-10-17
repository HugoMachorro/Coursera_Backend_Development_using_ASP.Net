using forms.Models;
using Microsoft.AspNetCore.Mvc;

namespace forms.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult WeeklyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost(string username, string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();
        }

        public IActionResult StronglyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginSuccess(LoginViewModel login)
        {
            if (login.Username != null && login.Password != null)
            {
                if (login.Username.Equals("admin") && login.Password.Equals("admin"))
                {
                    ViewBag.Message = "Soy un Administrador";
                    return View();
                }
            }

            ViewBag.Message = "No soy un administrador";
            return View();

        }

        public IActionResult UserDetails()
        {
            var user = new LoginViewModel()
            {
                Username = "Hugo",
                Password = "abcd0123"
            };
            return View(user);
        }

        public IActionResult UserList()
        {
            var users = new List<LoginViewModel>()
            {
                new LoginViewModel() {Username = "Hugo",
                Password = "abcd0123"},

                new LoginViewModel() {Username = "Andres",
                Password = "abcd01234"},

                new LoginViewModel() {Username = "Machorro",
                Password = "abcdef012345"},

            };
            return View(users);
        }

        public IActionResult GetAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostAccount()
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }

            return RedirectToAction("GetAccount");
            
        }
    }
}
