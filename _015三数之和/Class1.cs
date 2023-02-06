using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015三数之和
{
   public  class Class1
    {
        public  static  IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<List<int>> ss = new List<List<int>>();
         
            for (int k = 0; k < nums.Length - 2; k++)
            {
                if (nums[k] > 0) break;
               
                if (k > 0 && nums[k] == nums[k - 1]) continue;
                int i = k + 1;
                int j = nums.Length - 1;//定义左右指针
                while (i < j)
                {
                    int sum = nums[k] + nums[i] + nums[j];
                    if (sum < 0)
                    {
                        while (i < j && nums[i] == nums[++i]) ;
                    }
                    else if (sum > 0)
                    {
                        while (i < j && nums[j] == nums[--j]) ;
                    }
                    else
                    {
                        ss.Add(new List<int>()
                        {
                             nums[k],
                               nums[i],
                              nums[j]
                        });
                        while (i < j && nums[i] == nums[++i]) ;//左指针前进并去重
                        while (i < j && nums[j] == nums[--j]) ;//右指针后退并去重

                    }
                }
               
            }
            return ss.ToList<IList<int>>();

        }
    }
}
