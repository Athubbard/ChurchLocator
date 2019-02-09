using ChurchLocator.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChurchLocator.ViewModels
{
    public class AddChurchViewModel
    {
        [Required]
        [Display(Name = "Church Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Denomination")]
        public int DenominationID { get; set; }
        public List<SelectListItem> Denominations { get; set; }


        public AddChurchViewModel() { }

        public AddChurchViewModel(IEnumerable<Denomination> denominations)
        {
            Denominations = new List<SelectListItem>(); foreach (var denomination in denominations)
            {
                Denominations.Add(new SelectListItem
                {
                    Value = denomination.ID.ToString(),
                    Text = denomination.Name

                });
            }
        }
    }
}
