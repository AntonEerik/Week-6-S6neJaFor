using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Hello, World!";
            
            for (int i = firstName.Length-1; i >= 0; i--)
            {
                Console.Write(firstName[i]);
            }
        }
    }
}