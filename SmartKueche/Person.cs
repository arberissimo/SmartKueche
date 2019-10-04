using System;
using System.Collections.Generic;
using System.Text;

namespace SmartKueche
{

    public class Person
    {
        
        public List<Person> CreatePerson(List<Person> PersonenListe)
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

            return PersonenListe;
        }

        public void ListPerson(List<Person> PersonenListe)

        {
            Console.Clear();

            foreach (var person in PersonenListe)
            {
                Console.WriteLine($"Vor- und Nachname: {person.Vorname} {person.Nachname}\nStrasse und Strassennummer: {person.Strasse}");
                Console.WriteLine($"PLZ und Ort: {person.PLZ} {person.Ort}");
                Console.WriteLine($"Lieblingsessen: {person.Lieblingsessen}");
            }

            Console.ReadKey();
        }

        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Strasse { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }
        public string Lieblingsessen { get; set; }
    }


}
    
