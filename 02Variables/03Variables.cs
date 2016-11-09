using System;

namespace _02Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNumber = 10;
            Console.WriteLine("intNumber = " + intNumber);
            intNumber++;
            Console.WriteLine("intNumber = " + intNumber);
            intNumber--;
            Console.WriteLine("intNumber = " + intNumber);
            intNumber += 20;
            Console.WriteLine("intNumber = " + intNumber);


            double doubleNumber = 12.5;
            Console.WriteLine("doubleNumber = " + doubleNumber);
            doubleNumber++;
            Console.WriteLine("doubleNumber = " + doubleNumber);
            doubleNumber--;
            Console.WriteLine("doubleNumber = " + doubleNumber);
            doubleNumber *= 2;
            Console.WriteLine("doubleNumber = " + doubleNumber);

            FilTyper ft = FilTyper.csv;
            Console.WriteLine("Printing the ft text = " + ft);
            Console.WriteLine("Printing the ft value = " + (int)ft);

            DateTime myTime = DateTime.Now;
            Console.WriteLine("myTime now = " + myTime.ToString("ddMMyy"));
            Console.WriteLine("myTime now = " + myTime.ToString("dd. MMMM, yyyy"));

            Person p = new Person();
            p.Id = 1;
            p.Navn = "Mikkel";

            Console.WriteLine("Personen p's navn er nu: " + p.Navn);


            Console.ReadKey();
        }
            struct Person {
            public int Id;
            public string Navn;
        }       


            enum FilTyper {csv, pdf, txt};
        
    }
}
