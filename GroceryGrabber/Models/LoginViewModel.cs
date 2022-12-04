using System.ComponentModel.DataAnnotations;

namespace GroceryGrabber.Models
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Please enter a username.")]
		[StringLength(25)]
		public string Username { get; set; }

		[Required(ErrorMessage = "Please enter a password.")]
		[StringLength(25)]
		public string Password { get; set; }

		public string ReturnUrl { get; set; }

		public bool RememberMe { get; set; }

	}
}