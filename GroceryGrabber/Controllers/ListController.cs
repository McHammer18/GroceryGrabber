using GroceryGrabber.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GroceryGrabber.Controllers
{
    public class ListController : Controller
    {
        private GroceryContext context { get; set; }
        public ListController(GroceryContext ctx)
        {
            context = ctx;
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
            return View("CreateList", new GroceryViewModel());
        }

        [HttpPost]
        public IActionResult Create(GroceryViewModel list)
        {
            if (ModelState.IsValid)
            {
                //var groceryList = new GroceryViewModel
                //{
                //    item1 = list.item1,
                //    item2 = list.item2,
                //    item3 = list.item3,
                //};
                context.groceryViewModels.Add(list);
                context.SaveChanges();
                return RedirectToAction("Open");
            }
            else
            {
                return View("EditList");
            }
        }

    }
}
