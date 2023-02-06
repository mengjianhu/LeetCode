using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88.合并两个有序数组
{
    /*
     * 
     * 给你两个按 非递减顺序 排列的整数数组 nums1 和 nums2，另有两个整数 m 和 n ，分别表示 nums1 和 nums2 中的元素数目。

请你 合并 nums2 到 nums1 中，使合并后的数组同样按 非递减顺序 排列。

注意：最终，合并后数组不应由函数返回，而是存储在数组 nums1 中。为了应对这种情况，nums1 的初始长度为 m + n，其中前 m 个元素表示应合并的元素，后 n 个元素为 0 ，应忽略。nums2 的长度为 n 。
示例 1：

输入：nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
输出：[1,2,2,3,5,6]
解释：需要合并 [1,2,3] 和 [2,5,6] 。
合并结果是 [1,2,2,3,5,6] ，其中斜体加粗标注的为 nums1 中的元素。

示例 2：

输入：nums1 = [1], m = 1, nums2 = [], n = 0
输出：[1]
解释：需要合并 [1] 和 [] 。
合并结果是 [1] 。

示例 3：

输入：nums1 = [0], m = 0, nums2 = [1], n = 1
输出：[1]
解释：需要合并的数组是 [] 和 [1] 。
合并结果是 [1] 。
注意，因为 m = 0 ，所以 nums1 中没有元素。nums1 中仅存的 0 仅仅是为了确保合并结果可以顺利存放到 nums1 中。
     * */
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 }, nums2 = { 2, 5, 6 };
            // int[] nums1 = { 0 }, nums2 = { 1 };
            //int[] ss = Solution.Merge(nums1, 3, nums2, 3);
            Solution. Merge2(nums1, 6, nums2, 3);
        }
        public static class Solution
        {
            public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
            {
                Array.Copy(nums2, 0, nums1, m, n);
                Array.Sort(nums1);
                return nums1;
            }
            public static void Merge2(int[] nums1, int m, int[] nums2, int n)
            {
                int p = m-- + n-- - 1;
                while (m >= 0 && n >= 0)
                {
                    nums1[p--] = nums1[m] > nums2[n] ? nums1[m--] : nums2[n--];
                }

                while (n >= 0)
                {
                    nums1[p--] = nums2[n--];
                }
            
        }
}



    }
}
