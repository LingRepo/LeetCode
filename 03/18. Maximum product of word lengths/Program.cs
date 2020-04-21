﻿using System;

namespace _18._Maximum_product_of_word_lengths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().MaxProduct(new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" }));
        }
    }
    public class Solution
    {
        public int MaxProduct(string[] words)
        {
            if (words.Length == 0)
                return 0;
            int[] wordInfo = new int[words.Length];
            foreach (var c in words[0])
                wordInfo[0] |= (1 << c - 'a');
            
            int result = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    foreach (var c in words[j])
                        wordInfo[j] |= (1 << c - 'a');
                    if ((wordInfo[i] & wordInfo[j]) == 0)
                        result = Math.Max(result, words[i].Length * words[j].Length);
                }
            }
            return result;
        }
    }
}
