using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// First funny program, made by Klaus Cramer Bjørn
/// Doing funny things
/// </summary>
namespace _01HelloWold
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn:");
            string nameInput;
            nameInput = Console.ReadLine();
            nameInput = nameInput.ToUpper();
            Console.ForegroundColor = ConsoleColor.Cyan;

            //To print
            Console.WriteLine("Velkommen {0}", nameInput);
            Console.WriteLine("Tryk en tast for at fortsætte...");
            Console.ReadKey();
        }
    }
}
