using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Container
    {
        public Goods goods;

        public Container()
        {
            //
        }

        public Container(Goods goods)
        {
            this.goods = goods;
        }
        
        public void LoadContainer(Goods good)
        {
            this.goods = good;
        }

        public void UnloadContainer() 
        {
            this.goods = null;
        }

        public override string ToString()
        {
            return "Container contains " + goods.ToString();
        }

        public static bool Equals(Container container1, Container container2)
        {
            

            if (Goods.Equals(container1.goods, container2.goods))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Goods GetGoods()
        {
            return goods;
        }

    }
}
