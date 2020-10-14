using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArray
{
    class Program
    {

        public static int[] RunningSum(int[] nums)
        {
            int counter = 0;
            int lengthOfNums = nums.Length;
            int i, j;
            int[] sumArray = new int[nums.Length];
            sumArray[0] = nums[0];

            for (i = 1; i < lengthOfNums; i++)
            {
                int totalCount = 0;
                for (j = 0; j < i + 1; j++)
                {
                    totalCount = totalCount + nums[j];
                }
                sumArray[i] = totalCount;

            }
            return sumArray;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            var result = RunningSum(nums);
           
        }
    }
}
