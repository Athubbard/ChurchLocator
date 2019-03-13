using System.ComponentModel.DataAnnotations;

namespace ChurchLocator.ViewModels
{
    public class UserLoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        
    }
}