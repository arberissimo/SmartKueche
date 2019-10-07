using System;
using System.Collections.Generic;
using System.Text;

namespace SmartKueche
{
    public class Person
    {
        public void CreatePerson(List<Person> PersonenListe)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Clear();

                Console.WriteLine("Vorname: ");
                var vorname = Console.ReadLine();

                if (vorname.Equals("0"))
                {
                    break;
                }

                Console.WriteLine("Nachname: ");
                var nachname = Console.ReadLine();

                Console.WriteLine("Strasse und Strassennummer: ");
                var strasse = Console.ReadLine();

                Console.WriteLine("PLZ: ");
                var plz = Console.ReadLine();

                Console.WriteLine("Ort: ");
                var ort = Console.ReadLine();

                Console.WriteLine("Lieblingsessen: ");
                var lieblingsessen = Console.ReadLine();

                var person = new Person()
                {
                    Vorname = vorname,
                    Nachname = nachname,
                    Strasse = strasse,
                    PLZ = plz,
                    Ort = ort,
                    Lieblingsessen = lieblingsessen
                };

                PersonenListe.Add(person);
            }
        }

        public void ListPerson(List<Person> PersonenListe)

        {
            Console.Clear();

            foreach (var person in PersonenListe)
            {
                Console.WriteLine($"Vor- und Nachname: {person.Vorname} {person.Nachname}\nStrasse und Strassennummer: {person.Strasse}");
                Console.WriteLine($"PLZ und Ort: {person.PLZ} {person.Ort}");
                Console.WriteLine($"Lieblingsessen: {person.Lieblingsessen}");
                Console.WriteLine(".................................................................................");
            }

            Console.ReadKey();
        }

        public void EditPerson(List<Person> PersonenListe)
        {
            Console.Clear();
            int SelectedPersonEdit;

            for (int y = 0; y < PersonenListe.Count; y++)
            {
                Console.WriteLine($"[{y + 1}] {PersonenListe[y].Vorname} {PersonenListe[y].Nachname}");
            }
            var SelectedPersonEditBool = int.TryParse(Console.ReadLine(), out SelectedPersonEdit);
            if (SelectedPersonEdit == 0)
            {
                return;
            }
            var chosenPersonForEdit = PersonenListe[SelectedPersonEdit - 1];
            SelectedPersonEdit = SelectedPersonEdit - 1;

            EditPersonenListe();

            var SelectedFieldBool = int.TryParse(Console.ReadLine(), out var SelectedField);
            if (SelectedField == 0)
            {
                return;
            }

            Console.Clear();
            Console.WriteLine("Geben Sie eine neue Bezeichnung ein");
            var NewEditField = Console.ReadLine();

            switch (SelectedField)
            {
                case 1:
                    PersonenListe[SelectedPersonEdit].Vorname = NewEditField;
                    break;

                case 2:
                    PersonenListe[SelectedPersonEdit].Nachname = NewEditField;
                    break;

                case 3:
                    PersonenListe[SelectedPersonEdit].Strasse = NewEditField;
                    break;

                case 4:
                    PersonenListe[SelectedPersonEdit].PLZ = NewEditField;
                    break;

                case 5:
                    PersonenListe[SelectedPersonEdit].Ort = NewEditField;
                    break;

            }

            void EditPersonenListe()
            {
                int x = 0;
                Console.Clear();

                Console.WriteLine("Wählen Sie das zu bearbeitende Feld aus");
                Console.WriteLine($"[{x + 1}] {PersonenListe[SelectedPersonEdit].Vorname}");
                Console.WriteLine($"[{x + 2}] {PersonenListe[SelectedPersonEdit].Nachname}");
                Console.WriteLine($"[{x + 3}] {PersonenListe[SelectedPersonEdit].Strasse}");
                Console.WriteLine($"[{x + 4}] {PersonenListe[SelectedPersonEdit].PLZ}");
                Console.WriteLine($"[{x + 5}] {PersonenListe[SelectedPersonEdit].Ort}");
                Console.WriteLine("[0] Exit");

            }
        }

        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Strasse { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }
        public string Lieblingsessen { get; set; }
    }


}
    
