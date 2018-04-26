using NUnit.Framework;

namespace HackerRank.Tests.Challenges
{
    [TestFixture]
    public class FpSolveMeFirstTests
    {
        public static class TestCase0
        {
            public const string Input = @"2
3";
            public const string Output = @"5";
        }

        public static class TestCase1
        {
            public const string Input = @"100
1000";
            public const string Output = @"1100";
        }

        [TestCase(TestCase0.Input, ExpectedResult = TestCase0.Output, TestName = "Test Case #0")]
        [TestCase(TestCase1.Input, ExpectedResult = TestCase1.Output, TestName = "Test Case #1")]
        public string Test(string input)
        {
            return TestHelper.TestSolution(FpSolveMeFirst.main, input);
        }
    }
}
