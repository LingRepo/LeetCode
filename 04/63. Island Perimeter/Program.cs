﻿namespace _63._Island_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int IslandPerimeter(int[,] grid)
        {
            int len1 = grid.GetLength(0), len2 = grid.GetLength(1);
            int perimeter = 0;
            for (int i = 0; i < len1; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        perimeter += 4;
                        if (i + 1 < len1 && grid[i + 1, j] == 1)
                            perimeter -= 2;
                        if (j + 1 < len2 && grid[i, j + 1] == 1)
                            perimeter -= 2;
                    }
                }
            }
            return perimeter;
        }
    }
}