using System;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode2021.Solutions.Day2
{
    public static class Problem1
    {
        public static string Main(string[] input)
        {
            Dictionary<string, int> map = new Dictionary<string, int>()
            {
                { "forward", 0},
                { "down", 0},
                { "up", 0}
            };

            foreach(string instr in input)
            {
                string[] directionAndUnits = instr.Split(" ");
                map[directionAndUnits[0]] += Int32.Parse(directionAndUnits[1]);
            }
            
            int result = map["forward"] * (map["down"] - map["up"]);
            return result.ToString();
        }
    }
}