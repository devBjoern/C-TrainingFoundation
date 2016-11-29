using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Klaus";
            p.Efternavn = "Bjørn";

            Elev e = new Elev();
            e.Fornavn = "Magnus";
            e.Efternavn = "Bjørn";
            e.Klasselokale = "2.B";

            Instruktør i = new Instruktør();
            i.Fornavn = "Bent";
            i.Efternavn = "Nygaard Nielsen";
            i.NøgleID = 12345;

            Console.WriteLine(p.Skriv());
            Console.WriteLine(e.Skriv());
            Console.WriteLine(i.Skriv());

            Console.WriteLine("----------------------------- NY ØVELSE -----------------------------");

            List<Person> lst = new List<Person>();
            lst.Add(p);
            lst.Add(e);
            lst.Add(i);
            foreach (var item in lst)
            {
                Console.WriteLine(item.Skriv());
            }


        }
    }
    class Person
    {
        public String Fornavn { get; set; }
        public String Efternavn { get; set; }

        public virtual string Skriv()
        {
            return this.Fornavn + " " + this.Efternavn;
        }
    }
    class Elev : Person
    {
        public string Klasselokale { get; set; }
        public override string Skriv()
        {
            return this.Fornavn+" "+this.Efternavn+" "+this.Klasselokale;
        }
    }
    class Instruktør :Person
    {
        public int NøgleID { get; set; }
        public override string Skriv()
        {
            return this.Fornavn+" "+this.Efternavn+" "+this.NøgleID;
        }
    }
}
