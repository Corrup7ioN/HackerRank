using NUnit.Framework;

namespace HackerRank.Tests.Challenges
{
    [TestFixture]
    public class FpReverseAListTests
    {
        public static class Sample
        {
            public const string Input = @"19
22
3
28
26
17
18
4
28
0";
            public const string Output = @"0
28
4
18
17
26
28
3
22
19";

            public const string Description = "Sample";
        }

        [TestCase(Sample.Input, ExpectedResult = Sample.Output, TestName = Sample.Description)]
        public string Test(string input)
        {
            return TestHelper.TestSolution(FpRerverseAList.main, input);
        }
    }

}
