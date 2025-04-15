using System;
using System.IO;

namespace FileHandlingStreamDemo
{
    class FileHandling
    {
        public static void RunProgram()
        {
            string filePath = "./note/file.txt";

            // Step 1: Write to the file using StreamWriter
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello, this is line 1.");
                writer.WriteLine("This is line 2.");
                writer.WriteLine("C# file handling using StreamWriter and StreamReader.");
            }
            Console.WriteLine("Data written to file using StreamWriter.\n");

            // Step 2: Read from the file using StreamReader
            Console.WriteLine("Reading from file using StreamReader:");

            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
