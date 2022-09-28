using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GroceryGrabber.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Please enter a user name that is atleast 4 Charaters long and no more than 8")]
        [StringLength(8)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter your name that you want to be referred as.")]
        [StringLength(10)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a password that has atleast 1 Uppercase, 2 Numbers, and 1 Special.")]
        public string Password { get; set; }
    }
}
