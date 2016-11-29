using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Prop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program startes");
            Console.WriteLine("Class Init");
            Trekant triangle = new Trekant();
            Console.WriteLine("triangle created, values:");
            Console.WriteLine("Grundlinje: "+triangle.Grundlinje);
            Console.WriteLine("Højde: "+ triangle.Højde);
            Console.WriteLine("Areal: "+triangle.Areal);
            Console.WriteLine("Setting new values.");
            Console.WriteLine("Set Grundlinje: ");
            triangle.Grundlinje = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Set Højde: ");
            triangle.Højde = Int32.Parse(Console.ReadLine());
            Console.WriteLine("triangle changed, new values:");
            Console.WriteLine("Grundlinje: " + triangle.Grundlinje);
            Console.WriteLine("Højde: " + triangle.Højde);
            Console.WriteLine("Areal: " + triangle.Areal);

        }
    }

    class Trekant
    {
        public int Grundlinje { get; set; }
        public int Højde { get; set; }

        public Trekant()
        {
            this.Grundlinje = 30;
            this.Højde = 50;
        }

        private double result;

        public double Areal
        {
            get
            {
                result = this.Grundlinje * this.Højde * 0.5;
                return Math.Round(result, 2);
            }

        }

    }
    }
