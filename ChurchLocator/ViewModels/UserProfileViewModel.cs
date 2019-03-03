using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChurchLocator.ViewModels
{
    public class UserProfileViewModel
    {
        [Required]
        [Display(Name= "Username")]
        public string Name { get; set; }


        [Required]
        [Display(Name= "My Churches")]
        public string MyChurches { get; set; }


        [Required]
        [Display(Name= "My Denominations")]
        public string MyDenominations { get; set; }

    }
}
