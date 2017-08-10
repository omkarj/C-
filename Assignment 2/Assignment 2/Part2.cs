using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class DegreeToFarenheit
    {
        public void TemperatureConversion()
        {
            Console.Write("Enter temperature in Degrees : ");

            try
            {
                int tempInDegree = Convert.ToInt16(Console.ReadLine());
                int tempInfaren = (tempInDegree * 9) / 5 + 32;
                Console.WriteLine("Temperature in Farenheit : {0}", tempInfaren);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

    class LongestWordInSentence
    {
        public void findLongestWord()
        {
            Console.WriteLine("Enter the sentence :");
            try
            {
                String inputSentence = Console.ReadLine();
                inputSentence = string.Join(" ", inputSentence.Split(' ', '.').Distinct());
                String[] wordArray = inputSentence.Split(' ', '.');
                //int maxWordLength = wordArray.Max(w => w.Length);
                int maxWordLength = 0;
                for (int i = 0; i < wordArray.Length; i++)
                {
                    if (maxWordLength < wordArray[i].Length)
                    {
                        maxWordLength = wordArray[i].Length;
                    }
                }
                Console.WriteLine("Maximum word length : {0}",maxWordLength);
                Console.WriteLine("Longest word/words in the sentence is/are :");
                for (int i = 0; i < wordArray.Length; i++)
                {
                    if (maxWordLength == wordArray[i].Length)
                    {
                        Console.WriteLine( wordArray[i]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }      
    }

    class PrimeNumbers
    {
        public void SumOfPrimeNumbers()
        {
            //Console.WriteLine("Sum of first 500 prime numbers :");
           // bool isPrimeNumber = true;
            int sum = 0, primeNumberCount=0;
            
                for (int i = 1; primeNumberCount <= 5; ++i)
                {
                    for (int j = 2; j <= Math.Ceiling(Math.Sqrt(i)); ++j)
                    {
                        if (i % j != 0)
                        {
                            break;
                        }
                        else
                        {
                            primeNumberCount = +1;
                            sum = +i;
                        }
                    }
                    
                }

                Console.WriteLine("Sum of first 500 prime numbers : {0}",sum);
         }
    }

    class Digits
    {
        public void SumOfDigits()
        {
            Console.WriteLine("Enter the number :");
            try
            {
                int inputNumber = Convert.ToInt32( Console.ReadLine());
                int sum = 0, remainder;
                while (inputNumber != 0)
                {
                    remainder = inputNumber % 10;
                    inputNumber = inputNumber / 10;
                    sum = sum + remainder;
                }
                Console.WriteLine("Sum of Digits : {0}", sum);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

    class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Enter the year :");
            try
            {
                int inputYear = Convert.ToInt32(Console.ReadLine());
                if ((inputYear % 4 == 0 && inputYear % 100 != 0) || (inputYear % 400 == 0))
                {
                    Console.WriteLine("{0} is a Leap Year", inputYear);
                }
                else
                {
                    Console.WriteLine("{0} is not a Leap Year", inputYear);
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

    class LargestNumber
    {
        public void findingLargestNumber()
        {
            try
            {
                Console.Write("Input the 1st number : ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the 2nd number : ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the 3rd number : ");
                int z = Convert.ToInt32(Console.ReadLine());
                int [] a = new int[] { x, y, z };
                int maxValue = a.Max();
                int maxIndex = a.ToList().IndexOf(maxValue);
                Console.WriteLine("Input number {0} is largest", maxIndex+1);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

    class VowelConsonant
    {
        public void checkVowelConsonant()
        {
            Console.WriteLine("Enter the alphabet :");
            try
            {
                string s = Console.ReadLine();
                char inputChar = Convert.ToChar(s);
                bool isVowel = "aeiouAEIOU".IndexOf(inputChar) >= 0;
                if (isVowel)
                {
                    Console.WriteLine("The alphabet is a vowel");
                }
                else
                {
                    Console.WriteLine("The alphabet is a consonant");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

    class Binary
    {
        public void DecimalToBinary()
        {
            Console.Write("Enter the decimal number :");
            try
            {
                string s = Console.ReadLine();
                int decimalNumber = Convert.ToInt32(s);
                string binary = Convert.ToString(decimalNumber, 2);
                Console.WriteLine("Binary value : {0}", binary);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

    class DiamondPattern
    {
        public void DiamondPatternPrinting()
        {
            try
            {
                int n = 5;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j < (n - i); j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                for (int i = n - 1; i >= 1; i--)
                {
                    for (int j = 0; j < (n - i); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }

    }

    class PyramidPattern
    {
        public void NumberPatternPrinting()
        {
            try
            {
                Console.Write("Enter number of levels : ");
                int levels = Convert.ToInt32(Console.ReadLine());
                int  blanks, number;
                for (int i = 1; i <= levels; i++)
                {
                    for (blanks = 1; blanks <= (levels - i); blanks++)
                    {
                        Console.Write(" ");
                    }
                    for (number = 1; number <= i; number++)
                    {
                        Console.Write(number);
                    }
                    for (number = (i - 1); number >= 1; number--)
                    {
                        Console.Write(number);
                    }
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

    class Cubes
    {
        public void PrintingCubes()
        {
            Console.WriteLine("Enter a digit : ");
            try
            {
                int digit = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= digit; i++)
                {
                    Console.WriteLine("Cube of  number {0} : {1}", i, (i * i * i));
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
