using Microsoft.AspNetCore.Mvc;

public class XssDemoController : Controller
{
    [HttpGet]
    public IActionResult EnterText()
    {
        return View();
    }

    [HttpPost]
    public IActionResult EnterText(string userInput)
    {
        return View("SafeDisplay", model: userInput);
    }
}
