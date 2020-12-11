using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdventOfCode2018
{
    class Day2
    {
        public static int PartOne()
        {
            System.DateTime start = System.DateTime.Now;
            string[] inputLines = System.IO.File.ReadAllLines("inputDay3.txt");
            int twos = 0;
            int threes = 0;
            Dictionary<char, int> charCountDic = new Dictionary<char, int>();

            foreach (var l in inputLines)
            {
                foreach (var c in l.ToCharArray())
                {
                    charCountDic.TryGetValue(c, out int i);
                    charCountDic[c] = i + 1;
                }
                if (charCountDic.ContainsValue(2))
                {
                    twos++;
                }
                if (charCountDic.ContainsValue(3))
                {
                    threes++;
                }

                charCountDic.Clear();
            }

            System.TimeSpan duration = System.DateTime.Now - start;
            Console.WriteLine(string.Format("Part 1: Time spent: {0} milliseconds", duration.TotalMilliseconds));
            return twos * threes;
        }

        public static string PartTwo()
        {

            System.DateTime start = System.DateTime.Now;
            string[] inputLines = System.IO.File.ReadAllLines("inputDay2.txt");
            int d = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var lines1 in inputLines)
            {
                foreach (var lines2 in inputLines)
                {
                    for (var i = 0; i < lines1.Length; i++)
                    {
                        if (lines1[i] != lines2[i])
                        {
                            if (++d > 1)
                            {
                                break;
                            }
                        }
                        else
                        {
                            sb.Append(lines1[i]);
                        }
                    }

                    if (d == 1)
                    {
                        System.TimeSpan duration = System.DateTime.Now - start;
                        Console.WriteLine(string.Format("Part 1: Time spent: {0} milliseconds", duration.TotalMilliseconds));
                        return sb.ToString();
                    }

                    d = 0;
                    sb.Clear();
                }
            }

            return "error";
        }
    }
}
