using ChurchLocator.Data;
using ChurchLocator.Models;
using ChurchLocator.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ChurchLocator.Controllers
{
    public class LoginController : Controller
    {
        private ChurchDbContext context;
        
        public LoginController(ChurchDbContext dbContext)
        {
            context = dbContext;
        }

       

        // GET: /<controller>/


        public IActionResult Index()
        {
            User newUser = new User();

            return View(newUser);
        }
        
        public IActionResult Register()
        {
            User UserModel = new User();
            //use register viewmodel here and within view
          

          

            return View(UserModel);
        }
        [HttpPost]
        public IActionResult Add(RegisterUserViewModel registerUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User newuser = new User()
                {

                Email = registerUserViewModel.Email.ToString(),
                Password = registerUserViewModel.Password,
                ConfirmPassword = registerUserViewModel.ConfirmPassword
                };

                context.User.Add(newuser);
                context.SaveChanges();
            }
            

            return Redirect("/Login");
        }


    }
}
