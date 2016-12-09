using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChanged
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.PropertyChanged += P1_PropertyChanged;
            p1.ID = 1;
            p1.Name = "Oluf Sand";
            var persin = new { navn = "bøf", indikator = 23.23 };
        }

        private static void P1_PropertyChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Egenskab rettet");
        }
    }
}
