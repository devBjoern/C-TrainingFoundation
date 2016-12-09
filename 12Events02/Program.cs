using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Events02
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;
            w.Changed += W_Changed;
            w.Created += W_Created;
            w.Deleted += W_Deleted;
            w.Renamed += W_Renamed;
            do
            {

            } while (true);
            

        }

        private static void W_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            Console.WriteLine("Filen: " + e.Name + " er rettet. Der skete det at: " + e.ChangeType);
        }

        private static void W_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Filen: " + e.Name + " er rettet. Der skete det at: " + e.ChangeType);
        }

        private static void W_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Filen: " + e.Name + " er rettet. Der skete det at: " + e.ChangeType);
        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Filen: "+e.Name+" er rettet. Der skete det at: " + e.ChangeType);
        }

    }
}
