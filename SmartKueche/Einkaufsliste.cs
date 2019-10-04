using System;
using System.Collections.Generic;
using System.Text;

namespace SmartKueche
{
    public class Einkaufsliste
    {

        List<Einkaufsliste> einkaufsliste;
        public void CreateEinkaufsliste(List<Einkaufsliste> EinkaufsListe)
        {
            Console.Clear();

            for (int i = 1; i <= 15; i++)
            {
                Console.Clear();

                Console.WriteLine("Produkt: ");
                var produkt = Console.ReadLine();

                Console.WriteLine("Menge: ");
                var menge = Console.ReadLine();
                int mengeInt = Convert.ToInt16(menge);

                Console.WriteLine("Preis: ");
                var preis = Console.ReadLine();
                int preisInt = Convert.ToInt16(preis);

                int total = Console.Read();
                total = preisInt * mengeInt;

                var einkaufsliste = new Einkaufsliste()
                {
                    Produkt = produkt,
                    Menge = mengeInt,
                    Preis = preisInt,
                    Total = total
                };

                EinkaufsListe.Add(einkaufsliste);

                var eingabe = Console.ReadLine();
                int eingabeInt = Convert.ToInt32(eingabe);

                if (eingabeInt == 0)
                {
                    this.einkaufsliste = EinkaufsListe;
                    break;
                }
            }
        }

        public void ListEinkaufsliste(List<Einkaufsliste> EinkaufsListe)
        {
            Console.Clear();

            foreach (var einkaufsliste in EinkaufsListe)
            {
                Console.WriteLine($"{einkaufsliste.Produkt}: {einkaufsliste.Menge}x\n{einkaufsliste.Preis}\nTotal: {einkaufsliste.Total}");
            }

            Console.ReadKey();
        }

        public String Produkt { get; set; }
        public int Menge { get; set; }
        public int Preis { get; set; }
        public int Total { get; set; }


    }
}
