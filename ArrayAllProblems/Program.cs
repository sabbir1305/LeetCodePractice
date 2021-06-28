using System;

namespace ArrayAllProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] arr = new int[] {4,1,2,2,2,3,2,2 };
           var result= solution.MoveElementToTheLast(arr, 2);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(" "+result[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Montonic:-----");

            arr = new int[] { -1, -5, -10, -1100, -1100, -1101, -1102, -9001,-9002 };
            var isMonotonic = solution.IsMonotonicArray(arr);
            Console.WriteLine(isMonotonic);
            
        }
    }
}
