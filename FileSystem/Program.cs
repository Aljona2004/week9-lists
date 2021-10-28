using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\opilane\samples";
            Console.WriteLine("Enter directory name:");
            string userdirectory = Console.ReadLine();

            string newDirectoryPath = $@"{rootdirectory}\{userdirectory}";
            Console.WriteLine(newDirectoryPath);
            bool directoryExists = Directory.Exists(newDirectoryPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userdirectory} already exists in {rootdirectory}");
            }
            else
            {
                Directory.CreateDirectory(newDirectoryPath);
                Console.WriteLine($"Directory {userdirectory} has been created");
            }
            
        }
    }
}
