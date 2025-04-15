// Server Side State Management
using Microsoft.AspNetCore.Mvc;

namespace StateManagement.Controllers
{

    public class ServerSideSMController : Controller

    {
        public IActionResult Index()
        {
            // HttpSession
            HttpContext.Session.SetString("Name", "Sachin Thapa");
            HttpContext.Session.SetInt32("Age", 22);

            // TempData
            TempData["Faculty"] = "Bsc csit";
            TempData["sem"] = 6;
            return View();
        }

        public IActionResult GetState()
        {

            ViewData["Name"] = HttpContext.Session.GetString("Name");
            ViewData["Age"] = HttpContext.Session.GetInt32("Age");
            ViewData["Faculty"] = TempData["Faculty"];
            ViewData["sem"] = TempData["sem"];
            return View();
        }


    }

}

