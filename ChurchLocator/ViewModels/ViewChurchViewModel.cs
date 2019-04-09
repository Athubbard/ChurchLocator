/*  comment back in after sesseion implemented
 * 
 * 
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ChurchLocator.Models;

namespace ChurchLocator.ViewModels
{
    public class ViewChurchViewModel
    {
        [Required]
        [Display(Name = "Church")]
        public int ChurchID { get; set; }
        public int UserID { get; set; }

        public Church Church { get; set; }
        public IList<UserChurch> Items { get; set; }
    }
}

*/
