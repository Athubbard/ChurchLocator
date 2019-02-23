using Microsoft.AspNetCore.Mvc;
using ChurchLocator.Models;
using System.Collections.Generic;
using ChurchLocator.ViewModels;
using ChurchLocator.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ChurchLocator.Controllers
{
    public class ChurchController : Controller
    {
        private ChurchDbContext context;

        public ChurchController(ChurchDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {

            IList<Church> churches = new List<Church>();
            churches = context.Churches.Include(c => c.Denomination).ToList();

            return View(churches);
        }

        public IActionResult Add()
        {
            AddChurchViewModel addChurchViewModel = new AddChurchViewModel(context.Denominations.ToList());
            return View(addChurchViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddChurchViewModel addChurchViewModel)
        {



            if (ModelState.IsValid)

            {  // Add the new churches to my existing churches
                Denomination newDenomination = context.Denominations.Single(c => c.ID == addChurchViewModel.DenominationID); Church newChurch = new Church
                {
                    Name = addChurchViewModel.Name,
                    

                    Denomination = newDenomination
                };
                context.Churches.Add(newChurch);
                context.SaveChanges();


                return Redirect("/Church");
            }

            return View(addChurchViewModel);

        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Churches";
            ViewBag.churches = context.Churches.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] churchIds)
        {
            foreach (int churchId in churchIds)
            {

                Church theChurch = context.Churches.Single(c => c.ID == churchId);
                context.Churches.Remove(theChurch);
            }

            context.SaveChanges();

            return Redirect("/");
        }
    }
}


