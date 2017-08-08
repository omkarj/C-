using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Birds
    {
        public void BirdType()
        {
            Console.WriteLine("Bird Can walk");
        }
    }

    public class Bird1 : Birds
    {
        public void BirdType1()
        {
            BirdType();
            Console.WriteLine("Bird Can fly");
        }
    }


    public class Bird2 : Birds
    {
        public void BirdType2()
        {
            BirdType();
            Console.WriteLine("Bird Can sing");
        }
    }
}

