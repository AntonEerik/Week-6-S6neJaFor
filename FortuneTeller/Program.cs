using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] future = {"win a million", "fall in love", "buy youtube premium", "join the darkside for cookies"};
            
            Random rnd = new Random();
            int userNumber = rnd.Next(0, future.Length);

            Console.WriteLine($"Today you will {future[userNumber]}.");
        }
    }
}