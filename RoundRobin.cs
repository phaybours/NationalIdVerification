using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class RoundRobin
    {
        public static void ScheduleTeams(string inputFile, string outputFile)
        {
            var teams = new List<string>();
            var teamsB = new List<string>();
            string line;
            using (var fs = File.OpenRead(inputFile))
            using (var fw = File.OpenWrite(outputFile))
            using (var sw = new StreamWriter(fw))
            using (var sr = new StreamReader(fs))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    teams.Add(line);
                    teamsB.Add(line);
                }
                if (teams.Count > 0)
                {
                    bool s = true;
                    teams.Sort();
                    teamsB.Sort();
                    for(int i = 0; i < teams.Count; i++)
                    {
                        teamsB.Remove(teams[i]);
                        if(teamsB.Count > 0)
                        {
                            var match = s ? $"{teams[i]} vs {teamsB[0]}" : $"{teamsB[0]} vs {teams[i]}";
                            sw.WriteLine(match);
                            s = !s;
                        }
                    }
                }
            }
        }
    }
}
