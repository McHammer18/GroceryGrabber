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
        public IActionResult Delete()
        {
            // Dummy Data I used setting things up. once we have a DB going can deletet this
            ViewBag.listId = new List<int>() { 1, 2, 3, 4 };
            ViewBag.listName = new List<string>() { "ListOne", "ListTwo", "ListThree", "ListFour" };
            ViewBag.numberOfItems = new List<int> { 16, 32, 70, 43 };
            ViewBag.length = ViewBag.listName.Count;
            return View("DeleteList");
        }

        public IActionResult Edit()
        {
            // Dummy Data I used setting things up. once we have a DB going can deletet this
            ViewBag.listId = new List<int>() { 1, 2, 3, 4 };
            ViewBag.listName = new List<string>() { "ListOne", "ListTwo", "ListThree", "ListFour" };
            ViewBag.numberOfItems = new List<int> { 16, 32, 70, 43 };
            ViewBag.length = ViewBag.listName.Count;
            return View("EditList");
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
