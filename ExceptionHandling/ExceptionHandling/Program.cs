using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArithmeticOperations ao = new ArithmeticOperations();
                Console.WriteLine("Enter Two Integers : ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                if (firstNumber < 0 || secondNumber < 0)
                {
                    throw (new CustomException("Input numbers cannot be negative"));
                }
                Console.WriteLine("Enter choice : \n 1.Add \n 2.Subtract \n 3.Multiply \n 4.Divide");
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Result of Addition : {0}", ao.MyAdd(firstNumber, secondNumber));
                        break;
                    case 2:
                        Console.WriteLine("Result of Subtraction : {0}", ao.MySubtract(firstNumber, secondNumber));
                        break;
                    case 3:
                        Console.WriteLine("Result of Multiplication : {0}", ao.MyMultiply(firstNumber, secondNumber));
                        break;
                    case 4:
                        Console.WriteLine("Result of Division : {0}", ao.MyDivide(firstNumber, secondNumber));
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            catch (InvalidCastException e)
            {
                Console.WriteLine(e.InnerException);
            }

            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (CustomException e)
            {
                Console.WriteLine(e.Message + " (This is a Custom Exception)");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
