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

            string[] navnArray = { fornavn,efternavn};

            foreach (var item in navnArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
