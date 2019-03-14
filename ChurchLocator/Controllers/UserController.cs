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
            RegisterUserViewModel registerUserViewModel= new RegisterUserViewModel();
            //use register viewmodel here and within view




            return View(registerUserViewModel);
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


                return View("Profile/" + newuser.ID);

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
                   return Redirect("/User/Profile/" + existingUser.ID);
                }

                 
            
            }

            return View(userLoginViewModel);
        }



        [HttpGet]
        public IActionResult Profile(int id)
        {
            UserProfileViewModel userProfileViewModel = new UserProfileViewModel();
            User user = context.Users.Where(cm => cm.ID == id).SingleOrDefault();
            userProfileViewModel.Name = user.UserName;
          

            return View(userProfileViewModel);
        }

        [HttpPost]
        public IActionResult Profile(CompleteItemsListView completeItemsListView)
        {



            return View(completeItemsListView);
        }



    }
}
