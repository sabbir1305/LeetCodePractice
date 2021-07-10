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
    
        public (int,int) SubArraySort(int[] arr)
        {
            int minOutOrder=int.MaxValue, maxOutOrder=int.MinValue;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (IsOutOfOrder(i, arr))
                {
                    minOutOrder = arr[i] < minOutOrder ? arr[i] : minOutOrder;
                    maxOutOrder = arr[i] > maxOutOrder ? arr[i] : maxOutOrder;
                }
            }
            int leftIndex = 0;

            while (minOutOrder>=arr[leftIndex])
            {
                leftIndex++;
            }
            int rightIndex = arr.Length-1;
            while (maxOutOrder<=arr[rightIndex])
            {
                rightIndex--;
            }

            if(minOutOrder==int.MinValue) return (-1, -1);

            return (leftIndex, rightIndex);
            

           

        }

        private bool IsOutOfOrder(int i, int[] arr)
        {
            if (i == 0)
            {
                return arr[i] > arr[i + 1];
            }
            else if (i == arr.Length - 1)
            {
                return arr[arr.Length - 1] < arr[i - 1];
            }
            else
            {
                return arr[i] > arr[i + 1] || arr[i] < arr[i - 1];
            }
        }
    
        public (int,int) LargestRange(int[] arr)
        {
            int longestLength = 0;
            var bestRange = (0,0);
            var nums = new Dictionary<int,bool>();

            for (int i = 0; i < arr.Length; i++)
            {
                nums[arr[i]] = true;
            }

            foreach (var num in arr)
            {
                if (!nums[num])
                    continue;
                int currentLength = 1;
                int left = num - 1;
                int right = num + 1;

                while (nums.ContainsKey(left))
                {
                    nums[left] = false;
                    left--;
                    currentLength++;
                }
                while (nums.ContainsKey(right))
                {
                    nums[right] = false;
                    currentLength++;
                    right++;
                }

                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                    bestRange = (left + 1, right + 1);
                }

            }
            return bestRange;
        }

        #region minRewards
            
        //Naive O(n^2)
        public int MinRewards(int[] scores)
        {
            int[] rewards = new int[] { };
            for (int i = 0; i < scores.Length; i++)
            {
                rewards[i] = 1;
            }

            for (int i = 1; i < scores.Length; i++)
            {
                int j = i - 1;
                if (scores[i] > scores[j])
                {
                    rewards[i] = rewards[j] + 1;
                }
                else
                {
                    while (j>=0 && scores[j] > scores[j+1])
                    {
                        rewards[j] = GetMax(rewards[j], rewards[j + 1] + 1);
                        j--;
                    }
                }

               
            }

            return rewards.Sum();

        }
        #endregion

        public int MinRewardsTwo(int[] scores)
        {
            int[] rewards = new int[] { };
            for (int i = 0; i < scores.Length; i++)
            {
                rewards[i] = 1;
            }
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > scores[i - 1])
                {
                    rewards[i] = rewards[i - 1] + 1;
                }
            }

            for (int i = scores.Length-1; i >= 0; i--)
            {
                if(scores[i] > scores[i + 1])
                {
                    rewards[i] = this.GetMax(rewards[i], rewards[i + 1] + 1);
                }
            }
            return rewards.Sum();

        }


        public List<int> ZigZag(int[,] arr)
        {
            int height = arr.GetLength(0)-1;
            int width = arr.GetLength(1)-1;
            List<int> result = new List<int>();
            int row = 0, col = 0;
            bool goingDown = true;
            while (!IsOutOfBound(row,col,height,width))
            {
                result.Add(arr[row, col]);
                if (goingDown)
                {
                    if (col == 0 || row == height)
                    {
                        goingDown = false;
                        if (row == height)
                        {
                            col++;
                        }
                        else
                        {
                            row++;
                        }
                    }
                    else
                    {
                        row++;
                        col--;
                    }
                }
                else
                {
                    if (col == width || row == 0)
                    {
                        goingDown = true;
                        if (col == width)
                        {
                            row--;
                        }
                        else
                        {
                            col++;
                        }
                    }
                    else
                    {
                        row--;
                        col++;
                    }
                }
              
            }


            return result;
        }

  

        private bool IsOutOfBound(int row,int col,int heigh , int width)
        {
            return row < 0 || row > heigh || col < 0 || col > width;
        }




        private int GetMax(int num1,int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
        
    }
}
