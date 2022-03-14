using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IDrivable
    {
        double Velocity { get; set; }
        void Start();
        void Drive(double delta);
        void Stop();

    }
}
