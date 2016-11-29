using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Plymorphism02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] dyr = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }
            foreach (var item in dyr)
            {
                item.SigNoget();
            }
        }
    }
    class Dyr
    {
        public String Navn { get; set; }
        static Random rnd = new Random();

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder "+this.Navn);
        }

        public static Dyr TilfældigtDyr()
        {
            string sti = @"C:\Dyr\dyrenavne.txt";
            string[] dyreNavne = System.IO.File.ReadAllLines(sti);

            int tilfældigtDyr = rnd.Next(0, dyreNavne.Length);

            if (tilfældigtDyr % 2 == 0)
            {
                return new Hund(dyreNavne[tilfældigtDyr]);
            }
            else
            {
                return new Kat(dyreNavne[tilfældigtDyr]);
            }
        }
    }
    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder " +this.Navn);
        }
        public Hund(string navn)
        {
            this.Navn = navn;
        }
    }
    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder " +this.Navn);
        }
        public Kat(string navn)
        {
            this.Navn = navn;
        }

    }
}
