using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027移除元素
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ss = new int[]
            {
                1,3,3,5,7,9
            };
            Console.WriteLine(Solution.RemoveElement(ss, 3));
        }
    }
    public static class Solution
    {
        public static int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }
            return j;

        }
    }
}
