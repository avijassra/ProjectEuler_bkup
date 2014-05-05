(*
Multiples of 3 and 5
Problem 1
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
*)

[<EntryPoint>]
let main argv = 
    
    // Option 1
    let sumOfNoDivisbleBy3or5UnderN n = 
        [for i in 1 .. n-1 -> i]
            |> Seq.filter (fun x -> x%3 = 0 || x%5 = 0)
            |> Seq.sum

    let sumOfNoDivisbleBy3or5Under10 = sumOfNoDivisbleBy3or5UnderN 10

    let sumOfNoDivisbleBy3or5Under1000 = sumOfNoDivisbleBy3or5UnderN 1000

    ProjectEuler.Problem.PrintResult("0001", sumOfNoDivisbleBy3or5Under1000)

    // Option 2
    let sumOfFilteredSeq filterCri n = 
        seq { for i in 1 .. n-1 -> if filterCri i then i else 0 }
            |> Seq.sum

    let filteredSeqOf3or5 = sumOfFilteredSeq (fun x -> x%3 = 0 || x%5 = 0)

    let sumOfNoUnder10 = filteredSeqOf3or5 10

    let sumOfNoUnder1000 = filteredSeqOf3or5 1000

    ProjectEuler.Problem.PrintResult("0001", sumOfNoUnder1000)

    System.Console.Read() |> ignore
    0 // return an integer exit code
