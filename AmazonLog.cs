using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class AmazonLog
    {
        public static List<string> processLogs(List<string> logs, int threshold)
        {
            Dictionary<string, int> track = new Dictionary<string, int>();
            List<string> result = new List<string>();
            foreach (var item in logs)
            {
                var splitted = item.Split(' ');
                string lastKey = "";
                for (int i = 0; i < splitted.Length; i++)
                {
                    if (track.ContainsKey(splitted[i]) && splitted[i] != lastKey)
                        track[splitted[i]]++;
                    else if(!track.ContainsKey(splitted[i]))
                        track.Add(splitted[i], 1);

                    lastKey = splitted[i];
                }
            }
            foreach (var item in track)
            {
                if (item.Value > threshold)
                    result.Add(item.Key);
            }
            return result.OrderBy(x=>x).ToList();
        }
    }
}
