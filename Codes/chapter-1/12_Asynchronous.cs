using System;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class AsyncDataHandler
    {
        static async Task<string> GetDataAsync()
        {
            Console.WriteLine("GetDataAsync started...");
            await Task.Delay(3000);
            Console.WriteLine("GetDataAsync finished.");
            return "Hello from async method!";
        }

        public static async Task Run()
        {
            Console.WriteLine("Main started.");
            string result = await GetDataAsync();
            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Main ended.");
        }
    }
}
