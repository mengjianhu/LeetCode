namespace 二分查找
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 5;
            int[] s = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int lower = 0;//低
            int upper = s.Length - 1;//高
            while (lower <= upper)
            {
                int centerindx = (lower + upper) / 2;
                int centervalue = s[centerindx];
                if (val > centervalue)
                {
                    lower = centerindx + 1;
                }
                else if (val < centervalue)
                {
                    upper = centerindx - 1;
                }
                else if (centervalue == val)
                {
                    Console.WriteLine(centerindx.ToString());
                    break;
                }
            }
        }
    }
}