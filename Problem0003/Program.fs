(*
Largest prime factor
Problem 3
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*)

[<EntryPoint>]
let main argv =
    let theNumber = 600851475143I //13195

    (**********************************
    Solution 1 
    ***********************************
    slow solution as it iterates through all the numbers
    **********************************)

//    let rec LargestPrimeFactorial (x: bigint) (y:bigint) = 
//        match x, y with
//            | u, t when u = t -> u
//            | c, d when c%d = 0I -> 
//                match c with
//                    | m when m = theNumber -> LargestPrimeFactorial (m/d) 2I
//                    | n -> LargestPrimeFactorial theNumber ((theNumber/n)+1I)
//            | e, f -> LargestPrimeFactorial e (f+1I)
//            | a, b when a = b -> a
//            | _, _ -> failwith "not valid option"
//
//    let sw = System.Diagnostics.Stopwatch()
//    sw.Start()  
//    let primeFactorNo = LargestPrimeFactorial theNumber 2I
//    sw.Stop()

    (**********************************
    Solution 2
    ***********************************
    Better solution to find all the divisors
    if n / x = y, obviously both x and y are factors, so I don't have to probe y anymore
    If I start probing from 2 going up, I can stop probing when I have reached \sqrt n. In fact, any number bigger than \sqrt n must have been already found probing a smaller number.
    Suppose for example that we have to factor the number 36 (one of the triangle number)
    **********************************)
    let divides (x:bigint) (y:bigint) = (x % y = 0I)

    let rec GetAllFactors (num:bigint) (index:bigint) factors = 
        if (divides num index) then
            let y = num / index
            if index < y then
                GetAllFactors num (index + 1I) (index::y::factors)
            else if (y = index) then
                (index::factors)
            else 
                factors
        else if index > bigint (sqrt (float num)) then
            factors
        else 
            GetAllFactors num (index + 1I) factors

    let rec PrimeNumber = function
        | [] -> 0
        | h::t -> 
            let factors = GetAllFactors h 2I []
            if(factors.Length = 0) then
                int h
            else 
                PrimeNumber t

    let rec LargestPrimeFactorial (x: bigint) = 
        let factorList = GetAllFactors x 2I []
        let factorRevList = factorList
                                |> List.sort 
                                |> List.rev

        let largestPrimeNumber = PrimeNumber factorRevList
        largestPrimeNumber        
    
    let sw = System.Diagnostics.Stopwatch()
    sw.Start()    
    let primeFactorNo = LargestPrimeFactorial theNumber
    sw.Stop()


    printfn "%A - (with processing time %A)" primeFactorNo  sw.ElapsedMilliseconds

    System.Console.Read() |> ignore
    0 // return an integer exit code
