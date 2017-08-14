using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Part2
{
    public static class ExtensionMethod
    {
        public static StringBuilder firstCharacterUpperCase(this string sentence)
        {
            StringBuilder modifiedSentence = new StringBuilder();
            var wordArray = sentence.Split(' ');
            foreach(var word in wordArray)
            {
                var word1 = char.ToUpper(word[0]) + word.Substring(1);
                modifiedSentence.Append(word1).Append(" ");
            }
            return modifiedSentence;   
        }
    }
}
