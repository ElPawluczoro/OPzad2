using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Truck : Transport
    {

        public Truck(Town vehicleLocation) : base(vehicleLocation)
        {
            //maxCapacity = 1;
            containers = new Container[1];
        }

        public override void TransportFromTo(Town from, Town to)
        {
            Console.WriteLine("Attempting to transport from " + from + " to " + to + " by a Truck...");
            base.TransportFromTo(from, to);
        }

        public override void unload(Warehouse magazine)
        {
            base.unload(magazine);
            Array.Clear(containers, 0,1);
        }

        public override void load(ArrayList containers, Container container)
        {
            base.load(containers, container);
            Console.WriteLine(" Truck");
        }
    }
}
