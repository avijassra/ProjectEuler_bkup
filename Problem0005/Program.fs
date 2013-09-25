(*
Smallest multiple
Problem 5
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*)

[<EntryPoint>]
let main argv = 
    let rec gcf (a: int64) (b: int64) =
        match b with
            | 0L -> a
            | _ -> gcf b (a%b)

    let lcm (a: int64) (b: int64) =
        (a * b)/gcf a b
        
    let rec lcmlist (a: int64 list) = 
        match a with
            |[] -> 1L
            |[x] -> x
            |[x;y] -> lcm x y
            |h::t -> lcm h (lcmlist t)
        
    let generateListTo m =
        [for i in 1L .. m -> i]

    let resolveProblem5 =
        generateListTo 20L |>  lcmlist
    printfn "%A" resolveProblem5
    System.Console.Read() |> ignore
    0 // return an integer exit code
