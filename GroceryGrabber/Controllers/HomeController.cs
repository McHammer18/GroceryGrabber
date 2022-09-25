using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GroceryGrabber.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Authentication/Login.cshtml");
        }

        public IActionResult Register()
        {
            return View("~/Views/Authentication/Register.cshtml");
        }

        public IActionResult DashBoard()
        {
            // Dummy Data I used setting things up. once we have a DB going can deletet this
            ViewBag.listId = new List<int>() { 1, 2, 3, 4 };
            ViewBag.listName = new List<string>() { "ListOne", "ListTwo", "ListThree", "ListFour" };
            ViewBag.numberOfItems = new List<int> { 16, 32, 70, 43 };
            ViewBag.length = ViewBag.listName.Count;

            return View("Index");
        }

        public IActionResult Create()
        {
            return View("~/Views/List/CreateList.cshtml");
        }

        public IActionResult Admin()
        {
            return View("~/Views/Admin.cshtml");
        }

        public IActionResult Logout()
        {
            return View("~/Views/Authentication/Login.cshtml");
        }
    }
}