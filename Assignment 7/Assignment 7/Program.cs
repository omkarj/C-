using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {

        static void Main(string[] args)
        {
            //GenericClassDemo<int> arrayOfInt = new GenericClassDemo<int>(8);
            //GenericClassDemo<string> arrayOfString = new GenericClassDemo<string>(8);  
            //int i;
            //string s = "aaaaaaaaaaaaaaaaaaaaa";
            //for (i = 0; i < 8; i++)                                                   //Generic Class Demo
            //{
            //    arrayOfInt.insertItem(i + 100, i);
            //    arrayOfString.insertItem(s.Substring(0,i+1), i);
            //}
            //Console.WriteLine("Integer Item at index 4 : {0}", arrayOfInt.fetchItem(3));
            //Console.WriteLine("String Item at index 5 : {0}", arrayOfString.fetchItem(4));


            //int i = 1, j = 2;
            //string a = "aaa", b = "bbb";

            //Console.WriteLine("Before swapping : \n i : {0} \n j : {1} \n a : {2} \n b : {3}", i, j, a, b);
            //GenericMethodDemo.swappingVariables<int>(ref i, ref j);                     //Generic Method Demo
            //GenericMethodDemo.swappingVariables<string>(ref a, ref b);
            //Console.WriteLine("After swapping : \n i : {0} \n j : {1} \n a : {2} \n b : {3}", i, j, a, b);

            GenericDelegateDemo g = new GenericDelegateDemo();
            g.callDelegate();
            Console.ReadKey();
        }
    }
}
