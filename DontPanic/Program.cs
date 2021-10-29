using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string donT = "Don't Panic";
            

            donT = donT.Replace('o', '0');
            donT = donT.Replace('a', '4');
            Console.WriteLine(donT);
        }
    }
}