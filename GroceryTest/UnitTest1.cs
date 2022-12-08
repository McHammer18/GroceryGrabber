using System.Net.Sockets;
using System.Xml.Schema;
using GroceryGrabber.Controllers;
using GroceryGrabber.Migrations;
using GroceryGrabber.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;

namespace GroceryTest
{
    public class UnitTest1
    {
        [Fact]
        public void listCreationTest()
        {
            //Arange
            //var logger = new Mock<ILogger<ListController>>();
            var ulMock = new Mock<GroceryViewModel>();
            List<GroceryViewModel> lst = new List<GroceryViewModel>()
            {
                new GroceryViewModel() {GroceryID = 1, UserID = "1", GroceryName="Test List", item1="turkey", item2="grapes", item3="oatmeal", item4="tissues"},
                new GroceryViewModel() {GroceryID = 2, UserID = "2", GroceryName="Test List Two", item1="ham", item2="crackers", item3="cheese whiz", item4="mini diet-coke"}
            };

            //ulMock.Setup(r => r.Create(new GroceryViewModel()).Returns(lst);

            ListController ctrl = new ListController(GroceryContext, userMgr );

            //action
            var result = ctrl.Index("all");

            

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var vr = result as ViewResult;
            Assert.IsInstanceOfType(vr.Model, typeof(List<UsersLists>));
            var mdl = vr.Model as List<UsersLists>;
            Assert.AreEqual(2, mdl.Count());

        }
    }

    //home controller test
}