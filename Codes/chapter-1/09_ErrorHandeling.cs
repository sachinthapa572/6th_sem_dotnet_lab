using System;

// User-defined exception
public class InvalidInputException : Exception
{
    public InvalidInputException(string message) : base(message)
    {
    }
}

public class ErrorHandlingExample
{
    public static void RunProgram()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            if (numerator < 0 || denominator < 0)
            {
                throw new InvalidInputException("Negative numbers are not allowed.");
            }
            int result = numerator / denominator;

            Console.WriteLine($"Result: {result}");
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine($"Custom Error: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Built-in Error: Cannot divide by zero.{ex.Message}");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
