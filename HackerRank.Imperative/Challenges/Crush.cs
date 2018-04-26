namespace HackerRank.Imperative.Challenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Crush
    {
        public static void Main()
        {
            var input = GetInput();

            input.TestCases.ForEach(RunTestCase);
        }

        private static void RunTestCase(TestCase testCase)
        {
            var result = GetCrushResult(testCase.ArraySize, testCase.Operations);

            Console.WriteLine(result.ToString());
        }

        private static long GetCrushResult(int arraySize, IEnumerable<Operation> operations)
        {
            var prefixSequence = new long[arraySize];

            foreach (var operation in operations)
            {
                prefixSequence[operation.StartIndex - 1] += operation.NumberToAdd;

                if (operation.EndIndex < prefixSequence.Length)
                {
                    prefixSequence[operation.EndIndex] -= operation.NumberToAdd;
                }
            }

            long sum = 0;
            return prefixSequence
                .Select(n => sum += n)
                .Max();
        }

        private static InputModel GetInput()
        {
            var input = new InputModel
            {
                NumberOfTestCases = 1
            };

            input.TestCases = Enumerable.Range(1, input.NumberOfTestCases)
                .Select(GetTestCase)
                .ToList();

            return input;
        }

        private static TestCase GetTestCase(int index)
        {
            var testCase = new TestCase(index);

            var firstLine = Console.ReadLine().Split(' ');

            testCase.ArraySize = Convert.ToInt32(firstLine[0]);

            var numberOfOperations = Convert.ToInt32(firstLine[1]);
            testCase.Operations = Enumerable.Range(1, numberOfOperations)
                .Select(i => GetOperation())
                .ToList();

            return testCase;
        }

        private static Operation GetOperation()
        {
            var i = Console.ReadLine().Split(' ');

            return new Operation(Convert.ToInt32(i[0]), Convert.ToInt32(i[1]), Convert.ToInt32(i[2]));
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

            public int ArraySize { get; set; }

            public IReadOnlyCollection<Operation> Operations { get; set; }
        }

        public class Operation
        {
            public Operation(int startIndex, int endIndex, long numberToAdd)
            {
                this.StartIndex = startIndex;
                this.EndIndex = endIndex;
                this.NumberToAdd = numberToAdd;
            }

            public int StartIndex { get; set; }

            public int EndIndex { get; set; }

            public long NumberToAdd { get; set; }
        }
    }
}
