using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class PossibleSubSet
    {
        public static List<List<int>> GetPossibleSubSet(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < Math.Pow(2, nums.Length); i++)
            {
                int[] combination = new int[nums.Length];
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((i & (1 << (nums.Length - j - 1))) != 0)
                    {
                        combination[j] = nums[j];
                    }
                    
                }
                combination = combination.Where(x => x != 0).ToArray();
                Array.Sort(combination);
                result.Add(combination.ToList());
            }
            result.ForEach(x => x.Sort());
            //var cc = result.OrderBy(x => x.Count).ToArray();
            //Array.Sort(cc);
            return result;
        }
    }
}
