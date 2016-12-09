using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int hesteIFolden = 13;
            int hesteIStalden = 2;

            Console.WriteLine("Før Swap");
            Console.WriteLine(hesteIFolden+" "+hesteIStalden);
            Console.WriteLine("Efter swap");
            Swap(ref hesteIFolden, ref hesteIStalden);
            Console.WriteLine(hesteIFolden + " " + hesteIStalden);

        }
        public static void Swap<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
