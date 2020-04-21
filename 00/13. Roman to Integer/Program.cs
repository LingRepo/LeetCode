﻿using System;

namespace _13._Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "MCMXCIV";
            Console.WriteLine(solution.RomanToInt(s));
            Console.Read();
        }
    }
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                switch (s[i])
                {
                    case 'V':
                        result += 5;
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;
                    case 'I':
                        if (i < s.Length - 1 && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                            result--;
                        else
                            result++;
                        break;
                    case 'X':
                        if (i < s.Length - 1 && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                            result -= 10;
                        else
                            result += 10;
                        break;
                    case 'C':
                        if (i < s.Length - 1 && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                            result -= 100;
                        else
                            result += 100;
                        break;
                    default:
                        break;
                }
            }
            return result;
        }
    }
}
