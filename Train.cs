using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Train : Transport
    {


        public Train(Town vehicleLocation) : base(vehicleLocation)
        {
            // maxCapacity = 20;
            containers = new Container[20];
        }

        public override void TransportFromTo(Town from, Town to)
        {
            Console.WriteLine("Attempting to transport from " + from + " to " + to + " by a Train...");
            base.TransportFromTo(from, to);
        }

        public override void unload(Warehouse magazine)
        {
            base.unload(magazine);
            Array.Clear(containers, 0, 20);
        }

        public override void load(ArrayList containers)
        {
            base.load(containers);
            Console.WriteLine(" Train");
        }
    }
}
