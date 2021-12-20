using System;

namespace AdventOfCode2021.Solutions.Day2
{
    public static class Problem2
    {
        public static string Main(string[] input)
        {
            int depth = 0,
                xPos = 0, 
                aim = 0;

            foreach(string instr in input)
            {
                string[] directionAndUnits = instr.Split(" ");
                int units = Int32.Parse(directionAndUnits[1]);
                if (directionAndUnits[0][0] == 'f')
                {
                    xPos += units;
                    depth += aim * units;
                }
                else
                    aim += (directionAndUnits[0][0] == 'd' ? 1 : -1) * units;
            }
            
            int result = depth * xPos;
            return result.ToString();
        }
    }
}