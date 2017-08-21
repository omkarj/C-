using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class GenericClassDemo<T>
    {
        private T[] arrayOfElements;
        
        public GenericClassDemo(int sizeOfArray)
        {
            arrayOfElements = new T[sizeOfArray];
        }

        public T fetchItem(int i)
        {
            return arrayOfElements[i];
        }

        public void insertItem(T element, int i)
        {
            arrayOfElements[i] = element;
        }
    }
}
