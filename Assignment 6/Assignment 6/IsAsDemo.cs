using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
 /*   class IsAsDemo
    {
        public void IsAs()
        {
            int a = 200000;
            int b = 300000;

            if (a is float)
            {
                Console.WriteLine("a is int");
            }
            else
            {
                Console.WriteLine("a is not int");
            }
        }

    */
        class c1
        {
            public void Display()
            {
                Console.WriteLine("hi");
            }
        }
        class c2
        { }

    class AsDemo
    {
        public void AsOperator()
        {
            object[] myObject = new object[6];
            myObject[0] = new c1();
            myObject[1] = new c2();
            myObject[2] = "string";
            myObject[3] = 32;
            myObject[4] = new c1();
            for (int i = 0; i < myObject.Length; ++i)
            {
                string s = myObject[i] as string;
                Console.WriteLine("{0}", i);
                if (s != null)
                {
                    Console.WriteLine("'" + s + "'");
                }
                else
                {
                    Console.WriteLine("Not a string");
                }
            }
        }
    }
}



        