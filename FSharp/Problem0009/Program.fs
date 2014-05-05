(*
Special Pythagorean triplet
Problem 9
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
*)

[<EntryPoint>]
let main argv = 
    
    let rec getPythagoreanTriplet a b c =
        match a, b, c with
            | x, y, z when x*x + y*y = z*z && x + y + z = 1000 -> x*y*z
            | 1000, 1000, 1000 -> 0
            | _, 1000, 1000 -> getPythagoreanTriplet (a+1) 1 1
            | _, _, 1000 -> getPythagoreanTriplet a (b+1) 1
            | _, _, _ -> getPythagoreanTriplet a b (c+1)

    let product = getPythagoreanTriplet 20 20 20

    printfn "%A" product
    System.Console.Read() |> ignore
    0 // return an integer exit code
