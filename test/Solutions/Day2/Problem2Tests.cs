using System;
using NUnit.Framework;
using AdventOfCode2021.Solutions.Day2;

namespace AdventOfCode2021Tests.SolutionsTests.Day2
{
    [TestFixture]
    public class Problem2Tests
    {
        string[] input = new [] 
        {
            "forward 5",
            "down 5",
            "forward 8",
            "up 3",
            "down 8",
            "forward 2"
        };

        [Test]
        public void Main_ProvidedTestCase_Success()
        {
            string result = Problem2.Main(input);
            Assert.AreEqual(900, Int64.Parse(result));
        }
    }
}