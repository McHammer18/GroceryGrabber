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
            ViewBag.GroceriesList = context.GroceryViewModel.OrderBy(x => x.GroceryName).ToList();
            return View();
        }
    }
}