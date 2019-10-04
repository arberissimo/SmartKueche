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
            var refPerson = new Person();
            var refEinkaufsliste = new Einkaufsliste();
            var refBankkonto = new Bankkonto();
            var refConsoleHelper = new ConsoleHelper();

            int i = 1;
            while (i == 1)
            {
                int loophauptmenu = 1;
                while (loophauptmenu == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Was möchten Sie machen?\n[a] Person\n[b] Einkaufsliste\n[c] Bankkonto\n[d] Exit");
                    var hauptmenu = Console.ReadLine();

                    switch (hauptmenu)
                    {
                        case "a":
                            Console.Clear();
                            Console.WriteLine("Was möchten Sie machen?\n[a] Person erstellen\n[b] Person auflisten");
                            var personMenu = Console.ReadLine();

                            switch (personMenu)
                            {
                                case "a":
                                    refPerson.CreatePerson(PersonenListe);
                                    break;
                                case "b":
                                    refPerson.ListPerson(PersonenListe);
                                    break;
                            }
                            break;
                        case "b":
                            Console.Clear();
                            Console.WriteLine("Was möchten Sie machen?\n[a] Einkaufsliste erstellen\n[b] Einkaufsliste anzeigen");
                            var einkaufslisteMenu = Console.ReadLine();

                            switch (einkaufslisteMenu)
                            {
                                case "a":
                                    refEinkaufsliste.CreateEinkaufsliste(EinkaufsListe);
                                    break;
                                case "b":
                                    refEinkaufsliste.ListEinkaufsliste(EinkaufsListe);
                                    break;
                            }
                            break;
                        case "c":
                            Console.Clear();
                            Console.WriteLine("Was möchten Sie machen?\n[a] Bankkonto verwalten");
                            var bankkontoMenu = Console.ReadLine();

                            switch (bankkontoMenu)
                            {
                                case "a":
                                    refBankkonto.BankkontoVerwalten();
                                    break;
                            }
                            break;
                        case "d":
                            i = 0;
                            break;
                    }
                }
            }
        }
    }
}
