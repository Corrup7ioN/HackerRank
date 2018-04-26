using NUnit.Framework;

namespace HackerRank.Tests.Challenges
{
    [TestFixture]
    public class FpSumOfOddElementsTests
    {
        public static class Sample
        {
            public const string Input = @"3
2
4
6
5
7
8
0
1";
            public const string Output = "16";

            public const string Description = "Sample";
        }

        [TestCase(Sample.Input, ExpectedResult = Sample.Output, TestName = Sample.Description)]
        public string Test(string input)
        {
            return TestHelper.TestSolution(FpSumOfOddElements.main, input);
        }
    }

}
