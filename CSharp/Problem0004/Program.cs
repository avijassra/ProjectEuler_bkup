using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Problem0004
{
    class Program
    {
        static void Main(string[] args)
        {
            // OPTION 1
            var sw = new Stopwatch();
            sw.Start();
            var maxProduct = ListOfThreeDigitNumbersProduct().Max();
            sw.Stop();

            ProjectEuler.Problem.AddResult(maxProduct, sw.ElapsedMilliseconds, "looping thru all 3 digits number and their product, short list Palindrome numbers and find max in them");
            ProjectEuler.Problem.PrintResult("0004");
        }

        public static IEnumerable<int> ListOfThreeDigitNumbersProduct()
        {
            for (var i = 999; i > 99; i--)
            {
                for (var j = 999; j > 99; j--)
                {
                    var product = i*j;

                    if (product.CheckPalindrome())
                    {
                        yield return product;
                    }
                }
            }
        }
    }

    public static class Palindrome
    {
        public static bool CheckPalindrome(this int number)
        {
            var actualNumber = number;
            var palindromeNumber = 0;

            while (number != 0)
            {
                palindromeNumber = (palindromeNumber * 10) + (number % 10);
                number = number / 10;
            }

            return (actualNumber == palindromeNumber);
        }
    }

}

