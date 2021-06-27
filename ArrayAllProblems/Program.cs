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

            
        }
    }
}
