using System.ComponentModel.DataAnnotations;

namespace GroceryGrabber.Models
{
    public class GroceryItem
    {
        [Key]
        public int GroceryId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public string Department { get; set; }

        public float Price { get; set; }
    }
}
