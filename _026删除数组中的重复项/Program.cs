using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026删除数组中的重复项
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] ss = new int[]
            {
                1,3,3,5,7,9
            };
            Solution.RemoveDuplicates(ss);
        }

    }
    public static class Solution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int left = 0;//左指针
            int right = 1;//右指针

            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int j = 0;
            while (right < nums.Length)
            {

                if (nums[left] != nums[right])//循环判断是否右边的数字不等于左边的
                {
                    nums[left + 1] = nums[right];//
                    left++;
                }
                right++; //指针右移
                j++;      //
            }
            Console.WriteLine("j：" + j);
            return left + 1;
        }
        public static int RemoveDuplicates2(int[] nums)
        {
            int left = 0;//左指针 索引
            int right = 1;//右指针 索引

            while (right < nums.Length)
            {
                if (nums[left] != nums[right])
                {
                    nums[left + 1] = nums[right];
                    left++;
                }
                right++;
            }
            return left + 1;
        }
    }
}
