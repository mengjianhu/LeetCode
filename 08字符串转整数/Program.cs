using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace _08字符串转整数
{
     
    class Program
    {
        void fun()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
      
        static void Main(string[] args)
        {
            ThreadStart threadStart = new Program().fun;
            Thread thread = new Thread(threadStart);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = tokenSource.Token;
            Task task = new Task(() =>
            {
                int i = 0;

                while (true)
                {
                    if (tokenSource.IsCancellationRequested)
                    {
                        Console.WriteLine("Task canceled");
                        break;
                    }
                    Console.WriteLine(i);
                    i++;
                    if (i > 10000)
                    {

                        tokenSource.Cancel();
                    }
                }
            }, cancellationToken);

            //task.Start();
            //task.Wait();
            double dd = Math.Ceiling(50.0);
            Console.WriteLine(dd);
            // Console.ReadLine();

            string filePath = @"C:\Users\humengjian\Desktop\怎么把视频做成文件.mp4";
            byte[] bb = File.ReadAllBytes(filePath);
           

            int legth = bb.Length;
            var fileName = Path.GetFileName(filePath);
            using (FileStream fs = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[10000];
                int len = 0;
                while ((len = fs.Read(buffer, 0, buffer.Length)) > 0)
                {

                }



            }
        }

    }
    public class Solution
    {

        public int myAtoi(String str)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int len = str.Length;
            // str.charAt(i) 方法回去检查下标的合法性，一般先转换成字符数组
            char[] charArray = str.ToCharArray();

            // 1、去除前导空格
            int index = 0;
            while (index < len && charArray[index] == ' ')
            {
                index++;
            }

            // 2、如果已经遍历完成（针对极端用例 "      "）
            if (index == len)
            {
                return 0;
            }

            // 3、如果出现符号字符，仅第 1 个有效，并记录正负
            int sign = 1;
            char firstChar = charArray[index];
            if (firstChar == '+')
            {
                index++;
            }
            else if (firstChar == '-')
            {
                index++;
                sign = -1;
            }

            // 4、将后续出现的数字字符进行转换
            // 不能使用 long 类型，这是题目说的
            int res = 0;
            while (index < len)
            {
                char currChar = charArray[index];
                // 4.1 先判断不合法的情况
                if (currChar > '9' || currChar < '0')
                {
                    break;
                }

                // 题目中说：环境只能存储 32 位大小的有符号整数，因此，需要提前判：断乘以 10 以后是否越界
                if (res > int.MaxValue / 10 || (res == int.MaxValue / 10 && (currChar - '0') > int.MaxValue % 10))
                {
                    return int.MaxValue;
                }
                if (res < int.MinValue / 10 || (res == int.MinValue / 10 && (currChar - '0') > -(int.MinValue % 10)))
                {
                    return int.MinValue;
                }

                // 4.2 合法的情况下，才考虑转换，每一步都把符号位乘进去
                int ss = currChar - '0';

                res = res * 10 + sign * (currChar - '0');
                index++;
            }
            stopwatch.Stop();
            Console.WriteLine("=====>" + stopwatch.Elapsed.ToString());
            return res;
        }
    }
}
