(*
Largest prime factor
Problem 3
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
*)

open System

[<EntryPoint>]
let main argv = 
    let reverseNumber n =
        let rec loop acc = function
            |0 -> acc
            |x -> loop (acc * 10 + x % 10) (x/10)    
        loop 0 n

    let isPalindrome = function
        | x  when x = reverseNumber x -> true
        | _ -> false


    let maxPalindromeNumber =
        let numbers = seq {
            for i = 100 to 999 do
                for j = 100 to 999 do
                    let z = i * j
                    if isPalindrome z then
                        yield z
        }
        Seq.max numbers

    printfn "multple of 3 digit resulting %d" maxPalindromeNumber
    Console.Read() |> ignore
    0 // return an integer exit code
