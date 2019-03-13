using ChurchLocator.Data;
using ChurchLocator.Models;
using ChurchLocator.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ChurchLocator.Controllers
{
    public class UserController : Controller
    {
        private ChurchDbContext context;

        public UserController(ChurchDbContext dbContext)
        {
            context = dbContext;
        }



        // GET: /<controller>/


        public IActionResult Index()
        {
            User newUser = new User();

            return View(newUser);
        }

        public IActionResult Add()
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
                    UserName = registerUserViewModel.UserName,
                    FirstName = registerUserViewModel.FirstName,
                    LastName = registerUserViewModel.LastName,
                    Email = registerUserViewModel.Email.ToString(),
                    Password = registerUserViewModel.Password
                };

                context.Users.Add(newuser);
                context.SaveChanges();


                return Redirect("/Index");

            }
            return View(registerUserViewModel);


        }

        [HttpGet]
        public IActionResult Login()
        {
            UserLoginViewModel userLoginViewModel = new UserLoginViewModel();
           
            return View();

        }



        [HttpPost]
        public IActionResult Login(UserLoginViewModel userLoginViewModel)
        {
            User existingUser = context.Users.Where(user => user.UserName == userLoginViewModel.Username).SingleOrDefault();

            if (existingUser != null)
            {
                if (existingUser.Password == userLoginViewModel.Password)
                {
                   return Redirect("/Profile");
                }

                 
            
            }

            return View(userLoginViewModel);
        }



        [HttpGet]
        public IActionResult Profile(int id)
        {
            User userlogin = context.Users.Include(user => user.UserName).Where(cm => cm.ID == id).SingleOrDefault();

            return View(userlogin);
        }

        [HttpPost]
        public IActionResult Profile(UserProfileViewModel userProfileViewModel)
        {



            return View(userProfileViewModel);
        }



    }
}
