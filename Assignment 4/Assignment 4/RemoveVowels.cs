using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class RemoveVowels
    {
        public void Remove()
        {
            try
            {
                Console.WriteLine("Enter the word :");
                string Word = Console.ReadLine(); 
                Console.WriteLine("Word after removing vowels:");
                Word = Word.ToLower();
                for (int i = 0; i < Word.Length; i++)
                {
                    if (Word[i] == 'a' || Word[i] == 'e' || Word[i] == 'i' || Word[i] == 'o' || Word[i] == 'u')
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(Word[i]);
                    }
                }
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
