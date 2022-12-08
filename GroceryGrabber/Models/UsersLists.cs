using Microsoft.Extensions.Configuration.UserSecrets;

namespace GroceryGrabber.Models
{
    public class UsersLists
    {
        public int id { get; set; }
        public int GroceryID { get; set; }
        public UserModel? User { get; set; }
        public GroceryItem? Item { get; set; }

    }
}
