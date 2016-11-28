using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace _07Prop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Areal af firkant med l og b = 10:");
            Console.WriteLine(Arealberegninger.BeregnArealFirkant(10,10));
            Console.WriteLine("Areal af cirkel med radius 10:");
            Console.WriteLine(Arealberegninger.BeregnArealCirkel(10));
            
        }
    }

    public static class Arealberegninger
    {
        public static double BeregnArealFirkant(double højde, double bredde)
        {
            return højde * bredde;
        }

        public static double BeregnArealCirkel(double radius)
        {
            return Math.Round(Math.Pow(radius, 2) * Math.PI,3);
        }
    }
}
