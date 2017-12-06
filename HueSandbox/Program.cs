using System;
using System.Text;
using System.Threading;
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
            Thread.Sleep(500);
            Console.WriteLine("IPs of found bridges:");
            foreach (var bridge in hue.LocatedBridges)
                Console.WriteLine(bridge.IpAddress);

            Console.WriteLine("Press any key to initialize the first bridge, for first connection you must press the bridge-button");
            Console.ReadKey();

            hue.Initialize();
            Console.WriteLine("Bridge initialized");
            Console.WriteLine("Press any key to switch out all lights");
            Console.ReadKey();
            hue.TestLight();
            Console.ReadKey();
        }
    }
}
