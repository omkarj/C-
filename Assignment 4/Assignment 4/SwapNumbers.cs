using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class SwapNumbers
    {
        public void Swap()
        {
            try
            {
                Console.WriteLine("Enter the first number :");
                int firstNumber = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the second number :");
                int secondNumber = Convert.ToInt16(Console.ReadLine());
                int temp = secondNumber;
                secondNumber = firstNumber + secondNumber - secondNumber;
                firstNumber = temp;
                Console.WriteLine("Numbers after swapping : ");
                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);

            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
