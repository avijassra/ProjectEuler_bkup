namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Problem
    {
        static List<ResultViewModel> _results = new List<ResultViewModel>();

        public static void AddResult(int answer, long timeElapsed)
        {
            _results.Add(new ResultViewModel(answer, timeElapsed));
        }

        public static void PrintResult(string problemNumber, int answer, long timeElapsed) 
        {
            AddResult(answer, timeElapsed);
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
                stringBuilder.AppendFormat("Option {0} -> Answer is {1} ({2})", i, _results[i].Answer, _results[i].TimeElapsed);
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
