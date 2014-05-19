(*
Largest prime factor
Problem 3
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*)

[<EntryPoint>]
let main argv =
    let theNumber = 600851475143L //13195

    (**********************************
    Solution 1 
    ***********************************
    slow solution as it iterates through all the numbers
    **********************************)
    let sw = System.Diagnostics.Stopwatch()
    sw.Start()  
    let primeFactorNo = FSharp.Problem.Math.LargestPrimeFactor theNumber
    sw.Stop()

    ProjectEuler.Problem.AddResult(primeFactorNo, sw.ElapsedMilliseconds, "loop till we find divisor, replace and loop on that number")

    (**********************************
    Solution 2
    ***********************************
    Better solution to find all the divisors
    if n / x = y, obviously both x and y are factors, so I don't have to probe y anymore
    If I start probing from 2 going up, I can stop probing when I have reached \sqrt n. In fact, any number bigger than \sqrt n must have been already found probing a smaller number.
    Suppose for example that we have to factor the number 36 (one of the triangle number)
    **********************************)
    let divides (x:int64) (y:int64) = (x % y = 0L)

    let rec GetAllFactors (num:int64) (index:int64) factors = 
        if (divides num index) then
            let y = num / index
            if index < y then
                GetAllFactors num (index + 1L) (index::y::factors)
            else if (y = index) then
                (index::factors)
            else 
                factors
        else if index > int64 (sqrt (float num)) then
            factors
        else 
            GetAllFactors num (index + 1L) factors

    let rec PrimeNumber = function
        | [] -> 0
        | h::t -> 
            let factors = GetAllFactors h 2L []
            if(factors.Length = 0) then
                int h
            else 
                PrimeNumber t

    let rec LargestPrimeFactorial (x: int64) = 
        let factorList = GetAllFactors x 2L []
        let factorRevList = factorList
                                |> List.sort 
                                |> List.rev

        let largestPrimeNumber = PrimeNumber factorRevList
        largestPrimeNumber        
    
    let sw = System.Diagnostics.Stopwatch()
    sw.Start()    
    let primeFactorNo = LargestPrimeFactorial theNumber
    sw.Stop()

    ProjectEuler.Problem.AddResult(primeFactorNo, sw.ElapsedMilliseconds, "if n / x = y, obviously both x and y are factors, so I don't have to probe y anymore")

    ProjectEuler.Problem.PrintResult("0003")
    0 // return an integer exit code
