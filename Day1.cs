using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2018
{
    class Day1
    {
        public static int PartOne()
        {
            System.DateTime start = System.DateTime.Now;
            string[] lines = System.IO.File.ReadAllLines("inputDay1.txt");
            List<int> intLines = new List<int>();
            HashSet<int> seenLines = new HashSet<int>();
            int frequency = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                intLines.Add(Int32.Parse(lines[i]));
                frequency += intLines[i];
            }
            System.TimeSpan duration = System.DateTime.Now - start;
            Console.WriteLine(string.Format("Part 1: Time spent: {0} milliseconds", duration.TotalMilliseconds));
            return frequency;
        }

        public static int PartTwo()
        {
            System.DateTime start = System.DateTime.Now;
            string[] lines = System.IO.File.ReadAllLines("inputDay1.txt");
            int freq = 0;
            var hashList = new HashSet<int>();
            //HashSet<int> hashList = new HashSet<int>();
            while (true)
            {
                foreach (var l in lines)
                {
                    freq += int.Parse(l);
                    if (!hashList.Add(freq))
                    {
                        System.TimeSpan duration = System.DateTime.Now - start;
                        Console.WriteLine(string.Format("Part 2: Time spent: {0} milliseconds", duration.TotalMilliseconds));
                        return freq;
                    }
                }
            }

        }
    }
}
