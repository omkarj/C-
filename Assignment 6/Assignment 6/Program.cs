using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CheckedUncheckedOperator c = new CheckedUncheckedOperator();
            c.Operator();
            */

            AsDemo i = new AsDemo();
            i.AsOperator();
            
            /*
            SizeOf s = new SizeOf();
            s.SizeOfDemo();
            */

            /*
            int i = 20;
            object o = i;
            i = 40;
            i = (int)o;
            Console.WriteLine(i);
            Console.WriteLine(o);
            */

            /*
            ReferenceDemo r1 = new ReferenceDemo();
            ReferenceDemo r2 = new ReferenceDemo();
            Console.WriteLine(ReferenceEquals(null, null));
            Console.WriteLine(ReferenceEquals(r1, null));
            Console.WriteLine(ReferenceEquals(r1, r2));
            Console.WriteLine(Equals(r1, r2));
            */

            /*
            CastingChild cc = new CastingChild();
            cc.Display();
            cc.show();
            */
            /*
            CastingParent cp1 = new CastingChild();
            CastingParent cp2 = new CastingParent();
            CastingChild cc1 = (CastingChild)cp1;
            //CastingChild cc2 = (CastingChild)cp2;
            cc1.Display();
            cc1.show();
            */
            Console.ReadLine();
        }
    }
}
