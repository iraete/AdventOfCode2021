using System;

namespace AdventOfCode2021.Solutions.Day1
{
    public static class Problem2
    {
        public static string Main(string[] input)
        {
            long[] depths = new long[input.Length];
            for(int idx = 0; idx < input.Length; idx++)
            {
                long depth = Int32.Parse(input[idx]);
                depths[idx] = depth;
            }
            return Calculate(depths).ToString();
        }

        private static int Calculate(long[] depths, int idx=0)
        {
            if (idx + 2 > depths.Length - 1)
                return 0;

            if (idx < 1)
                return Calculate(depths, idx + 1);

            long prevWindow = depths[idx - 1] + depths[idx] 
                                + depths[idx + 1];
            
            long nextWindow = depths[idx] + depths[idx + 1]
                                + depths[idx + 2];
            
            return IncrementBy(prevWindow, nextWindow) 
                + Calculate(depths, idx + 1);
        }

        private static int IncrementBy(long prevWindow, long nextWindow)
        {
            return nextWindow > prevWindow ? 1 : 0;
        }
    }
}