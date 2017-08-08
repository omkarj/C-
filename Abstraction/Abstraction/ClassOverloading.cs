using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class ClassOverloading
    {
        public void Sum()
        {
            Console.WriteLine("no value");
        }

        public void Sum(int x, int y)
        {
            Console.WriteLine("SUM of {0} and {1} is {2}",x,y,(x+y));
        }

     
        public void Sum(double x, double y)
        {
            Console.WriteLine("SUM of {0} and {1} is {2}", x, y, (x + y));
        }

        public void Sum(float x, float y)
        {
            Console.WriteLine("SUM of {0} and {1} is {2}", x, y, (x + y));
        }
    }
}
