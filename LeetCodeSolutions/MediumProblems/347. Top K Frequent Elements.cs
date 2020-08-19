using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions.MediumProblems
{
	public class TopKFrequentElements
	{
		public int[] Solve(int [] nums, int k)
        {
            var map = new Dictionary<int, int>();

            foreach (int n in nums)
            {
                if (!map.ContainsKey(n))
                    map.Add(n, 1);
                else
                    map[n]++;
            }

            return map.OrderByDescending(c => c.Value)
                .Take(k).Select(c => c.Key).ToArray();
        }
    }
}
