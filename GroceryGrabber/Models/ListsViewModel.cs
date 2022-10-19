using Microsoft.Extensions.Configuration.UserSecrets;

namespace GroceryGrabber.Models
{
    public class ListsViewModel
    {
       public List<Lists> List { get; set; }
       public int UserID { get; set; }
       public int ListId { get; set; }
    }
}
