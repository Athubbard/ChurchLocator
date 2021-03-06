﻿using ChurchLocator.Data;
using ChurchLocator.Models;
using ChurchLocator.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


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
                return Redirect("/Login");

            }
            return View(registerUserViewModel);


        }

        public IActionResult Profile()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Profile(UserProfileViewModel userProfileViewModel)

       
        {
            if (ModelState.IsValid)
            {
                User newuser = new User();
            }

            return View(userProfileViewModel);
        }
            


    }
}
