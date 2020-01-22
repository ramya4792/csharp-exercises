using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>"+
                "<input type='text' name='name'/>" +
                "<input type='submit' value='Greet'/>"+
                "</form>";
            return Content(html, "text/html");
           // return Redirect("/Hello/Goodbye");
        }
        // /hello
        [Route("/hello")]
        [HttpPost]
        public IActionResult Display(string name="world")
        {
            return Content(string.Format("<h1>Hello {0}!</h1>", name), "text/html");
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
