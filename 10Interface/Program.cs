using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            TransportBånd t = new TransportBånd();
            t.Start();
            t.Stop();


            IMaskine tt = new TransportBånd();
            tt.Start();
            TransportBånd ttt = (TransportBånd)tt;
            ttt.Start();
            Console.WriteLine();

            IMaskine[] maskiner = new IMaskine[2];
            maskiner[0] = new TransportBånd();
            maskiner[1] = new Køler();
            for (int i = 0; i < maskiner.Length; i++)
            {
                //maskiner[i].Start();
                Test(maskiner[i]);
            }


            // DI (dependency injection)
            IRepository rep;
            string r = System.Configuration.ConfigurationManager.AppSettings["repository"];
            //if (DateTime.Now.Millisecond % 2 == 0) {
            if (r == "FilRepository")
            {
                rep = new FilRepository();
            }
            else
            {
                rep = new MockRepository();
            }


            //var rep = new FilRepository();
            //var rep = new MockRepository();
            var l = rep.HentAlleDyr();
            foreach (var item in l)
            {
                Console.WriteLine(item.Navn);
            }


            Console.WriteLine();

            Zoo z = new Zoo();
            z.TilføjDyr(new Dyr() { Navn = "Løve" });
            z.TilføjDyr(new Dyr() { Navn = "Tiger" });

            foreach (var item in z)
            {

            }

            using (Zoo zz = new Zoo())
            {

            }

            //{
            //    Zoo zzz = null;
            //    try
            //    {
            //        zzz = new Zoo();
            //    }
            //    finally
            //    {
            //        zzz.Dispose();
            //    }
            //}

        }

        public static void Test(IMaskine m)
        {
            // log m
            m.Start();
            // færdig
        }
    }
}