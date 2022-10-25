using GroceryGrabber.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GroceryGrabber.Controllers
{


    public class HomeController : Controller
    {
        private GroceryContext context { get; set; }
        public HomeController(GroceryContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var groceries = context.GroceryItems.OrderBy(x => x.Name).ToList();
            return View(groceries);
        }

        public IActionResult Register()
        {
            return View("~/Views/Authentication/Register.cshtml");
        }


        public IActionResult Logout()
        {
            return View("~/Views/Authentication/Login.cshtml");
        }
    }
}