using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
   public class Car : IDrivable // имя класса:имя интерфейса
    {
        public string Name;
        public double Velocity;

        double IDrivable.Velocity { get; set; }

        public void Drive(double delta)
        {
            Velocity += delta;
        }

        public void Start()
        {
            Console.WriteLine("Зажигание включено");
        }

        public void Stop()
        {
            while (Velocity > 0)
            {
                Drive(-10);              
                if (Velocity < 0) Velocity = 0;
            }
        }
    }
}
