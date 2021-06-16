using System;

namespace NumberOfIlsands
{

    /*
    Given an m x n 2D binary grid grid which represents a map of '1's(land) and '0's(water), return the number of islands.
    An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.
     Example 1:

    Input: grid = [
      ["1","1","1","1","0"],
      ["1","1","0","1","0"],
      ["1","1","0","0","0"],
      ["0","0","0","0","0"]
    ]
    Output: 1

     */
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new char[][]{
            new char[]  { '1', '1', '1', '1', '0' },
             new char[]  { '1', '1', '0', '1', '0'},
            new char[]   {'1', '1', '0', '0', '0'},
           new char[]    {'0', '0', '0', '0', '0'}
            };


            Console.WriteLine("Number of Ilands Is :" + NumIslands(grid));
            Console.ReadKey();
        }

        public static int NumIslands(char[][] grid)
        {
            int numberOfIsLands = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        numberOfIsLands += 1;
                        BFS(grid, i, j);
                    }
                }
            }

            return numberOfIsLands;
        }

        private static void BFS(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
            {
                return;
            }

            grid[i][j] = '0';
            BFS(grid, i + 1, j);//up
            BFS(grid, i - 1, j);//down
            BFS(grid, i, j - 1);//left
            BFS(grid, i, j + 1);//right
        }
    }
}
