using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Events
{
    class Program
    {
        public delegate int Beregn(int a, int b);
        public delegate int Beregner(int a, int b);
        static void Main(string[] args)
        {
            Beregn beregnResultatAfPlus = Program.Divider;
            Console.WriteLine(beregnResultatAfPlus(5,10));

            Console.WriteLine(Beregning(100,10,Minus));


        }

        public static int Beregning(int a, int b, Beregner funktion) {
            return funktion(a, b);
        }
        public static int Plus(int a, int b){
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a, int b)
        {
            return a / b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }

    }
}
