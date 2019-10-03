using System;
using System.Collections.Generic;

namespace SmartKueche
{
    public class Program
    {
        private List<Person> PersonenListe = new List<Person>();
        private List<Einkaufsliste> EinkaufsListe = new List<Einkaufsliste>();

        public static void Main(string[] args)
        {
            new Program().Run();
        }

        public void Run()
        {
            int i = 1;
            while (i == 1)
            {
                int loophauptmenu = 1;
                while (loophauptmenu == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Was möchten Sie machen?\n[a] Person hinzufügen\n[b] Person auflisten\n[c] Einkaufsliste erstellen\n[d] Einkaufsliste zeigen\n[e] Exit");
                    var hauptmenu = Console.ReadLine();

                    switch (hauptmenu)
                    {
                        case "a":
                            CreatePerson();
                            break;
                        case "b":
                            ListPerson();
                            break;
                        case "c":
                            CreateEinkaufsliste();
                            break;
                        case "d":
                            ListEinkaufsliste();
                            break;
                        case "e":
                            i = 0;
                            break;
                    }
                }
            }
        }

        public void CreatePerson()
        {
            Console.Clear();

            Console.WriteLine("Vorname: ");
            var vorname = Console.ReadLine();

            Console.WriteLine("Nachname: ");
            var nachname = Console.ReadLine();

            Console.WriteLine("Strasse und Strassennummer: ");
            var strasse = Console.ReadLine();

            Console.WriteLine("PLZ: ");
            var plz = Console.ReadLine();

            Console.WriteLine("Ort: ");
            var ort = Console.ReadLine();

            Console.WriteLine("Geld: ");
            var mengegeld = Console.ReadLine();

            Console.WriteLine("Lieblingsessen: ");
            var lieblingsessen = Console.ReadLine();


            var person = new Person()
            {
                Vorname = vorname,
                Nachname = nachname,
                Strasse = strasse,
                PLZ = plz,
                Ort = ort,
                MengeGeld = mengegeld,
                Lieblingsessen = lieblingsessen
            };

            PersonenListe.Add(person);
        }

        public void ListPerson()
        {
            Console.Clear();

            foreach (var person in PersonenListe)
            {
                Console.WriteLine($"Vor- und Nachname: {person.Vorname} {person.Nachname}\nStrasse und Strassennummer: {person.Strasse}");
                Console.WriteLine($"PLZ und Ort: {person.PLZ} {person.Ort}");
                Console.WriteLine($"Vermögen: {person.MengeGeld}");
                Console.WriteLine($"Lieblingsessen: {person.Lieblingsessen}");
            }

            Console.ReadKey();
        }

        public void CreateEinkaufsliste()
        {
            Console.Clear();

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Produkt: ");
                var produkt = Console.ReadLine();

                Console.WriteLine("Menge: ");
                var menge = Console.ReadLine();

                
                var einkaufsliste = new Einkaufsliste()
                {
                    Produkt = produkt,
                    Menge = menge
                };

                EinkaufsListe.Add(einkaufsliste);

                var eingabe = i;

                if (eingabe == 0) 
                {
                    break;
                }
            }
        }

        public void ListEinkaufsliste()
        {
            Console.Clear();

            foreach (var einkaufsliste in EinkaufsListe)
            {
                Console.WriteLine($"{einkaufsliste.Produkt}: {einkaufsliste.Menge}x");
            }

            Console.ReadKey();
        }
    }
}
