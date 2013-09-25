(*
Multiples of 3 and 5
Problem 1
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
*)

[<EntryPoint>]
let main argv = 
    let sumNo = [1..999]
                    |> Seq.filter (fun x -> x % 3 = 0 || x % 5 = 0)
                    |> Seq.sum
    
    printfn "The sum of all the multiples of 3 or 5 below 1000 is %d" sumNo
    System.Console.Read() |> ignore
    0 // return an integer exit code
