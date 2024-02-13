using IntroToASP.NETMVC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace IntroToASP.NETMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            throw new Exception();
            return View();
        }

    
        public IActionResult SongForm() => View();

        [HttpPost]
        public IActionResult Sing()
        {
            HttpContext.Session.SetString("numberInput", Request.Form["numberInput"]);

            return View();
        }


        [HttpGet]
        public IActionResult CreateStudent() => View();

        [HttpPost]
        public IActionResult DisplayStudent(LoginInformationModel model)
        {
            return View(model);
        }

     
        public IActionResult Error()
        {
            return View();
        }
    }
}
