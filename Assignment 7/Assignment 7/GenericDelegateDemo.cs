using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    delegate T MyDelegate<T>(T n);

    public class GenericDelegateDemo
    {
        public static int doubleTheNumber(int i)
        {
            return i * i;
        }

        public static float divideTheNumberByTwo(float f)
        {
            return f / 2;
        }

        public void callDelegate()
        {
            MyDelegate<int> delegate1 = new MyDelegate<int>(doubleTheNumber);
            MyDelegate<float> delegate2 = new MyDelegate<float>(divideTheNumberByTwo);

            Console.WriteLine("Value after 5 is doubled : {0}",delegate1(5));
            Console.WriteLine("Value after 5 is halved : {0}", delegate2(5));

        }
    }
}
