using System;
using System.Collections.Generic;
using System.Text;

namespace SmartKueche
{
    public class Einkaufsliste
    {
        public void CreateEinkaufsliste(List<Einkaufsliste> EinkaufsListe)
        {
            Console.Clear();

            Console.WriteLine("Wie soll die Einkaufsliste heissen?");
            var nameEinkaufsliste = Console.ReadLine();

            for (int i = 0; i < 15; i++)
            {
                Console.Clear();

                Console.WriteLine("Produkt: ");
                var produkt = Console.ReadLine();

                if (produkt.Equals("0"))
                {
                    break;
                }

                Console.WriteLine("Menge: ");
                var menge = Console.ReadLine();

                Console.WriteLine("Preis: ");
                var preis = Console.ReadLine();

                var einkaufsliste = new Einkaufsliste()
                {
                    nameEinkaufsliste = nameEinkaufsliste,
                    Produkt = produkt,
                    Menge = menge,
                    Preis = preis,
                };

                EinkaufsListe.Add(einkaufsliste);
            }
        }

        public void ListEinkaufsliste(List<Einkaufsliste> EinkaufsListe)
        {
            Console.Clear();

            foreach (var einkaufsliste in EinkaufsListe)
            {
                Console.WriteLine($"{einkaufsliste.nameEinkaufsliste}\n{einkaufsliste.Produkt}: {einkaufsliste.Menge}Stk. à {einkaufsliste.Preis}.-\nTotal: {einkaufsliste.Total}");
                Console.WriteLine("..................................................................");
            }
            Console.ReadKey();
        }

        public void RelateEinkaufsliste(List<Einkaufsliste> EinkaufsListe)
        {
            Console.Clear();

            Console.WriteLine("Wählen Sie eine Liste: ");

            int SelectedEinkaufslisteEdit;

            for (int y = 0; y < EinkaufsListe.Count; y++)
            {
                Console.WriteLine($"[{y + 1}] {EinkaufsListe[y].nameEinkaufsliste}");
            }
            var SelectedEinkaufslisteEditBool = int.TryParse(Console.ReadLine(), out SelectedEinkaufslisteEdit);
            if (SelectedEinkaufslisteEdit == 0)
            {
                return;
            }
            var chosenEinkaufslisteForEdit = EinkaufsListe[SelectedEinkaufslisteEdit - 1];
            SelectedEinkaufslisteEdit = SelectedEinkaufslisteEdit - 1;

            var SelectedFieldBool = int.TryParse(Console.ReadLine(), out var SelectedField);
            if (SelectedField == 0)
            {
                return;
            }
        }

        public String nameEinkaufsliste { get; set; }
        public String Produkt { get; set; }
        public String Menge { get; set; }
        public String Preis { get; set; }
        public String Total { get; set; }
    }
}
