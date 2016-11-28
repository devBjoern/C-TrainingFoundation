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
            //Recursive methods
            Console.WriteLine("Recursive method counting to 10:");
            CountToTen(1);
            Console.WriteLine();

            // Other interesting practises

            Console.WriteLine("Læg 5 og 2 sammen. Resultat: "+LægSammen(5,2));
            Console.WriteLine();
            Console.WriteLine("Arealet af en cirkel med radius 5. Resultat: " + BeregnAreal(5));
            Console.WriteLine();
            Console.WriteLine("Write what you want to print:");
            consolePrint(Console.ReadLine());
            consolePrint();
            Console.WriteLine();
            Console.WriteLine("Calling calculation with assigned percentage:");
            calculateToll(100, 0.50);
            Console.WriteLine("Calling calculation with unassigned percentage:");
            calculateToll(100);
            Console.WriteLine();
            Console.WriteLine("Values given 5, 800, 2000:");
            int[] averageNumbers = { 5, 800, 2000 };
            Console.WriteLine("Result: "+avgOfArray(averageNumbers));
            Console.ReadKey();
         

        }
        // Recursive method, calling itself to count numbers 1-10, without using for, while...
        static void CountToTen(int tal) {
            if (tal < 11) { 
                Console.Write(tal);
            tal++;
            CountToTen(tal);
            

            }
        }

        static int LægSammen (int a, int b) {
            Console.WriteLine("Method for addition of 5 and 2:");
            int resultat = a + b;
            return resultat;
          
        }
        static double BeregnAreal(int radius) {
            Console.WriteLine("Method for calculating a cirkel");
            double areal = Math.Pow(radius, 2) * Math.PI;
            areal = Math.Round(areal, 2);
            return areal;
        }

        static void consolePrint(string inputPrint){
            Console.WriteLine("Method for printing written text:");
            Console.WriteLine(inputPrint);
        }
        static void consolePrint()
        {
            Console.WriteLine("Method for printing an empty line:");
            Console.WriteLine();
            Console.WriteLine("Empty line done.");
        }

        static double calculateToll(double price, double tollPercentage=0.25) {
            Console.WriteLine("Method with default:");
            Console.WriteLine("Print values:"+"Price: "+price + " Percentage: "+tollPercentage);
            double tollResult;
            tollResult = (price * tollPercentage);
            Console.WriteLine("Result: "+tollResult);
            return tollResult;
        }

        static double avgOfArray(int[] simpleArray)
        {
            Console.WriteLine("Calculating average of an array of integers:");
            double avgOfArray;
            avgOfArray = simpleArray.Average();
            return avgOfArray;
        }
    }
}
