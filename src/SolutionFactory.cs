using System;
using System.Collections.Generic;
using Day1 = AdventOfCode2021.Solutions.Day1;

namespace AdventOfCode2021
{
    public static class SolutionFactory
    {
        static Dictionary<(int, int), Func<string[], string>> _solutionDict =
            new Dictionary<(int, int), Func<string[], string>>()
            {
                { (1, 1), Day1.Problem1.Main },
                { (1, 2), Day1.Problem2.Main }
            };

        public static Func<string[], string> GetSolution(int day, int problem)
        {
            return _solutionDict[(day, problem)];
        }
    }
}