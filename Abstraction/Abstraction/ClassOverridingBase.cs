using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class ClassOverridingBase
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("Base Class");
        }
    }

    class DerivedClass : ClassOverridingBase
    {
        public override void MyMethod()
        {
            Console.WriteLine("Derived Class");
        }
    }
}
