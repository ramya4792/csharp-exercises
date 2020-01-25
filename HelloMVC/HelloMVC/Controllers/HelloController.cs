using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public  class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
           
            string html = "<form method='post'>" +
                "<input type='text' name='name'/>" +
                "<select name='lang'>" +
                "<option value='en' selected>English</option>" +
                "<option value='sp'>Spanish</option>" +
                "<option value='fr'>French</option>" +
                "<option value='it'>Italian</option>" +
                "<option value='ge'>German</option>" +
                "</select>" +
                "<input type='submit' value='GreetMe'/>" +
                "</form>";
            return Content(html, "text/html");
        }
        public static String CreateMessage(string name, string lang)
        {
            string  message= "";

            if (lang == "sp")
                message = "Hola ";
            else if (lang == "ge")
                message = "Hallo ";
            else if (lang == "fr")
                message = "Bonjour ";
            else if (lang == "it")
                message = "Ciao ";
            else
                message = "Hello ";
            


            return message+name;
        }
        // /hello
        [Route("/hello")]
        [HttpPost]
        public IActionResult Display(string name="world", string lang="en")
        {
            string hi=CreateMessage(name, lang);
            return Content(string.Format("<h1>{0} !</h1>", hi), "text/html");
        }
        //handle requests to /hello/Name(URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name="world")
        {
            return Content(string.Format("<h1>Hello {0}!</h1>", name), "text/html");
        }
        
        public IActionResult Goodbye()
        {
            return Content("GoodBye..");
        }
    }
}
