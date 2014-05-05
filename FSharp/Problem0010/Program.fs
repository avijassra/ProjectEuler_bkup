(*
Summation of primes
Problem 10
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.
*)

open System.Collections.Generic

[<EntryPoint>]
let main argv = 
    let sieve (n:int64) =
        let candidatePrimes = new Dictionary<int64, bool>()
        for i in 2L .. n do candidatePrimes.Add(i, true)
        for i in 2L .. n/2L do
            if candidatePrimes.[i] = true then
                let mutable j = i
                while (j + i <= n) do
                    j <- j + i
                    candidatePrimes.[j] <- false
        seq { for i in 2L .. n do
                if candidatePrimes.[i] = true then
                    yield i }
        |> Seq.sum

    let sumOfPrimeNumbers = sieve 2000000L

    printfn "sum of all the primes below two million - %A" sumOfPrimeNumbers
    System.Console.Read() |> ignore
    0 // return an integer exit code
