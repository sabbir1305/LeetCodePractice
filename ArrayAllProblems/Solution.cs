using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAllProblems
{
  public  class Solution
    {
        public int[] MoveElementToTheLast(int[] arr , int element)
        {
            int j = arr.Length - 1;
            int i = 0;

            while(i<j)
            {
                int jValue = arr[j];
                int iValue = arr[i];
                while (arr[j] == element && i<j)
                {
                    j--;
                }

                if (arr[i] == element )
                {
                    arr[i] = arr[j];
                    arr[j] = element;


                }
                i++;
              

            }
            return arr;
        }

    }
}
