using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05最长回文字符串
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            string result = "";
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    // 检查 s[i]到s[j]是否是回文串，如果是，且长度大于result长度，就更新它
                    int p = i, q = j;
                    bool isPalindromic = true;
                    while (p < q)
                    {
                        if (s[p++] != s[q--])
                        {
                            isPalindromic = false;
                            break;
                        }
                    }
                    if (isPalindromic)
                    {
                        int len = j - i + 1;
                        if (len > result.Length)
                        {
                            result = s.Substring(i, len);
                        }
                    }

                }
            }
            return result;
        }

    }
}
