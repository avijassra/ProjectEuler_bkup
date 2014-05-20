(*
Largest prime factor
Problem 3
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
*)

open System

[<EntryPoint>]
let main argv =

    // function to flip the existing number to reverse the digits 
    let reverseNumber n =
        // recurring function to create new number to flip the 
        // existing the number digit one at a time
        let rec loop newNum = function
            // if the new number is 0
            // return the new created number as it is
            |0 -> newNum
            // if number is not 0
            // recall the function with new number * 10 and adding modules 
            // of number dividing by 10.
            // return update old number by dividing by 10 
            |x -> loop (newNum * 10 + x % 10) (x/10)    
        loop 0 n

    // check if the number is palindrome
    let isPalindrome = function
        // if number is equal to reversed number then its palindrome, 
        // return true
        | x  when x = reverseNumber x -> true
        // else return false
        | _ -> false

    // function to get the max palindrome number of multiplication
    // of two numbers between the limits
    let maxPalindromeNumber lowerLimit upperLimit =
        // create the seq of all the palidrome numbers create 
        // by multiple two numbers between the limits
        let numbers = seq {

            // get first number from the loop
            for i = lowerLimit to upperLimit do
                // get the second number from the loop
                for j = lowerLimit to upperLimit do
                    // multiple both the numeber
                    let z = i * j
                    // and check if number is palindrome
                    if isPalindrome z then
                        // if yes, return the number to seq else 
                        // move back to new numbers in the loop
                        yield z
        }
        // return the max number from the seq
        Seq.max numbers

    // create diagnostics stopwatch
    let sw = System.Diagnostics.Stopwatch()
    // start the stopwatch
    sw.Start() 
    // call function to get max palindrome number product of two numbers 
    // between 100 and 900
    let number = maxPalindromeNumber 100 999
    // stop the stopwatch
    sw.Stop()

    // print number
    ProjectEuler.Problem.AddResult(number, sw.ElapsedMilliseconds, "multple of 3 digit resulting %d  - (with processing time %A)")
    ProjectEuler.Problem.PrintResult("0004")
    0 // return an integer exit code
