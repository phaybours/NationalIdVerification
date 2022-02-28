using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class DeduceWord
    {
        public static string Deduce(string[] input, int b)
        {
            List<string> chars = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (string.IsNullOrEmpty(input[i]))
                    continue;
                var splitted = input[i].Split('>'); 
                if(!chars.Contains(splitted[0]))
                    chars.Add(splitted[0]);
                if(!chars.Contains(splitted[1]))
                    chars.Add(splitted[1]);

                int index1 = chars.IndexOf(splitted[0]);
                int index2 = chars.IndexOf(splitted[1]);
                if(index1 > index2)
                    (chars[index1], chars[index2]) = (chars[index2], chars[index1]); 
            }
            return string.Join("", chars);
        }
        
        public static string Deduce(string[] input)
        {
            Dictionary<string, string> charPair=  new Dictionary<string, string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (string.IsNullOrEmpty(input[i]) || string.IsNullOrWhiteSpace(input[i]))
                    continue;
                var split = input[i].Split('>');
                charPair.Add(split[0], split[1]);
            }
            var first = charPair.Keys.FirstOrDefault(x => !charPair.Values.Contains(x));
            var last = charPair.Values.FirstOrDefault(x => !charPair.ContainsKey(x));
            string result = first, currKey = first;
            while(currKey != last)
            {
                string cVal = charPair[currKey];
                result += cVal;
                currKey = cVal;
            }
            return result;
        }
    }
}
