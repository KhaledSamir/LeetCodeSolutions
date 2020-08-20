using System;
namespace LeetCodeSolutions.EasyProblems
{
    public class AddDigits58
    {
        // Recursion solution

        public int Solve(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            num = sum;

            return sum >= 10 ? Solve(num) : sum;
        }

        // Iterative solution

        //public int Solve(int num)
        //{

        //    while (num >= 10)
        //    {
        //        int sum = 0;
        //        while (num > 0)
        //        {
        //            sum += num % 10;
        //            num /= 10;
        //        }
        //        num = sum;
        //    }


        //    return num;
        //}
    }
}
