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
            
            Console.WriteLine("Spilral:-----");
            int[,] arrSpiral = new int[,] { 
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 }, 
                { 9, 10, 12, 13 } };

            var singleArray = solution.SpiralTraverse(arrSpiral);
            foreach (var item in singleArray)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Console.WriteLine("Longest Peek -----");
            int[] peeks = new int[] {1,2,3,3,4,0,10,2,5,-1,-3,-4,3 };
            var maxPeekLength= solution.LongestPeek(peeks);
            Console.WriteLine("Peek:.'{0}'.",maxPeekLength);
            Console.WriteLine("Peek:....-'{0}'-....'.", solution.LongestPeek2(peeks));

            Console.WriteLine("Sorted Subarray-----Indez");

            var sortedIndex = solution.SubArraySort(new int[]{1,2,4,7,10,11,7,12,6,7,16,18,19 });
            Console.WriteLine("[{0},{1}]",sortedIndex.Item1,sortedIndex.Item2);

        }
    }
}
