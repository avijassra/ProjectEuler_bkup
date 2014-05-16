using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem0003
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            // OPTION 1
            stopwatch.Start();
            var lpf = Problem.Common.Math.LargestPrimeFactor(600851475143);
            stopwatch.Stop();

            ProjectEuler.Problem.AddResult(lpf, stopwatch.ElapsedMilliseconds, "Test");

            ProjectEuler.Problem.PrintResult("0003");
        }
    }
}