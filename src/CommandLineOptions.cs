using System;
using CommandLine;

namespace AdventOfCode2021
{
    public class CommandLineOptions
    {
        [Value(index: 0, Required = true, HelpText = "Indicate what day's set of problems to run")]
        public int Day { get; set; }

        [Value(index: 1, Required = true, HelpText = "Indicate which problem to run")]
        public int Problem { get; set; }

        [Value(index: 2, Required = false, HelpText = "Input file to use")]
        public string InputFile { get; set;}

        [Option(shortName: 'o', longName: "output", Required = false, HelpText = "Output directory to store results")]
        public string OutputDir { get; set; }
    }
}