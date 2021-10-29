using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string HelloW = "Hello World!";

            //for (int i = 0; i < HelloW.Length; i++)
            //{
            //    HelloW[i] = '*';
            //}

            HelloW = HelloW.Replace('o', '*');
            HelloW = HelloW.Replace('!', '1');
            Console.WriteLine(HelloW);
        }
    }
}