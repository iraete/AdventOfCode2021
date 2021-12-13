using System;

namespace AdventOfCode2021.Solutions.Day1
{
    public static class Problem1
    {
        public static string Main(string[] input)
        {
            int result = 0;
            long lastDepth = Int64.Parse(input[0]);
            foreach(string depthString in input)
            {
                long depth = Int64.Parse(depthString);
                if (depth > lastDepth)
                    result++;
                lastDepth = depth;
            }
            return result.ToString();
        }
    }
}