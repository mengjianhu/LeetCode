using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217存在重复元素
{
    /// <summary>
    /// 给你一个整数数组 nums 。如果任一值在数组中出现 至少两次 ，返回 true ；如果数组中每个元素互不相同，返回 false 。
    /*
     * 输入：nums = [1,2,3,1]
输出：true

示例 2：

输入：nums = [1,2,3,4]
输出：false

示例 3：

输入：nums = [1,1,1,3,3,4,3,2,4,2]
输出：true
     * */
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 5, 7, 6 };
            Console.WriteLine(Solution.ContainsDuplicate2(nums));
        }
    }
    public static class Solution
    {
        /// <summary>
        /// 暴力解法
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int right = i + 1;
                while (right < nums.Length)
                {
                    if (nums[i] == nums[right])//循环判断是否右边的数字不等于左边的
                    {
                        return true;
                    }
                    right++; //指针右移  
                }
            }
            return false;

        }

        public static bool ContainsDuplicate2(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }
            return false;

        }
    }
}
