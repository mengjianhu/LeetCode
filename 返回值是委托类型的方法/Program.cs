namespace 返回值是委托类型的方法
{
    internal class Program
    {
        public delegate bool ClientConnectionAcceptedCallback(object sender, object args);
        public static ClientConnectionAcceptedCallback ClientConnectionAcceptedHandle { get; set; } = (a, b) => { return true; };//方法
        static void Main(string[] args)
        {
            //ClientConnectionAcceptedCallback clientConnectionAcceptedCallback = (a, b) =>
            //          {
            //              return true;
            //          };

            //ClientConnectionAcceptedHandle = (args, b) => { return Convert.ToInt32(args) > Convert.ToInt32(b); };
            //object a = 10;
            //object b = 2;
            //bool aa = clientConnectionAcceptedCallback(a, b);
            //Console.WriteLine(aa.ToString());

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    // 抛出异常
                    if (i == 5)
                    {
                        throw new Exception("Exception occurred");
                    }
                    Console.WriteLine(  i.ToString());
                    // 其他代码
                }
                catch (Exception ex)
                {
                    // 处理异常
                    //Console.WriteLine("Exception occurred: {0}", ex.Message);
                }
            }
        }
    }
}