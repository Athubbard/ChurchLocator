using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChurchLocator.Data;
using Microsoft.AspNetCore.Mvc;
using ChurchLocator.ViewModels;
using ChurchLocator.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChurchLocator.Controllers
{
    public class DenominationController : Controller
    {
        private readonly ChurchDbContext context;

        public DenominationController(ChurchDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View(context.Denominations.ToList());
        }

        public IActionResult Add()
        {
            AddDenominationViewModel addDenominationViewModel = new AddDenominationViewModel();
            return View(addDenominationViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddDenominationViewModel addDenominationViewModel)
        {
            if(ModelState.IsValid)
            {
                Denomination newDenomination = new Denomination
                {
                    Name = addDenominationViewModel.Name
                };
                context.Denominations.Add(newDenomination);
                context.SaveChanges();
                return Redirect("/Denomination");

            }
            return View(addDenominationViewModel);
        }
    }
}
