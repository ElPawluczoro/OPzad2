using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Town
    {
        string name;

        public Town(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
