using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
    
    private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
        int tal2 = Convert.ToInt32(Console.ReadLine());
        int res = tal1 + tal2;
        Console.WriteLine("resultatet er "+res);
        }
    }
}
