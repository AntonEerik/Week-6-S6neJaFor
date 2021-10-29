using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Hello World!".ToLower();
            
            int hCounter = 0, oCounter = 0, lCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'h')
                {
                    hCounter++;
                }
                else if (fullName[i] == 'o')
                {
                    oCounter++;
                }
                else if (fullName[i] == 'l')
                {
                    lCounter++;
                }
            }

            if (hCounter !=1)
            {
                Console.Write($"Lauses 'Hello World!' on {hCounter} h tähte,");
                if (oCounter !=1)
                {
                    Console.Write($"{oCounter} o tähte");
                    if (lCounter !=1)
                    {
                        Console.WriteLine($" ja {lCounter} l tähte.");
                    }
                    else
                    {
                        Console.WriteLine($" ja {lCounter} l täht.");
                    }
                }
                else
                {
                    Console.Write($"{oCounter} o täht");
                    if (lCounter !=1)
                    {
                        Console.WriteLine($" ja {lCounter} l tähte.");
                    }
                    else
                    {
                        Console.WriteLine($" ja {lCounter} l täht.");
                    }
                }
            }
            else
            {
                Console.Write($"Lauses 'Hello World!' on {hCounter} h täht,");
                if (oCounter !=1)
                {
                    Console.Write($"{oCounter} o tähte");
                    if (lCounter !=1)
                    {
                        Console.WriteLine($" ja {lCounter} l tähte.");
                    }
                    else
                    {
                        Console.WriteLine($" ja {lCounter} l täht.");
                    }
                }
                else
                {
                    Console.Write($"{oCounter} o täht");
                    if (lCounter !=1)
                    {
                        Console.WriteLine($" ja {lCounter} l tähte.");
                    }
                    else
                    {
                        Console.WriteLine($" ja {lCounter} l täht.");
                    }
                }
            }
        }
    }
}