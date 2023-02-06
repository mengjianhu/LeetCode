using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3无重复字符的最长子串
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Solution.LengthOfLongestSubstring("lllppp") ); ;
        }
    }
    public static class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {

            List<char> ls = new List<char>();
            int n = s.Length;
            int intMaxLength = 0;
            for (int i = 0; i < n; i++)
            {
                if (ls.Contains(s[i]))
                {
                    ls.RemoveRange(0, ls.IndexOf(s[i]) + 1);
                }
                ls.Add(s[i]);
                intMaxLength = ls.Count > intMaxLength ? ls.Count : intMaxLength;
            }

            return intMaxLength;
        }
    }
}
