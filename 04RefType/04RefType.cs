using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04RefType
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Klaus";
            string efternavn = "Cramer Bjørn";

            string samletNavn;
            samletNavn = $"{fornavn} {efternavn}";
            Console.WriteLine("samletNavn: " + samletNavn);

            string navnStort;
            navnStort = samletNavn.ToUpper();
            Console.WriteLine("navnStort: " + navnStort);

            string navnLille;
            navnLille = samletNavn.ToLower();
            Console.WriteLine("navnLille: " + navnLille);

            string del;
            del = samletNavn.Substring(14);
            Console.WriteLine("delNavn: " + del);

            string testSplit;
            testSplit = fornavn + "," + efternavn;

            string[] navnArray = testSplit.Split(',');

            foreach (var item in navnArray)
            {
                Console.WriteLine(item);
            }

            // Int array med variable månedslønninger

            int[] monthSalaries = new int[7];
            Random rndSalary = new Random();

            for (int i = 0; i < 7; i++)
            {
                monthSalaries[i] = rndSalary.Next(40000, 100000);
                Console.WriteLine("Salary " + i + " :" + monthSalaries[i]);
            }

            double avgSalary = Math.Round(monthSalaries.Average(),2);
            
            Console.WriteLine("Average salary is: " + avgSalary);

            Array.Sort(monthSalaries);
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Salary " + i + " :" + monthSalaries[i]);
            }


            Console.WriteLine();
            Console.WriteLine("Her kommer den svedigste tabel:");
            for (int xAkse = 1; xAkse < 11; xAkse++)
            {
                
                for (int yAkse = 1; yAkse < 11; yAkse++)
                {
                    int temp = yAkse * xAkse;
                    if (temp > 49)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    string tal = temp.ToString();
                    Console.Write(tal.PadLeft(4));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
