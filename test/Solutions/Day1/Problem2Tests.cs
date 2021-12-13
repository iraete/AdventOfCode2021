using System;
using NUnit.Framework;
using AdventOfCode2021.Solutions.Day1;

namespace AdventOfCode2021Tests.SolutionsTests.Day1
{
    [TestFixture]
    public class Problem2Tests
    {
        string[] input = new [] 
        { 
            "607", "618", "618", "617",
            "647", "716", "769", "792"
        };

        [Test]
        public void Main_ProvidedTestCase_Success()
        {
            string result = Problem2.Main(input);
            Assert.AreEqual(5, Int64.Parse(result));
        }
    }
}