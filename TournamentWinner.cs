using System.Collections.Generic;
using System.Linq;

namespace NationalIdVerification
{
    public static class TournamentWinner
    {
		public static string GetTournamentWinner(List<List<string>> competitions, List<int> results)
		{
			if(competitions.Count != results.Count)
				return "Invalid Competition";
			Dictionary<string, int> scores = new Dictionary<string, int>();
            string winner = "";
            for (int i = 0; i < competitions.Count; i++)
			{
				if (results[i] == 1)
                {
                    UpdateScore(competitions, scores, i,0);
                }
                else
				{
                    UpdateScore(competitions, scores, i, 1);
                }
			}
			return scores.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        }

        private static void UpdateScore(List<List<string>> competitions, Dictionary<string, int> scores, int i, int j)
        {
            if (scores.ContainsKey(competitions[i][j]))
            {
                scores[competitions[i][j]] += 3;
            }
            else
            {
                scores.Add(competitions[i][j], 3);
            }
        }
    }
}
