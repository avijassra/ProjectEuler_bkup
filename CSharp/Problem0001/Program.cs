namespace Problem0001
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var sum = GenerateNumberList(1000)
                        .Where(x => x % 3 == 0 || x % 5 == 0)
                        .Sum();

            ProjectEuler.Problem.PrintResult("0001", sum);
        }

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
