using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2018
{
    class Day3
    {
        public static int PartOne()
        {

            System.DateTime start = System.DateTime.Now;
            string[] inputLines = System.IO.File.ReadAllLines("inputDay3.txt");
            string[] splitChars = new string[] { " @ ", ",", ": ", "x" };
            var coords = new HashSet<(int x, int y)>();
            var overlap = new HashSet<(int x, int y)>();
            foreach (var l in inputLines)
            {
                var parts = l.Split(splitChars, StringSplitOptions.None);
                var left = int.Parse(parts[1]);
                var top = int.Parse(parts[2]);
                var width = int.Parse(parts[3]);
                var height = int.Parse(parts[4]);
                for (var x = left; x < width + left; x++)
                {
                    for (var y = top; y < height + top; y++)
                    {
                        if (!coords.Add((x, y)))
                        {
                            overlap.Add((x, y));
                        }
                    }
                }
            }
            System.TimeSpan duration = System.DateTime.Now - start;
            Console.WriteLine(string.Format("Part 1: Time spent: {0} milliseconds", duration.TotalMilliseconds));
            return overlap.Count;
        }

        public static int PartTwo()
        {

            System.DateTime start = System.DateTime.Now;
            string[] inputLines = System.IO.File.ReadAllLines("inputDay3.txt");
            string[] splitChars = new string[] { " @ ", ",", ": ", "x" };

            var ids = new HashSet<int>();
            foreach (var l in inputLines)
            {
                ids.Add(int.Parse(l.Substring(1, l.IndexOf(' '))));
            }

            var map = new Dictionary<(int x, int y), List<int>>();
            foreach (var l in inputLines)
            {
                var parts = l.Split(splitChars, StringSplitOptions.None);
                var left = int.Parse(parts[1]);
                var top = int.Parse(parts[2]);
                var width = int.Parse(parts[3]);
                var height = int.Parse(parts[4]);
                for (var x = left; x < width + left; x++)
                {
                    for (var y = top; y < height + top; y++)
                    {
                        List<int> list;
                        if (!map.TryGetValue((x, y), out list))
                        {
                            list = new List<int>();
                        }

                        list.Add(int.Parse(parts[0].Substring(1)));
                        map[(x, y)] = list;
                    }
                }
            }

            foreach (var pos in map.Values)
            {
                if (pos.Count > 1)
                {
                    ids.RemoveWhere((int i) => pos.Contains(i));
                }
            }
            System.TimeSpan duration = System.DateTime.Now - start;
            Console.WriteLine(string.Format("Part 1: Time spent: {0} milliseconds", duration.TotalMilliseconds));
            return new List<int>(ids)[0];
        }
    }
}
