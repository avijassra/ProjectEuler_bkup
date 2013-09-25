(*
Sum square difference
Problem 6
The sum of the squares of the first ten natural numbers is,

12 + 22 + ... + 102 = 385
The square of the sum of the first ten natural numbers is,

(1 + 2 + ... + 10)2 = 552 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*)

[<EntryPoint>]
let main argv = 
    let sqTheNum a = a * a

    let sqOfAllNumAndSum a =
        a |> Seq.map sqTheNum |> Seq.sum

    let sumOfAllNumAndSq a =
        a |> Seq.sum |> sqTheNum

    let generateListTo a = [for i in 1 .. a -> i]

    let sumSqDiff a = 
        let list = generateListTo a

        (list |> sumOfAllNumAndSq) - (list |> sqOfAllNumAndSum)

    let diff = sumSqDiff 100

    printfn "%d" diff

    System.Console.Read() |> ignore
    0 // return an integer exit code
