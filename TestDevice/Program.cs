using System;
using System.Net;
using DeviceEmulator;

namespace TestDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            var device = new SwitchDevice("Test", 1234, IPAddress.Parse("192.168.2.121"), 8100);

            var upnp = new UpnpBroadcastResponder();
            upnp.AddDevice(device);

            Console.ReadLine();
        }
    }
}
