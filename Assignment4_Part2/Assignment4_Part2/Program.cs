using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter the sentence : ");
            try
            {
                string sentence = Console.ReadLine();
                StringBuilder modifiedSenetence = sentence.firstCharacterUpperCase();
                Console.WriteLine("Modified sentence : {0}", modifiedSenetence);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            /*
            Console.WriteLine("Choose the vehicle type : ");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Bike ");
            try
            {
                int choice = Convert.ToInt16(Console.ReadLine());
                if (choice == 1)
                {
                    Car v = new Car();
                    v.displayCommonFeatures();
                    v.show();
                }
                else if (choice == 2)
                {
                    Bike v = new Bike();
                    v.displayCommonFeatures();
                    v.show();
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            /*
            Console.WriteLine("Choose the vehicle type : ");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Bike ");
            try
            {
                int choice = Convert.ToInt16(Console.ReadLine());
                if (choice == 1)
                {
                    IVehicle v = new Car1();
                    v.displayCommonFeatures();
                }
                else if (choice == 2)
                {
                    IVehicle v = new Bike1();
                    v.displayCommonFeatures();     
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            Console.WriteLine("Enter length & breadth of the rectangle respectively : ");
            try
            {
                int length = Convert.ToInt16(Console.ReadLine());
                int breadth = Convert.ToInt16(Console.ReadLine());
                int area = StaticClass.AreaOfRectangle(length, breadth);
                Console.WriteLine("Area of Rectangle : {0}", area);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
