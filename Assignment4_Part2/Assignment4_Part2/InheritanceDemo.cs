using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Part2
{
    class Vehicle
    {
        public void displayCommonFeatures()
        {
            Console.WriteLine("Common Features of the Vehicle");
        }
    }

    class Car : Vehicle
    {
        public void show()
        {
            Console.WriteLine("Special Features of the Car");
        }
    }

    class Bike : Vehicle
    {
        public void show()
        {
            Console.WriteLine("Special Features of the Bike");
        }
    }
}
