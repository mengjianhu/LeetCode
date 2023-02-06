using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017电话号码的字母组合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ss = Solution.LetterCombinations("23").ToList<string>();
            foreach (var item in ss)
            {
                Console.WriteLine(item);
            }
        }


    }

    public static class Solution
    {
        public static IList<string> LetterCombinations(string digits)
        {
            String[] letter_map = {
            " ","*","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"
        };
            if (digits == null || digits.Length == 0)
            {
                return new List<String>();
            }
            List<String> res = new List<String>();
            res.Add("");
            for (int i = 0; i < digits.Length; i++)
            {
                //由当前遍历到的字符，取字典表中查找对应的字符串
                String letters = letter_map[digits.ToArray()[i] - '0'];
                int size = res.Count();
                //计算出队列长度后，将队列中的每个元素挨个拿出来
                for (int j = 0; j < size; j++)
                {
                    //每次都从队列中拿出第一个元素
                    String tmp = res.ToArray()[0];
                    //然后跟"def"这样的字符串拼接，并再次放到队列中
                    for (int k = 0; k < letters.Length; k++)
                    {
                        res.Add(tmp + letters.ToArray()[k]);
                    }
                }
            }
            return res.ToList<string>();
        }
    }



}
