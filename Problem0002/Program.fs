﻿(*
Even Fibonacci numbers
Problem 2
Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:

1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
*)

[<EntryPoint>]
let main argv =
 
    let fabList = 
      // Create a mutable list, so that we can add elements 
      // (this corresponds to standard .NET 'List<T>' type)
      let l = new ResizeArray<_>([1;2])
      let mutable a = 1
      let mutable b = 2
      while l.[l.Count - 1] <= 4000000 do
        let c = a + b
        l.Add(c) // Add element to the mutable list
        a <- b
        b <- c
      l |> List.ofSeq // Convert any collection type to standard F# list

    //printfn "%A" fabList

    let sumOfEven =
        fabList
            |> Seq.filter (fun x -> x % 2 = 0) 
            |> Seq.sum 


    printfn "The sum of the even-valued terms of the Fibonacci sequence whose values do not exceed four million  is %d" sumOfEven
    System.Console.Read() |> ignore
    0 // return an integer exit code
