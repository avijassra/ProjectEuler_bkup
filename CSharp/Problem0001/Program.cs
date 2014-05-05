namespace Problem0001
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var sum = GenerateNumberList(1000)
                        .Where(x => x % 3 == 0 || x % 5 == 0)
                        .Sum();

            stopwatch.Stop();

            ProjectEuler.Problem.PrintResult("0001", sum, stopwatch.ElapsedMilliseconds);
        }

        // generate the list of numbers from lower bound to upper down
        private static IList<int> GenerateNumberList(int upperBound, int lowerBound = 0)
        {
            var numberList = new List<int>();

            for (var i = lowerBound; i < upperBound; i++)
            {
                numberList.Add(i);
            }

            return numberList;
        }
    }
}
