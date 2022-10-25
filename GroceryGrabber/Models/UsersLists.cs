using Microsoft.Extensions.Configuration.UserSecrets;

namespace GroceryGrabber.Models
{
    public class UsersLists
    {
        public int id { get; set; }
        public int UserID { get; set; }
        public UserModel? User { get; set; }

        public int GroceryId { get; set; }
        public GroceryItem? Item { get; set; }

    }
}
