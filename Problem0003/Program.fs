(*
Largest prime factor
Problem 3
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*)

[<EntryPoint>]
let main argv =
    let theNumber = 600851475143I //13195

    let rec LargestPrimeFactorial (x: bigint) (y:bigint) = 
        match x, y with
            | u, t when u = t -> u
            | c, d when c%d = 0I -> 
                match c with
                    | m when m = theNumber -> LargestPrimeFactorial (m/d) 2I
                    | n -> LargestPrimeFactorial theNumber ((theNumber/n)+1I)
            | e, f -> LargestPrimeFactorial e (f+1I)
            | a, b when a = b -> a
            | _, _ -> failwith "not valid option"

    let primeFactorNo = LargestPrimeFactorial theNumber 2I

    printfn "%A" primeFactorNo 

    System.Console.Read() |> ignore
    0 // return an integer exit code
