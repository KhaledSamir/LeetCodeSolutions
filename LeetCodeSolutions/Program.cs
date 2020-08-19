using System;
using LeetCodeSolutions.MediumProblems;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new TopKFrequentElements();
            Console.WriteLine(string.Join(",", solution.Solve(new int[] {1, 1, 1, 2 , 2, 3 }, 2)));
        }
    }
}
