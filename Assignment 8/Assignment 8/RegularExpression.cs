using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_8
{
    class RegularExpression
    {
        public void RegExForPhoneNumber()
        {
            Console.WriteLine(@"/*Regular Expression to verify the pattern 'xxx-xxxx' \n Enter the phone number : ");
            string PhoneNumber = Console.ReadLine();
            string RegExPattern = @"^\d{3}-\d{4}$";
            Regex r = new Regex(RegExPattern, RegexOptions.IgnoreCase);
            Match m = r.Match(PhoneNumber);
            if (m.Success)
            {
                Console.WriteLine("Phone number is in correct format");
            }
            else
            {
                Console.WriteLine("Phone number is not in correct format");
            }
        }

        public void RegExForExtraWhiteSpaces()
        {
            Console.WriteLine(@"/*Regular Expression to remove extra white spaces \n Enter the string : ");
            string InputString = Console.ReadLine();
            string RegExPattern = "\\s+";
            string ReplacePattern = " ";
            Regex r = new Regex(RegExPattern);
            InputString = r.Replace(InputString, ReplacePattern);
            Console.Write("String after removing extra spaces : {0}", InputString);
        }
    }
}
