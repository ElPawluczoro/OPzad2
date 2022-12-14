using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Transport> vehicles = new Dictionary<string, Transport>();

            Town gdansk = new Town("Gdańsk");
            Town newYork = new Town("New York");
            Town poznan = new Town("Poznań");
            Town wroclaw = new Town("Wrocław");
            Town krakow = new Town("Kraków");

            vehicles.Add("ship", new Ship(gdansk));
            vehicles.Add("train1", new Train(gdansk));
            vehicles.Add("train2", new Train(gdansk));
            for (int i = 1; i < 11; i++)
            {
                vehicles.Add("truck" + i, new Truck(gdansk));
            }

            Warehouse gdanskWerehouse = new Warehouse(gdansk);
            Warehouse newYorkWerehouse = new Warehouse(newYork);
            Warehouse poznanWerehouse = new Warehouse(poznan);
            Warehouse wroclawWerehouse = new Warehouse(wroclaw);
            Warehouse krakowWerehouse = new Warehouse(krakow);

            Goods electronicParts = new Goods("Electronic parts");
            Goods phones = new Goods("Phones");
            Goods shoes = new Goods("Shoes");
            Goods clothes = new Goods("Clothes");

            ArrayList containers = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                Container container = new Container();
                container.LoadContainer(electronicParts);
                containers.Add(container);     
            }
            for (int i = 0; i < 20; i++)
            {
                Container container = new Container();
                container.LoadContainer(phones);
                containers.Add(container);
            }
            for (int i = 0; i < 5; i++)
            {
                Container container = new Container();
                container.LoadContainer(shoes);
                containers.Add(container);
            }
            for (int i = 0; i < 5; i++)
            {
                Container container = new Container();
                container.LoadContainer(clothes);
                containers.Add(container);
            }

            newYorkWerehouse.addContainers(containers);

            vehicles["ship"].TransportFromTo(gdansk, newYork);
            vehicles["ship"].load(newYorkWerehouse.getContainers());
            vehicles["ship"].checkContainers();
            vehicles["ship"].TransportFromTo(newYork, gdansk);
            vehicles["ship"].unload(gdanskWerehouse);
            //vehicles["ship"].checkContainers();
            //gdanskWerehouse.checkMagazine();

            vehicles["train1"].load(gdanskWerehouse.getContainers());
            //vehicles["train1"].checkContainers();
            //gdanskWerehouse.checkMagazine();
            vehicles["train2"].load(gdanskWerehouse.getContainers());
            //vehicles["train2"].checkContainers();
            //gdanskWerehouse.checkMagazine();

            vehicles["train1"].TransportFromTo(gdansk, wroclaw);
            vehicles["train1"].unload(wroclawWerehouse);
            wroclawWerehouse.checkMagazine();
            vehicles["train2"].TransportFromTo(gdansk, wroclaw);
            vehicles["train2"].unload(wroclawWerehouse);
            wroclawWerehouse.checkMagazine();
            for(int i = 1; i < 6; i++)
            {
                vehicles["truck" + i].TransportFromTo(gdansk, wroclaw);
                vehicles["truck" + i].load(wroclawWerehouse.getContainers(), new Container(shoes));
                vehicles["truck" + i].TransportFromTo(wroclaw, poznan);
                vehicles["truck" + i].checkContainers();
                vehicles["truck" + i].unload(poznanWerehouse);
            }
            for (int i = 6; i < 11; i++)
            {
                vehicles["truck" + i].TransportFromTo(gdansk, wroclaw);
                vehicles["truck" + i].load(wroclawWerehouse.getContainers(), new Container(clothes));
                vehicles["truck" + i].TransportFromTo(wroclaw, poznan);
                vehicles["truck" + i].checkContainers();
                vehicles["truck" + i].unload(poznanWerehouse);
            }
            //wroclawWerehouse.checkMagazine();
            //poznanWerehouse.checkMagazine();

            for (int i = 1; i < 11; i++)
            {
                vehicles["truck" + i].TransportFromTo(poznan, wroclaw);
                vehicles["truck" + i].load(wroclawWerehouse.getContainers(), new Container(electronicParts));
                vehicles["truck" + i].TransportFromTo(wroclaw, krakow);
                vehicles["truck" + i].unload(krakowWerehouse);
            }
           // wroclawWerehouse.checkMagazine();
            //krakowWerehouse.checkMagazine();
            Transport.checkCourses();








        }
    }
}
