using coreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> customers = new List<Customer>
        {
            new Customer() { Id = 1, Name="Hugo", Amount=1000},
            new Customer() { Id = 2, Name="Andres", Amount=1001},
        };

        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount = customers.Count();
            ViewBag.CustomerList = customers;
            return View();
        }

        public IActionResult IndexDemo()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount = customers.Count();
            ViewBag.CustomerList = customers;
            return View();
        }

        public IActionResult IndexDemo_viewData()
        {
            ViewData["Message"] = "Customer Management System";
            ViewData["CustomerCount"] = customers.Count();
            ViewData["CustomerList"] = customers;
            return View();
        }

        public IActionResult IndexDemo_tempData()
        {
            TempData["Message"] = "Customer Management System";
            TempData["CustomerCount"] = customers.Count();
            TempData["CustomerList"] = customers;
            return View();
        }

        public IActionResult Metodo_dos()
        {
            if (TempData["Message"] == null)
            {
                return RedirectToAction("Index");
            }
            TempData["Message"] = TempData["Message"].ToString();
            return View();

        }


        public IActionResult Details()
        {
            return View();
        }

        //[Route("~/")]
        [Route("~/sample/message")]

        public IActionResult Message()
        {
            return View();
        }




    }
}
