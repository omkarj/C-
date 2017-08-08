using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass cob = new DerivedClass();
            ClassOverridingBase cb = cob;
            cb.MyMethod();
            Console.ReadKey();
            */
            ClassOverridingBase cob = new ClassOverridingBase();
            DerivedClass cb = cob;
            cb.MyMethod();
            Console.ReadKey();
            */
        }
    }
}
