using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Ship : Transport
    {

        public Ship(Town vehicleLocation) : base(vehicleLocation)
        {
            // maxCapacity = 90;
            containers = new Container[90];
        }

        public override void TransportFromTo(Town from, Town to)
        {
            Console.WriteLine("Attempting to transport from " + from + " to " + to + " by a Ship...");
            base.TransportFromTo(from, to);
        }

        public override void unload(Warehouse magazine)
        {
            base.unload(magazine);
            Array.Clear(containers, 0, 90);
        }

        public override void load(ArrayList containers)
        {
            base.load(containers);
            Console.WriteLine(" Ship");
        }
    }
}
