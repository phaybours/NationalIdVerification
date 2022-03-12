using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class ReverseCharactersOfEachWord
    {
        public static string ReverseWordInString1(string input)
        {
            var reversed = string.Empty;            
            foreach(var word in input.Split(' '))
            {
                string wordString = "";
                for(int i =  word.Length - 1; i >= 0; i--)
                {
                    if (word[i] == ' ')
                        continue;
                    wordString+=word[i];
                }
                if(reversed.Length > 0)
                    reversed += $" {wordString}";
                else
                    reversed =  wordString;
            }

            return reversed;
        }
        public static string ReverseWordInString2(string input)
        {
            return string.Join(" ", input.Split(' ').Select(x=> new string(x.Reverse().ToArray())));
        }
    }
}
