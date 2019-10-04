using System;
using System.Collections.Generic;
using System.Text;

namespace SmartKueche
{
    public class ConsoleHelper
    {
        public int ReadInt(int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                string input = Console.ReadLine();
                int value;
                var parsed = int.TryParse(input, out value);
                min = 4;
                max = 4;

                if (parsed)
                {
                    if (value >= min && value <= max)
                    {
                        return value;
                    }
                    Console.WriteLine($"Wert muss zwischen {min} und {max} liegen.");
                }
                else
                {
                    Console.WriteLine("Ungültige Zahl.");
                }
            }
        }
    }
}
