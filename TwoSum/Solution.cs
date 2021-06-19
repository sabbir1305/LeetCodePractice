using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var resultIndex = new int[2];

            var end = numbers.Length - 1;
            int start = 0;

            while (start < end)
            {
                int tempTarget = numbers[start] + numbers[end];
                if (tempTarget < target)
                {
                    start += 1;
                }
                else if (tempTarget > target)
                {
                    end -= 1;
                }
                else
                {
                    resultIndex[0] = start + 1;
                    resultIndex[1] = end + 1;

                    return resultIndex;
                }
            }




            return resultIndex;
        }
    }

}
