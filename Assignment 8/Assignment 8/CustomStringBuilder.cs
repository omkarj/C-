using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    public class CustomStringBuilder<T> 
    {
        private T[] arrayOfElements;
        private int i;
        public CustomStringBuilder()
        {
            arrayOfElements = new T[1000];
            i = 0;
        }

        public void CustomAppend(T element)
        {
            arrayOfElements[i] = element;
            i++;
        }

        public void CustomRemove()
        {
            i--;
            arrayOfElements[i] = default(T);
        }

        public void CustomDisplay()
        {
            foreach (var v in arrayOfElements)
            {
                Console.Write(v);
            }
        }
    }
}
