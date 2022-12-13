using GroceryGrabber.Models;
using GroceryGrabber.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GroceryGrabber.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<UserModel> userManager;
        private IGroceryRepository groceryRepository;
        public AdminController(IGroceryRepository repo, UserManager<UserModel> userMgr)
        {
            groceryRepository = repo;
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
            var groceryItem = groceryRepository.Find(id);
            return View("EditGroceryItem", groceryItem);
        }
        public IActionResult EditGroceryItem(GroceryItem groceryItem)
        {
            if(ModelState.IsValid)
            {
                if(groceryItem.GroceryId == 0)
                {
                    groceryRepository.InsertGroceryItem(groceryItem);
                }
                else
                {
                    groceryRepository.UpdateGroceryItem(groceryItem);
                }
                groceryRepository.Save();
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
            var groceryItem = groceryRepository.Find(id);
            return View(groceryItem);
        }

        [HttpPost]
        public IActionResult DeleteGroceryItem(GroceryItem groceryItem)
        {
            groceryRepository.DeleteGroceryItem(groceryItem);
            return RedirectToAction("Admin", "Admin");
        }

        public IActionResult Admin()
        {
            var userid = userManager.GetUserId(HttpContext.User);
            var user = userManager.FindByIdAsync(userid).Result;
            ViewBag.AdminID = user.Id;
            var groceries = groceryRepository.GetAllItems();
                return View(groceries);
                
        }
    }
}
