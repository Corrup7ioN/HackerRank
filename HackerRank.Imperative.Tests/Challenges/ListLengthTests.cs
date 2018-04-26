using NUnit.Framework;

namespace HackerRank.Tests.Challenges
{
    [TestFixture]
    public class ListLengthTests
    {
        public static class Sample
        {
            public const string Input = @"2
5
1
4
3
7
8
6
0
9";
            public const string Output = "10";

            public const string Description = "Sample";
        }

        [TestCase(Sample.Input, ExpectedResult = Sample.Output, TestName = Sample.Description)]
        public string Test(string input)
        {
            return TestHelper.TestSolution(() => ListLength.main, input);
        }
    }

}
