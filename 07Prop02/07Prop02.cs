using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Prop02
{
    class Program
    {
        static void Main(string[] args)
        {

            Person accountant = new Person();
            accountant.Fornavn = "Brian";
            accountant.Efternavn = "Jespersen";

            Person trader = new Person();
            trader.Fornavn = "Poul";
            trader.Efternavn = "Ib";

            //Console.WriteLine(accountant.Fuldtnavn());
            //Console.WriteLine(trader.Fuldtnavn());
            Console.WriteLine(accountant.FuldtNavn);
            Console.WriteLine(trader.FuldtNavn);

        }
    }

    class Person
    {
        public string Fornavn { get; set; }

        private string efternavn;

        public string Efternavn         
        {
            get { return efternavn; }
            set {
                if(value.Length <= 3)
                {
                    efternavn = "";
                }
                else
                {
                    efternavn = value;
                }

            }
        }

        //public string Fuldtnavn()
        //{
        //    return Fornavn + " " + Efternavn;
        //}

        private string fuldtNavn;

        public string FuldtNavn
        {
            get {
                fuldtNavn = Fornavn + " " + Efternavn;
                return fuldtNavn; }
        }
   
    }
}
