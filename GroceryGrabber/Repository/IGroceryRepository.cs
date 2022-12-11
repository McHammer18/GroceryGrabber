using GroceryGrabber.Models;

namespace GroceryGrabber.Repository
{
    public interface IGroceryRepository
    {
        List<GroceryItem> GetAllItems();
        GroceryItem Find(int id);
        //GroceryItem OrderGroceryItems();
        void Save();
        void InsertGroceryItem(GroceryItem groceryItem);
        void DeleteGroceryItem(GroceryItem groceryItem);
        void UpdateGroceryItem(GroceryItem groceryItem);
    }
}
