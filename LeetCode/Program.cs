using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoNumsAdd twoNumsAdd = new TwoNumsAdd();
            int[] nums = twoNumsAdd.TwoSum(new int[] { 3, 2, 4 }, 6);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }
    }
    /// <summary>
    /// 两数之和
    /// </summary>
    class TwoNumsAdd
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };

        }
        //哈希表
        //public int[] twoSum(int[] nums, int target)
        //{
        //    Hashtable  hashtable = new Hashtable ();
        //    for (int i = 0; i < nums.Length; ++i)
        //    {
        //        if (hashtable.ContainsKey(target - nums[i]))
        //        {
        //            return new int[] { hashtable.GetHashCode()};
        //        }
        //        hashtable.Add(nums[i], i);
        //    }
        //    return new int[0];
        //}
    }
}
