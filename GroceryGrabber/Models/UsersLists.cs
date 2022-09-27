using Microsoft.Extensions.Configuration.UserSecrets;

namespace GroceryGrabber.Models
{
    public class UsersLists
    {
       public int UserID { get; set; }
       public int ListId { get; set; }
       public Lists List { get; set; } 

    }
}
