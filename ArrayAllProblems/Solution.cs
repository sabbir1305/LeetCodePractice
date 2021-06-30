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

        public bool IsMonotonicArray(int[] arr)
        {
            bool increasingMonotonic = true;
            bool decreasingMonotonic = true;



            //1 1 2 3 5 6 7
            for (int i = 0; i < arr.Length - 1; i++)
            {


                if (arr[i] >= arr[i+1])
                {
                    increasingMonotonic = false;
                }
                else if (arr[i] <= arr[i + 1])
                {
                    decreasingMonotonic = false;
                }
                else
                {
                    decreasingMonotonic = false;
                    increasingMonotonic = false;
                    break;
                }


            }

            return ( increasingMonotonic || decreasingMonotonic);
        }

        internal List<int> SpiralTraverse(int[,] arrSpiral)
        {
            //{ 1, 2, 3, 4 },
            //    { 5, 6, 7, 8 }, 
            //    { 9, 10, 12, 13 }
            var result = new List<int>();

            int startRow = 0, endRow = arrSpiral.GetLength(0)-1;
            int startCol = 0, endCol = arrSpiral.GetLength(1)-1;
            this.FillArray(arrSpiral, startRow, endRow, startCol, endCol, result);

            return result;

        }

        private void FillArray(int[,] arrSpiral,int startRow,int endRow,int startCol,int endCol, List<int> result)
        {
            if(startCol>endCol || startRow > endRow)
            {
                return;
            }

            //top row
            for (int i = startCol; i < endCol+1; i++)
            {
                result.Add(arrSpiral[startRow, i]);
            }
            //last column
            for (int i = startRow+1; i < endRow+1; i++)
            {
                result.Add(arrSpiral[i, endCol]);
            }

            //bottom column
            for (int i = endCol-1; i >startCol; i--)
            {
                result.Add(arrSpiral[endRow, i]);
            }
            //first colum
            for (int i = endRow; i > startRow; i--)
            {
                result.Add(arrSpiral[i, startCol]);
            }
            FillArray(arrSpiral, startRow + 1, endRow - 1, startCol + 1, endCol - 1,result);

        }
    
        public int LongestPeek(int[] arr)
        {
            List<int> PeekIndex = new List<int>();
            List<int> PeekLenghth = new List<int>();
            for (int i = 1; i < arr.Length-1; i++)
            {
                if(arr[i-1]<arr[i] && arr[i] > arr[i + 1])
                {
                    PeekIndex.Add(i);
                }
            }

            if (PeekIndex == null)
                return 0;

            foreach (var peek in PeekIndex)
            {
                int left = peek-1;
                int right = peek+1;
                int length = 1;
                
               
                    while (left >= 0 && arr[left] < arr[left + 1])
                    {
                   

                        length++;
                        left--;
                  
                    }
                    while (right < arr.Length && arr[right] < arr[right - 1])
                    {
                    
                        length++;
                        right++;
                  
                        
                    }
                   

                PeekLenghth.Add(length);
            }



            return PeekLenghth.Max();
        }

        public int LongestPeek2(int[] arr)
        {
            int i = 1, maxPeek = 0;

            while (i<arr.Length-1)
            {
                var isPeek = ( (arr[i]>arr[i-1]) && (arr[i]>arr[i+1]) )?true:false;
                if (!isPeek)
                {
                    i++;
                    continue;
                }
                int leftIndex = i - 2;
                int rightIndex = i + 2;
                while (leftIndex>=0 && arr[leftIndex]<arr[leftIndex+1])
                {
                    leftIndex--;
                }

                while (rightIndex<arr.Length && arr[rightIndex]<arr[rightIndex-1])
                {
                    rightIndex++;
                }

                int currentPeek = rightIndex - leftIndex - 1;
                maxPeek = currentPeek < maxPeek ? maxPeek : currentPeek;
                i = rightIndex;
            }


            return maxPeek;
        }
    }
}
