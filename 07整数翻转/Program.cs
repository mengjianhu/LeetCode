using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07整数翻转
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.MaxValue;
            
            Console.WriteLine(i);
            Console.WriteLine(Solution1.Reverse(int.MaxValue-1));
        }
    }
    public class Solution
    {
        public static int Reverse(int x)
        {
            if (x > int.MaxValue)
            {
                return 0;
            }
            string xToString = x.ToString();
            List<char> ss = new List<char>();
            for (int i = 0; i < xToString.Length; i++)
            {
                ss.Add(xToString[i]);
            }
            string news = "";
            if (ss[0] == '-')
            {

                news += ss[0];
                ss.RemoveAt(0);
                for (int i = ss.Count ; i > 0; i--)
                {

                    news += ss.Last();
                    ss.RemoveAt(i -1);
                }
               
                return Convert.ToInt32(news);

            }
            else
            {

                for (int i = ss.Count; i > 0; i--)
                {

                    news += ss.Last();
                    ss.RemoveAt(i - 1);
                }
                return Convert.ToInt32(news);
            }
        }
    }

    public class Solution1
    {
        public static int Reverse(int x)
        {
            int rev = 0;//反转后的数字
            while (x != 0)
            {
                if (rev < int.MinValue / 10 || rev > int.MaxValue / 10)
                {
                    return 0;
                }
                int digit = x % 10;//取末尾的数字

                //125 
                x /= 10; //去除末尾的数字
                rev = rev * 10 + digit;
            }
            return rev;
        }
    }
}
