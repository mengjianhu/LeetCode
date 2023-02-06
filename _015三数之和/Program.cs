using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015三数之和
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            int[] numss = new int[] { 0, 0, 0, 0, 0, 0 };
            var sss = Class1.ThreeSum(numss);


            foreach (var item in sss)
            {
                var k = item as List<int>;
                foreach (var s in k)
                {
                    Console.WriteLine(s);
                }
            }
            var ss = Solution.ThreeSum(nums);
            foreach (var item in ss)
            {
                var k = item as List<int>;
                foreach (var s in k)
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
    /*
     * 给你一个整数数组 nums ，判断是否存在三元组 [nums[i], nums[j], nums[k]] 满足 i != j、i != k 且 j != k ，同时还满足 nums[i] + nums[j] + nums[k] == 0 。请

你返回所有和为 0 且不重复的三元组。

注意：答案中不可以包含重复的三元组。

    输入：nums = [-1,0,1,2,-1,-4]
输出：[[-1,-1,2],[-1,0,1]]
解释：
nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0 。
nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0 。
nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0 。
不同的三元组是 [-1,0,1] 和 [-1,-1,2] 。
注意，输出的顺序和三元组的顺序并不重要。

 
     * */
    public static class Solution
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<List<int>> res = new List<List<int>>();
            //k < nums.length - 2是为了保证后面还能存在两个数字
            for (int k = 0; k < nums.Length - 2; k++) 
            {
                if (nums[k] > 0) break;//若nums[k]大于0，则后面的数字也是大于零（排序后是递增的）
                if (k > 0 && nums[k] == nums[k - 1]) continue;//nums[k]值重复了，去重   注：重复三元组意思是结果中res的三元组
                int i = k + 1;
                int j = nums.Length - 1;//定义左右指针
                while (i < j)
                {
                    int sum = nums[k] + nums[i] + nums[j];
                    if (sum < 0)
                    {
                        while (i < j && nums[i] == nums[++i]) ;//左指针前进并去重   判断 nums[i] == nums[++i]  是为了去重
                    }
                    else if (sum > 0)
                    {
                        while (i < j && nums[j] == nums[--j]) ;//右指针后退并去重
                    }
                    else //sum=0
                    {
                        res.Add(new List<int>()
                        {
                            nums[k],
                            nums[i],
                             nums[j],

                        });
                        while (i < j && nums[i] == nums[++i]) ;//左指针前进并去重
                        while (i < j && nums[j] == nums[--j]) ;//右指针后退并去重
                    }
                }
            }
            return res.ToList<IList<int>>();
        }
        public static IList<IList<int>> ThreeSum2(int[] nums)
        {
            Array.Sort(nums);
            int size = nums.Length;
            List<List<int>> res = new List<List<int>>();
            // 保证有正数负数
            if (nums[0] <= 0 && nums[size - 1] >= 0)
            {
                int i = 0;
                while (i < size - 2)
                {
                    if (nums[i] > 0) break; // 最左侧大于0，无解
                    int first = i + 1;
                    int last = size - 1;
                    while (first < last)
                    {
                        if (nums[i] * nums[last] > 0) break; // 三数同符号，无解
                        int sum = nums[i] + nums[first] + nums[last];
                        if (sum == 0)
                        {
                            res.Add(new List<int>() { nums[i], nums[first], nums[last] });
                        }
                        if (sum <= 0)
                        {
                            // 负数过小，first右移
                            while (nums[first] == nums[++first]) { } // 重复值跳过
                        }
                        else
                        {
                            while (nums[last] == nums[--last]) { } // 重复值跳过
                        }
                    }
                    while (nums[i] == nums[++i]) { }
                }
            }
            return res.ToList<IList<int>>();
        }
    }

}
