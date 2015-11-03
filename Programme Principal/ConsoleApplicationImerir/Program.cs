using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationImerir
{
   

    class Program
    {
        static TDx.TDxInput.Device device;

        static void Main(string[] args)
        {
            device = new TDx.TDxInput.Device();
            device.Connect();

            Console.WriteLine("Hello world");


            while (true)
            {
                var translation = device.Sensor.Translation;
                var rotation = device.Sensor.Rotation;

                Console.WriteLine("translation X : " + translation.X);
                Console.WriteLine("Rotation X : " + rotation.X);

                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}
