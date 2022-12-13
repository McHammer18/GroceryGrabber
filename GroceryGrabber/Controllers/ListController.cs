using GroceryGrabber.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GroceryGrabber.Controllers
{
    public class ListController : Controller
    {
        private GroceryContext context { get; set; }
        private readonly UserManager<UserModel> userManager;
        public ListController(GroceryContext ctx, UserManager<UserModel> userMgr)
        {
            context = ctx;
            userManager = userMgr;
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var list = context.GroceryViewModel.Find(id);
            ViewBag.GroceriesList = context.GroceryViewModel.OrderBy(x => x.GroceryName).ToList();
            return View("DeleteList", list);
        }

        [HttpPost]
        public IActionResult Delete(GroceryViewModel model)
        {
            context.GroceryViewModel.Remove(model);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Open()
        {
            //This is grabbing the person's list
            var itm = context.GroceryList
                 .Include(gl => gl.User)
                 .Include(gl => gl.Item)
                 .ToList();
            return View("~/Views/List/ViewGroceryList.cshtml", itm);
        }

        public IActionResult Open(int id)
        {
            //This is grabbing the person's list
            ViewBag.listId = id;
            ViewBag.itm = context.GroceryViewModel.OrderBy(x => x.GroceryName).ToList();
            return View("ViewGroceryList");
        }

        // OR Attribute that catches /create/ and rename method to CreateList
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.item = context.GroceryItems.ToList();
            var list = new GroceryViewModel();
            var userid = userManager.GetUserId(HttpContext.User);
            var user = userManager.FindByIdAsync(userid).Result;
            ViewBag.ID = user.Id;
            return View("CreateList", list);
        }

        [HttpPost]
        public async Task<IActionResult> Create(GroceryViewModel list)
        {
            context.GroceryViewModel.Add(list);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");

        }

    }
}
