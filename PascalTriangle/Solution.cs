using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    //Given an integer numRows, return the first numRows of Pascal's triangle.

    //Input: numRows = 5
    //Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]

    class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var pascalTriAngle = new List<IList<int>>();
            if (numRows == 0)
                return pascalTriAngle;

            var firstRow = new List<int> { 1 };
            pascalTriAngle.Add(firstRow);
            for (int i = 1; i < numRows; i++)
            {
                var prevRow = pascalTriAngle[i - 1];

                pascalTriAngle.Add(GeneratePascalRow(i, prevRow));

            }

            return pascalTriAngle;
        }

        private IList<int> GeneratePascalRow( int i, IList<int> prevRow)
        {
            var row =new List<int>();
            row.Add(1);

            for (int j = 1; j < i; j++)
            {
                row.Add(prevRow[j - 1] + prevRow[j]);
            }
            row.Add(1);
            return row;
        }
    }
}
