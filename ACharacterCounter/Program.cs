using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if (aCounter !=1)
            {
                Console.WriteLine($"Sinu täisnimes {firstName} on {aCounter} a tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu täisnimes {firstName} on {aCounter} a täht.");
            }
            
        }
    }
}