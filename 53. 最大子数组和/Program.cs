using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.最大子数组和
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            
            int res = nums[0];
            int sum = 0;
            foreach (var num in nums)
            {
                if (sum > 0)
                    sum += num;
                else
                    sum = num;
                res = Math.Max(res, sum);
            }
            return res;


        }
        public int MaxSubArray2(int[] nums)
        {
            int pre = 0, maxAns = nums[0];
            foreach (int x in nums)
            {
                pre = Math.Max(pre + x, x);//pre+x=前面的数组和最大值与x比较

                maxAns = Math.Max(maxAns, pre);
            }
            return maxAns;
        }
    }
}
