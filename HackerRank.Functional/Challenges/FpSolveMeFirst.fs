module FpSolveMeFirst

open System

let main() = 
    let a = Console.ReadLine() |> int
    let b = Console.ReadLine() |> int
    printfn "%d" (a+b)
    0