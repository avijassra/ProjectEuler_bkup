(*
Smallest multiple
Problem 5
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*)

[<EntryPoint>]
let main argv = 
    // calculate the Greatest Common Factor
    let rec gcf (a: int64) (b: int64) =
        match b with
            // if b is 0 then return a
            | 0L -> a
            // if b is not 0, then 
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

        // create diagnostics stopwatch
    let sw = System.Diagnostics.Stopwatch()
    // start the stopwatch
    sw.Start() 
    
    let resolveProblem5 =
        generateListTo 20L |>  lcmlist 
    // stop the stopwatch
    sw.Stop()
    
    printfn "%A  - (with processing time %A)" resolveProblem5 sw.ElapsedMilliseconds
    System.Console.Read() |> ignore
    0 // return an integer exit code
