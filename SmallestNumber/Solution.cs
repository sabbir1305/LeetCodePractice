using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestNumber
{
    class Solution
    {
        public (int,int) SmallestDifference(int[] array1, int[] array2)
        {
            Array.Sort(array1);
            Array.Sort(array2);

            int smallDif = int.MaxValue;
            int currentDiff, smallIndexOne=0, smallIndexTwo=0, indexOne = 0, indexTwo = 0;
           

            while (array1.Length>indexOne && array2.Length > indexTwo)
            {
              

                if (array2[indexTwo] > array1[indexOne])
                {
                    currentDiff = array2[indexTwo] - array1[indexOne];
                    indexOne++;
                }
               else if (array2[indexTwo] < array1[indexOne])
                {
                    currentDiff =  array1[indexOne] - array2[indexTwo];
                    indexTwo++;
                }
                else
                {
                    return (array1[indexOne], array2[indexTwo]);
                }

                if (smallDif > currentDiff)
                {

                    smallDif = currentDiff;
                    smallIndexOne = indexOne;
                    smallIndexTwo = indexTwo;
                }

            }

            return (smallIndexOne, smallIndexTwo);
           
        }
    }
}
