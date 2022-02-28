using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class ReverseNumber
    {
        public static int Reverse(int input)
        {
            int reversed = 0; int remainder;
            while (input != 0)
            {
                remainder = input % 10;
                reversed = (reversed * 10) + remainder;
            }
            return reversed;
        }
        public static string ReverseString1(string input)
        {
            return (input.Reverse()).ToString();
        }

        public static string ReverseString2(string input)
        {
            string reverserd = "";
            int length = input.Length;
            while(length > 0)
            {
                reverserd += input[length];
                length--;
            }
            return reverserd;
        }


        public static string ReverseString3(string input)
        {
            string reversed = "";
            int length = input.Length;
            foreach(var character in input)
            {
                reversed += character;
            }
            return reversed;
        }
    }
}
