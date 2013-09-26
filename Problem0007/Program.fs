(*
10001st prime
Problem 7
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?
*)
[<EntryPoint>]
let main argv = 
    let l = new ResizeArray<_>([])
    let mutable num = 2I

    let rec isPrime (x : bigint) (y : bigint) =
        match x, y with
            | _, _ when y > x/2I -> true
            | _, _ when x%y = 0I -> false
            | _, _ -> isPrime x (y+1I)

    while l.Count < 10001 do
        if isPrime num 2I then
            printfn "Number added to list - %A" num
            l.Add(num)
        num <- num + 1I



    printfn "10001st prime number is %A" l.[10000]
    System.Console.Read() |> ignore
    0 // return an integer exit code
