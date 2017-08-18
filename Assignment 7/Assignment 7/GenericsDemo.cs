using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class GenericsList<T>
    {
        List<T> List = new List<T>(3);

        public void Insert(T Data)
        {
            List.Add(Data);
        }
    }
}
