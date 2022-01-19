using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ASP_Basics.Controllers
{
    public class HelloWorldController : Controller
    {
        //Get: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //Get: /HelloWorld/Welcome/

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
