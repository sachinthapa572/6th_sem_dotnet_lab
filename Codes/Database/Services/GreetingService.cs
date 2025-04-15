// Services/GreetingService.cs
public class GreetingService : IGreetingService
{
    public string Greet(string name)
    {
        return $"Hello, {name}! Welcome to ASP.NET Core DI.";
    }
}
