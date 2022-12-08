using GroceryGrabber.Controllers;
using Castle.Core.Logging;
using GroceryGrabber.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace Grocery_Test
{
    [TestClass]
    public class HomeControllerTest
    {

        [TestMethod]
        public void Index_Happy()
        {
            //Arange
            var logger = new Mock<ILogger<HomeController>>();
            var ctx = new Mock<GroceryContext>();
            var usrmgr = new Mock<UserManager<UserModel>>();
    
            List<GroceryViewModel> lst = new List<GroceryViewModel>()
            {
                new GroceryViewModel() {GroceryID = 1, UserID = "1", GroceryName = "First List", item1 = "Bread", item2 = "Milk", item3 ="Cereal"},
                new GroceryViewModel() {GroceryID = 2, UserID = "1", GroceryName = "Second List", item1 = "Green Beans", item2 = "Tea", item3 ="Pizza", item4 = "Hamburger"}
            };

            

            HomeController ctrl = new HomeController(ctx.Object, usrmgr.Object);

            //Action
            var result = ctrl.Index();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var vr = result as ViewResult;
            Assert.IsInstanceOfType(vr.Model, typeof(List<GroceryViewModel>));
            var mdl = vr.Model as List<GroceryViewModel>;
            Assert.AreEqual(2, mdl.Count());
        }
    }
}