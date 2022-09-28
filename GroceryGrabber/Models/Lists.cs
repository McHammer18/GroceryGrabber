using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Security;

namespace GroceryGrabber.Models
{
    public class Lists
    {
        [Key]
        public int ListId { get; set; }
        [ForeignKey("UserModel")]
        public int UserID { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public virtual ICollection<GroceryItem> Items { get; set; }

    }
}
