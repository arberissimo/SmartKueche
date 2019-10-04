using System;
using System.Collections.Generic;
using System.Text;

namespace SmartKueche
{
    public class Bankkonto
    {  
        public void BankkontoVerwalten()
        {
            var refBankkonto = new Einkaufsliste();

            Console.Clear();
            Console.WriteLine("[a] Einkauf tätigen");
            Console.WriteLine("[b] Kontostand aufzeigen");

            var einkauf = Console.ReadLine();
            var kontostand = 300;

            switch (einkauf)
            {
                case "a":
                    int newkontostand = kontostand - 100/*refBankkonto.Total*/;
                    break;
                case "b":
                    newkontostand = kontostand - 100/*refBankkonto.Total*/;
                    Console.WriteLine($"Ihr Kontostand beträgt: {newkontostand}");
                    break;
            }
        }
    }
}
