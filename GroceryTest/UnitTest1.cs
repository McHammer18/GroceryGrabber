using System;
using System.Net.Sockets;
using System.Xml.Schema;
using GroceryGrabber.Controllers;
using GroceryGrabber.Migrations;
using GroceryGrabber.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using Moq;

namespace GroceryTest
{
    public class UnitTest1
    {
        private GroceryContext ctx;

        

        public UnitTest1() //Makes db, edit things for db
        {
            DbContextOptions<GroceryContext>inmemory = new DbContextOptionsBuilder<GroceryContext>().UseInMemoryDatabase("Filename=test.db").ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning)).Options;
            ctx = new GroceryContext(inmemory);
            ctx.GroceryList.Add(new UsersLists()
            {
                GroceryID = 1,
                User = new UserModel(),
                id = 1,
                Item = new GroceryItem()
                {
                    GroceryId = 1,
                    Name = "1lbs Hamburger",
                    Description = "Roll of ground Hamburger Meat",
                    Department = "Meat",
                    Location = "Meat Counter/ Aisle 65"
                }
            });
            ctx.SaveChanges();
        }
     
        [Fact]
        public void listCreationTest()
        {
            //Arange
            var store = new Mock<IUserStore<UserModel>>();
            var mgr = new Mock<UserManager<UserModel>>(store.Object, null, null, null, null, null, null, null, null);
            
            ListController ctrl = new ListController(ctx , mgr.Object );
            
            //action
            var result = ctrl.Open();

            
            //Assert
            var vr = Assert.IsType<ViewResult>(result);
            var mdl = Assert.IsType<List<UsersLists>>(vr.Model);
            
            Assert.Equal(1, mdl.Count);
            var itm = mdl[0];
            
            Assert.NotNull(itm.User);
            Assert.NotNull(itm.Item);
        }
    }
    //public IActionResult Open()
    //{
    //    //This is grabbing the person's list
    //    var itm = context.GroceryList
    //        .Include(gl => gl.User)
    //        .Include(gl => gl.Item)
    //        .ToList();
    //    return View("~/Views/List/ViewGroceryList.cshtml", itm);
    //}
    //
    //home controller test
}