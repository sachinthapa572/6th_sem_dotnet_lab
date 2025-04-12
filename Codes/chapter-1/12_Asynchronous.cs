using System;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class AsyncDataHandler
    {
        public static async Task FetchDataAsync()
        {
            Console.WriteLine("Fetching data...");


            await Task.Delay(3000);

            Console.WriteLine("Data fetched successfully!");
        }


        public static async Task ProcessDataAsync()
        {
            Console.WriteLine("Starting data processing...");

            await FetchDataAsync();

            Console.WriteLine("Data processing complete.");
        }


        public static async Task Run()
        {
            Console.WriteLine("Program started.");

            await ProcessDataAsync();

            Console.WriteLine("Program ended.");
        }
    }
}
