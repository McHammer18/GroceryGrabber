using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GroceryGrabber.Models
{
    public class GroceryViewModel
    {
        [Key]
        public int GroceryID { get; set; }
        public string UserID { get; set; }
        public string GroceryName { get; set; }
        public string item1 { get; set; }
        public string item2 { get; set; }
        public string item3 { get; set; }
        public string item4 { get; set; }
    }
}
