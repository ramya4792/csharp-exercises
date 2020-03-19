using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;
using UserSignup.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //get all users data
            ViewBag.Title = "All Users";
            ViewBag.users = UserData.GetAll();
            return View();
        }
        //Add action method
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            //validate succeed add user to userData
            if (ModelState.IsValid)
            {
                User newUser = new User()
                {
                    Username = addUserViewModel.UserName,
                    Email = addUserViewModel.Email,
                    Password = addUserViewModel.Password
                };
                UserData.Add(newUser);
                return Redirect("/User");
            }
            //otherwise render same form
            return View(addUserViewModel);
        }
        
        //details action method to display the details of the selected user
        public IActionResult Details(int id)
        {
            //getting username, email and date from User with corresponding user id
            var userId = UserData.GetById(id);
            ViewBag.Name = userId.Username;
            ViewBag.Email = userId.Email;
            ViewBag.Id = userId.UserId;
            ViewBag.Date = userId.DateTime;
            return View();
        }
    }
}
