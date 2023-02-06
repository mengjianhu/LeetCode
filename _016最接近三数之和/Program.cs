using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016最接近三数之和
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 2, 1, -4 };
            Console.WriteLine(Program.ThreeSum(nums, -2));
        }

        public static int ThreeSum(int[] nums, int target)
        {
            Array.Sort(nums);
            int closestNum = nums[0] + nums[1] + nums[2];//默认最接近的值
            //k < nums.length - 2是为了保证后面还能存在两个数字
            for (int k = 0; k < nums.Length - 2; k++)//内循环
            {
                int i = k + 1;
                int j = nums.Length - 1;//定义左右指针
                while (i < j)
                {
                    int threeSum = nums[k] + nums[i] + nums[j];
                    if (Math.Abs(threeSum - target) < Math.Abs(closestNum - target))//判断最接近
                    {
                        closestNum = threeSum;
                    }
                    if (threeSum > target)
                    {
                        j--;//右指针左移
                    }
                    else if (threeSum < target)
                    {
                        i++;//左指针右移
                    }
                    else
                    {
                        // 如果已经等于target的话, 肯定是最接近的
                        return target;
                    }
                }
            }
            return closestNum;


        }
    }
}
