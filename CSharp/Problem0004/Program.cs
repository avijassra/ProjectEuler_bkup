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

			// OPTION 2
			sw.Reset ();
			sw.Start();
			var maxProductFast = ListOfThreeDigitNumbersProductFast();
			sw.Stop();

			ProjectEuler.Problem.AddResult(maxProductFast, sw.ElapsedMilliseconds, "looping thru 3 digits number where second number is always less \n then first number in every iteration and before checking for is palindrome \n always check if new number is greater then last selected palindrone number.");
			
			ProjectEuler.Problem.PrintResult("0004");
		}

		// basic looping
		public static IEnumerable<int> ListOfThreeDigitNumbersProduct()
		{
			// looping for the first 3 digit numbers
			for (var i = 999; i > 99; i--)
			{
				// looping for the second 3 digit numbers
				for (var j = 999; j > 99; j--)
				{
					// find the product b/w the numbers
					var product = i*j;

					// check if the number is palindome
					if (product.IsPalindrome())
					{
						yield return product;
					}
				}
			}
		}

		// intelligent fast looping
		public static int ListOfThreeDigitNumbersProductFast()
		{
			// initialize largest palindrome number variabel
			var largestPalindromeNumber = 0; 

			// loopping thru all 3 digit numbers
			for (var i = 999; i > 99; i--)
			{
				// PERFORMACE BOOST
				// looping thru 3 digits number from 100 to first number
				// anything greater then first number has been already calculated
				// as (a*b) = (b*a)
				for (var j = 100; j <= i; j++)
				{
					// product of nunmbers
					var product = i*j;

					// PERFORMACE BOOST
					// if current product is greated then the previous saved palindrome product
					// only then check for number is palindrome else we can avoid extra checking task
					if (product > largestPalindromeNumber) 
					{
						// check number is palindrome
						if (product.IsPalindrome())
						{
							// if is palindrome, save it as largest palindrome number 
							largestPalindromeNumber = product;
						}
					}
				}
			}

			return largestPalindromeNumber;
		}
	}

	public static class Palindrome
	{
		// Check is number is palindrome
		public static bool IsPalindrome(this int number)
		{
			// store the actual number for check
			var actualNumber = number;
			// initialize new palindrome number
			var palindromeNumber = 0;

			// to reverse the number e.g. 98743 and set new palindrome number to 0
			// multiple new palindrome number with 10, and add modulus when number is divide by 10 and set it back in the new number
			// iteration 1 -> newPalindromeNumber: (0*10 + 98743%10) -> 3; number -> 9874
			// iteration 2 -> newPalindromeNumber: (3*10 + 9874%10) -> 34; number -> 987
			// iteration 3 -> newPalindromeNumber: (34*10 + 987%10) -> 347; number -> 98
			// iteration 4 -> newPalindromeNumber: (347*10 + 98%10) -> 3478; number -> 9
			// iteration 5 -> newPalindromeNumber: (3478*10 + 9%10) -> 34789; number -> 0
			// loops till number is not equal to 0
			// and now we have reversed number to check if its palindrome
			while (number != 0)
			{
				palindromeNumber = (palindromeNumber * 10) + (number % 10);
				number = number / 10;
			}
			//if actual number and new expected palindrome numbers are same
			return (actualNumber == palindromeNumber);
		}
	}

}

