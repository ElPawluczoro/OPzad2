using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Goods
    {
        private string name;

        public Goods(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

        public static bool Equals(Goods goods1, Goods goods2)
        {
           if (goods1.name == goods2.name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

    }
}
