using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var plane = new Plane();

            IDrivable[] vehicles = new IDrivable[] { car,plane};
          
            foreach (var vehicle in vehicles)
                vehicle.Start();
           
            Console.ReadKey();
        }
    }
}
