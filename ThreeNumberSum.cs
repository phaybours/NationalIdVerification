using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class ThreeNumberSum
    {
        public static List<int[]> SolveThreeNumberSum(int[] array, int targetSum)
        {
			Array.Sort(array);
			var result = new List<int[]>();
			int sum = 0;
			for (int i = 0; i < array.Length - 2; i++)
			{
				int leftIndex = i + 1, rightIndex = array.Length - 1;
				while (leftIndex < rightIndex)
				{
					sum = array[i] + array[leftIndex] + array[rightIndex];
					if (sum == targetSum)
					{
						result.Add(new int[] { array[i], array[leftIndex], array[rightIndex] });
						leftIndex++; rightIndex--;
					}
					else
					{
						if (sum > targetSum) rightIndex--;
						else leftIndex++;
					}
				}
			}
			return result;
		}
    }
}
