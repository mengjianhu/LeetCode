namespace 回调函数
{
    internal class Program
    {
        public delegate void Callback(int i);
        static void Main(string[] args)
        {
            LongOperation(5, 6, (a) =>
            {
                Console.WriteLine( a);
            });
        }
        public static void LongOperation(int x, int y, Callback callback=null)
        {
            // 模拟一个耗时的操作
            Thread.Sleep(3000);

            int result = x + y;

            // 调用回调函数
            if(callback != null)  
            callback(result);
        }

    }

}