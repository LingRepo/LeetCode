﻿using System;

namespace _48._Rotate_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrix =
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12 },
                {13,14,15,16 }
            };
            solution.Rotate(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j]);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
    public class Solution
    {
        public void Rotate(int[,] matrix)
        {
            int len = matrix.GetLength(0);
            for (int i = 0; i < len / 2; i++)
            {
                for (int j = i; j < len - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[len - 1 - j, i];
                    matrix[len - 1 - j, i] = matrix[len - 1 - i, len - 1 - j];
                    matrix[len - 1 - i, len - 1 - j] = matrix[j, len - 1 - i];
                    matrix[j, len - 1 - i] = temp;
                }
            }
        }
    }
}
