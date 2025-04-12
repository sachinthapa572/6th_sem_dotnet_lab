using System;

namespace Practical.Codes
{
    public class Labs
    {
        public static void PrintName()
        {
            System.Console.Write("Hello, What is your name? : ");
            string name = Console.ReadLine() ?? string.Empty;
            System.Console.WriteLine($"Hello, {name}!");
        }
    }
}