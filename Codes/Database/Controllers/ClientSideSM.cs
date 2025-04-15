// Client Side State Management
using Microsoft.AspNetCore.Mvc;

namespace StateManagement.Controllers
{

    public class ClientSideSMController : Controller

    {
        public IActionResult Index()
        {

            CookieOptions cookieOptions = new CookieOptions()
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict,
                Expires = DateTimeOffset.Now.AddDays(2)
            };
            // Set cookies Cookies
            HttpContext.Response.Cookies.Append("Name", "Sachin Thapa", cookieOptions);
            HttpContext.Response.Cookies.Append("Age", "22", cookieOptions);
            HttpContext.Response.Cookies.Append("Faculty", "Csit", cookieOptions);

            return View();
        }

        [ValidateAntiForgeryToken]
        public IActionResult GetState(string num)
        {

            // Cookies
            ViewData["Name"] = HttpContext.Request.Cookies["Name"];
            ViewData["Age"] = HttpContext.Request.Cookies["Age"];
            ViewData["Faculty"] = HttpContext.Request.Cookies["Faculty"];

            // hidden Field
            var number = int.Parse(num);
            number++;
            ViewData["Number"] = number.ToString();

            return View();
        }

        public IActionResult RemoveState()
        {
            // Remove Cookies
            HttpContext.Response.Cookies.Delete("Name");
            HttpContext.Response.Cookies.Delete("Age");
            HttpContext.Response.Cookies.Delete("Faculty");

            // Remove Hidden Field
            ViewData["Number"] = "0";

            return RedirectToAction(nameof(Index));
        }
    }

}

