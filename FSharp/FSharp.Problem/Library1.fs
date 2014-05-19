namespace FSharp.Problem

open System

    module Math =
        
        let rec CalculatePrimeFactor (number:int64) (lpf:int64) =
            match number with
                | _ when float lpf > Math.Sqrt(float number) -> number
                | _ when (number%lpf) = 0L -> CalculatePrimeFactor (number/lpf) 2L
                | _ -> CalculatePrimeFactor number (lpf+1L)

        let LargestPrimeFactor number = 
            CalculatePrimeFactor number 2L    


//
//type Math() = 
//    static member CalculatePrimeFactor(number, lpf) =
//        if number = lpf then
//            lpf
//        else 
//            match (number%lpf) with
//                | 0 -> Math.CalculatePrimeFactor (number/lpf) 2
//                | _ -> Math.CalculatePrimeFactor number (lpf+1)
//
//    static member LargestPrimeFactor(number) = 
//        Math.CalculatePrimeFactor number 2      