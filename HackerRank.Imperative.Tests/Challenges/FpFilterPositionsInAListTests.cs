using NUnit.Framework;

namespace HackerRank.Tests.Challenges
{
    [TestFixture]
    public class FpFilterPositionsInAListTests
    {
        public static class Sample
        {
            public const string Input = @"2
5
3
4
6
7
9
8";
            public const string Output = @"5
4
7
8";

            public const string Description = "Sample 0";
        }

        [TestCase(Sample.Input, ExpectedResult = Sample.Output, TestName = Sample.Description)]
        public string Test(string input)
        {
            return TestHelper.TestSolution(FpFilterPositionsInAList.main, input);
        }
    }

}
