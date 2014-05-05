namespace ProjectEuler
{
    using System;

    public static class Problem
    {
        public static void PrintResult(string problemNumber, int result) {
            PrintResult(problemNumber, result.ToString());
        }

        public static void PrintResult(string problemNumber, string result)
        {
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Problem {0}", problemNumber);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(ProjectEulerProblems._0001);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Answer is {0}", result);
            Console.WriteLine("********************************************************************************");
            Console.ReadLine();
        }
    }
}
