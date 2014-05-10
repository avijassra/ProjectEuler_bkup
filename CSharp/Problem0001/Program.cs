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

			// OPTION 1
			stopwatch.Start();

			var listSum = GenerateNumberList(1000)
						.Where(x => x % 3 == 0 || x % 5 == 0)
						.Sum();

			stopwatch.Stop();

			ProjectEuler.Problem.AddResult (listSum, stopwatch.ElapsedMilliseconds, "Using number list");

			// OPTION 2
			stopwatch.Reset ();
			stopwatch.Start ();

			var arrSum = GenerateNumberArray (1000)
						.Where (x => x % 3 == 0 || x % 5 == 0)
						.Sum ();

			stopwatch.Stop();

			ProjectEuler.Problem.AddResult (arrSum, stopwatch.ElapsedMilliseconds, "Using number array");

<<<<<<< HEAD
			// OPTION 3
			stopwatch.Reset ();

			stopwatch.Start ();

			var sum = 0;

			for(var i = 0; i < 1000000; i++) {
				if (i % 3 == 0 || i % 5 == 0) {
					sum += i;
				}
			}

			stopwatch.Stop ();

			ProjectEuler.Problem.AddResult (sum, stopwatch.ElapsedMilliseconds, "Using for loop");

            ProjectEuler.Problem.PrintResult("0001");
        }
=======
			ProjectEuler.Problem.PrintResult("0001");
		}
>>>>>>> FETCH_HEAD

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

		// generate the array of numbers from lower bound to upper down
		private static int[] GenerateNumberArray(int upperBound, int lowerBound = 0)
		{
			var arrLength = upperBound - lowerBound;

			var numberArr = new int[arrLength];

			for (var i = 0; i < arrLength; i++)
			{
				numberArr[i] = lowerBound + i;
			}

			return numberArr;
		}
	}
}
