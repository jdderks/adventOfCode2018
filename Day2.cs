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
            string[] inputLines = System.IO.File.ReadAllLines("inputDay2.txt");
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

            return twos * threes;
        }

        public static int PartTwo()
        {
            string[] inputLines = System.IO.File.ReadAllLines("inputDay2.txt");
            int v = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var i in inputLines) 
            {
                foreach (var j in inputLines)
                {
                    for (int a = 0; a < i.Length; a++)
                    {
                        if (i[a] != j[a])
                        {

                        }
                    }
                }
            }
            return 0;
        }
    }
}
