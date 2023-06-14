namespace 选择排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[] { 3, 9, 9, 8, 7, 10 };

            for (int i = 0; i < s.Length; i++)
            {
                var low = i;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[j] < s[low])
                    {
                        low = j;
                    }
                }
                if (low != i)
                {
                    var temps = s[i];
                    s[i] = s[low];
                    s[low] = temps;

                }
               
            }
            foreach (var item in s)
            {
                Console.WriteLine(  item.ToString());
            }
        }
    }
}