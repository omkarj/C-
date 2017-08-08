using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class ClassAddition
    {
        public void add(int x, int y)
            {
            Console.WriteLine("Sum of {0} and {1} is {2}",x,y,x+y);
            }

        public void add(int x, int y,int z)
        {
            Console.WriteLine("Sum of {0},{1} and {2} is {3}",x,y,z, x + y + z);
        }

        public void add(int x, int y, int z,int p)
        {
            Console.WriteLine("Sum of {0},{1},{2} and {3} is {4}", x, y, z, p, x + y + z + p);
        }
    }
}
