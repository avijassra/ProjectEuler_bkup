using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problem
{
    public static class Math
    {
        public static long LargestPrimeFactor(long number)
        {
            /*
             * The thing with Project Euler is that there is usually an obvious brute-force method to do the problem, 
             * which will take just about forever. As the questions become more difficult, you will need to implement clever solutions.
             * 
             * One way you can solve this problem is to use a loop that always finds the smallest (positive integer) factor of a number. 
             * When the smallest factor of a number is that number, then you've found the greatest prime factor!
             * 
             * Detailed Algorithm description:
             * 
             * You can do this by keeping three variables:
             * The number you are trying to factor (A)
             * A current divisor store (B)
             * A largest divisor store (C)
             * Initially, let (A) be the number you are interested in - in this case, it is 600851475143. Then let (B) be 2. 
             * Have a conditional that checks if (A) is divisible by (B). If it is divisible, divide (A) by (B), reset (B) to 2, 
             * and go back to checking if (A) is divisible by (B). Else, if (A) is not divisible by (B), increment (B) by +1 
             * and then check if (A) is divisible by (B). Run the loop until (A) is 1. The (3) you return will be the largest prime divisor of 600851475143.
             * 
             * There are numerous ways you could make this more effective - instead of incrementing to the next integer, 
             * you could increment to the next necessarily prime integer, and instead of keeping a largest divisor store, 
             * you could just return the current number when its only divisor is itself. However, the algorithm I described above will run in seconds regardless. 
             */

            long lpf = 2;

            while (System.Math.Sqrt(number) > lpf)
            {
                if (number % lpf == 0)
                {
                    number = number/lpf;
                    lpf = 2;
                }
                else
                {
                    lpf++;
                }
            }

            return number;
        }

        public static long LargestPrimeFactorFaster(long number)
        {
            /*
             * The thing with Project Euler is that there is usually an obvious brute-force method to do the problem, 
             * which will take just about forever. As the questions become more difficult, you will need to implement clever solutions.
             * 
             * One way you can solve this problem is to use a loop that always finds the smallest (positive integer) factor of a number. 
             * When the smallest factor of a number is that number, then you've found the greatest prime factor!
             * 
             * Detailed Algorithm description:
             * 
             * You can do this by keeping three variables:
             * The number you are trying to factor (A)
             * A current divisor store (B)
             * A largest divisor store (C)
             * Initially, let (A) be the number you are interested in - in this case, it is 600851475143. Then let (B) be 2. 
             * Have a conditional that checks if (A) is divisible by (B). If it is divisible, divide (A) by (B), reset (B) to 2, 
             * and go back to checking if (A) is divisible by (B). Else, if (A) is not divisible by (B), increment (B) by +1 
             * and then check if (A) is divisible by (B). Run the loop until (A) is 1. The (3) you return will be the largest prime divisor of 600851475143.
             * 
             * There are numerous ways you could make this more effective - instead of incrementing to the next integer, 
             * you could increment to the next necessarily prime integer, and instead of keeping a largest divisor store, 
             * you could just return the current number when its only divisor is itself. However, the algorithm I described above will run in seconds regardless. 
             */

            long lpf = 2;

            while (number % 2 == 0)
            {
                number = number / 2;
            }

            lpf = 3;

            while (System.Math.Sqrt(number) > lpf)
            {
                if (number % lpf == 0)
                {
                    number = number / lpf;
                    lpf = 2;
                }
                else
                {
                    lpf++;
                }
            }

            return number;
        }
    }
}
