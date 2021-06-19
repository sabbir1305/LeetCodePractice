using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {


            var numbers = new int[] { 5, 25, 75 };
            Solution solution = new Solution();
            var result = solution.TwoSum(numbers,100);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
