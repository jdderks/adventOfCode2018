using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2018
{
    class Day1
    {
        public static int PartOne()
        {
            string[] lines = System.IO.File.ReadAllLines("inputDay1.txt");
            List<int> intLines = new List<int>();
            HashSet<int> seenLines = new HashSet<int>();
            int frequency = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                intLines.Add(Int32.Parse(lines[i]));
                frequency += intLines[i];
            }
            return frequency;
        }

        public static int PartTwo()
        {
            string[] lines = System.IO.File.ReadAllLines("inputDay1.txt");
            int freq = 0;
            var hashList = new HashSet<int>();
            while (true)
            {
                foreach (var l in lines)
                {
                    freq += int.Parse(l);
                    if (!hashList.Add(freq))
                    {
                        return freq;
                    }
                }
            }
        }
    }
}
