using System;
using NUnit.Framework;
using AdventOfCode2021.Solutions.Day2;

namespace AdventOfCode2021Tests.SolutionsTests.Day2
{
    [TestFixture]
    public class Problem1Tests
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
            string result = Problem1.Main(input);
            Assert.AreEqual(150, Int64.Parse(result));
        }
    }
}