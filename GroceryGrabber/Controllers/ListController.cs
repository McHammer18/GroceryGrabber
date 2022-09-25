using Microsoft.AspNetCore.Mvc;

namespace GroceryGrabber.Controllers
{
    public class ListController : Controller
    {
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
            return View("~/Views/List/ViewGroceryList.cshtml");
        }
        
    }
}
