using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    static class ExtensionMethod
    {
        public static void CheckLogin(this int i)
        {
            if (i == 1)
                Console.WriteLine("Login Successful");
            else
                Console.WriteLine("Login Unsuccessful");
        }
    }
}
