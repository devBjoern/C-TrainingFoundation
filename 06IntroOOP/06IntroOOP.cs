using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06IntroOOP
{
    class Program
    {
        static void Main(string[] args){
            Person far;
            far = new Person();
            far.fornavn = "Klaus";
            far.efternavn = "Bjoern";
            far.foedselsAar = 1982;

            Person son;
            son = new Person("magnus", "bjoern", 2008);


            Console.WriteLine("Udskriver Far og Søn:");
            Console.WriteLine("Far navn: "+far.FuldtNavn());
            Console.WriteLine("Far alder: "+far.Alder());
            Console.WriteLine("Søn navn: "+son.FuldtNavn());
            Console.WriteLine("Søn alder: "+son.Alder());



        }
    }

    class Person
    {
        public string fornavn;
        public string efternavn;
        public int foedselsAar;

        public string FuldtNavn()
        {
            return $"{this.fornavn} {this.efternavn}";
        }

        public int Alder()
        {
            int alder;
            alder = DateTime.Today.Year - this.foedselsAar;
            return alder;
        }

        public Person()
        {
            this.fornavn = "";
            this.efternavn = "";
        }

        public Person(string fornavn, string efternavn, int foedselsAar)
        {
            this.fornavn = fornavn.ToUpper();
            this.efternavn = efternavn.ToUpper();
            this.foedselsAar = foedselsAar;
        }
    }
}

