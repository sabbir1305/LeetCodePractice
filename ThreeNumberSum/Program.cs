using System;

namespace ThreeNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[]{ 12,3,1,2,-6,5,-8,6};
            Solution solution = new Solution();
            var result = solution.ThreeNumberSum(arr, 0);
            var result2 = solution.FourNumberSum(arr, 0);

            foreach (var item in result)
            {
                Console.Write("[");
                Console.Write("{0}, {1}, {2} ",item.Item1,item.Item2,item.Item3);
                Console.Write("]");

                Console.WriteLine();
            }

            foreach (var item in result2)
            {
                Console.Write("[");
                Console.Write("{0}, {1}, {2}, {3} ", item.Item1, item.Item2, item.Item3,item.Item4);
                Console.Write("]");

                Console.WriteLine();
            }

        }
    }
}
