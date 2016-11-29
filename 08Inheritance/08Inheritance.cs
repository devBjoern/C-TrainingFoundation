using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv persons fornavn:");
            string fornavnP = Console.ReadLine();
            Console.WriteLine("Skriv persons Efternavn:");
            string efternavnP = Console.ReadLine();
            Person person = new Person(fornavnP,efternavnP);

            Console.WriteLine("Skriv elevs fornavn:");
            string fornavnE = Console.ReadLine();
            Console.WriteLine("Skriv elevs Efternavn:");
            string efternavnE = Console.ReadLine();
            Elev elev = new Elev(fornavnE,efternavnE);

            Console.WriteLine("Skriv instruktørs fornavn:");
            string fornavnI = Console.ReadLine();
            Console.WriteLine("Skriv instruktørs Efternavn:");
            string efternavnI = Console.ReadLine();
            Instruktør instruktør = new Instruktør(fornavnI,efternavnI);

            Console.WriteLine("Person navn: "+person.Fuldtnavn());
            Console.WriteLine("Elev navn: " + elev.Fuldtnavn());
            Console.WriteLine("Instruktør navn: " + instruktør.Fuldtnavn());

            

        }
        class Person
        {
            public String Fornavn { get; set; }
            public String Efternavn { get; set; }

            public virtual string Fuldtnavn()
            {
                return this.Fornavn + " " + this.Efternavn;
            }

            public Person(String fornavn = "John", String efternavn = "Doe")
            {
                this.Fornavn = fornavn;
                this.Efternavn = efternavn;
            }
        }
        class Elev : Person
        {
            public String Klasselokale { get; set; }
            public Elev(string fornavn, string efternavn) : base(fornavn, efternavn)
            {

            }

            //Polymorphism overriding virtual methods
            public override string Fuldtnavn()
            {
                return base.Fuldtnavn();
            }
        }
        class Instruktør : Person
        {
            public int NøgleId { get; set; }
            public Instruktør(string fornavn, string efternavn) : base(fornavn, efternavn)
            {

            }
        }
        
    }
}
