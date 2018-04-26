namespace HackerRank.Imperative.Challenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindDigits
    {
        public static void Main()
        {
            var input = GetInput();

            input.TestCases.ForEach(RunTestCase);
        }

        private static void RunTestCase(TestCase testCase)
        {
            var result = GetDigits(testCase.Number).Where(d => d != 0).Count(d => testCase.Number % d == 0);
            Console.WriteLine(result.ToString());
        }

        private static IEnumerable<int> GetDigits(int n)
        {
            return n.ToString().Select(c => Convert.ToInt32(c - '0'));
        }

        private static InputModel GetInput()
        {
            var input = new InputModel
            {
                NumberOfTestCases = Convert.ToInt32(Console.ReadLine())
            };

            input.TestCases = Enumerable.Range(1, input.NumberOfTestCases).Select(GetTestCase).ToList();

            return input;
        }

        private static TestCase GetTestCase(int index)
        {
            var testCase = new TestCase(index)
            {
                Number = Convert.ToInt32(Console.ReadLine())
            };


            return testCase;
        }

        public class InputModel
        {
            public int NumberOfTestCases { get; set; }

            public List<TestCase> TestCases { get; set; }
        }

        public class TestCase
        {
            public TestCase(int index)
            {
                this.Index = index;
            }

            public int Index { get; }

            public int Number { get; set; }
        }
    }
}
