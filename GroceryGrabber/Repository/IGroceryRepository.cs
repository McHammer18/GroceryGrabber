using GroceryGrabber.Models;

namespace GroceryGrabber.Repository
{
    public class IGroceryRepository
    {
        List<GroceryItem> GetAllItems();
        GroceryItem Find(int id);
        void Save();
        void InsertGroceryItem(GroceryItem groceryItem);
        void DeleteGroceryItem(GroceryItem groceryItem);
        void UpdateGroceryItem(GroceryItem groceryItem);
    }
}
