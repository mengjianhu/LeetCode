using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018四数之和
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1000000000, -1000000000, 1000000000, -1000000000, -1000000000 };
            int[] nums1 = { 2, -1, 0, 1 };
            //long ss = long.Parse(294967296.ToString());
            //int l1 = -1000000000;
            //int l2 = -1000000000;
            //int l3 = -1000000000;
            //int l4 = -1000000000;
            //Console.WriteLine(l1 + l2 + l3 + l4);
            //if (l1 + l2 + l3 + l4 == ss)
            //{

            //}

            IList<IList<int>> ll = Solution.FourSum1(nums, 2);
        }


    }
    public class Solution
    {
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            List<List<int>> res = new List<List<int>>();


            if (nums.All(a => a < 0) && target > 0)
            {
                return res.ToList<IList<int>>();
            }
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (  nums[i] > target&& nums[i] >  0)
                {

                    return res.ToList<IList<int>>();
                }
            }
            

            for (int k = 0; k < nums.Length - 1; k++)
            {

                for (int i = k + 1; i < nums.Length; i++)
                {

                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        for (int l = j + 1; l < nums.Length; l++)
                        {
                            if (nums[k] + nums[i] + nums[j] + nums[l] == (long)target)
                            {
                                if (res.Count <= 0)
                                {
                                    res.Add(new List<int>()
                                        {
                                         nums[k] , nums[i] , nums[j] , nums[l]
                                       });
                                }
                                else
                                {
                                    int len = res.Count;
                                    int i2 = 0;
                                    for (int s = 0; s < len; s++)
                                    {


                                        if (res[s][0] == nums[k] && res[s][1] == nums[i] && res[s][2] == nums[j] && res[s][3] == nums[l])
                                        {
                                            break;
                                        }
                                        else
                                        {

                                            i2++;
                                            if (i2 == len)
                                            {
                                                res.Add(new List<int>()
                                        {
                                         nums[k] , nums[i] , nums[j] , nums[l]
                                       });
                                            }
                                        }


                                    }


                                }

                            }
                        }
                    }
                }
            }

            return res.ToList<IList<int>>();


        }


        public static IList<IList<int>> FourSum1(int[] nums, int target)
        {

            Array.Sort(nums);
            List<List<int>> res = new List<List<int>>();
            foreach (var item in nums)
            {
                if (item < 0 && target > 0)
                {
                    return res.ToList<IList<int>>();
                }
            }

            if (target < 0 && nums[0] > 0)
            {

                return res.ToList<IList<int>>();
            }


            for (int k = 0; k < nums.Length - 1; k++)
            {


                for (int i = k + 1; i < nums.Length; i++)
                {

                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        for (int l = j + 1; l < nums.Length; l++)
                        {
                            if (nums[k] + nums[i] + nums[j] + nums[l] == target)
                            {
                                if (res.Count <= 0)
                                {
                                    res.Add(new List<int>()
                                        {
                                         nums[k] , nums[i] , nums[j] , nums[l]
                                       });
                                }
                                else
                                {
                                    int len = res.Count;
                                    int i2 = 0;
                                    for (int s = 0; s < len; s++)
                                    {


                                        if (res[s][0] == nums[k] && res[s][1] == nums[i] && res[s][2] == nums[j] && res[s][3] == nums[l])
                                        {
                                            break;
                                        }
                                        else
                                        {

                                            i2++;
                                            if (i2 == len)
                                            {
                                                res.Add(new List<int>()
                                        {
                                         nums[k] , nums[i] , nums[j] , nums[l]
                                       });
                                            }
                                        }


                                    }


                                }

                            }
                        }
                    }
                }
            }

            return res.ToList<IList<int>>();


        }
    }

}
