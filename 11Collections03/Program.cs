using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Collections03
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = GetAppSettings("ip", "127.0.0.1");
            Console.WriteLine("ip: "+ip);
            double maxRecords = GetAppSettings("maxRecords", 100.00);
            Console.WriteLine("maxRecords: " + maxRecords);

            string something = GetAppSettings("klaus", "111.111.111.111");
            Console.WriteLine("klaus: " + something);

        }
        //  static string GetAppSettings(string key, string defaultValue) {
        //    var appSetting = System.Configuration.ConfigurationManager.AppSettings[key];
        //  if (appSetting == null)
        //          return defaultValue;
        //      return appSetting;
        //  }
        static T GetAppSettings<T>(string key, T defaultValue)
        {
            string result = System.Configuration.ConfigurationManager.AppSettings[key];
            if (result == null)
                return defaultValue;
            return (T)Convert.ChangeType(result, typeof(T));
        }
    }
}
