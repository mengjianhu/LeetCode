namespace _冒泡排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 6;
            int temp = 0;

            if (a > b)
            {
                temp = b;
                b = a;
                a = temp;
            }
            int[] nums = { 1, 3, 5, 4,6,8 };

            var nums1=  from k in nums
            orderby k ascending
            select k;
            foreach (var item in nums1)
            {
                Console.WriteLine(item);
            }

            foreach (var item in MyClass.BubbleSort(nums, (a, b) =>
            {
                return a > b;
            }))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }

    static class MyClass
    {
        public static int[] BubbleSort(int[] nums, Func<int, int, bool> func)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length - 1 - i; j++)
                {

                    if (func(nums[j], nums[j + 1]))
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            return nums;
        }

    }
}