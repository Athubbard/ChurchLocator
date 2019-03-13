using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChurchLocator.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ChurchLocator.ViewModels
{
    public class CompleteItemsListView
    {
        public List<SelectListItem> Churches { get; set; }
        public List<SelectListItem> Denominations { get; set; }
        public string  User  { get; set; }

    }
}

