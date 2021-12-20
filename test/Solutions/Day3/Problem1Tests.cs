using System;
using NUnit.Framework;
using AdventOfCode2021.Solutions.Day3;

namespace AdventOfCode2021Tests.SolutionsTests.Day3
{
    [TestFixture]
    public class Problem1Tests
    {
        string[] input = new [] 
        {
            "00100",
            "11110",
            "10110",
            "10111",
            "10101",
            "01111",
            "00111",
            "11100",
            "10000",
            "11001",
            "00010",
            "01010"
        };

        [Test]
        public void Main_ProvidedTestCase_Success()
        {
            string result = Problem1.Main(input);
            Assert.AreEqual(198, Int32.Parse(result));
        }
    }
}