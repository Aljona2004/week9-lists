using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishes = new List<string>();
            myWishes.Add("new crocs");
            myWishes.Add("new umbrella");
            myWishes.Add("new coffee mug");
            myWishes.Add("new smartphone");

            //Console.WriteLine($"There are {myWishes.Count} items on your wish list.");

            //Console.WriteLine(myWishes[0]);
            //Console.WriteLine(myWishes[myWishes.Count - 1]);

            foreach(string wish in myWishes)
            {
                Console.WriteLine($"item on your wish list: {wish}");
            }
            Console.WriteLine("Enter a wish:");
            string userWish = Console.ReadLine();

            myWishes.Add(userWish);

            foreach (string wish in myWishes)
            {
                Console.WriteLine($"item on your wish list: {wish}");
            }
        }
    }
}
