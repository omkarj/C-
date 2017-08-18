using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {
        enum Days : short { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
        static void Main(string[] args)
        {
            var PersonDetails = Tuple.Create("Mark", "J", "Smith");
            Console.WriteLine(PersonDetails.Item1);

            var EvenNos = new Tuple<int, int, int, int, int, int, int,Tuple<int>>
                        (2, 4, 6, 8, 10, 12, 14,
                        new Tuple<int>(16));
            Console.WriteLine(EvenNos.Item1);

          

            Console.ReadLine();

        }
    }
}
