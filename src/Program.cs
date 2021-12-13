using System;
using System.Diagnostics;
using System.IO;
using CommandLine;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            ParserResult<CommandLineOptions> parserResults = CommandLine.Parser
                .Default.ParseArguments<CommandLineOptions>(args);

            parserResults.WithParsed(RunOptions);
        }

        static void RunOptions(CommandLineOptions opts)
        {

            string directory = GetOutputDirectoryPath(opts);
            StreamWriter sw = GetOutputFileWriter(opts, directory);

            if (sw != null)
                Console.SetOut(sw);

            string[] input = File.ReadAllLines(opts.InputFile);
            DateTime runAtTime = DateTime.Now;

            Stopwatch timer = new Stopwatch();
            timer.Start();
            string results = SolutionFactory
                .GetSolution(opts.Day, opts.Problem)(input); 
            timer.Stop();

            Console.WriteLine($"Result: {results}");
            Console.WriteLine($"\n---");
            Console.WriteLine($"Executed at: {runAtTime}");
            Console.WriteLine($"Time elapsed: {timer.ElapsedMilliseconds}ms");
            
            if (sw != null)
                sw.Dispose();
        }

        private static string GetOutputDirectoryPath(CommandLineOptions opts)
        {
            string directory = opts.OutputDir;

            if (string.IsNullOrWhiteSpace(opts.OutputDir))
            {
                directory = null;
            }
            else
                Directory.CreateDirectory(directory);
            
            return directory;
        }

        private static StreamWriter GetOutputFileWriter(CommandLineOptions opts, 
            string directoryPath)
        {
            const string DEFAULT_INPUT_DIR = "../input";

            if (directoryPath == null)
                return null;

            if (string.IsNullOrEmpty(opts.InputFile))
            {
                opts.InputFile = DEFAULT_INPUT_DIR 
                    + $"/day{opts.Day}_problem{opts.Problem}.in";
            }

            string fileName = $"results_day{opts.Day}_problem{opts.Problem}";
            string relativePath = $"{directoryPath}/{fileName}";

            return new StreamWriter(relativePath);
        }
    }
}
