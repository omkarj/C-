using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }

    public class Temparature
    {
        
        public void showTemp()
        {
            int temp = 0;
            if (temp == 0)
            {
                throw (new CustomException("Temparature is Zero"));
            }
            else
            {
                Console.WriteLine(temp);
            }
        }
    }
}

