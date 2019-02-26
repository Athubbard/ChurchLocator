using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChurchLocator.ViewModels
    
{

    public class RegisterUserViewModel
    {
        /*
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        */

        [Required]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }



        //[Required]
        //[EmailAddress]
        //[Display(Name = "Email")]
        //public object Email { get; private set; }


        //[Required]
        //[Display(Name = "Password")]
        //public string Password { get; private set; }

        //[Display(Name = "Confirm password")]
        //[Compare("Password", ErrorMessage = "Passwords do not match.")]
        //public string ConfirmPassword { get; private set; }
        
    }

       
 }

