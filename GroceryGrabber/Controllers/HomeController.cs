using GroceryGrabber.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GroceryGrabber.Controllers
{
    
    public class HomeController : Controller
    {
        private GroceryContext context { get; set; }
        private readonly UserManager<UserModel> userManager;
        public HomeController(GroceryContext ctx, UserManager<UserModel> userMgr)
        {
            context = ctx;
            userManager = userMgr;
        }

        public IActionResult Index()
        {
            var userid = userManager.GetUserId(HttpContext.User);
            var user = userManager.FindByIdAsync(userid).Result;

            if (ModelState.IsValid)
            {
                if (userid != null)
                {
                    ViewBag.ID = user.Id;
                    ViewBag.GroceriesList = context.GroceryViewModel.OrderBy(x => x.GroceryName).ToList();
                    return View();
                } else
                {
                    return RedirectToAction("Login", "Account");
                }
            } else
            {
                return RedirectToAction("Login", "Acccount");
            }
        }
    }
}