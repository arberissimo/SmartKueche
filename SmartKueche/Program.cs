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
                            int looppersonMenu = 1;
                            while (looppersonMenu == 1)
                            {

                            Console.Clear();
                            Console.WriteLine("Was möchten Sie machen?\n[a] Person erstellen\n[b] Person auflisten\n[c] Person bearbeiten\n[d] Exit");
                            var personMenu = Console.ReadLine();
                            
                                switch (personMenu)
                                {
                                    case "a":
                                        refPerson.CreatePerson(PersonenListe);
                                        break;
                                    case "b":
                                        refPerson.ListPerson(PersonenListe);
                                        break;
                                    case "c":
                                        refPerson.EditPerson(PersonenListe);
                                        break;
                                    case "d":
                                        looppersonMenu = 0;
                                        break;
                                }
                            }
                            break;
                        case "b":
                            int loopeinkaufslisteMenu = 1;
                            while (loopeinkaufslisteMenu == 1)
                            {

                            Console.Clear();
                            Console.WriteLine("Was möchten Sie machen?\n[a] Einkaufsliste erstellen\n[b] Einkaufsliste anzeigen\n[c] Einkaufsliste jemandem zuordnen\n[d] Exit");
                            var einkaufslisteMenu = Console.ReadLine();

                                switch (einkaufslisteMenu)
                                {
                                    case "a":
                                        refEinkaufsliste.CreateEinkaufsliste(EinkaufsListe);
                                        break;
                                    case "b":
                                        refEinkaufsliste.ListEinkaufsliste(EinkaufsListe);
                                        break;
                                    case "c":
                                        refEinkaufsliste.RelateEinkaufsliste(EinkaufsListe);
                                        break;
                                    case "d":
                                        loopeinkaufslisteMenu = 0;
                                        break;
                                }
                            } 
                            break;
                        case "c":
                            int loopbankkontoMenu = 1;
                            while (loopbankkontoMenu == 1)
                            {

                            Console.Clear();
                            Console.WriteLine("Was möchten Sie machen?\n[a] Bankkonto verwalten\n[b] Exit");
                            var bankkontoMenu = Console.ReadLine();

                                switch (bankkontoMenu)
                                {
                                    case "a":
                                        refBankkonto.BankkontoVerwalten();
                                        break;
                                    case "b":
                                        loopbankkontoMenu = 0;
                                        break;
                                }
                            }
                            break;
                        case "d":
                            return;
                    }
                }
            }
        }
    }
}
