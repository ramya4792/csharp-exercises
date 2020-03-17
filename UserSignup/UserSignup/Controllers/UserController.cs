using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

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
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user, string verify)
        {

            //check password is not null
            //password verify matches
            if (user.Password != null && user.Password == verify)
            {
                    //add newuser to exsting users
                    UserData.Add(user);
                    //return to index page
                    return Redirect("/User/Index");
            }

            else
                    //otherwise return to same form
                    return View(user);
            
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
