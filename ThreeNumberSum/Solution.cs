using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeNumberSum
{
    class Solution
    {
        public List<(int,int,int)> ThreeNumberSum(int[] arr,int targetSum)
        {
            List<(int, int, int)> result = new List<(int, int, int)>();
            Array.Sort(arr);
            int length = arr.Length;

            if (length == 0) return result;
            int right, left,currentSum;

            //sum = arr[i]+arr[left] + arr[right]
            for (int i = 0; i < length-2; i++)
            {
                left = i + 1;
                right = length - 1;
                while (left<right)
                {
                    currentSum = arr[i] + arr[left] + arr[right];

                    if (currentSum == targetSum)
                    {
                        result.Add((arr[i], arr[right], arr[left]));
                        right -= 1;
                        left += 1;
                    }
                    else if (currentSum < targetSum)
                    {
                        left += 1;
                    }
                    else if (currentSum > targetSum)
                    {
                        right -= 1;
                    }
                }
            }

            return result;
        }
        public List<(int, int, int,int)> FourNumberSum(int[] arr, int targetSum)
        {
            List<(int, int, int,int)> result = new List<(int, int, int,int)>();
            int length = arr.Length;

            var allPairSums = new Dictionary<int, List<(int, int)>>();

            for (int i = 1; i < length-1; i++)
            {
                for (int j = i+1; j < length; j++)
                {
                    int currentSum = arr[i] + arr[j];
                    int diff = targetSum - currentSum;

                    if (allPairSums.ContainsKey(diff))
                    {
                        foreach (var pair in allPairSums[diff])
                        {
                            result.Add((pair.Item1, pair.Item2, arr[i], arr[j]));

                        }
                    }
                }
                for (int k = 0; k < i; k++)
                {
                    int currentSum = arr[i] + arr[k];
                    if (!allPairSums.ContainsKey(currentSum))
                    {
                        var lst = new List<(int, int)> { (arr[i],arr[k]) };
                        allPairSums.Add(currentSum, lst);
                    }
                    else
                    {
                        var element = allPairSums[currentSum];
                        element.Add((arr[i], arr[k]));
                    }
                }
            }


         

            return result;
        }

    }
}
