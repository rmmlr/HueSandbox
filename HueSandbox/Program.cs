using Q42.HueApi;
using Q42.HueApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rca.HueSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hue-Sandbox :)");

            var hue = new HueWrapper();
            Console.WriteLine("Scanning for bridges...");
            hue.ScanBridges();
            Console.WriteLine("IPs of found bridges:");
            foreach (var bridge in hue.LocatedBridges)
                Console.WriteLine(bridge.IpAddress);

            Console.WriteLine("Press any key to initialize the first bridge, for first connection you must press the bridge-button");
            Console.ReadKey();

            hue.Initialize();
            Console.WriteLine("Bridge initialized");
            Console.ReadKey();
        }
    }
}
