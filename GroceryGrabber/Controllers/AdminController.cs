using GroceryGrabber.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GroceryGrabber.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<UserModel> userManager;
        private GroceryContext context { get; set; }
        public AdminController(GroceryContext ctx, UserManager<UserModel> userMgr)
        {
            context = ctx;
            userManager = userMgr;
        }

        [HttpGet]
        public IActionResult AddGroceryItem()
        {
            ViewBag.Action = "Add Item";
            return View("EditGroceryItem", new GroceryItem());
        }
        [HttpGet]
        public IActionResult EditGroceryItem(int id)
        {
            ViewBag.Action = "Edit Item";
            var groceryItem = context.GroceryItems.Find(id);
            return View("EditGroceryItem", groceryItem);
        }
        public IActionResult EditGroceryItem(GroceryItem groceryItem)
        {
            if(ModelState.IsValid)
            {
                if(groceryItem.GroceryId == 0)
                {
                    context.GroceryItems.Add(groceryItem);
                }
                else
                {
                    context.GroceryItems.Update(groceryItem);
                }
                context.SaveChanges();
                return RedirectToAction("Admin");
            }
            else
            {
                ViewBag.Action = (groceryItem.GroceryId > 0) ? "AddGroceryItem" : "EditGroceryItem";
                return View();
            }
        }

        public IActionResult DeleteGroceryItem(int id)
        {
            var groceryItem = context.GroceryItems.Find(id);
            return View(groceryItem);
        }

        [HttpPost]
        public IActionResult DeleteGroceryItem(GroceryItem groceryItem)
        {
            context.GroceryItems.Remove(groceryItem);
            context.SaveChanges();
            return RedirectToAction("Admin", "Admin");
        }

        public IActionResult Admin()
        {
            var userid = userManager.GetUserId(HttpContext.User);
            var user = userManager.FindByIdAsync(userid).Result;
            ViewBag.AdminID = user.Id;
                var groceries = context.GroceryItems.OrderBy(x => x.Name).ToList();
                return View(groceries);
                
        }
    }
}
