using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bird1 b1 = new Bird1();
            Bird2 b2 = new Bird2();
            b1.BirdType1();
            b2.BirdType2();
            */

            /*
            ClassAddition ca = new ClassAddition();
            ca.add(3, 4);
            ca.add(5, 4, 8);
            ca.add(6, 7, 3, 5);
            */

            /*
            Console.WriteLine("Enter 1 to send email or 2 to send SMS");
            String input = Console.ReadLine();
            int choice = Convert.ToInt32(input);

            if (choice == 1)
            {
                ClassNotification cn = new ClassNotification();
                cn.Notify();
            }
            else
            {
                NotifyThroughSMS cn = new NotifyThroughSMS();
                cn.Notify();
            }
            */
            /*
            Console.WriteLine("Enter choice:\n 1.Developer \n 2. Admin \n 3. Tester");
            String input = Console.ReadLine();
            int choice = Convert.ToInt32(input);
            ClassEmployee d;

            if (choice == 1)
            {
                d = new Developer();
                d.display("Developer");
                d.Salary();
                
            }
            else if(choice == 2)
            {
                d = new Admin();
                d.display("Admin");
                d.Salary();
            }
            else
            {
                d = new Tester();
                d.display("Tester");
                d.Salary();
            }*/
            Console.WriteLine("HI");
            Console.ReadKey();
        }
    }
}
