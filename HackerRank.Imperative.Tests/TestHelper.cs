using System;
using System.IO;

namespace HackerRank.Tests
{
    using System.Diagnostics;
    using System.Timers;

    public class TestHelper
    {
        public static string TestSolution(Action solution, string input)
        {
            return TestSolution(() =>
            {
                solution();
                return 0;
            }, input);
        }

        public static string TestSolution<T>(Func<T> solution, string input)
        {
            using (var inputReader = new StringReader(input))
            using (var outputWriter = new StringWriter())
            {
                // Arrange
                var originalOutput = Console.Out;

                Console.SetIn(inputReader);
                Console.SetOut(outputWriter);

                TimeSpan timeTaken = TimeSpan.MinValue;

                // Act
                try
                {
                    var timer = new Stopwatch();
                    timer.Start();

                    solution();

                    timer.Stop();

                    timeTaken = timer.Elapsed;
                }
                finally
                {
                    Console.SetOut(originalOutput);

                    Console.WriteLine($"Complete in {timeTaken.TotalSeconds}");
                    Console.WriteLine();
                    Console.WriteLine("Input");
                    Console.WriteLine("-----------");
                    Console.WriteLine(input);
                    Console.WriteLine(string.Empty);
                    Console.WriteLine("Output");
                    Console.WriteLine("-----------");
                    Console.Write(outputWriter.ToString());
                }
                // Assert
                return outputWriter.ToString().Trim();
            }
        }
    }
}