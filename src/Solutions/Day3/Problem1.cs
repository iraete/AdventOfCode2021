using System;

namespace AdventOfCode2021.Solutions.Day3
{
    public static class Problem1
    {
        public static string Main(string[] input)
        {
            long gamma = 0,
                counter = 0;
            int inputLength = input.Length,
                bitstringLength = input[0].Length;
            for (int i=0; i < bitstringLength; i++, counter = 0)
            {
                foreach(string bitstring in input)
                    counter += (bitstring[i] - '0') * 1;
                gamma = (gamma << 1) | ((counter > (inputLength/2)) ? 1L : 0L);
            }
            long bitmask = (1 << (bitstringLength)) - 1;
            long epsilon = gamma == bitmask ? 1 : gamma ^ bitmask;
            return (gamma * epsilon).ToString();
        }
    }
}