using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Problem0002
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            // OPTION1
            stopwatch.Start();

            var sum = GenerateList(4000000)
                        .Where(x => x % 2 == 0)
                        .Sum();

            stopwatch.Stop();

            ProjectEuler.Problem.AddResult(sum, stopwatch.ElapsedMilliseconds, "By creating list first ");

            ProjectEuler.Problem.PrintResult("0002");
        }

        public static IEnumerable<int> GenerateList(int upperBound)
        {
            if (upperBound < 2)
            {
                throw new Exception("Invalid upper bound");
            }

            IList<int> list = new List<int>();

            var prev1 = 1;
            list.Add(prev1);
            var prev2 = 2;
            list.Add(prev2);
            var sum = 0;

            while (sum < upperBound)
            {
                sum = prev1 + prev2;
                list.Add(sum);
                prev1 = prev2;
                prev2 = sum;
            }

            return list;
        }
    }
}
