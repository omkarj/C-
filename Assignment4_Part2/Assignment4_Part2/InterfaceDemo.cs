using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Part2
{

    interface IVehicle
    {
        void displayCommonFeatures();
    }

    class Car1 : IVehicle
    {
        public void displayCommonFeatures()
        {
            Console.WriteLine("Common Features of the vehicle");
            Console.WriteLine("Special Features of the Car");
        }
    }

    class Bike1 : IVehicle
    {
        public void displayCommonFeatures()
        {
            Console.WriteLine("Common Features of the vehicle");
            Console.WriteLine("Special Features of the Car");
        }
    }
}
