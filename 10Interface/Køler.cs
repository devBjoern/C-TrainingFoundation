using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Interface
{
    class Køler : IMaskine
    {
        public void LogFejl(string txt)
        {
        }

        public bool Start()
        {
            Console.WriteLine("Nu starter køleren");
            return true;
        }

        public bool Stop()
        {
            return true;
        }
    }
}