﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        static private Dictionary<string,string> Cheeses = new Dictionary<string, string>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            

            ViewBag.cheeses = Cheeses;

            return View();
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/cheese/Add")]
        public IActionResult NewCheese(string name, string description)
        {
            //Add the new cheese to Existing cheeses
            Cheeses.Add(name,description);

            return Redirect("/cheese");
        }
        
        public IActionResult Remove()
        {
            ViewBag.cheeses = Cheeses;
            return View();
        }
        [HttpPost]
        [Route("/cheese/Remove")]

        
        public IActionResult RemoveCheese(string dropdown1)
        {
            
            //Removing the selected cheese
            Cheeses.Remove(dropdown1.Trim());

            return Redirect("/cheese");
        }

        
    }
}
