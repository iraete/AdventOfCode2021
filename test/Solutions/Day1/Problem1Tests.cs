using System;
using NUnit.Framework;
using AdventOfCode2021.Solutions.Day1;

namespace AdventOfCode2021Tests.SolutionsTests.Day1
{
    [TestFixture]
    public class Problem1Tests
    {
        string[] input = new [] 
        { 
            "199", "200", "208", "210", "200", "207", 
            "240", "269", "260", "263" 
        };

        [Test]
        public void Main_ProvidedTestCase_Success()
        {
            string result = Problem1.Main(input);
            Assert.AreEqual(7, Int64.Parse(result));
        }
    }
}