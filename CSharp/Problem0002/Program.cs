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

			// OPTION 1
            stopwatch.Start();

            var sum = GenerateList(4000000)
                        .Where(x => x % 2 == 0)
                        .Sum();

            stopwatch.Stop();

            ProjectEuler.Problem.AddResult(sum, stopwatch.ElapsedMilliseconds, "By creating list first ");

			// OPTION 2
			stopwatch.Reset ();
			stopwatch.Start();

			var prev1 = 1;
			var prev2 = 2;
			// prev2 value is 2 which is a even number, so sum starts from 2
			var sumByLooping = prev2;

			while(prev2 < 4000000) {
				var sumOf2Nos = prev1 + prev2;

				prev1 = prev2;
				prev2 = sumOf2Nos;

				if (sumOf2Nos % 2 == 0) {
					sumByLooping += sumOf2Nos;
				}
			}

			stopwatch.Stop();

			ProjectEuler.Problem.AddResult (sumByLooping, stopwatch.ElapsedMilliseconds, "By looping thru numbers as adding only +ve numbers");

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
