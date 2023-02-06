using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 寻找两个正序数组的中位数
{
    class Program
    {
        static void Main(string[] args)
        {
            int []nums = { 1,3};
            int[] nums2 = {2 };
            Console.WriteLine(Solution.FindMedianSortedArrays(nums, nums2) ); 
        }
    }
    public static class Solution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> newNums = new List<int>(nums1);
            newNums.AddRange(nums2);
            int length = nums1.Length + nums2.Length;
            newNums.Sort(); 
            if (length % 2 == 1)
            {
                return  newNums[length / 2];
            }
            else
            {
                return (newNums[length / 2 - 1] + newNums[length / 2]) / 2.0;
            }
            // 1  2  3  4
        }
    }
}
