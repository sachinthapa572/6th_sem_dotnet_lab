// Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class DiController : ControllerBase
{
    private readonly IGreetingService _greetingService;
    public DiController(IGreetingService greetingService)
    {
        _greetingService = greetingService;
    }
    [HttpGet("{name}")]
    public IActionResult GetGreeting(string name)
    {
        var message = _greetingService.Greet(name);
        return Ok(new { message });
    }
}
