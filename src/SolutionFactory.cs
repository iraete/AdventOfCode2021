using System;
using System.Collections.Generic;
using Day1 = AdventOfCode2021.Solutions.Day1;
using Day2 = AdventOfCode2021.Solutions.Day2;
using Day3 = AdventOfCode2021.Solutions.Day3;
namespace AdventOfCode2021
{
    public static class SolutionFactory
    {
        static Dictionary<(int, int), Func<string[], string>> _solutionDict =
            new Dictionary<(int, int), Func<string[], string>>()
            {
                { (1, 1), Day1.Problem1.Main },
                { (1, 2), Day1.Problem2.Main },
                { (2, 1), Day2.Problem1.Main },
                { (2, 2), Day2.Problem2.Main },
                { (3, 1), Day3.Problem1.Main }
            };

        public static Func<string[], string> GetSolution(int day, int problem)
        {
            return _solutionDict[(day, problem)];
        }
    }
}