namespace 最小路径和
{
    internal class Program
    {
        /// <summary>
        /// 最小路径和  动态规划
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[][] array = new int[2][];
            array[0] = new int[] { 1, 2, 3 };
            array[1] = new int[] { 4, 5, 6 };
          
          int i=  Solution. MinPathSum(array);
            Console.WriteLine(  i.ToString());

        }
    }
    public class Solution
    {
        public static int MinPathSum(int[][] grid)
        {
            int width = grid[0].Length;//宽
            int high = grid.Length;//高
            if (high == 0 || width == 0) return 0;
            // 初始化
            for (int i = 1; i < high; i++) grid[i][0] += grid[i - 1][0];
            for (int i = 1; i < width; i++) grid[0][i] += grid[0][i - 1];
            for (int i = 1; i < high; i++)
            {
                for (int j = 1; j < width; j++)
                {
                    grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
                }
            }
            return grid[high - 1][width - 1];
        }
    }
}