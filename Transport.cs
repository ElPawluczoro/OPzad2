using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    abstract class Transport
    {
        private static int courses;

        protected Town vehicleLocation;
        //public static int maxCapacity;
        //public Container[] containers = new Container[maxCapacity];
        public Container[] containers;
        public Transport(Town vehicleLocation)
        {
            this.vehicleLocation = vehicleLocation;
           // maxCapacity = 0;
        }

        public virtual void TransportFromTo(Town from, Town to)
        {
            if (vehicleLocation == from)
            {
                vehicleLocation = to;

                courses++;

                Console.WriteLine("Succes!");
            }
            else
            {
                Console.WriteLine("Vechicle is not here");
            }
        }

        public virtual void load(ArrayList containers)
        {
            /*containers.CopyTo(this.containers);
            Console.WriteLine("Loaded");
            containers.Clear();*/
            int remove=0;
            ArrayList containersToLoad = new ArrayList();
            for (int i = 0; i < containers.Count; i++)
            {
                containersToLoad.Add(containers[i]);
                if (i + 1 == this.containers.Length)
                {
                    remove = i + 1;
                break;
                }
            }
            containersToLoad.CopyTo(this.containers);
            
            for(int i = 0; i < remove; i++)
            {
                containers.RemoveAt(0);
            }

            Console.WriteLine("Loaded");
        }



        public virtual void unload( Warehouse magazine)
        {
            ArrayList unloadedContainers = new ArrayList();
            //magazine.addContainers(unloadedContainers);

            for(int i = 0; i < containers.Length; i++)
            {
                if (containers[i] != null)
                {
                    //ArrayList unloadedContainers = new ArrayList();
                    unloadedContainers.Add(containers[i]);
                }
            }
            magazine.addContainers(unloadedContainers);
            Console.WriteLine("Unloaded");
        }

        public virtual void load(ArrayList containers, Container container)
        {
            ArrayList containersToLoad = new ArrayList();
            int remove = 0;

            Container[] containersToCompare = new Container[containers.Count];
            containers.CopyTo(containersToCompare);

            for (int i = 0; i < containers.Count; i++)
            {
                if (Goods.Equals(containersToCompare[i].GetGoods(), container.goods))
                {
                    containersToLoad.Add(containers[i]);
                    remove = i;
                    break;
                }
            }
            containers.RemoveAt(remove);
            containersToLoad.CopyTo(this.containers);
            Console.WriteLine("Loaded");
        }

        public void checkContainers()
        {
            Console.WriteLine("Vehicle magazine:");
            for (int i=0; i<containers.Length; i++)
            {
                Console.WriteLine(i + " " + containers[i]);
            }
        }

        public static void checkCourses()
        {
            Console.WriteLine("courses taken: " + courses);
        }



    }
}
