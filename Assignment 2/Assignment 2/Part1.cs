using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Pattern
    {
        public void PatternPrinting()
        {
            int levels = 8;
            String asterik ="********";
            while (levels != 0)
            {
                Console.Write(" ".PadLeft(levels));
                Console.Write(asterik.Substring(0, asterik.Length - (levels-1)));  
                levels--;
                Console.WriteLine();          
            }
        }
        
    }

    class Palindrome
    {
        public void PalindromeCheck()
        {
            Console.WriteLine("Enter string :");
            String inputString = Console.ReadLine();
            String reversedString = new String(inputString.Reverse().ToArray());
            if (inputString == reversedString)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not a Palindrome");
            }
        }
    }

    class Duplicate
    {
        public void RemoveDuplicate()
        {
            Console.WriteLine("Enter the sentence :");
            try
            {
                String inputSentence = Console.ReadLine();
                String newSentence = string.Join(" ", inputSentence.Split(' ').Distinct());
                Console.WriteLine(newSentence);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
