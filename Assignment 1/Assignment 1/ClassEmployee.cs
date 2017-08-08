using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    abstract class ClassEmployee
    {
        abstract public void Salary();
        public void display(string x)
        {
            Console.WriteLine("Salary of {0}(Printing this statement from base class):",x);
        }

    }

    class Developer : ClassEmployee
    {
        public override void Salary()
        {
            Console.WriteLine("Developer salary is 5000");
        }
    }

    class Admin : ClassEmployee
    {
        public override void Salary()
        {
            Console.WriteLine("Admin salary is 6000");
        }
    }

    class Tester : ClassEmployee
    {
        public override void Salary()
        {
            Console.WriteLine("Tester salary is 4500");
        }
    }
}
