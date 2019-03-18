using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2A8
{
    class Program
    {
        struct struPerson
        {
            public int pNr;
            public String name;
            public String surname;
        }


        static void Main(string[] args)
        {
            struPerson personA = Eingeben();
            Ausgeben(personA);
            Console.Read();
        }

        static struPerson Eingeben()
        {
            struPerson personA;

            Console.WriteLine("PersonenNr:");
            personA.pNr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vorname:");
            personA.name = Console.ReadLine();
            Console.WriteLine("Nachname:");
            personA.surname = Console.ReadLine();

            return personA;
        }



        static void Ausgeben(struPerson p)
        {
            Console.WriteLine("Nummer: " + p.pNr);
            Console.WriteLine("Vorname: " + p.name);
            Console.WriteLine("Nachname: " + p.surname);

        }
    }
}
