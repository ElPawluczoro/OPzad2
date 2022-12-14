using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Warehouse
    {
        private Town location;
        private ArrayList containersInWerehouse = new ArrayList();

        public Warehouse(Town location)
        {
            this.location = location;
        }

        public void addContainers(ArrayList containers)
        {
            //containersInWerehouse = new ArrayList(containers);
            for (int i = 0; i < containers.Count; i++)
            {
                if (containers[i] != null)
                {
                    containersInWerehouse.Add(containers[i]);
                }
            }
            containers.Clear();
        }
        
        public ArrayList getContainers()
        {
            return containersInWerehouse;
        }

        public void checkMagazine()
        {
            Console.WriteLine("Werehouse Magazine");
            for(int i = 0; i < containersInWerehouse.Count; i++)
            {
                Console.WriteLine(i + " " + containersInWerehouse[i]);
            }
        }


    }
}
