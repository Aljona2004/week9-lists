using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string rootdirectory = @"C:\Users\opilane\samples\wishlist";
            Console.WriteLine("Enter file name:");
            string filename = Console.ReadLine();
            string fullFilePath = $@"{rootdirectory}\{filename}.txt";

            bool directoryExists = Directory.Exists(rootdirectory);
            bool fileExists = File.Exists(fullFilePath);

            if(directoryExists && fileExists)
            {
                Console.WriteLine($"File {filename} already exists in {rootdirectory}");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"wishlist directory does not exist");
                Directory.CreateDirectory(rootdirectory);
                File.Create(fullFilePath);
                Console.WriteLine($"File {filename}.txt has been created");
            }
            else
            {
                File.Create(fullFilePath);
                Console.WriteLine($"File {filename}.txt has been created");
            }

        }            
    }
}
