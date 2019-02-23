using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChurchLocator.ViewModels
    
{

    public class RegisterUserViewModel
    {
       
       
        
        private const int M = 100;
        //internal readonly object Name;

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public object Email { get; private set; }


        [Required]
        [StringLength(M, ErrorMessage = "Must be at least {2} characters long.", MinimumLength = 2)]
        [Display(Name = "Password")]
        public string Password { get; private set; }

        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; private set; }
    }

       
 }

