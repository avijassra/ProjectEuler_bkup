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
            var lpf = CSharp.Problem.Math.LargestPrimeFactor(600851475143);
            stopwatch.Stop();
            ProjectEuler.Problem.AddResult(lpf, stopwatch.ElapsedMilliseconds, "let (A) be the number you are interested in - in this case, it is 600851475143. Then let (B) be 2. \n Have a conditional that checks if (A) is divisible by (B). If it is divisible, divide (A) by (B), reset (B) to 2, \n and go back to checking if (A) is divisible by (B). Else, if (A) is not divisible by (B), increment (B) by +1 \n and then check if (A) is divisible by (B). Run the loop until (A) is 1");

            stopwatch.Reset();

            // OPTION 2
            stopwatch.Start();
            var lpfFaster = CSharp.Problem.Math.LargestPrimeFactorByDividingBy2InLoopsInitially(600851475143);
            stopwatch.Stop();
            ProjectEuler.Problem.AddResult(lpfFaster, stopwatch.ElapsedMilliseconds, "looping and divide by 2 until it is not divisible by 2 anymore.");

            ProjectEuler.Problem.PrintResult("0003");
        }
    }
}