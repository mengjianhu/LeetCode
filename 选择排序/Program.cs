namespace 选择排序
{
    internal class Program
    {
        /// <summary>
        /// 择排序算法的原理是，重复在未排序部分中找到最小元素并将其移动到未排序部分的开头。这是通过迭代整个数组并将每个元素与当前最小元素进行比较来实现的。如果找到一个比当前最小值更小的元素，则它成为新的最小值。在遍历整个数组后，最小元素与未排序部分的第一个元素进行交换。这个过程对于剩余未排序部分的数组也是重复的，直到整个数组排序完成。  外部的 for 循环从数组的第一个元素到倒数第二个元素进行迭代。内部的 for 循环从数组的下一个元素开始，迭代未排序部分的剩余部分，以查找最小的元素。如果在外部循环的当前位置之外发现了最小元素，则交换这两个元素。在外部循环结束时，数组按升序排列。选择排序算法的时间复杂度为O(n^2)，其中n是数组的长度。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] s = new int[] { 3, 9, 9, 8, 7, 10 };

            for (int i = 0; i < s.Length; i++)
            {
                int low = i;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[j] < s[low])
                    {
                        low = j;
                    }
                }
                if (low != i)
                {
                    int temp = s[i];
                    s[i] = s[low];
                    s[low] = temp;
                }
            }
            foreach (var item in s)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}