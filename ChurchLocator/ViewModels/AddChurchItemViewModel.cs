using ChurchLocator.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurchLocator.ViewModels
{
    public class AddChurchItemViewModel
    {
        public int userID { get; set; }
        public int churchID { get; set; }

        public User User { get; set; }
        public List<SelectListItem> Churches { get; set; }

        public AddChurchItemViewModel(Church Church, List<User> users
            ) { }

        public AddChurchItemViewModel(User aUser, IEnumerable<Church> theSelectListChurches)
        {
            this.User = aUser;
            Churches = new List<SelectListItem>();

            foreach (Church church in theSelectListChurches)
            {
                Churches.Add(new SelectListItem
                {
                    Value = church.ID.ToString(),
                    Text = church.Name
                });
            }
        }
    }
}
