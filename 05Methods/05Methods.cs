using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursion methods
            CountToTen(1);
            Console.WriteLine();
            Console.WriteLine("Læg 5 og 2 sammen. Resultat: "+LægSammen(5,2));
            Console.WriteLine("Arealet af en cirkel med radius 5. Resultat: " + BeregnAreal(5));


            Console.ReadKey();
         

        }

        static void CountToTen(int tal) {
            if (tal < 11) { 
                Console.Write(tal);
            tal++;
            CountToTen(tal);
            

            }
        }

        static int LægSammen (int a, int b) {
            int resultat = a + b;
            return resultat;
          
        }
        static double BeregnAreal(int radius) {
            double areal = Math.Pow(radius, 2) * Math.PI;
            areal = Math.Round(areal, 2);
            return areal;
        }

    }
}
