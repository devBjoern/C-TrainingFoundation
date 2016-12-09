using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Interface
{
    class FilRepository
    {
        public List<Dyr> HentAlleDyr()
        {
            var a = System.IO.File.ReadAllLines("dyrenavne.txt");
            List<Dyr> d = new List<Dyr>();
            foreach (var item in a)
            {
                d.Add(new _10Interface.Dyr() { Navn = item });
            }
            return d;
        }
    }
}
