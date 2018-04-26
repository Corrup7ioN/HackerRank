using NUnit.Framework;

namespace HackerRank.Tests.Challenges
{
    [TestFixture]
    public class FpArrayOfNElementsTests
    {
        public static class Sample0
        {
            public const string Input = "10";
            public const string Output = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10]";
            public const string Description = "Sample 0";
        }

        public static class Sample1
        {
            public const string Input = "3";
            public const string Output = "[1, 2, 3]";
            public const string Description = "Sample 1";
        }

        [TestCase(Sample0.Input, ExpectedResult = Sample0.Output, TestName = Sample0.Description)]
        [TestCase(Sample1.Input, ExpectedResult = Sample1.Output, TestName = Sample1.Description)]
        public string Test(string input)
        {
            return TestHelper.TestSolution(FpArrayOfNElements.main, input);
        }
    }

}
