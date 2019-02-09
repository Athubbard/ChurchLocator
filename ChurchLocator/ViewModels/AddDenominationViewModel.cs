using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ChurchLocator.ViewModels
{
    public class AddDenominationViewModel
    {
        [Required]
        [Display(Name = "Denomination Name")]
        public string Name { get; set; }
    }
}
