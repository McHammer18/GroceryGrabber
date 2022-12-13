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
        public string? item1 { get; set; }
        public string? item2 { get; set; }
        public string? item3 { get; set; }
        public string? item4 { get; set; }
        public string? item5 { get; set; }
        public string? item6 { get; set; }
        public string? item7 { get; set; }
        public string? item8 { get; set; }
        public string? item9 { get; set; }
        public string? item10 { get; set; }
        public string? item11 { get; set; }
        public string? item12 { get; set; }
        public string? item13 { get; set; }
        public string? item14 { get; set; }
        public string? item15 { get; set; }
    }
}
