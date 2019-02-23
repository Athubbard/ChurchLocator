using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ChurchLocator.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "This field is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

        public User()
        {

        }
      




    }
}
