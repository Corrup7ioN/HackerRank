using NUnit.Framework;

namespace HackerRank.Tests.Challenges
{
    [TestFixture]
    public class LambdaMarchComputeThePerimeterOfAPolygonTests
    {
        public static class Sample
        {
            public const string Input = @"4
0 0
0 1  
1 1  
1 0";
            public const string Output = "4.0";

            public const string Description = "Sample";
        }

        public static class TestCase0
        {
            public const string Input = @"3
1043 770
551 990
681 463";

            public const string Output = "1556.4"; //"1556.3949033";

            public const string Description = "TestCase0";
        }

        public static class TestCase1
        {
            public const string Input = @"8
458 695
621 483
877 469
1035 636
1061 825
875 1023
645 1033
485 853";

            public const string Output = "1847.5"; //"1847.48055065";

            public const string Description = "TestCase1";
        }

        [TestCase(Sample.Input, ExpectedResult = Sample.Output, TestName = Sample.Description)]
        [TestCase(TestCase0.Input, ExpectedResult = TestCase0.Output, TestName = TestCase0.Description)]
        [TestCase(TestCase1.Input, ExpectedResult = TestCase1.Output, TestName = TestCase1.Description)]
        public string Test(string input) => TestHelper.TestSolution(() => LambdaMarchComputeThePerimeterOfAPolygon.main(""), input);
    }

}
