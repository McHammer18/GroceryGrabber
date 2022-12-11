using GroceryGrabber.Migrations;
using GroceryGrabber.Models;

namespace GroceryGrabber.Repository
{
    public class GroceryRepository : IGroceryRepository
    {
        private GroceryContext context;
        public GroceryRepository(GroceryContext ctx)
        {
            context = ctx;
        }

        public List<GroceryItem> GetAllItems()
        {
            return context.GroceryItems.ToList();
        }

        public GroceryItem Find(int id)
        {
            return context.GroceryItems.Find(id);
        }

        public void DeleteGroceryItem(GroceryItem groceryItem)
        {
            context.GroceryItems.Remove(groceryItem);
            context.SaveChanges();
        }

        public void InsertGroceryItem(GroceryItem groceryItem)
        {
            context.Add(groceryItem);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateGroceryItem(GroceryItem groceryItem)
        {
            context.GroceryItems.Update(groceryItem);
        }

        //public GroceryItem OrderGroceryItems()
        //{
        //    return context.GroceryItems.OrderBy(x => x.Name).ToList();
       // }
    }
}
