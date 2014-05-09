namespace ProjectEuler
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public static class Problem
	{
		static List<ResultViewModel> _results = new List<ResultViewModel>();

		public static void AddResult(int answer, long timeElapsed, string description)
		{
			AddOptionResult(answer, timeElapsed, description);
		}

		private static void AddOptionResult(int answer, long timeElapsed, string description = null)
		{
			_results.Add(new ResultViewModel(answer, timeElapsed, description));
		}

		public static void PrintResult(string problemNumber, int answer, long timeElapsed) 
		{
			AddOptionResult(answer, timeElapsed);
			PrintResult(problemNumber);
		}

		public static void PrintResult(string problemNumber)
		{
			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("********************************************************************************");
			stringBuilder.AppendFormat("Problem {0}", problemNumber);
			stringBuilder.AppendLine("");
			stringBuilder.AppendLine("--------------------------------------------------------------------------------");
			stringBuilder.AppendLine(ProjectEulerProblems._0001);
			stringBuilder.AppendLine("********************************************************************************");

			for (var i = 0; i < _results.Count; i++)
			{
				if (!string.IsNullOrEmpty (_results [i].Description)) {
					stringBuilder.AppendFormat ("Option: {0}", _results [i].Description);
					stringBuilder.AppendLine("");
					stringBuilder.AppendLine ("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
				}
				stringBuilder.AppendFormat("Answer is {0} (Execution time: {1}ms)", _results[i].Answer, _results[i].TimeElapsed);
				stringBuilder.AppendLine("");
				if (_results.Count > 0 && i != _results.Count - 1)
				{
					stringBuilder.AppendLine("--------------------------------------------------------------------------------");
				}
			}
			stringBuilder.AppendLine("********************************************************************************");

			Console.WriteLine(stringBuilder.ToString());
			Console.ReadLine();
		}
	}
}