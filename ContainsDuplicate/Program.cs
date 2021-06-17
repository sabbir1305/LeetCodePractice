using System;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            if (solution.ContainsDuplicate(nums)){
                Console.WriteLine("Contains Duplicate");
            }
            else
            {
                Console.WriteLine("Uninque List");

            }
        }
    }
}
