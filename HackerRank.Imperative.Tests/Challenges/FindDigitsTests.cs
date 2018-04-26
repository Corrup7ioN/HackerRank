namespace HackerRank.Tests.Challenges
{
    using HackerRank.Imperative.Challenges;

    using NUnit.Framework;

    [TestFixture]
    public class FindDigitsTests
    {
        public static class Sample0
        {
            public const string Input = @"2
12
1012";

            public const string Output = @"2
3";
        }

        public static class TestCase0
        {
            public const string Input = @"2
12
1012";

            public const string Output = @"2
3";
        }

        [TestCase(Sample0.Input, ExpectedResult = Sample0.Output, TestName = "Sample #0")]
        [TestCase(TestCase0.Input, ExpectedResult = TestCase0.Output, TestName = "Test Case #0")]
        public string Test(string input)
        {
            return TestHelper.TestSolution(FindDigits.Main, input);
        }
    }
}
