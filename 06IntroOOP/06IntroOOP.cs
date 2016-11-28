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

            Person mor;
            mor = new Person("Sarah", "bjoern", 1981, "kvinde");


            Console.WriteLine("Udskriver Far og Søn:");
            Console.WriteLine("Far navn: "+far.getFuldtNavn());
            Console.WriteLine("Far alder: "+far.getAlder());
            Console.WriteLine("Søn navn: "+son.getFuldtNavn());
            Console.WriteLine("Søn alder: "+son.getAlder());
            Console.WriteLine("Søn køn: " +son.getGender());
            Console.WriteLine("Mor navn: " + mor.getFuldtNavn());
            Console.WriteLine("Mor alder: " + mor.getAlder());
            Console.WriteLine("Mor køn: " + mor.getGender());

        }
    }

    class Person
    {
        public string fornavn;
        public string efternavn;
        public int foedselsAar;
        private string gender;

        public string getFuldtNavn()
        {
            return $"{this.fornavn} {this.efternavn}";
        }

        public int getAlder()
        {
            int alder;
            alder = DateTime.Today.Year - this.foedselsAar;
            return alder;
        }

        public string getGender()
        {
            if(this.gender=="mand")
            return $"{this.gender}";
            else
            {
                return "Ja";
            }
        }

        public Person()
        {
            this.fornavn = "";
            this.efternavn = "";
        }

        public Person(string fornavn, string efternavn, int foedselsAar, string gender="mand")
        {
            this.fornavn = fornavn.ToUpper();
            this.efternavn = efternavn.ToUpper();
            this.foedselsAar = foedselsAar;
            this.gender = gender;
        }
    }
}

