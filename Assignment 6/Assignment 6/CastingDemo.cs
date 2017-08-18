using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class CastingParent
    {
        public void Display()
        {
            Console.WriteLine("This is Parent Class");
        }
    }

    class CastingChild : CastingParent
    {
        public void show()
        {
            Console.WriteLine("This is Child Class");
        }
    }
}
