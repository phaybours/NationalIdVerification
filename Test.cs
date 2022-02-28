using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class Test
    {
        public static string solution(string message, int K)
        {
            message = message.TrimEnd(' ').TrimStart(' ');
            if (message.Length < K)
                return message;

            string concat = "";
            foreach (var item in (string[])message.Split(' '))
            {
                if (item == " ")
                    continue;

                if ((concat.TrimEnd().Length + item.Length + 1) > K)
                    return concat.TrimEnd(' ').TrimStart(' ');

                concat = concat + " " + item.TrimEnd();
            }
            concat = concat.TrimEnd(' ').TrimStart(' ');
            return concat;
        }

        public static int solution(int[] P, int[] S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int N = 0;
            var noSeats = S.OrderByDescending(x => x).ToList();
            var totalFriends = P.Sum(x => x);
            for (int i = 0; i < noSeats.Count(); i++)
            {
                if (N >= totalFriends)
                    return i;
                N += noSeats[i];
            }

            return noSeats.Count();
        }
    }
}
