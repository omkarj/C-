using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            EventsExample1 e = new EventsExample1();
            Listener l = new Listener();
            l.Subscribe(e);
            e.Start();
            */
            /*
            EmployeeData e = new EmployeeData();
            e.DisplayEmployeeData();
            */

            DelegateExample d = new DelegateExample();
            d.CallDelegates(d);

            Console.ReadKey();
        }
    }
}