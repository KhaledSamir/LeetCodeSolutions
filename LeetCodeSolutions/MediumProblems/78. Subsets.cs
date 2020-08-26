using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions.MediumProblems
{
    public class SubSets78
    {
        public IList<IList<int>> Solve(int[] nums)
        {
            IList<IList<int>> subsets = new List<IList<int>>();
            subsets.Add(new List<int>());
            backTrack(nums, subsets, 0, new List<int>());
            return subsets;
        }

        public void backTrack(int[] nums, IList<IList<int>> subsets, int len,List<int> current)
        {
            subsets.Add(new List<int>(current));

            for(int i = len; i < nums.Length;i++)
            {
                current.Add(nums[i]);
                backTrack(nums, subsets, i + 1, current);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
