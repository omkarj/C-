using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class GenericMethodDemo
    {
        public static void swappingVariables<T>(ref T x, ref T y)
        {
            T tempVariable;
            tempVariable = x;
            x = y;
            y = tempVariable;
        }
    }
}
