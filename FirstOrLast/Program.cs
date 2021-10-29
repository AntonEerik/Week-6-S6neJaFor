using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            if (firstName.Length>lastName.Length)
            {
                Console.WriteLine($"Sinu eesnimes on {firstName.Length-lastName.Length} sümbolit rohkem kui perekonnanimes.");
            }
            else if (firstName.Length<lastName.Length)
            {
                Console.WriteLine($"Sinu perekonnanimes on {lastName.Length-firstName.Length} sümbolit rohkem kui eesnimes.");
            }
            else
            {
                Console.WriteLine("Sinu perekonnanimes on sama palju sümboleid kui eesnimes.");
            }

        }
    }
}